using System;
using System.Threading.Channels;

namespace TypesOfRailwayCars
{
    public class SleepingCar : RailwaysCar
    {
        public string name_of_car { get; set; }
        public string code_of_car { get; set; }
        public int passangers { get; set; }
        public int plase_for_luggage { get; set; }
        public int weight { get; set; }
        public int power { get; set; }
        public int comfort_level { get; set; }

        public SleepingCar()
        {
            name_of_car = "sleeping car";
            code_of_car = "SC";
            passangers = 18;
            plase_for_luggage = 18;
            weight = 20;
            comfort_level = 5;
        }

        public void start()
        {
            Console.WriteLine("Car goes with help of HeadCar engine.");
        }

        public void stop()
        {
            Console.WriteLine("Сar brakes with its braking system.");
        }
    }
}