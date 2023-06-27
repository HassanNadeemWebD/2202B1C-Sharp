using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritence
{
    class Student : Person
    {
       public  Student(string stdName ,int stdID)
        {
            this.ID = stdID;
            this.Name = stdName;
            

            Console.WriteLine("Student Constructor Function");

        }

        public string Grade;
        public string Course;


    }
}
