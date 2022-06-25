/* Indien we alle natuurlijke getallen van 0 tot en met 10 oplijsten die een meervoud van 3 of 5 zijn, dan krijgen we de getallen
 3,5,6,9 en 10. De som van deze 4 getallen is 33. Maak nu een programma dat de som van alle veelvouden van 3 of 5 weergeeft van 0 tot
  1000 (dit zou 234168 moeten geven). */

int som = 0;
for (int i = 0; i < 1000; i++)
{
    if( i % 3 == 0 || i % 5 == 0){
        som+=i;
    }
}
Console.WriteLine($"som = {som}");