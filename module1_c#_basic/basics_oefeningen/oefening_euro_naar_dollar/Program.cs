using System;

namespace oefening_euro_naar_dollar
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Geef bedrag in euro in:");  
      double bedragEuro = double.Parse(Console.ReadLine());
      double wisselkoersEuroDollar = 1.05;
      double resultaat = Math.Round(bedragEuro*wisselkoersEuroDollar,2);
      Console.WriteLine($"{bedragEuro} euro is gelijk aan {resultaat} dollar");
    }
  }
}