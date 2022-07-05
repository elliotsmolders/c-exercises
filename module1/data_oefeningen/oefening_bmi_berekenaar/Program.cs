/* Maak een programma dat aan de gebruiker z’n lengte en gewicht vraagt en vervolgens z’n berekende BMI (Body Mass Index) toont.
 Gebruik Math.Round om de uitkomst tot maximum 2 cijfers na de komma te tonen.

Reken na met je rekenmachine of je uitkomst wel degelijk klopt! */
Console.WriteLine("Geef je lengte in meter:");
double lengte = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Geef je gewicht in kg:");
double gewicht = Convert.ToDouble(Console.ReadLine());
double bmi = Math.Round(gewicht/Math.Pow(lengte,2),2);
Console.WriteLine($"Je hebt een BMI van {bmi}");