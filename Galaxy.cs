using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks

class Galaxy : CelestialBody                                // Inherits name and mass from the celestial body super class but mass is never used
{
    private double Magnitude;
    private List<Star> Stars = new List<Star>();            // Wil store the corresponding list of Stars for the galaxy in this list
 
    public Galaxy(string varName, double varMagnitude)      // Constructor
    { 
        Name = varName;
        Magnitude = varMagnitude;
    }
 
    public void AddStar(Star varStar)
    {
        Stars.Add(varStar);
    }
    public void Print()
    {
        Console.WriteLine("Galaxy: {0} has a magnitude of {1}", Name, Magnitude);
        foreach (Star item in Stars)
        {
            item.Print();
        }
    }
}
