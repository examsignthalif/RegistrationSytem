using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RegistrationSytem.Model;
using RegistrationSytem.Package;

namespace RegistrationSytem.TextData
{
    public partial class TxtDatabase : Validation
    {
        static string Local_Database_FilePath = string.Empty;

        string Database_Location = "E:\\Registration_System";
        string Database_Name = "Registration_System_DB.txt";

        public Dictionary<string, User> DatabaseList = new Dictionary<string, User>();

        public TxtDatabase()
        {
            CreateDatabase(Database_Location, Database_Name);
            LoadFromTextFile();
        }
    }

    public partial class TxtDatabase 
    {
        static public User GetUserDetails(string handle)
        {
            App a = App.Current as App;
            return a.AppList[handle];
        }
        static public void SetNewPassword(User user, string oldPassword, string NewPassword)
        {
            if (oldPassword == user.Password)
                user.Password = NewPassword;
            else
                throw new Exception("Password mismatch..!");
        }
    }


    public partial class TxtDatabase
    {
        void LoadFromTextFile()
        {
            StreamReader sr = new StreamReader(Local_Database_FilePath);
            string line = sr.ReadLine();
            while (line != null)
            {
                StringOperation(line);
                line = sr.ReadLine();
            }
        }
        void StringOperation(string line)
        {
            string[] Split = line.Split('-').Select(o => o.Trim()).ToArray();
            DatabaseList.Add(Split[1].Trim(),
                new User
                {
                    UserType = Split[0].Trim(),
                    Handle = Split[1].Trim(),
                    Password = Split[2].Trim(),
                    DateOfBirth = Split[3].Trim(),
                    Email = Split[4].Trim(),
                    MobileNumber = Split[5].Trim()
                });
        }
        void CreateDatabase(string location, string fileName)
        {
            Local_Database_FilePath = location + "\\" + fileName;
            if (!Directory.Exists(location)) Directory.CreateDirectory(location);
            if (!File.Exists(Local_Database_FilePath)) File.Create(Local_Database_FilePath);
        }

        public static void SyncDatabase(Dictionary<string, User> toSync)
        {
            List<string> toWrite = new List<string>();
            StringBuilder sb = new StringBuilder();

            foreach(KeyValuePair<string, User> item in toSync)
            {
                toWrite.Add(item.Value.ToString());
            }
            File.WriteAllLines(Local_Database_FilePath, toWrite);
        }
    }

}
