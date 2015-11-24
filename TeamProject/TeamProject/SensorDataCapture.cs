using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows;

namespace TeamProject
{
    public class ValuesReceivedEventArgs<T> : EventArgs
    {
        public T SensorReading { get; set; }
    }
    public enum Context
    {
        WhileStartingListener,
        WhileReceivingData
    }

    public class ExceptionOccuredEventArgs : EventArgs
    {
        public Exception Exception { get; set; }
        public Context Context { get; set; }
    }

    /// <summary>
    /// Interface for a sensor reading (classes that hold values of sensor measurements).
    /// </summary>
    public interface ISensorReading
    {
        /// <summary>
        /// Has to return a constant number of values this ISensorReading class expects.
        /// </summary>
        int NumSensorValues { get; }

        void SetSensorValues(float[] values);
    }
    private void OnValuesReceived(float[] values)
        {
            if (ValuesReceived != null && Application.Current != null)
            {
                T sensorReading = new T();
                sensorReading.SetSensorValues(values);

                Application.Current.Dispatcher.Invoke(ValuesReceived, this,
                        new ValuesReceivedEventArgs<T>() { SensorReading = sensorReading });
            }
        }
public class SensorEmitterReading : ISensorReading
    {
        public int NumSensorValues { get { return 23; } }

        public double QuaternionX { get; set; }
        public double QuaternionY { get; set; }
        public double QuaternionZ { get; set; }
        public double QuaternionW { get; set; }

        public double RotationPitch { get; set; }
        public double RotationRoll { get; set; }
        public double RotationYaw { get; set; }

        public double RotationRateX { get; set; }
        public double RotationRateY { get; set; }
        public double RotationRateZ { get; set; }

        public double RawAccelerationX { get; set; }
        public double RawAccelerationY { get; set; }
        public double RawAccelerationZ { get; set; }

        public double LinearAccelerationX { get; set; }
        public double LinearAccelerationY { get; set; }
        public double LinearAccelerationZ { get; set; }

        public double GravityX { get; set; }
        public double GravityY { get; set; }
        public double GravityZ { get; set; }

        public double MagneticHeading { get; set; }
        public double TrueHeading { get; set; }
        public double HeadingAccuracy { get; set; }

        public double MagnetometerX { get; set; }
        public double MagnetometerY { get; set; }
        public double MagnetometerZ { get; set; }
        public bool MagnetometerDataValid { get; set; }

        public void SetSensorValues(float[] values)
        {
            if (values == null)
                throw new ArgumentNullException("No array of values given.");

            if (values.Length != NumSensorValues)
                throw new ArgumentException("Unexpected length of array. Exactly " +
                                            NumSensorValues + " items were expected.");

            double x = values[0];
            double y = values[1];
            double z = values[2];
            double w = values[3];

            RotationPitch = Math.Atan2(2 * (y * z + w * x), w * w - x * x - y * y + z * z);
            RotationRoll = Math.Atan2(2 * (x * y + w * z), w * w + x * x - y * y - z * z);
            RotationYaw = Math.Asin(-2 * (x * z - w * y));

            QuaternionX = values[0];
            QuaternionY = values[1];
            QuaternionZ = values[2];
            QuaternionW = values[3];

            RotationRateX = values[7];
            RotationRateY = values[8];
            RotationRateZ = values[9];

            RawAccelerationX = values[13];
            RawAccelerationY = values[14];
            RawAccelerationZ = values[15];

            LinearAccelerationX = values[4];
            LinearAccelerationY = values[5];
            LinearAccelerationZ = values[6];

            GravityX = values[10];
            GravityY = values[11];
            GravityZ = values[12];

            MagneticHeading = values[16];
            TrueHeading = values[17];
            HeadingAccuracy = values[18];

            MagnetometerX = values[19];
            MagnetometerY = values[20];
            MagnetometerZ = values[21];
            MagnetometerDataValid = values[22] == 1d;
        }
    }


    class SensorDataCapture
    {

    }

