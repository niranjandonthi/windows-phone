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
            userInfo.Text = e.Parameter.ToString();
            base.OnNavigatedTo(e);
     
       }


       private void btn_log_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ///Taking the variables and its values and concat them in a variable.
                int count = 0;

                count = count++;

                string auto_rotate = ((ComboBoxItem)cmb_ar.SelectedItem).Content.ToString();
                string layout = ((ComboBoxItem)cmb_layout.SelectedItem).Content.ToString();
                string variation = ((ComboBoxItem)cmb_Variation.SelectedItem).Content.ToString();
                string orientation = ((ComboBoxItem)cmb_or.SelectedItem).Content.ToString();
                string input = ((ComboBoxItem)cmb_input.SelectedItem).Content.ToString();
                string postures = ((ComboBoxItem)cmb_post.SelectedItem).Content.ToString();
                string add_ons = ((ComboBoxItem)cmb_add.SelectedItem).Content.ToString();
                string others = ((ComboBoxItem)cmb_other.SelectedItem).Content.ToString();
                string user = userInfo.Text;
                ///Concatination of the values after getting all the values.
                string concat_value = String.Concat("[", "------",user, ",", count.ToString(), ",", auto_rotate, ",", layout, ",", variation, ",", orientation, ",", input, ",", postures, ",", add_ons, ",", others, "------", "]");
                
                test.Text = concat_value;
                
                
            }
            catch
            {
                var msg = new MessageDialog("Enter all the values");
                msg.ShowAsync();
                
            }
               
               
                         
            }

       private void btnContinue_Click(object sender, RoutedEventArgs e)
       {
           this.Frame.Navigate(typeof(GyroAcceloData));
       }

        
        }
       
 
}
       
       

