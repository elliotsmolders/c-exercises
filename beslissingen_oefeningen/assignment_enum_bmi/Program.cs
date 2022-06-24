/* Maak een enum die de verschillende soorten gewichten voorsteld (Obees, Zwaarlijvig, NormaalGewicht, etc.) 
Pas de bestaande “BMI met if” oefening aan zodat je deze enum gebruikt om je code leesbaarder te maken. */
/* Console.WriteLine("Geef je lengte in meter:");
double lengte = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Geef je gewicht in kg:");
double gewicht = Convert.ToDouble(Console.ReadLine());
double bmi = Math.Round(gewicht/Math.Pow(lengte,2),1);
Console.WriteLine($"Je hebt een BMI van {bmi}");

Gewichten mijnGewicht = Gewichten.Onbekend;
if(bmi<18.5){
    Console.ForegroundColor = ConsoleColor.Red;
    mijnGewicht = Gewichten.ondergewicht;
    Console.WriteLine("ondergewicht");
}
else if(18.5 <= bmi && bmi <= 24.9){
    Console.ForegroundColor = ConsoleColor.Green;
    mijnGewicht = Gewichten.normaalGewicht;
    Console.WriteLine("normaal gewicht");
}
else if(25 <= bmi && bmi <= 29.9){
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    mijnGewicht = Gewichten.overgewicht;
    Console.WriteLine("overgewicht. Je loopt niet echt een risico, maar je mag niet dikker worden.");
}
else if(30 <= bmi && bmi <= 39.9){
    Console.ForegroundColor = ConsoleColor.Red;
    mijnGewicht = Gewichten.obesitas;
    Console.WriteLine("Zwaarlijvigheid (obesitas). Verhoogde kans op allerlei aandoeningen zoals diabetes, hartaandoeningen en rugklachten. Je zou 5 tot 10 kg moeten vermageren.");
}
else if(bmi >= 40){
    Console.ForegroundColor = ConsoleColor.Magenta;
    mijnGewicht = Gewichten.ernstigeZwaarlijvigheid;
    Console.WriteLine("ernstige zwaarlijvigheid. Je moet dringend vermageren want je gezondheid is in gevaar (of je hebt je lengte of gewicht in verkeerde eenheid ingevoerd");
}
Console.ForegroundColor = ConsoleColor.White;
 */

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
else if(25 <= bmi && bmi <= 29.9){
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine("overgewicht. Je loopt niet echt een risico, maar je mag niet dikker worden.");
}
else if(30 <= bmi && bmi <= 39.9){
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Zwaarlijvigheid (obesitas). Verhoogde kans op allerlei aandoeningen zoals diabetes, hartaandoeningen en rugklachten. Je zou 5 tot 10 kg moeten vermageren.");
}
else if(bmi >= 40){
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.WriteLine("ernstige zwaarlijvigheid. Je moet dringend vermageren want je gezondheid is in gevaar (of je hebt je lengte of gewicht in verkeerde eenheid ingevoerd");
}
Console.ForegroundColor = ConsoleColor.White;