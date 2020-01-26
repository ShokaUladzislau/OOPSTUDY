using System;

namespace TypesOfRailwayCars
{
    public class FourPlacesCoupeCar : RailwaysCar
    {
        public string name_of_car { get; set; }
        public string code_of_car { get; set; }
        public int passangers { get; set; }
        public int plase_for_luggage { get; set; }
        public int weight { get; set; }
        public int power { get; set; }
        public int comfort_level { get; set; }

        public FourPlacesCoupeCar()
        {
            name_of_car = "four-places coupe car";
            code_of_car = "FPC";
            passangers = 36;
            plase_for_luggage = 36;
            weight = 38;
            comfort_level = 4;
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