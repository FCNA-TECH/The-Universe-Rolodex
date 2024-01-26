using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Star : CelestialBody                                                      // Inherits name and Mass from Celesital Body
{
    private double SurfaceTemp;
    private List<Planet> Planets = new List<Planet>();                          // Will store its corresponding list of planets for the star in this list
 
    public Star(string varName, double varMass, double varSurfaceTemp)
    {
        Name = varName;
        Mass = varMass; 
        SurfaceTemp = varSurfaceTemp;
    }
 
    public void AddPlanet(Planet planet)
    {
        Planets.Add(planet);
    }
 
    public void Print()
    {
        Console.WriteLine("\t  Star: {0} has a mass of {1}kg and temp of {2}°C", Name, Mass, SurfaceTemp);
        foreach (Planet item in Planets)
        {
            item.Print();
        }
    }
}
