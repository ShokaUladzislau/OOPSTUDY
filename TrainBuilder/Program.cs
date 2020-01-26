using System;
using System.Collections.Generic;
using TypesOfRailwayCars;

namespace TrainBuilder
{
    class Program
    {
        
        static void Main(string[] args)
        {
            CommonCar commonCar = new CommonCar();
            FourPlacesCoupeCar fourPlacesCoupeCar = new FourPlacesCoupeCar();
            LaggageCar laggageCar = new LaggageCar();
            ReservedSeatsCar reservedSeatsCar = new ReservedSeatsCar();
            SeatsCar seatsCar = new SeatsCar();
            SleepingCar sleepingCar = new SleepingCar();
            TrainBuild trainBuild = new TrainBuild();


            Console.WriteLine("Do you want create a train ? : y | n");
            string Choise = Console.ReadLine();
            switch (Choise)
            {
                case "y":
                {
                    trainBuild.AddToTrain(sleepingCar);
                    trainBuild.AddToTrain(fourPlacesCoupeCar);
                    trainBuild.AddToTrain(reservedSeatsCar);
                    trainBuild.AddToTrain(commonCar);
                    trainBuild.AddToTrain(seatsCar);
                    trainBuild.AddToTrain(laggageCar);
                    trainBuild.AddHeadCars();
                    break;
                }
                case ("n") : 
                {
                    Console.WriteLine("Ok, good Bye.");
                    break;
                }
            }
            Console.Clear();
            
            while (Choise != "0")
            {
                Console.WriteLine("\n * Amount of passengers - 1\n * Amount of laggage -2\n * Show your train - 3\n * Find a railcar for a group of passengers - 4\n * Exit - 0" );
                Choise = Console.ReadLine();
                switch (Choise)
                {
                    case ("1"):
                    {
                        Console.Clear();
                        trainBuild.CountOfPassangers();
                        break;
                    }
                    case ("2"):
                    {
                        Console.Clear();
                        trainBuild.CountOfLaggage();
                        break;
                    }
                    case ("3"):
                    {
                        Console.Clear();
                        trainBuild.ShowSortedCars();
                        break;
                    }
                    case ("4"):
                    {
                        Console.Clear();
                        Console.WriteLine("Insert your diapason (x , y)");
                        trainBuild.PassFinder(Int32.Parse(Console.ReadLine()), Int32.Parse(Console.ReadLine()));
                        break;
                    }
                    default:
                    {
                        Console.Clear();
                        break;
                    }
                }
            }
        }
    }
}