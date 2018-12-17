using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleAppUnitTestsLab7
{
    public static class Validator
    {

        public static bool EmailValidate(string email)
        {
            try
            {
                MailAddress m = new MailAddress(email);
                return true;
            }
            catch (FormatException ex)
            {
                return false;
            }
        }

        public static bool PhoneNumberValidate(string phoneNumber)
        {
            Regex phoneNumberRegex = new Regex(@"\(?\d{3}\)?-? *\d{3}-? *-?\d{4}");

            if (phoneNumberRegex.IsMatch(phoneNumber))
                return true;
            return false;
        }
    }
}
