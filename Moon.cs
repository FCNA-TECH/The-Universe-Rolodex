using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Moon : CelestialBody                            // Inherits name and Mass from Celestial Body
{
    private double Speed;  
 
    public Moon (string varName, double varSpeed) 
    {
        Name = varName;
        Speed = varSpeed;
    }
 
    public void Print()
    {
        Console.WriteLine("\t\t\t    Moon: {0} has a speed of {1}m/s", Name, Speed);
    }
}
