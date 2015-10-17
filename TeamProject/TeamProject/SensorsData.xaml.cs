using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556

namespace TeamProject
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class SensorsData : Page
    {
        public SensorsData()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        /// 
        public enum Context
        {
            WhileStartingListener,
            WhileReceivingData
        }

        public class ValuesReceivedEventArgs<T> : EventArgs
        {
            public T SensorReading { get; set; }
        }

        public class ExceptionOccurredEventArgs : EventArgs
        {
            public Exception Exception { get; set; }
            public Context Context { get; set; }
        }

        /// <summary>
        /// Interface for reading sensors
        /// </summary>
        public interface IsSensorReading
        {
            int NumSensorValues { get; }
            void SetSensorValues(float[] values);
        }
        //Handles the exception and refer it to main function.

        private void OnException(Exception ex, Context context)
        {
           //// if()
            ///{

           /// }
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }
    }
}
