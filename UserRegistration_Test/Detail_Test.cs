using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserRegistration;

namespace UserRegistration_Test
{
    public class Detail_Test
    {
        [Test]
        public void Validate_FirstName()
        {
            try
            {
                string name = "Sa";
                Details details = new Details();
                string ss = details.FirstNameValidate(name);
                Assert.AreEqual(name, ss);
            }
            catch(CustomException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        [Test]
        public void Validate_LastName()
        {
            try
            {
                string name = "adab";
                Details details = new Details();
                string ss = details.Last_NameValidate(name);
                Assert.AreEqual(name, ss);
            }
           
            catch (CustomException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        [Test]
        public void Validate_Email()
        {
            try
            {
                string mail = "satya";
                Details details = new Details();
                string ss = details.Email_Validate(mail);
                Assert.AreEqual(mail, ss);
            }
            catch (CustomException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        [Test]
        public void Validate_Phone()
        {
            try
            {
                string phone = "satya";
                Details details = new Details();
                string ss = details.PhoneNumber(phone);
                Assert.AreEqual(phone, ss);
            }
            catch (CustomException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        [Test]
        public void Validate_Password()
        {
            try
            {
                string password = "efwr4@";
                Details details = new Details();
                string ss = details.Password(password);
                Assert.AreEqual(password, ss);
            }
            catch(CustomException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        [Test]
        public void SampleEmails()
        {
            //string mail="abc@yahoo.com";
            string[] mail = {"abc-100@yahoo.com", "abc.100@yahoo.com", "abc111@abc.com", "abc - 100@abc.net", "abc.100@abc.com.au",
                                    "abc@1.com","abc@gmail.com.com","abc+100@gmail.com"};


            for (int i = 0; i < mail.Length; i++)
            {
                Details details = new Details();
                string ss = details.SampleTest(mail[i]);
                Assert.AreEqual(mail[i], ss);

            }

        }
    }
}
