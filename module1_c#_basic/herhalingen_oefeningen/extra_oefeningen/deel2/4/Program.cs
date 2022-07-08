/* Schrijf een programma om de eerste n termen van een harmonische reeks te tonen en bereken vervolgens de som van deze termen.
 Als de gebruiker bijvoorbeeld 5 invoert verschijnt er (de laatste plus mag je tonen om geen onnodige ingewikkelde code te moeten schrijven)
 :1/1 + 1/2 + 1/3 + 1/4 + 1/5 + Som = 2.283334 */

 Console.WriteLine("geef n:");
 int n = Convert.ToInt32(Console.ReadLine());
 double som=0;
 for(int i =1;i<=n;i++){
    som += 1.0/i;
    Console.Write($"1/{i} +");
 }
 Console.Write($"Som = {som}");