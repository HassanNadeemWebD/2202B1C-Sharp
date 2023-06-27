using System;

namespace Inheritence
{




    class Program
    {
        static void Main(string[] args)
        {

            Student std1 = new Student("Ali" , 102);
            std1.setPassword("Hassan123");


            //BMW c1 = new BMW();
            Car car1 = new Car();
            car1.speed();

            Vehicle v1 = new Vehicle();
            v1.speed();
            

        }
    }
}
