using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration
{
    public class Lambda_Validation
    {
        public string FirstNameValidate()
        {
            Console.WriteLine("Enter the First name");
            string name = Console.ReadLine();
            Regex validation_FirstName =new Regex( "^[A-Z]{1}[a-z]{3,}?");
            bool Name(string firstname)=>validation_FirstName.IsMatch(firstname);
            bool result = Name(name);
            if (result)
            {
                Console.WriteLine("First Name is valid");
            }
            else
            {
                Console.WriteLine("First Name is INVALID");
            }
            return name;
        }
        public string Last_NameValidate()
        {
            Console.WriteLine("Enter the Last name");
            string name = Console.ReadLine();
            Regex validationLastName = new Regex("^[A-Z]{1}[a-z]{3,}?");
            bool Name(string lastName)=>validationLastName.IsMatch(lastName);
            bool result = Name(name);
            if (result)
            {
                Console.WriteLine("Last name is Vaild");
            }
            else
            {
                Console.WriteLine("Last Name is INVALID");
            }
            return name;
        }
        public string Email_Validate()
        {
            Console.WriteLine("Enter the e-Mail Address");
            string address = Console.ReadLine();
            Regex validationEmail = new Regex("^[A-Za-z0-9]+@[a-z]+[.][a-z]?");
            bool mail(string email)=>validationEmail.IsMatch(email);
            bool result = mail(address);
            if (result)
            {
                Console.WriteLine("Email is Vaild");
            }
            else
            {
                Console.WriteLine("Email is INVALID");
            }
            return address;
        }
        public string PhoneNumber()
        {
            Console.WriteLine("Enter the mobile number");
            string phone = Console.ReadLine();
            Regex Validationnumber = new Regex("^[1-9]{2}( )[7-9]{1}[0-9]{9}$");
            bool number(string pno)=>Validationnumber.IsMatch(pno);
            bool result = number(phone);
            if (result)
            {
                Console.WriteLine("Phone Number is valid");
            }
            else
            {
                Console.WriteLine("Invalid Phone Number");
            }
            return phone;
        }
        public string Password()
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
            Regex pattern = new Regex("^(?=[a-zA-Z0-9#@$?-_]{8,}$)(?=.*?[a-z])(?=.*?[A-Z])(?=.*?[0-9]).*$");
            bool word(string val)=>pattern.IsMatch(val);
            bool result =word(password);
            if (result)
            {
                Console.WriteLine("Password is valid");
            }
            else
            {
                Console.WriteLine("Password is Invalid");
            }
            return password;
        }
    }
}
