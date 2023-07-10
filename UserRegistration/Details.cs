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

    }
}
