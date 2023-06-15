using System;

namespace ConsoleApp1
{
    class Program

    {
             static void hello(string name)
        {
            // function definition
            Console.WriteLine("Hello "+ name);


        }
        static int add(int num1 , int num2)
        {
            // function definition
            int sum = num1 + num2;

         //   Console.WriteLine("Addition of num1 and num2 =  " + sum );
            return sum;

        }



        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            // Console.WriteLine("Enter Vowel");
            //   string userInput = Console.ReadLine();
/*    switch (userInput)
    {

        case "a":
            Console.WriteLine("a is a vowel");
            break;

        case "e":
            Console.WriteLine("e is a vowel");
            break;

        case "i":
            Console.WriteLine("i is a vowel");
            break;

        default:

            Console.WriteLine("Please Enter Correct Vowel");
            break;





    }   */

    // Assignment operator
    // =  +=  -=  *=  %= /=

    int balance = 500;
    // Console.WriteLine("Enter Deposite Amount");
       // int depositeAmount = Convert.ToInt32(Console.ReadLine());
  //   balance += depositeAmount;      // balance = balance + depositeAmount
            // balance*= 100;  balance = balance * 100  
       //     Console.WriteLine("Account Balance: " + balance);

            // balance  = 5000;    balance = balance +10000

            int a = 0;
            //Console.WriteLine(++a);  // pre-increment
            //Console.WriteLine(a++);
            //Console.WriteLine(a);

            //Console.WriteLine(--a);

            //Console.WriteLine(a--);

            //Console.WriteLine(a);

            int sum = a++ + --a + a-- + ++a + ++a + a-- + --a + ++a + a;
            //          0    +  0 +  0   +  0  +  1  + 1  +  -1  +  0  +  0 
            //Console.Write("Result: " + sum);

          
           // for (int i = 1;  i<=50; i++)
           // {
           //     if( i == 4) {

           //        // break;
            
           //       continue;
                
           //     }
           //Console.WriteLine(i);

           // }

            int j = 101;
            //while (j<=100)
            //{

            //    Console.WriteLine(j);
            //    j++;

            //}


            do
            {


                Console.WriteLine(j);
                j++;

            } while (j <= 100);


            string[] arr = { "Apple" , "Mango" ,"Banana" ,"Guava" };

            Console.WriteLine(arr[2]);

            foreach(string element in arr)
            {

                Console.WriteLine(element);


            }

            hello("Uzair");

           int res =  add(55, 60);
            Console.WriteLine(res);

        }
}
}
