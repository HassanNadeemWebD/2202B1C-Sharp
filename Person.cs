using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritence
{
    public class Person
    {
     public  Person()
        {
            Console.WriteLine("Person Constructor Function");



        }


       protected int ID;
        public string Name;
        public string Contact;
        public string Email;
        private string Password;

        public void setPassword(string password)
        {
            this.Password = password;


        }





    }
}
