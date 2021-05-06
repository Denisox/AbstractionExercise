using System;
using System.Collections.Generic;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IVehicle> vehicles = new List<IVehicle>();

            // myCar1 code


            Console.WriteLine("\nInformation for the first car. \n");
            RegularCar myCar1 = new RegularCar("Ford", 500, "black");
            myCar1.DriveBad(myCar1.Drivable);
            myCar1.TakeSeat();
            myCar1.TakeSeat();
            myCar1.Repair(myCar1.Drivable);
            Console.WriteLine(myCar1.MaxRPM);
            vehicles.Add(myCar1);

            //myCar2 Code

            Console.WriteLine("\nInformation for the second car. \n");
            RegularCar myCar2 = new RegularCar("Opel", 680, "dark blue");
            myCar2.ChangeColor(myCar2.Color);
            Console.WriteLine(myCar2.MaxRPM);
            vehicles.Add(myCar2);

            //sportCar1 Code

            Console.WriteLine("\nInformation for the third car. \n");
            SportCar sportCar1 = new SportCar("Ferrari", 920, "red", 2.2);
            sportCar1.IsGood(sportCar1.From0to100);
            vehicles.Add(sportCar1);

            // cityTruck1 Code

            Console.WriteLine("\nInformation for the first truck. \n");
            CityTruck myCityTruck1 = new CityTruck(200, 455, 4);
            myCityTruck1.LockDoor(myCityTruck1.UnlockedDoors);
            myCityTruck1.GetCargo();
            vehicles.Add(myCityTruck1);

            //cityTruck2 Code

            Console.WriteLine("\nInformation for the second truck. \n");
            CityTruck myCityTruck2 = new CityTruck(400, 500, 6);
            myCityTruck2.GetCargo();
            myCityTruck2.IsGood();
            vehicles.Add(myCityTruck2);

            // interCityTruck1 Code

            Console.WriteLine("\nInformation for the third truck. \n");
            IntercityTruck interCityTruck1 = new IntercityTruck(2000, 480, 8);
            interCityTruck1.GetCargo();
            interCityTruck1.IsGood();
            interCityTruck1.LockDoor(interCityTruck1.UnlockedDoors);
            vehicles.Add(interCityTruck1);
            
            //List Manipulation

            foreach(IVehicle vehicle in vehicles)
            {
                if (vehicle.CalculateSpeed(vehicle.MaxRPM) > 170)
                {
                    Console.WriteLine("\n" + vehicle.ToString() + "It is in the category fast with max speed " + vehicle.CalculateSpeed(vehicle.MaxRPM) + " km/h. \n");
                }
            }

        }
    }
}
