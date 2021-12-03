using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using RegistrationSytem.Model;
using RegistrationSytem.TextData;
namespace RegistrationSytem
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public Dictionary<string, User> AppList = new Dictionary<string, User>();
        public App()
        {
            TxtDatabase obj = new TxtDatabase();
            AppList = obj.DatabaseList;
        }
    }
}
