using System;
using System.Collections.Generic;


namespace InterfaceHomework
{
    class WaterShop
    {
        static void Main(string[] args)
        {


            //Instances, Creation of the first List
            List<IHasSpeed> movingThings = new List<IHasSpeed>();
            Yacht myYacht = new Yacht(500, 70, 0, 10);
            movingThings.Add(myYacht);
            RowBoat myRowBoat = new RowBoat(15, 0, 5);
            movingThings.Add(myRowBoat);
            Truck myTruck = new Truck(4, 500, 5000);
            myTruck.CalculateSpeed();
            movingThings.Add(myTruck);


            //first collection -> iterating through the items and selecting the ones for the second collection
            
            List<IHasSpeed> objectsForSale = new List<IHasSpeed>();
            foreach(IHasSpeed entity in movingThings)
            {
                
                if (entity.MaxSpeed < 70)
                {
                    objectsForSale.Add(entity);
                }
            }

            //second collection -> getting the size of the list (dumb method, but there must be amn action upon all the objects)
            int i = 0;
            foreach (IHasSpeed entity in objectsForSale)
            {
                i++;
            }


            //third collection - using a method on all the objects from an interface
            Console.WriteLine( i + " objects for sale!");

            List<IWaterCraft> waterCrafts = new List<IWaterCraft>();
            waterCrafts.Add(myRowBoat);
            waterCrafts.Add(myYacht);

            foreach (IWaterCraft entity in waterCrafts)
            {
                entity.Sail();
            }

        }
    }
}
