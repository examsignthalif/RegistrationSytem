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

namespace RegistrationSytem.View
{
    /// <summary>
    /// Interaction logic for AdminBoard.xaml
    /// </summary>
    public partial class AdminBoard : Page
    {
        User NewUserObject = new User();
        public AdminBoard(string handle)
        {
            InitializeComponent();
            NewUserObject.Handle = "jaleel";
            NewUserObject.DateOfBirth = "21/01/2004";
            NewUserObject.Email = "jaleel@gmail.com";
            NewUserObject.MobileNumber = "9894405010";
            xNewUserPanel.DataContext = NewUserObject;

            App a = App.Current as App;
            xUserList.ItemsSource = a.AppList.Values.ToList();
        }

        private void xAddNewUser_Click(object sender, RoutedEventArgs e)
        {
            Registration.Add_NewUser(NewUserObject);
        }

        private void xIsAdminCB_Checked(object sender, RoutedEventArgs e)
        {
            if (xIsAdminCB.IsChecked == true)
                NewUserObject.UserType = "Admin";
            else
                NewUserObject.UserType = "0";
        }
    }
}
