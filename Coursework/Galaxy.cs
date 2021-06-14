using System;
using System.Collections.Generic;
using System.Text;

namespace Coursework
{
    class Galaxy
    {
        string galName;
        string galType;
        string galAge;

        public string GalName { get => galName; set => galName = value; }
        public string GalType { get => galType; set => galType = value; }
        public string GalAge { get => galAge; set => galAge = value; }

        public Galaxy() { }

        public Galaxy(string galName, string galType, string galAge)
        {
            this.GalName = galName;
            this.GalType = galType;
            this.GalAge = galAge;
        }

        public void ShowGalaxyInfo()
        {
            Console.WriteLine($"Galaxy name: {this.galName}");
            //Console.WriteLine($"Galaxy type: {this.galType}");
            //Console.WriteLine($"Galaxy age: {this.galAge}");
        }

        public void PrintGalaxy()
        {
            Console.WriteLine($"--- Data for {galName} galaxy ---");
            Console.WriteLine($"Type: {galType}");
            Console.WriteLine($"Age: {galAge}");
        }
    }
}