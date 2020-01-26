using System;

namespace TypesOfRailwayCars
{
    public class ReservedSeatsCar : RailwaysCar
    
    {
        public string name_of_car { get; set; }
        public string code_of_car { get; set; }
        public int passangers { get; set; }
        public int plase_for_luggage { get; set; }
        public int weight { get; set; }
        public int power { get; set; }
        public int comfort_level { get; set; }

        public ReservedSeatsCar()
        {
            name_of_car = "reserved seats car";
            code_of_car = "RS";
            passangers = 54;
            plase_for_luggage = 81;
            weight = 55;
            comfort_level = 3;
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