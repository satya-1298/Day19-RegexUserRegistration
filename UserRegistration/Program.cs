using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistration
{
    public  class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Details details = new Details();
                Console.WriteLine("*****************");
                Console.WriteLine("1-Validate first name");
                Console.WriteLine("2-Validating Last Name");
                Console.WriteLine("3-Validate Email");
                Console.WriteLine("4-Phone Number Validation");
                Console.WriteLine("5-Password Vaildation");
                Console.WriteLine("6-Validating sample Emails");
                Console.WriteLine("*****************");
                Console.WriteLine("Choose the Above options");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {

                    case 1:
                        Console.WriteLine("Enter the First name");
                        string name = Console.ReadLine();
                        details.FirstNameValidate(name);
                        Console.WriteLine("*****************");
                        break;
                    case 2:
                        Console.WriteLine("Enter the last name");
                        string lName = Console.ReadLine();
                        details.Last_NameValidate(lName);
                        Console.WriteLine("*****************");
                        break;
                    case 3:
                        Console.WriteLine("Enter the e-Mail Address");
                        string address = Console.ReadLine();
                        details.Email_Validate(address);
                        Console.WriteLine("*****************");
                        break;
                    case 4:
                        Console.WriteLine("Enter the mobile number");
                        string phone = Console.ReadLine();
                        details.PhoneNumber(phone);
                        Console.WriteLine("*****************");
                        break;
                    case 5:
                        Console.WriteLine("Enter the mobile number");
                        string password = Console.ReadLine();
                        details.Password(password);
                        Console.WriteLine("******************");
                        break;
                    case 6:
                        details.SampleTest("abc@yahoo.com");
                        details.SampleTest("abc-100@yahoo.com");
                        details.SampleTest("abc.100@yahoo.com");
                        details.SampleTest("abc111@abc.com");
                        details.SampleTest("abc-100@abc.net");
                        details.SampleTest("abc.100@abc.com.au");
                        details.SampleTest("abc@1.com");
                        details.SampleTest("abc@gmail.com.com");
                        details.SampleTest("abc+100@gmail.com");

                        break;
                    case 7:
                        Lambda_Validation lambda_Validation = new Lambda_Validation();
                        lambda_Validation.FirstNameLambda_Validate();
                        break;
                    default:
                        Console.WriteLine("Invalid option");
                        break;

                }
            }
        }
    }
}
