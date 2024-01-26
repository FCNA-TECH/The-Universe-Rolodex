using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Planet : CelestialBody                                    // Inherits Name and Mass from Celestial Body
{
    private double Gravity;
    private List<Moon> Moons = new List<Moon>();                // Stores its corresponding Moons in a list of moons
 
    public Planet(string varName, double varGravity)
    {
        Name = varName;
        Gravity = varGravity;
    }
 
    public void AddMoon(Moon moon)
    {
        Moons.Add(moon);
    }
 
    public void Print()
    {
        Console.WriteLine("\t\t  Planet: {0} has a Gravitational Acceleration of {1}m/ss", Name, Gravity);
        foreach (Moon item in Moons)
        {
            item.Print();
        }
    }
}
