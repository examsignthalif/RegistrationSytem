using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RegistrationSytem.Package;

namespace RegistrationSytem.Model
{
    public partial class User : Validation
    { 
        string _handle;
        public string Handle
        {
            get { return _handle; }
            set
            {
                if (Validation.IsValid_Handle(value))
                    _handle = value;
            }
        }

        string _userType;
        public string UserType
        {
            get { return _userType; }
            set { _userType = value; }
        }
        private string _password_String = "0000";

        public string Password
        {
            get { return _password_String; }
            set
            {
                if (Validation.IsValid_PasswordFormat(value))
                    _password_String = value;
            }
        }

        string _dateOfBirth;
        public string DateOfBirth
        {
            get { return _dateOfBirth; }
            set
            {
                if (Validation.IsValid_DOB_Formate(value))
                    _dateOfBirth = value;
            }
        }
        string _email;
        public string Email
        {
            get { return _email; }
            set
            {
                if (Validation.IsValid_EmailId(value))
                    _email = value;
            }
        }
        string _mobileNumber;
        public string MobileNumber
        {
            get { return _mobileNumber; }
            set
            {
                if (Validation.IsValid_MobileNumber(value))
                    _mobileNumber = value;
            }
        }

        string _address;
        public string Address
        {
            get { return _address; }
            set { Set_Address(value); }
        }
    }

    public partial class User
    {
        public override string ToString()
        {
            string ss = UserType + " - " + Handle + " - " + Password + " - " + DateOfBirth + " - " + Email + " - " + MobileNumber;
            return ss;
        }
        public void ResetToDefaultPassword()
        {
            _password_String = "0000";
        }
    }
}
