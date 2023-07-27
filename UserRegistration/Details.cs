using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration
{
    public class Details
    {
        public string FirstNameValidate(string name)
        {
           
            string firstname = "^[A-Z]{1}[a-z]{3,}?";
            if (Regex.IsMatch(name, firstname))
            {
                Console.WriteLine("First Name is valid");
            }
            else
            {
                Console.WriteLine("First Name is INVALID");
            }
            return name;
        }
        public string Last_NameValidate(string name)
        {
           
            string lastname = "^[A-Z]{1}[a-z]{3,}?";
            if (Regex.IsMatch(name, lastname))
            {
                Console.WriteLine("Last name is Vaild");
            }
            else
            {
                Console.WriteLine("Last Name is INVALID");
            }
            return name;
        }
        public string Email_Validate(string address)
        {
           
            string email = "^[A-Za-z0-9]+@[a-z]+[.][a-z]?";
            if (Regex.IsMatch(address, email))
            {
                Console.WriteLine("Email is Vaild");
            }
            else
            {
                Console.WriteLine("Email is INVALID");
            }
            return email;
        }
        public string PhoneNumber(string phone)
        {
           
            string number = "^[1-9]{2}( )[7-9]{1}[0-9]{9}$";
            if (Regex.IsMatch(phone, number))
            {
                Console.WriteLine("Phone Number is valid");
            }
            else
            {
                Console.WriteLine("Invalid Phone Number");
            }
            return number;
        }
        public string Password(string password)
        {
           
            //Minimum 8 characters
            //string pattern = "^[0-9A-Za-z@#$%&!]{8,}$";
            //Should have atleast a Upper case
            // string pattern = "^[A-Z]{1}[0-9A-Za-z@#$%&!]{8,}$";
            //should have a numeric
            //string pattern = "^(?=.*?[A-Z])(?=.*?[0-9])[0-9A-Za-z@#$%&!]{8,}$";
            //should have only one special character
            string pattern = "^(?=[a-zA-Z0-9#@$?-_]{8,}$)(?=.*?[a-z])(?=.*?[A-Z])(?=.*?[0-9]).*$";
            if (Regex.IsMatch(password,pattern))
            {
                Console.WriteLine("Password is valid");
            }
            else
            {
                Console.WriteLine("Password is Invalid");
            }
            return password;
        }
        public string SampleTest(string email)
        {
            string  pattern = "^[0-9A-Za-z]+[.+_-]{0,1}[0-9A-Za-z]+[@][A-Za-z]+[.][a-z]{2,3}([.][a-z]{2,3}){0,1}$";
            if (Regex.IsMatch(email, pattern))
            {
                Console.WriteLine("email is valid");
            }
            else
            {
                Console.WriteLine("Email is Invalid");
            }
            return pattern;
        }

    }
}
