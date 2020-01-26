using System;

namespace TypesOfRailwayCars
{
    public class SeatsCar : RailwaysCar
    {
        public string name_of_car { get; set; }
        public string code_of_car { get; set; }
        public int passangers { get; set; }
        public int plase_for_luggage { get; set; }
        public int weight { get; set; }
        public int power { get; set; }
        public int comfort_level { get; set; }

        public SeatsCar()
        {
            name_of_car = "seats car";
            code_of_car = "S";
            passangers = 62;
            plase_for_luggage = 0;
            weight = 60;
            comfort_level = 2;
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