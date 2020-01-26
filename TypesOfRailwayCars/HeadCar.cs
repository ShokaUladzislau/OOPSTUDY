using System;
using System.Runtime.InteropServices;

namespace TypesOfRailwayCars
{
    public class HeadCar : RailwaysCar
    {
        public string name_of_car { get; set; }
        public string code_of_car { get; set; }
        public int passangers { get; set; }
        public int plase_for_luggage { get; set; }
        public int weight { get; set; }
        public int power { get; set; }
        public int comfort_level { get; set; }

        public HeadCar()
        {
            name_of_car = "head car";
            code_of_car = "H";
            plase_for_luggage = 2;
            weight = 126;
            power = 2000;
            comfort_level = 5;
        }
        
        public void start()
        {
            Console.WriteLine("Car goes with help of Engine.");
        }

        public void stop()
        {
            Console.WriteLine("Сar brakes with its braking system.");
        }
    }
}