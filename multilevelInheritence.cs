using System;

public class Vehicle
{
	public Vehicle()
	{

		Console.WriteLine("Vehicle COnstructor");


	}

	public string make;
	public int model;
	private int price;


 	virtual public void speed()
    {

		Console.WriteLine("Vehicle Speed");



    }

}



public class Car : Vehicle
{

	public Car() {

		Console.WriteLine("Car Constructor");

	}

	public bool powerStearing;


    override public void speed()
	{

		Console.WriteLine("Car Speed");



	}

}


sealed class BMW : Car
{
	public BMW()
    {


		Console.WriteLine("BMW COnstructor");
    }

	public string propertyBMW;


}
