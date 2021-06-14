using System;
using System.Collections.Generic;

namespace Coursework
{
    class Program
    {

        public static void Main(string[] args)
        {
            string galName;
            string galType;
            string galAge;
            string starName;
            string starClass = "0";
            int temperature;
            double luminosity;
            double mass;
            double size;
            string plName;
            string plType;
            string habitable;
            string moonName;


            List<Galaxy> GalaxiesList = new List<Galaxy>();
            List<Star> StarsList = new List<Star>();
            List<Planet> PlanetsList = new List<Planet>();
            List<Moon> MoonsList = new List<Moon>();
            string cmd = Console.ReadLine();
            
            while (cmd != "exit")
            {
                switch (cmd)
                {
                                            // ADDING GALAXIES TO LIST
                    case "add galaxy":
                        
                        Console.WriteLine("Enter galaxy name, type and age:");
                        galName = Console.ReadLine();
                        galType = Console.ReadLine();
                        galAge = Console.ReadLine();

                        var Galaxy = new Galaxy(galName, galType, galAge);
                        
                        GalaxiesList.Add(Galaxy);
                        cmd = Console.ReadLine();

                        break;

                                            // LISTING GALAXIES
                    case "list galaxies":
                        Console.WriteLine($"\n--- List of all researched galaxies ---");
                        for (int i = 0; i < GalaxiesList.Count; i++)
                        {
                            GalaxiesList[i].ShowGalaxyInfo();
                        }
                        Console.WriteLine($"--- End of galaxies list ---\n");
                        cmd = Console.ReadLine();

                        break;

                                             // ADDING STARS TO LIST
                    case "add star":

                        
                        Console.WriteLine("Enter galaxy of star, star name, temperature, luminosity, mass and size");

                        galName = Console.ReadLine();
                        
                        starName = Console.ReadLine();
                        mass = double.Parse(Console.ReadLine());
                        size = double.Parse(Console.ReadLine());
                        temperature = int.Parse(Console.ReadLine());
                        luminosity = double.Parse(Console.ReadLine());


                        while (temperature >= 30000 && luminosity >= 30000 && mass >= 16 && size >= 6.6)
                        {
                            starClass = "O";
                        }

                        while ((temperature >= 10000 && temperature < 30000) && (luminosity >= 25 && luminosity < 30000) && (mass >= 2.1 && mass < 16) && (size >= 1.8 && size < 6.6))
                        {
                            starClass = "B";
                        }

                        while ((temperature >= 7500 && temperature < 10000) && (luminosity >= 5 && luminosity < 25) && (mass >= 1.4 && mass < 2.1) && (size >= 1.4 && size < 1.8))
                        {
                            starClass = "A";
                        }

                        while ((temperature >= 6000 && temperature < 7500) && (luminosity >= 1.5 && luminosity < 5) && (mass >= 1.04 && mass < 1.4) && (size >= 1.15 && size < 1.4))
                        {
                            starClass = "F";
                        }

                        while ((temperature >= 5200 && temperature < 6000) && (luminosity >= 0.6 && luminosity < 1.5) && (mass >= 0.8 && mass < 1.04) && (size >= 0.96 && size < 1.15))
                        {
                            starClass = "G";
                        }

                        while ((temperature >= 3700 && temperature < 5200) && (luminosity >= 0.08 && luminosity < 0.6) && (mass >= 0.45 && mass < 0.8) && (size >= 0.7 && size < 0.96))
                        {
                            starClass = "K";
                        }

                        while ((temperature >= 2400 && temperature < 3700) && (luminosity <= 0.08) && (mass >= 0.08 && mass < 0.45) && (size <= 0.7))
                        {
                            starClass = "M";
                        }
                        var Star = new Star(starName, starClass, temperature, luminosity, mass, size);

                        StarsList.Add(Star);
                        cmd = Console.ReadLine();

                        break;
                                                     // LISTING STARS
                    case "list stars":
                        for (int i = 0; i < StarsList.Count; i++)
                        {
                            Console.WriteLine($"\nStar info:\n");
                            StarsList[i].ShowStarInfo();
                        }
                        cmd = Console.ReadLine();

                        break;


                    // ADDING PLANETS TO LIST
                    case "add planet":
                        
                        Console.WriteLine("Enter star of planet, planet name, type and if habitable:");
                        starName = Console.ReadLine();
                        plName = Console.ReadLine();
                        plType = Console.ReadLine();
                        habitable = Console.ReadLine();

                        var Planet = new Planet(plName, plType, habitable);

                        PlanetsList.Add(Planet);
                        cmd = Console.ReadLine();

                        break;
                    // LISTING PLANETS
                    case "list planets":
                        for (int i = 0; i < PlanetsList.Count; i++)
                        {
                            Console.WriteLine($"\nPlanet info:\n");
                            PlanetsList[i].ShowPlanetInfo();
                        }
                        cmd = Console.ReadLine();

                        break;


                    // ADDING MOONS TO LIST
                    case "add moon":
                        
                        Console.WriteLine("Enter planet of moon, moon name:");
                        plName = Console.ReadLine();
                        moonName = Console.ReadLine();

                        var Moon = new Moon(moonName);

                        MoonsList.Add(Moon);
                        cmd = Console.ReadLine();

                        break;
                    // LISTING MOONS
                    case "list moons":
                        for (int i = 0; i < MoonsList.Count; i++)
                        {
                            Console.WriteLine($"\nMoon info:\n");
                            MoonsList[i].ShowMoonInfo();
                        }
                        cmd = Console.ReadLine();

                        break;
                        
                            
                    case "stats":
                        int a = GalaxiesList.Count;
                        int b = StarsList.Count;
                        int c = PlanetsList.Count;
                        int d = MoonsList.Count;
                            Console.WriteLine("--- Stats ---");
                            Console.WriteLine($"Galaxies: {a}");
                            Console.WriteLine($"Stars: {b}");
                            Console.WriteLine($"Planets: {c}");
                            Console.WriteLine($"Moons: {d}");
                            Console.WriteLine("--- End of stats ---");
                        cmd = Console.ReadLine();
                        break;

                    case "print":

                        for (int i = 0; i < GalaxiesList.Count; i++)
                        {
                            GalaxiesList[i].PrintGalaxy();
                            StarsList[i].PrintStar();
                            PlanetsList[i].PrintPlanet();
                            MoonsList[i].PrintMoon();

                            Console.WriteLine($"--- End of data for this galaxy ---");
                        }

                        cmd = Console.ReadLine();
                        break;
                }
            }
            while (cmd == "exit")
            {
                return;
            }
            
        }
    }
}