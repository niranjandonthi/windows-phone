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
            NavigationContext navcon = new NavigationContext()
            {
                userID = ((ComboBoxItem)cmb_user.SelectedItem).Content.ToString()
            };
            ///Validation of the credentials.
            
            if (pw_txtbx.Password.Equals(""))
            {
               msg_valid.Text = "Please enter the Password";
            }
            else if (navcon.userID == "User 1" || navcon.userID == "User 2" || navcon.userID == "User 3")
            {
                if (pw_txtbx.Password.Equals("niranjan"))
                {
                   
                    this.Frame.Navigate(typeof(Config),navcon);
                }

                else
                {
                    msg_valid.Text = "Incorrect Credentials";
                }
            }

            //Checking whether value is being taken or not.
            txt_test.Text = navcon.userID;
            
           
            
        }
        }



    }

