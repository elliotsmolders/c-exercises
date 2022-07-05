/* Maak een enum die de verschillende soorten gewichten voorsteld (Obees, Zwaarlijvig, NormaalGewicht, etc.) 
Pas de bestaande “BMI met if” oefening aan zodat je deze enum gebruikt om je code leesbaarder te maken. */

Console.WriteLine("Geef je lengte in meter:");
double lengte = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Geef je gewicht in kg:");
double gewicht = Convert.ToDouble(Console.ReadLine());
double bmi = Math.Round(gewicht/Math.Pow(lengte,2),1);
Gewichten bmiCase = Gewichten.onbekend;

if(bmi<18.5){bmiCase=Gewichten.ondergewicht;}
else if(bmi<24.9){bmiCase=Gewichten.normaalGewicht;}
else if(bmi<29.9){bmiCase=Gewichten.overgewicht;}
else if(bmi<39.9){bmiCase=Gewichten.obesitas;}
else if(bmi>40){bmiCase=Gewichten.ernstigeZwaarlijvigheid;}

switch(bmiCase){
    case Gewichten.ondergewicht:{
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("ondergewicht");        
        break;
    }
    case Gewichten.normaalGewicht:{
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("normaal gewicht");
        break;
    }
    case Gewichten.overgewicht:{
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("overgewicht. Je loopt niet echt een risico, maar je mag niet dikker worden.");
        break;
    }
    case Gewichten.obesitas:{
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Zwaarlijvigheid (obesitas). Verhoogde kans op allerlei aandoeningen zoals diabetes, hartaandoeningen en rugklachten. Je zou 5 tot 10 kg moeten vermageren.");
        break;
    }
    case Gewichten.ernstigeZwaarlijvigheid:{
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("ernstige zwaarlijvigheid. Je moet dringend vermageren want je gezondheid is in gevaar (of je hebt je lengte of gewicht in verkeerde eenheid ingevoerd");
        break;
    }
    case Gewichten.onbekend:{
        Console.WriteLine("fout");
        break;
    }
}
