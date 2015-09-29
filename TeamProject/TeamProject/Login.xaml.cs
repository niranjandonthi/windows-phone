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
    public sealed partial class Login : Page
    {
        public Login()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="ex">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs ex)
        {
        }
      
        private void btn_login_Click(object sender, RoutedEventArgs e)
        {
            ///Validation of the credentials.
            string selectedUser=((ComboBoxItem)cmb_user.SelectedItem).Content.ToString();
            if (pw_txtbx.Password.Equals(""))
            {
               msg_valid.Text = "Please enter the Password";
            }
            else if (selectedUser == "User 1" || selectedUser == "User 2" || selectedUser == "User 3")
            {
                if (pw_txtbx.Password.Equals("niranjan"))
                {
                   /// Frame.Navigate(typeof(Config), new PassedData { userdata= ((ComboBoxItem)cmb_user.SelectedItem).Content.ToString()});
                    this.Frame.Navigate(typeof(Config),selectedUser);
                }

                else
                {
                    msg_valid.Text = "Incorrect Credentials";
                }
            }

            //Checking whether value is being taken or not.
            txt_test.Text = selectedUser;
            
           
            
        }
        }



    }

