/* Vraag aan de gebruiker wat hij wenst te berekenen: spanning, weerstand of stroomsterkte. Vraag vervolgens de 2 andere waarden 
(als dus de gebruiker “Spanning” kiest vraag je aan de gebruiker de stroomsterkte en de weerstand) en bereken m.b.v. de wet van Ohm
 de gewenste waarde. (spanning = stroomsterkte*weerstand)*/

Console.WriteLine("wat wil je berekenen?\n1:Spanning\n2:Stroomsterkte\n3:Weerstand");
int option = Convert.ToInt32(Console.ReadLine());
switch (option)
 {
    case 1:{
    Console.WriteLine("We berekenen de spanning.");
    Console.WriteLine("geef de stroomsterkte:");
    double stroomsterkte = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Geef de weerstand:");
    double weerstand = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine($"De spanning is {stroomsterkte*weerstand:F2} volt");
    break;

    }


    case 2:{
    Console.WriteLine("We berekenen de stroomsterkte.");
    Console.WriteLine("Geef de spanning:");
    double spanning = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Geef de weerstand:");
    double weerstand = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine($"De stroomsterkte is {spanning/weerstand:F2} ampère");
    break;
    }


    case 3:{
    Console.WriteLine("We berekenen de weerstand.");
    Console.WriteLine("geef de stroomsterkte:");
    double stroomsterkte = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Geef de spanning:");
    double spanning = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine($"De weerstand is {spanning/stroomsterkte:F2} ohm");
    break;}

    default:
    Console.WriteLine("ongeldige input");
    break;
 }