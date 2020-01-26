using System;
using TypesOfRailwayCars;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace TrainBuilder
{
    public class TrainBuild
    {
        HeadCar _headCar =new HeadCar();
        List<RailwaysCar> railcarslist = new List<RailwaysCar>();
        int count;
        
        public void AddToTrain(RailwaysCar x)
        {
            Console.WriteLine($"how many {x.name_of_car}s  are you needed ? (Type - {x.code_of_car})"); 
            count = Int32.Parse(Console.ReadLine());

                for (int i = 0; i < count; i++)
                {
                    railcarslist.Add(x);
                }
            count = 0;
        }

        public void AddHeadCars()
        {
            int weight_of_train = 0;
            int power_of_train = 0;
            railcarslist.Add(_headCar);

            foreach (var H in railcarslist)
            {
                weight_of_train += H.weight;
                power_of_train += H.power;
            }

            if (weight_of_train > power_of_train)
            {
                AddHeadCars();
            }
        }

        private void ShowListOfCars()
        {
            Console.WriteLine("Your train:");
            foreach (var C in railcarslist)
            {
                Console.WriteLine(
                    $"- Type of railcar - {C.code_of_car} ({C.name_of_car}), Passangers - {Convert.ToString(C.passangers)}, Luggage - {Convert.ToString(C.plase_for_luggage)}, " +
                    $"Power - {Convert.ToString(C.power)}, Weight - {Convert.ToString(C.weight)}"); 
            }
        }

         public void CountOfPassangers()
        {
            foreach (var P in railcarslist)
            {
                count += P.passangers;
            }
            Console.WriteLine($"Count of passangers - {Convert.ToString(count)}");
            count = 0;
        }
         public void CountOfLaggage()
         {
             foreach (var L in railcarslist)
             {
                 count += L.plase_for_luggage;
             }
             Console.WriteLine($"Count of laggage - {Convert.ToString(count)}");
             count = 0;
         }

         public void ShowSortedCars()
         {
             railcarslist.Sort((x, y) =>  y.comfort_level.CompareTo(x.comfort_level));
             ShowListOfCars();
         }

         public void PassFinder(int x, int y)
         {
             foreach (var C in railcarslist)
             {
                 if (C.passangers >= x && C.passangers <= y)
                 {
                     Console.WriteLine($"fit your parameters - {C.name_of_car}, Cod - {C.code_of_car}, Amount passengers - {C.passangers}");
                 }
             }
         }
    }
}