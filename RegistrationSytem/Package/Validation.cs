using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationSytem.Package
{
    public class Validation
    {
        public static bool IsValid_Handle(string handle)
        {
            // Code
            try
            {
                return true;
            }
            catch (Exception ex) { return false; }
        }
        public static bool IsValid_DOB_Formate(string dob)
        {
            // Code
            try
            {
                return true;
            }
            catch (Exception ex) { return false; }
        }
        public static bool IsValid_PasswordFormat(string _pwd)
        {
            // Code
            try
            {
                return true;
            }
            catch (Exception ex) { return false; }
            
        }

        public static bool IsValid_MobileNumber(string mobileNumber)
        {
            // Code
            try
            {
                return true;
            }
            catch (Exception ex) { return false; }
        }

        public static bool IsValid_EmailId(string emailId)
        {
            // Code
            try
            {
                return true;
            }
            catch (Exception ex) { return false; }
        }

        public static bool Set_Address(string address)
        {
            // Code
            try
            {
                return true;
            }
            catch (Exception ex) { return false; }
        }

        public bool IsOnlyAlphas(string handleName)
        {
            // Code
            return true;
        }
    }
}
