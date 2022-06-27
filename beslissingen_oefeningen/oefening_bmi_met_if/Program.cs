/* Pas je BMI-programma (zie practica vorige hoofdstuk) aan zodat je programma feedback geeft aan de gebruiker naargelang
 het berekende BMI.

De kleur tussen haakjes geeft aan in welke kleur je deze tekst zet:

Onder de 18,5 (rood): ondergewicht.
Tussen de 18,5 en de 24,9 (groen): normaal gewicht.
Tussen de 25 en de 29,9 (donkergeel): overgewicht. Je loopt niet echt een risico, maar je mag niet dikker worden.
Tussen de 30 en de 39,9 (rood): Zwaarlijvigheid (obesitas). Verhoogde kans op allerlei aandoeningen zoals diabetes, hartaandoeningen
 en rugklachten. Je zou 5 tot 10 kg moeten vermageren.
Boven de 40 (magenta): ernstige zwaarlijvigheid. Je moet dringend vermageren want je gezondheid is in gevaar (of je hebt je lengte of
 gewicht in verkeerde eenheid ingevoerd). */

Console.WriteLine("Geef je lengte in meter:");
double lengte = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Geef je gewicht in kg:");
double gewicht = Convert.ToDouble(Console.ReadLine());
double bmi = Math.Round(gewicht/Math.Pow(lengte,2),1);
Console.WriteLine($"Je hebt een BMI van {bmi}");

if(bmi<18.5){
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("ondergewicht");
}
else if(18.5 <= bmi && bmi <= 24.9){
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("normaal gewicht");
}
else if(bmi <= 29.9){
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine("overgewicht. Je loopt niet echt een risico, maar je mag niet dikker worden.");
}
else if(bmi <= 39.9){
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Zwaarlijvigheid (obesitas). Verhoogde kans op allerlei aandoeningen zoals diabetes, hartaandoeningen en rugklachten. Je zou 5 tot 10 kg moeten vermageren.");
}
else if(bmi >= 40){
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.WriteLine("ernstige zwaarlijvigheid. Je moet dringend vermageren want je gezondheid is in gevaar (of je hebt je lengte of gewicht in verkeerde eenheid ingevoerd");
}
Console.ForegroundColor = ConsoleColor.White;
