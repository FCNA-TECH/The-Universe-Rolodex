using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http.Headers;

// The Main Program

 
 
// Milkyway
Galaxy Milkyway = new Galaxy("Milkyway", -20.6);
 
// Milkyway's Stars
Star Sun = new Star("Sun", 300, 600);
Milkyway.AddStar(Sun);

// Planets of the Sun and their moons
Planet Mercury = new Planet("Mercury", 3.7);
Sun.AddPlanet(Mercury);
Planet Venus = new Planet("Venus", 8.87);
Sun.AddPlanet(Mercury);
 
// Earth and its moon
Planet Earth = new Planet("Earth", 9.81);
Sun.AddPlanet(Earth);
Moon Moon = new Moon("Moon", 2288);
Earth.AddMoon(Moon);
 
// Mars and its Moons
Planet Mars = new Planet("Mars", 3.71);
Sun.AddPlanet(Mars);
Moon Phobos = new Moon("Phobos", 2138);
Mars.AddMoon(Phobos);
Moon Demos = new Moon("Demos", 1351);
Mars.AddMoon(Demos);

// Jupiter and its Moons (im not adding all 95 only 3)
Planet Jupiter = new Planet("Jupiter", 24.79);
Sun.AddPlanet(Jupiter);
Moon Europa = new Moon("Europa", 12743);
Jupiter.AddMoon(Europa);
Moon Io = new Moon("Io", 17334);
Jupiter.AddMoon(Io);
Moon Ganymede = new Moon("Ganymede", 10880);
Jupiter.AddMoon(Ganymede);
  
// Saturn and its Moons (im not adding all 146 only 3)
Planet Saturn = new Planet("Saturn", 10.44);
Sun.AddPlanet(Saturn);
Moon Titan = new Moon("Titan", 5570);
Saturn.AddMoon(Titan);
Moon Enceladus = new Moon("Enceladus", 12640);
Saturn.AddMoon(Enceladus);
Moon Mimas = new Moon("Mimas", 14000);
Saturn.AddMoon(Mimas);
 
// Uranus and its Moons (im not adding all 27 only 3)
Planet Uranus = new Planet("Uranus", 8.69);
Sun.AddPlanet(Uranus);
Moon Miranda = new Moon("Miranda", 0000);                         // The Speed value is 0 becuase i have not found it yet
Uranus.AddMoon(Miranda);
Moon Cupid = new Moon("Cupid", 0000);                         // The Speed value is 0 becuase i have not found it yet
Uranus.AddMoon(Cupid);
Moon Oberon = new Moon("Oberon", 0000);                         // The Speed value is 0 becuase i have not found it yet
Uranus.AddMoon(Oberon);
 
Planet Neptune = new Planet("Neptune", 11.15);
Sun.AddPlanet(Neptune);

  
Star Alpha_Centauri = new Star("Alpha Centauri", 150, 300);                         // The mass and temp values are random becuase i have not found it yet
Milkyway.AddStar(Alpha_Centauri);

Planet ProximaB = new Planet("Proxima B", 10);                                   // The gravity values are random becuase i have not found it yet
Alpha_Centauri.AddPlanet(ProximaB);

Planet Aplha_CentauriBb= new Planet("Alpha Centauri Bb", 3.71);               // The gravity values are random becuase i have not found it yet
Alpha_Centauri.AddPlanet(Aplha_CentauriBb);

 
// Andromida
Galaxy Andromida = new Galaxy("Andromida", 3.44);

// Andromida's Stars
Star Alpheratz = new Star("Alpheratz", 10, 60);                              // The mass and temp values are random becuase i have not found it yet
Andromida.AddStar(Alpheratz);

Star Mirach = new Star("Mirach", 30, 70);                                   // The mass and temp values are random becuase i have not found it yet
Andromida.AddStar(Mirach);



 
 
Milkyway.Print();
Andromida.Print();
