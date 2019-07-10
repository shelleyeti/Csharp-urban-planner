using System;

namespace urban_planner
{
    public class Building
    {
        private string _designer;
        private DateTime _dateConstructed;
        private string _address;
        private string _owner;

        public int Stories { get; set; }
        public string BuildingInfo
        {
            get
            {
                return _address;
            }
        }
        public double Width { get; set; }
        public double Depth { get; set; }

        public double Volume
        {
            get
            {
                return Width * Depth * (3 * Stories);
            }
        }
        public Building(string address, string designer)
        {
            _address = address;
            _designer = designer;
        }

        public void Date()
        {
            _dateConstructed = DateTime.Now;
        }

        public void Purchase(string name)
        {
            _owner = name;
            Date();
            Console.WriteLine($"{_owner} has purchased {_address}. Deigned by {_designer} and constructed on {_dateConstructed} with {Volume} cubic meters of space.");
        }
    }
}
