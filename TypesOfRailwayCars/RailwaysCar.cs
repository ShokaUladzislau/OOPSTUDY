namespace TypesOfRailwayCars
{
    public interface RailwaysCar
    {
        public int comfort_level { get; set; }
        string name_of_car { get; set;  }   
        public string code_of_car { get; set; }
        public int passangers { get; set; }
        public int plase_for_luggage { get; set; }
        public int weight { get; set; }
        public int power { get; set; }
        void start();
        void stop();
    }
}