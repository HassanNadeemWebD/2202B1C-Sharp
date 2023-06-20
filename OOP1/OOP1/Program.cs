using System;

namespace OOP1
{
    class Car
    {
      public  Car(string make, int model, string color, bool hasPowerSteering)
        {
            Console.WriteLine("Car Constructor Function with 4 Parameters");
            this.make = make;
            this.model = model;
            this.color = color;
            this.hasPowerSteering = hasPowerSteering;



        }


        public Car()
        {
            Console.WriteLine("Car Constructor Function with 0 Parameter");
         



        }
        public string make;
        public int model;
        public string color;
        public bool hasPowerSteering;
        //public  void postData(string carMake , int  carModel , string carColor , bool carPowerSteering)
        //  {
        //      make = carMake;
        //      model = carModel;
        //      color = carColor;
        //      hasPowerSteering = carPowerSteering;



        //  }

        public void postData(string make, int model, string color, bool hasPowerSteering)
        {
            this.make = make;
            this.model = model;
            this.color = color;
           this.hasPowerSteering = hasPowerSteering;



        }
        public void showData()
        {
            Console.WriteLine("Color: {0}   Make: {1}   Model: {2}  PowerSteering: {3} " ,
               color, make, model, hasPowerSteering);


        }

    }



    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();

            car1.color = "Black";
            car1.make = "Suzuki";
            car1.model = 2022;
            car1.hasPowerSteering = true;

            Console.WriteLine("Color: {0}   Make: {1}   Model: {2}  PowerSteering: {3} " 
                ,  car1.color, car1.make , car1.model ,car1.hasPowerSteering);


            Car car2 = new Car();
            car2.postData("Toyota", 2020, "Red", true);
            car2.showData();


            Car car3 = new Car("BMW" , 2019 , "White" , true);






         
        }
    }
}
