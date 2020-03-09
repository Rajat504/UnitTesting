using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace XUnitRegex
{
    class Userregistration
    {
        public static bool FirstName(string name)
        {
            var nameregexpattern = "^([a-zA-Z]*){1,15}$";
            Regex pattern = new Regex(nameregexpattern);
            if(pattern.IsMatch(name))
            {
                return true;

            }

            return false;
        }
        public static bool LastName(string name)
        {
            var nameregexpattern = "^([a-zA-Z]*){1,10}$";
            Regex pattern = new Regex(nameregexpattern);
            if (pattern.IsMatch(name))
            {
                return true;
            }
            else
                return false;
        }
        public static bool email(string name)
        {
            var emailpattern= "^[A-Za-z0-9/.]{6,}@[a-zA-Z]{4,}.(com|in|co.in)$"; 
            Regex pattern = new Regex(emailpattern);
            if (pattern.IsMatch(name))
            {
                return true;
            }
            else
                return false;
        }
        public static bool password(string name)
        {
            var password = "^(?=.*[A-Z])(?=.*[a-z])(?=.*[0-9])(?=.*[/-_!@#$%^&*])(?=.{8,14})";
            Regex pattern = new Regex(password);
            if (pattern.IsMatch(name))
            {
                return true;

            }
            else
                return false;
        }
        public static bool contact(string name)
        {
            var contact = "^[0-9]{10}$";
            Regex pattern = new Regex(contact);
            if (pattern.IsMatch(name))
            {
                return true;
            }
            else
                return false;
        }

    }
}
