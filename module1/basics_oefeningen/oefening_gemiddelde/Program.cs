using System;

namespace oefening_gemiddelde
{
  class Program
  {
    static void Main(string[] args)
    {
        int september = 210;
        int oktober = 220;
        int november = 225;
        double averageSleep = (september+oktober+november)/3.0;
        Console.WriteLine(averageSleep);
    }
  }
}