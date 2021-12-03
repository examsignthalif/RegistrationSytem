using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using RegistrationSytem.Model;
using RegistrationSytem.Package;
using RegistrationSytem.View;

namespace RegistrationSytem.View
{
    /// <summary>
    /// Interaction logic for UserLoginPage.xaml
    /// </summary>
    public partial class UserLoginPage : Page
    {
        LoginModel UserCredentials = new LoginModel();
        public UserLoginPage()
        {
            InitializeComponent();
            this.DataContext = UserCredentials;
        }

        private void xLoginBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Login validate = new Login();
                if (validate.IsValidCredentials(UserCredentials))
                {
                    string userType = validate.Get_UserType(UserCredentials).ToUpper();

                    if (userType == "Admin".ToUpper())
                        this.NavigationService.Navigate(new AdminBoard(UserCredentials.UserHandle));

                    else if (userType == "0".ToUpper())
                        this.NavigationService.Navigate(new OperatorBoard(UserCredentials.UserHandle));
                }
                else
                {
                    MessageBox.Show("Invalid credentials");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
