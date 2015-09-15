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
using System.Threading.Tasks;
using Windows.Storage;
using Windows.Storage.Streams;
using System.Text;
using Windows.UI.Popups;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556

namespace TeamProject
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Config : Page
    {
        private string[] userid;
        public Config()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            ///Using the parameter to get the navigated value from Login.xaml.cs.
           TeamProject.Login.PassedData user_id = e.Parameter as TeamProject.Login.PassedData;
            ///Config in_data = e.Parameter as Config;
            ///base.OnNavigatedTo(e);
            ///string msg = "";
           string usr=user_id.ToString();
           
            
            
        }

        private async void btn_log_Click(object sender, RoutedEventArgs e)
        {
            
            ///Taking the variables and its values and concat them in a variable.
            int count = 0;
            if(count <= 100)
            {
                count=count++;
                  
                string auto_rotate = ((ComboBoxItem)cmb_ar.SelectedItem).Content.ToString();
                string orientation = ((ComboBoxItem)cmb_or.SelectedItem).Content.ToString();
                string input = ((ComboBoxItem)cmb_input.SelectedItem).Content.ToString();
                string postures = ((ComboBoxItem)cmb_post.SelectedItem).Content.ToString();
                string add_ons = ((ComboBoxItem)cmb_add.SelectedItem).Content.ToString();
                string others = ((ComboBoxItem)cmb_other.SelectedItem).Content.ToString();

                string concat_value = String.Concat("[","------",",",count.ToString(),",",auto_rotate, ",", orientation, ",", input, ",", postures, ",", add_ons, ",", others,"------","]");

                test.Text = concat_value;

               ///Storing the raw concatenated value in the text file.
               /// try
                ///{
                    string FileName = "log.txt";

                    StorageFolder localFolder = Windows.Storage.ApplicationData.Current.LocalFolder;
                    StorageFile localFile = await localFolder.CreateFileAsync(FileName, CreationCollisionOption.ReplaceExisting);
                    await FileIO.WriteTextAsync(localFile, concat_value);
                    MessageDialog msd = new MessageDialog("File created");
                ///}
              ///  catch 
               /// {
                    
                    MessageDialog msgd=new MessageDialog ("File is not created");
               /// }
               






                ///--------------------For Future Use-------------------------------------
                ///
                /// 
          
                ///await Windwos.Storage.FileIO.WriteTextAsync(sampleFile, concat_value);
              /// try{
                   ////using (System.IO.StreamWriter writer = new System.IO.StreamWriter(string log.txt, true)) 
               //// {
                    ///writer.Write(concat_value);
                ///}
              // }
              ///  catch(Exception exc)
              /// {
                    
               /// }

                ///
            }

        }
       /// public async Task writedata(string folder, string content)
        ///{
            ///StorageFolder folder =
    ///Windows.Storage.ApplicationData.Current.LocalFolder;
       ///     StorageFile sampleFile =
          ///      await folder.CreateFileAsync("Log.txt", CreationCollisionOption.ReplaceExisting);
           /// await Windows.Storage.FileIO.WriteTextAsync(sampleFile, textBox1.text);
       /// }
       


        ///Class for creating a file and filename for data input and copy.
       /// public async Task WriteDataToFileAsync(string fileName, string content)
        ///{
            ///byte[] data = Encoding.Unicode.GetBytes(content);

           /// var folder = ApplicationData.Current.LocalFolder;
           //// var file = await folder.CreateFileAsync(fileName, CreationCollisionOption.ReplaceExisting);

           /// using (var s = await file.OpenStreamForWriteAsync())
           //// {
             ////   await s.WriteAsync(data, 0, data.Length);
          ///  }
       /// }
       /// <summary>
       /// Class for the reading data for future from the created file.
       /// </summary>
       /// <param name="fileName"></param>
       /// <returns></returns>
        ///public async Task<string> ReadFileContentsAsync(string fileName)
        ///{
            ////var folder = ApplicationData.Current.LocalFolder;

            ////try
           /// <summary>
           /// /
           /// </summary>
 ///{
               /// var file = await folder.OpenStreamForReadAsync(fileName);

               /// using (var streamReader = new StreamReader(file))
               /// {
                    ///return streamReader.ReadToEnd();
                ///}
          ///  }
           /// catch (Exception)
           /// {
               //// return string.Empty;
            ////}
       //// <summary>
       /// 
       /// </summary>
 }
}
       
       

