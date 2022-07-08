/* Toon de tafels tot 10 van ieder getal van 1 tot en met n. Toon iedere tafel horizontaal! Als de gebruiker 8 invoert verschijnt er:1x1
 = 1, 2x1 = 2, 3x1 = 3, 4x1 = 4, 5x1 = 5, 6x1 = 6, 7x1 = 7, 8x1 = 8, ... 1x10 = 10, 2x10 = 20, 3x10 = 30, 4x10 = 40, 5x10 = 50, 6x10 = 60,
  7x10 = 70, 8x10 = 80, */
Console.WriteLine("geef n");
int n = Convert.ToInt32(Console.ReadLine());
for(int i = 1;i<=n;i++){
    for (int j = 1; j <= 10; j++)
    {
        Console.Write($"{j}x{i} = {j*i}, ");   
    }
}