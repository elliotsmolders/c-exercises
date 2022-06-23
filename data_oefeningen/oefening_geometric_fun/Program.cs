/*
Vraag aan de gebruiker een hoek in graden. Zet deze om naar radialen (rad= π * graden / 180.0), gebruik Math.PI voor Pi (π).
 Gebruik vervolgens de verschillende geometrische functies in de Math. bibliotheek om de sinus (.Sin), cosinus (.Cos)
  en tangens (.Tan) van de hoek aan de gebruiker te tonen (deze functies werken in radialen, daarom moeten we deze eerst omzetten).
*/
Console.WriteLine("Geef de hoek in graden:");
double hoek = Convert.ToDouble(Console.ReadLine());
double rad = Math.PI *hoek/180.0;
double tan = Math.Tan(rad);
double sin = Math.Sin(rad);
double cos = Math.Cos(rad);
Console.WriteLine($"De hoek van {hoek} graden geeft\nsinus = {sin:F2}\ncosinus = {cos:F2}\ntangens = {tan:F2}");