using System;
using System.Collections.Generic;

namespace urban_planner
{
    class Program
    {
        static void Main(string[] args)
        {
            var FiveOneTwoEigth = new Building("512 8th Avenue", "Eliot Clarke")
            {
                Stories = 3,
                Width = 50,
                Depth = 25,
            };

            var OneOneOneTwo = new Building("1112 Douglas Avenue", "Addam Joor")
            {
                Stories = 2,
                Width = 30,
                Depth = 50,
            };

            FiveOneTwoEigth.Purchase("Shelley");
            OneOneOneTwo.Purchase("Emily Loggins");

            var nashville = new City("Nashville", "David I Won't Pay the Teachers Briley", 2017);
            nashville.addBuilding(FiveOneTwoEigth);
            nashville.addBuilding(OneOneOneTwo);

            foreach (Building building in nashville.BuildingList)
            {
                Console.WriteLine($"This is the address of a building in Nashville: {building.BuildingInfo}.");
            }
        }
    }
}
