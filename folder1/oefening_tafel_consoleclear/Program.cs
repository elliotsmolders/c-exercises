using System;

namespace oefening_tafel_consoleclear
{
  class Program
  {
    static void Main(string[] args)
    {
      string userInput = System.String.Empty;
      int tableOf = 414;
      int count = 1;
      Console.WriteLine($"table of {tableOf}, type 'stop' to exit, anything else to see the next table ");
      Console.ReadLine();
      Console.Clear();
      while (userInput != "stop"){
        Console.WriteLine($"{count}*{tableOf}={count*tableOf}");
        Console.WriteLine("druk op enter voor de volgende lijn");
        userInput = Console.ReadLine();
        count++;
        Console.Clear();
      }    
    }
  }
}