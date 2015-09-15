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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556

namespace TeamProject
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Login : Page
    {
        public Login()
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
        }
        public class PassedData
        {
            public string userdata { get; set; }
            
        }

        private void btn_login_Click(object sender, RoutedEventArgs e)
        {
            ///Validation of the credentials.
            if (pw_txtbx.Password.Equals(""))
            {
               msg_valid.Text = "Please enter the Password";
            }
            else if (((ComboBoxItem)cmb_user.SelectedItem).Content.ToString() == "User 1" || ((ComboBoxItem)cmb_user.SelectedItem).Content.ToString() == "User 2" || ((ComboBoxItem)cmb_user.SelectedItem).Content.ToString() == "User 3")
            {
                if (pw_txtbx.Password.Equals("niranjan"))
                {
                    Frame.Navigate(typeof(Config), new PassedData { userdata= ((ComboBoxItem)cmb_user.SelectedItem).Content.ToString() });
                   ///NavigationService.Navigate(new Uri("/Config.xaml?msg=" + ((ComboBoxItem)cmb_user.SelectedItem).Content.ToString(), UriKind.Relative));

                }

                else
                {
                    msg_valid.Text = "Incorrect Credentials";
                }
            }
            
        }
        }



    }

