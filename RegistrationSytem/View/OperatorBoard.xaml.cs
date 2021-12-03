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
using RegistrationSytem.TextData;
namespace RegistrationSytem.View
{
    /// <summary>
    /// Interaction logic for OperatorBoard.xaml
    /// </summary>
    public partial class OperatorBoard : Page
    {
        User CurrentUser = new User();
        public OperatorBoard(string handle)
        {
            InitializeComponent();
            CurrentUser = TxtDatabase.GetUserDetails(handle);
            xUserDetailPanel.DataContext = CurrentUser;
        }

        private void xEditUserDetail_Click(object sender, RoutedEventArgs e)
        {

        }

        private void xChangePassword_Click(object sender, RoutedEventArgs e)
        {
            xChangePwdPanel.Visibility = Visibility.Visible;
        }

        private void xChange_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                xChangePwdPanel.Visibility = Visibility.Collapsed;
                TxtDatabase.SetNewPassword(CurrentUser, xOldPwd.Text.Trim(), xNewPwd.Text.Trim());
                App a = App.Current as App;
                TxtDatabase.SyncDatabase(a.AppList);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
