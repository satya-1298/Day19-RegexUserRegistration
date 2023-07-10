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
        public void FirstNameValidate()
        {
            Console.WriteLine("Enter the First name ");
            string name = Console.ReadLine();
            string firstname = "^[A-Z]{1}[a-z]{3,}?";
            if (Regex.IsMatch(name, firstname))
            {
                Console.WriteLine("First Name is valid");
            }
            else
            {
                Console.WriteLine("First Name is INVALID");
            }
        }
        public void Last_NameValidate()
        {
            Console.WriteLine("Enter the last name");
            string name = Console.ReadLine();
            string lastname = "^[A-Z]{1}[a-z]{3,}?";
            if (Regex.IsMatch(name, lastname))
            {
                Console.WriteLine("Last name is Vaild");
            }
            else
            {
                Console.WriteLine("Last Name is INVALID");
            }
        }
        public void Email_Validate()
        {
            Console.WriteLine("Enter the e-Mail Address");
            string address = Console.ReadLine();
            string email = "^[A-Za-z0-9]+@[a-z]+[.][a-z]?";
            if (Regex.IsMatch(address, email))
            {
                Console.WriteLine("Email is Vaild");
            }
            else
            {
                Console.WriteLine("Email is INVALID");
            }
        }
        public void PhoneNumber()
        {
            Console.WriteLine("Enter the mobile number");
            string phone = Console.ReadLine();
            string number = "^[0-9]{2}[ ][7-9]{1}[0-9]{9}$";
            if (Regex.IsMatch(phone, number))
            {
                Console.WriteLine("Phone Number is valid");
            }
            else
            {
                Console.WriteLine("Invalid Phone Number");
            }
        }
        public void Password()
        {
            Console.WriteLine("Enter the Password");
            string password = Console.ReadLine();
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
        }

    }
}
