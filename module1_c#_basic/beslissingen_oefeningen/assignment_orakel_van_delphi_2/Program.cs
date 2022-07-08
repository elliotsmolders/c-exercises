/* Vul de oefening aan uit het vorige hoofdstuk (zie hier). Voor het orakel je vertelt hoe lang je te leven hebt zal het eerste vragen of je
 een vrouw (v) of een man (m) bent. Dan vraagt ze je leeftijd. Mannen leven maximum tot hun 120 jaar. Vrouwen tot 150 jaar. Laat het orakel
  een duur voorspellen die kan. Als een vrouw van 50 de vraag stelt dan zal het orakel dus een getal tussen 5 en 100 (150-50) genereren. Een
   man van 35 zal tussen de 5 en 85 (120-35) jaren langer kunnen leven.
 */
Random randomGenerator = new Random();
int minJaarTeLeven = 5;
int maxLeeftijd = 125;
Console.WriteLine("Ben je een man(m) of vrouw(v)");
char geslacht = Convert.ToChar(Console.ReadLine());
Console.WriteLine("Wat is je leeftijd?");
int huidigeLeeftijd = Convert.ToInt32(Console.ReadLine());
switch(geslacht){
    case 'm':{
        maxLeeftijd = 120;
        break;
    }
    case 'v':{
        maxLeeftijd = 150;
        break;
    }
}
Console.WriteLine($"Je zal nog {randomGenerator.Next(minJaarTeLeven,(maxLeeftijd-huidigeLeeftijd))} jaar leven.");