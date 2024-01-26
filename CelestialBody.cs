using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CelestialBody                        // This is the super class that all other classses will inherit name and mass properties from
{
    protected string Name;
    protected double Mass;
    public string GetName()
    {
        return Name;
    }
 
    public double GetMass() 
    { 
        return Mass; 
    }
}
