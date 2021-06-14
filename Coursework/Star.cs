using System;
using System.Collections.Generic;
using System.Text;

namespace Coursework
{
    class Star : Program
    {
        string starName;
        string starClass;
        int temperature;
        double luminosity;
        double mass;
        double size;

        public string StarName { get => starName; set => starName = value; }
        public string StarClass { get => starClass; set => starClass = value; }
        public int Temperature { get => temperature; set => temperature = value; }
        public double Luminosity { get => luminosity; set => luminosity = value; }
        public double Mass { get => mass; set => mass = value; }
        public double Size { get => size; set => size = value; }

        public Star(string starName, string starClass, int temperature, double luminosity, double mass, double size)
        {
            this.StarName = starName;
            this.StarClass = starClass;
            this.Temperature = temperature;
            this.Luminosity = luminosity;
            this.Mass = mass;
            this.Size = size;
        }

        public void ShowStarInfo()
        {
            Console.WriteLine($"Star name: {this.starName}");
            Console.WriteLine($"Star class: {this.starClass}");
            Console.WriteLine($"Star temperature: {this.temperature}");
            Console.WriteLine($"Star luminosity: {this.luminosity}");
            Console.WriteLine($"Star mass: {this.mass}");
            Console.WriteLine($"Star size: {this.size}");
        }
        public void PrintStar()
        {
            Console.WriteLine("Stars:");
            Console.WriteLine($"   -   Name {starName}");
            Console.WriteLine($"       Class: {starClass}");
        }
    }
}