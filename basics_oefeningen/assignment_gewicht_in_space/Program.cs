using System;

namespace assignment_gewicht_in_space
{
  class Program
  {
    static void Main(string[] args)
    {
        double gewichtOpAarde = 90; //kg
        double omzettingMercurius = 0.38;
        double omzettingVenus = 0.91;
        double omzettingAarde = 1;
        double omzettingMars = 0.38;
        double omzettingJupiter = 2.34;
        double omzettingSaturnus = 1.06;
        double omzettingUranus = 0.92;
        double omzettingNeptunus = 1.19;
        double omzettingPluto = 0.06;
        Console.WriteLine($"Je weegt op planeet Mercurius {Math.Round(gewichtOpAarde*omzettingMercurius,2)}kg");
        Console.WriteLine($"Je weegt op planeet Venus {Math.Round(gewichtOpAarde*omzettingVenus,2)}kg");
        Console.WriteLine($"Je weegt op planeet Aarde {Math.Round(gewichtOpAarde*omzettingAarde,2)}kg");
        Console.WriteLine($"Je weegt op planeet Mars {Math.Round(gewichtOpAarde*omzettingMars,2)}kg");
        Console.ForegroundColor=ConsoleColor.Red;
        Console.WriteLine($"Je weegt op planeet Jupiter {Math.Round(gewichtOpAarde*omzettingJupiter,2)}kg");
        Console.ForegroundColor=ConsoleColor.White;
        Console.WriteLine($"Je weegt op planeet Saturnus {Math.Round(gewichtOpAarde*omzettingSaturnus,2)}kg");
        Console.WriteLine($"Je weegt op planeet Uranus {Math.Round(gewichtOpAarde*omzettingUranus,2)}kg");
        Console.WriteLine($"Je weegt op planeet Neptunus {Math.Round(gewichtOpAarde*omzettingNeptunus,2)}kg");
        Console.ForegroundColor=ConsoleColor.Green;
        Console.WriteLine($"Je weegt op planeet Pluto {Math.Round(gewichtOpAarde*omzettingPluto,2)}kg");
        Console.ForegroundColor=ConsoleColor.White;
    }
  }
}