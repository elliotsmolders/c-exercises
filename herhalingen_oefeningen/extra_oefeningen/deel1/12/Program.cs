/* Schrijf een programma dat de macht van een getal toont. De gebruiker voert eerst het getal in, gevolgd door de macht 
(bv. 2 en 4 zal als resultaat 16 geven (2 tot de 4e macht)). Merk op dat je geen gebruik mag maken van Math.Pow. Je dient zelf de
 vermenigvuldiging helemaal(m.b.v. loops) uit te voeren. */
 Console.WriteLine("geef getal in:");
 int getal = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine("geef exponent:");
 int exponent = Convert.ToInt32(Console.ReadLine());
 int result = 1;
 for(int i = 1;i<=exponent;i++){
    result *= getal;
 }
 Console.WriteLine($"{getal} tot de macht {exponent} is {result}");
 
