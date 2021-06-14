using System;
using System.Collections.Generic;
using System.Text;

namespace Coursework
{
    class Planet
    {
        string plName;
        string plType;
        string habitable;

        public string PlName { get => plName; set => plName = value; }
        public string PlType { get => plType; set => plType = value; }
        public string Habitable { get => habitable; set => habitable = value; }

        public Planet(string plName, string plType, string habitable)
        {
            this.PlName = plName;
            this.PlType = plType;
            this.Habitable = habitable;
        }

        public void ShowPlanetInfo()
        {
            Console.WriteLine($"Planet name: {this.plName}");
            Console.WriteLine($"Planet type: {this.plType}");
            Console.WriteLine($"Supports life? {habitable.ToString()}.");
        }
        public void PrintPlanet()
        {
            Console.WriteLine("       Planets:");
            Console.WriteLine($"         -   Name {plName}");
            Console.WriteLine($"             Type: {plType}");
            Console.WriteLine($"             Supports life: {habitable}");
        }
    }
}
