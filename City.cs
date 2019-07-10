using System;
using System.Collections.Generic;

namespace urban_planner
{
    public class City
    {
        public string CityName { get; set; }
        public string Mayor { get; set; }
        public int Year { get; set; }
        // A collection of all of the buildings in the city.
        public List<Building> BuildingList;

        public City(string cityName, string mayor, int year)
        {
            CityName = cityName;
            Mayor = mayor;
            Year = year;
            BuildingList = new List<Building>();
            Console.WriteLine($"{Mayor} is the mayor of {CityName} since {Year}.");
        }


        // A method to add a building to the city.
        public void addBuilding(Building name) => BuildingList.Add(name);
    }
}