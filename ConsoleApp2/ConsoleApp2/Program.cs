using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Data Types
            int a = 1234569878;
            long l = 12345698783656956;
            char c = 'a';
            float f = 3.365F;
            double d = 5.3654D;
            string s = "Ali Ahmed";
            bool b = true;

            Console.WriteLine("Hello World!");
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(f);
            Console.WriteLine(s);
            Console.WriteLine(l);

            //Type Casting

            //Explicit casting
            //  int num = (int)  l;
            // Console.WriteLine(num);

            // Implicit Casting
            // string name =   d ;

            //  double ab = c;


            //  Console.WriteLine(ab);

            //Arithmetic operators
            Console.WriteLine("Enter Any Integer");
           string usernum =Console.ReadLine() ;
            int num1 = Convert.ToInt32(usernum);
            int num2 = 2;
            Console.WriteLine(num1 + num2 +  " Addition  "  );
            Console.WriteLine($"Addition : {num1 + num2} ");
            Console.WriteLine($"Mod/Remainder : {num1 % num2} ");

            //Comparison Operators (== ,< ,> , != , === , >= , <=)
        //    Console.WriteLine(num1 < num2);
            if (num1 % num2 == 0)
            {

                Console.WriteLine("Number is Even");

            }
            else if(num1 % num2 == 1)
            {
                Console.WriteLine("Number is Odd");

            }else
            {

                Console.WriteLine("Enter Correct Integer");


            }


            string name = "hassan nadeem";
            Console.WriteLine(name.ToUpper())
            Console.WriteLine(name[0]);






        }
    }
}
