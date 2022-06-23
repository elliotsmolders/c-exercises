using System;

namespace assignment_simple_maths
{
  class Program
  {
    static void Main(string[] args)
    {
int resultInt1 = -1+4*6;
double resultDouble1 = -1+4*6;
Console.WriteLine($"Uitkomst -1+4*6 saved als integer:{resultInt1}");
Console.WriteLine($"Uitkomst -1+4*6 saved als double:{resultDouble1}");
int resultInt2 = ( 35 + 5 ) % 7;
double resultDouble2 = ( 35 + 5 ) % 7;
Console.WriteLine($"Uitkomst ( 35 + 5 ) % 7 saved als integer:{resultInt2}");
Console.WriteLine($"Uitkomst ( 35 + 5 ) % 7 saved als double:{resultDouble2}");
int resultInt3 = 14 + -4 * 6 / 11;
double resultDouble3 = 14 + -4 * 6 / 11;
Console.WriteLine($"Uitkomst 14 + -4 * 6 / 11 saved als integer:{resultInt3}");
Console.WriteLine($"Uitkomst 14 + -4 * 6 / 11 saved als double:{resultDouble3}");
int resultInt4 = 2 + 15 / 6 * 1 - 7 % 2;
double resultDouble4 = 2 + 15 / 6 * 1 - 7 % 2;
Console.WriteLine($"Uitkomst 2 + 15 / 6 * 1 - 7 % 2 saved als integer:{resultInt4}");
Console.WriteLine($"Uitkomst 2 + 15 / 6 * 1 - 7 % 2 saved als double:{resultDouble4}");
int resultInt5 = 7 / 3;
double resultDouble5 = 7 / 3;
Console.WriteLine($"Uitkomst 7 / 3 saved als integer:{resultInt5}");
Console.WriteLine($"Uitkomst 7 / 3 saved als double:{resultDouble5}");
//int resultInt6 = 7 / 3.0;
double resultDouble6 = 7 / 3;
Console.WriteLine($"Uitkomst 7 / 3.0 saved als integer:kan niet expliciet een double naar een int casten");
Console.WriteLine($"Uitkomst 7 / 3.0 saved als double:{resultDouble6}");  
    }
  }
}