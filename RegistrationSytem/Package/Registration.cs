using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RegistrationSytem.Model;
using RegistrationSytem.TextData;
namespace RegistrationSytem.Package
{
    public class Registration
    {
        static App a = App.Current as App;
        public static void Add_NewUser(User userDetails)
        {
            a.AppList.Add(userDetails.Handle, userDetails);
            TxtDatabase.SyncDatabase(a.AppList);
        }
        public void Remove_User(User userDetails)
        {
            a.AppList.Remove(userDetails.Handle);
        }
        public void Reset_Password(string userHandle)
        {
            a.AppList[userHandle].ResetToDefaultPassword();
            TxtDatabase.SyncDatabase(a.AppList);
        }
    }
}
