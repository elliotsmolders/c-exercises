//Vraag aan de gebruiker 3 kommagetallen. Bereken het gemiddelde van deze 3 getallen.
Console.WriteLine("Geef 3 kommagetallen");
Console.WriteLine("Getal1:");
double getal1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Getal2:");
double getal2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Getal3:");
double getal3 = Convert.ToDouble(Console.ReadLine());
double gemiddelde = (getal1+getal2+getal3)/3;
Console.WriteLine($"Gemiddelde = {gemiddelde:F2}");



