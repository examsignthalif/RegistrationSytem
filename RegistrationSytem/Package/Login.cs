using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RegistrationSytem.Model;
namespace RegistrationSytem.Package
{
    public class Login
    {
        App a = App.Current as App;
        public bool IsValidCredentials(LoginModel login)
        {
            try
            {
                string pwd = a.AppList[login.UserHandle].Password;
                return a.AppList[login.UserHandle].Password == login.UserPassword;
            }
            catch(KeyNotFoundException ex)
            {
                throw new Exception("User not found..!");
            }
        }
        public string Get_UserType(LoginModel login)
        {
            return a.AppList[login.UserHandle].UserType;
        }
    }
}
