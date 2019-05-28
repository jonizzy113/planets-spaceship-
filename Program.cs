using System;
using System.Collections.Generic;

namespace planets_spaceship
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            List<string> planetList = new List<string>(){"Mercury", "Mars"};
            planetList.Add("Jupiter");
            planetList.Add("Saturn");

            List<string> last = new List<string>();
            last.Add("Uranus");
            last.Add("Neptune");
            planetList.AddRange(last);
            planetList.Insert(1, "Venus");
            planetList.Insert(2, "Earth");
            planetList.Add("Pluto");

            List<string> rockyPlanets = planetList.GetRange(0, 4);
            planetList.Remove("Pluto");

            foreach(string planet in planetList) {
                Console.WriteLine(planet);
            }

            Console.WriteLine("---------");
            foreach(string rock in rockyPlanets) {
                Console.WriteLine(rock);
            }


        }
    }
}
