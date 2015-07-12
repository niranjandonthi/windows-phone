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
    public sealed partial class LoginPortal : Page
    {
        public LoginPortal()
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

        private void btn_login_Click(object sender, RoutedEventArgs e)
        {
            ///Manual validation of the credentials.
            if (un_txtbx.Text.Equals("niranjan"))
            {
                if (pw_txtbx.Password.Equals("niranjan"))
                {
                    msg_valid.Text = "Login Successful !!!";
                }
                else
                {
                    msg_valid.Text = "Incorrect Credentials";
                }
               
            }
            else
            {
                msg_valid.Text = "Incorrect Credentials";
            }
            ///Validation of the empty credentials.
            if (un_txtbx.Text.Equals("") && un_txtbx.Text.Equals(""))
            {
                msg_valid.Text = "Please enter the credentials";
            }
            else if (un_txtbx.Text.Equals("") || un_txtbx.Text.Equals(""))
            {
                msg_valid.Text = "Please enter the credentials";
            }
        }
       
    }
}
