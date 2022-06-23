using System;

namespace oefening_kdr
{
  class Program
  {
    static void Main(string[] args)
    {
      double kills = 10;
      double deaths = 3;
      Console.WriteLine($"kdr van:{Math.Round(kills/deaths,2)}");
    }
  }
}