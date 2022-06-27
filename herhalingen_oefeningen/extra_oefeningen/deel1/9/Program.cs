/* Schrijf een programma dat een ingevoerd getal als tekst uitschrijft. Als de gebruiker dus 123 invoert zal de uitvoer zijn: honderd
 drie en twintig.
 */
int getal;
do{
 Console.WriteLine("geef een getal tot 999 in:");
  getal = Convert.ToInt32(Console.ReadLine());
}while(getal>999);
int test = 1;
int honderdTallen =getal/100;
int tienTallen =(getal-honderdTallen*100)/10;
int eenheden =(getal-honderdTallen*100-tienTallen*10);




string honderdTalTekst ="";
string tienTalTekst="";
string eenheidTekst="";
/* System.Console.WriteLine((Getallen).test); */

