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
            string name = "Satya";
            Details details = new Details();
            string ss = details.FirstNameValidate(name);
            Assert.AreEqual(name,ss);
        }
        [Test] 
        public void Validate_LastName() 
        {
            string name = "Adabala";
            Details details = new Details();
            string ss = details.Last_NameValidate(name);
            Assert.AreEqual(name, ss);
        }
        [Test]
        public void Validate_Email()
        {

            string mail = "satya123@gmail.com";
            Details details = new Details();
            string ss = details.Email_Validate(mail);
            Assert.AreEqual(mail, ss);
        }
        [Test]
        public void Validate_Phone()
        {

            string phone ="91 9342424223";
            Details details = new Details();
            string ss = details.PhoneNumber(phone);
            Assert.AreEqual(phone, ss);
        }
        [Test]
        public void Validate_Password()
        {

            string password = "#@3Sad@234";
            Details details = new Details();
            string ss = details.Last_NameValidate(password);
            Assert.AreEqual(password, ss);
        }
        [Test]
        public void SampleEmails()
        {
            //string mail="abc@yahoo.com";
            string[] mail = {"abc-100@yahoo.com", "abc.100@yahoo.com", "abc111@abc.com", "abc - 100@abc.net", "abc.100@abc.com.au",
                                    "abc@1.com","abc@gmail.com.com","abc+100@gmail.com"};
            
           
            for (int i =0;i<mail.Length;i++)
            {
                Details details = new Details();
                string ss = details.SampleTest(mail[i]);               
                Assert.AreEqual(mail[i], ss);
                
            }
           
        }
    }
}
