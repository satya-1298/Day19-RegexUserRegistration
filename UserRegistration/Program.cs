﻿using System;
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
                Console.WriteLine("*****************");
                Console.WriteLine("Choose the Above options");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {

                    case 1:
                        details.FirstNameValidate();
                        Console.WriteLine("*****************");
                        break;
                    case 2:
                        details.Last_NameValidate();
                        Console.WriteLine("*****************");
                        break;
                    case 3:
                        details.Email_Validate();
                        Console.WriteLine("*****************");
                        break;
                    default:
                        Console.WriteLine("Invalid option");
                        break;

                }
            }
        }
    }
}
