using System;

namespace TypesOfRailwayCars
{
    public class CommonCar : RailwaysCar
    {
        public string name_of_car { get; set; }
        public string code_of_car { get; set; }
        public int passangers { get; set; }
        public int plase_for_luggage { get; set; }
        public int weight { get; set; }
        public int power { get; set; }
        public int comfort_level { get; set; }

        public CommonCar()
        {
            name_of_car = "common car";
            code_of_car = "C";
            passangers = 81;
            plase_for_luggage = 81;
            weight = 78;
            comfort_level = 1;
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