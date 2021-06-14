using System;
using System.Collections.Generic;
using System.Text;

namespace Coursework
{
    class Moon
    {
        string moonName;

        public string MoonName { get => moonName; set => moonName = value; }

        public Moon(string moonName)
        {
            this.MoonName = moonName;
        }

        public void ShowMoonInfo()
        {
            Console.WriteLine($"Moon name: {this.moonName}");
        }
        public void PrintMoon()
        {
            Console.WriteLine("             Moons:");
            Console.WriteLine($"              -   {moonName}");
        }
    }
}
