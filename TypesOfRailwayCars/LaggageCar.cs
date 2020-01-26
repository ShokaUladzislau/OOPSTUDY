using System;

namespace TypesOfRailwayCars
{
    public class LaggageCar : RailwaysCar
    {
        public string name_of_car { get; set; }
        public string code_of_car { get; set; }
        public int passangers { get; set; }
        public int plase_for_luggage { get; set; }
        public int weight { get; set; }
        public int power { get; set; }
        public int comfort_level { get; set; }

        public LaggageCar()
        {
            name_of_car = "laggage car";
            code_of_car = "L";
            passangers = 0;
            plase_for_luggage = 96;
            weight = 84;
            comfort_level = 0;
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