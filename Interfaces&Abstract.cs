using System;

namespace abstractclasses
{
    interface IVehicle {

        abstract public void show();
        abstract public void edit();
     

 
        //{
        //    Console.WriteLine("Hello");
        //}

    
    }
    interface ICar
    {
    

        abstract public void carSpecs();
        abstract public void fuelAverage() ;



        //{
        //    Console.WriteLine("Hello");
        //}


    }


    abstract class Vehicle 
    {
        public string transportMode;
        public int numOfWheels;


    }
    abstract class Car : IVehicle , ICar
    {
       public  string carName;
        public string model;
        public int make;
        public int price;

        abstract public void myCar();
        public void show()
        {

            Console.WriteLine("Car Data");
        }

        public void edit()
        {
            Console.WriteLine("Edit Car Info");


        }

        public void carSpecs()
        {

            Console.WriteLine("Car Specs");

        }

        public void fuelAverage()
        {
            Console.WriteLine("my Car Fuel Average");

        }
        //{
        //    Console.WriteLine("This is my Car");
        //}
 
    }
    class BMW : Car
    {

        public string color;
      override  public void myCar()
        {
            Console.WriteLine("Look at my BMW !");

        }



    }

    class Program
    {
        static void Main(string[] args)
        {
         BMW car1 = new BMW();
            car1.carName = "BMW";
            car1.myCar();
            car1.show();

            Console.WriteLine(car1.carName);
            Console.WriteLine("Hello World!");
        }
    }
}
