/* Indien we alle natuurlijke getallen van 0 tot en met 10 oplijsten die een meervoud van 3 of 5 zijn, dan krijgen we de getallen
 3,5,6,9 en 10. De som van deze 4 getallen is 33. Maak nu een programma dat de som van alle veelvouden van 3 of 5 weergeeft van 0 tot
  1000 (dit zou 234168 moeten geven). */

int som = 0;
for (int i = 0; i < 1000; i++) 
{
    //if(som>=231468){break;}
    if( i % 3 == 0 || i % 5 == 0){
        som+=i;
        //if(i==0){continue;}
        //Console.WriteLine(i);
    }
}
Console.WriteLine($"som = {som}");

/*
Stap 2: Los onderstaande puntjes op door gebruik te maken van break en continue.

De loop begint te lopen vanaf 0. Toon alle cijfers die deelbaar zijn door 3 of door 5.
Zorg ervoor dat 0 niet geprint wordt naar de console.


Laat de loop niet 1.000 maar 10.000 keer draaien.
Als de som groter of gelijk is dan 234168 mag de loop stoppen.

Voeg toe in commentaar waar en waarom je break of continue gebruikt hebt. Welke voordelen kunnen deze keywords opleveren? Zijn er
 ook nadelen verbonden aan het gebruik van deze keywords? Staaf je uitleg met comments in de code.

 Je kan break/continue als preconditions gebruiken aan de start van de loops, vaak kan je het gewoon op andere manieren oplossen;
 zo kunnen we in dit geval gewoon:  && som<=234168 toevoegen wat hetzelfde resultaat oplevert.
    (int i = 0; i < 10000 && som<=234168; i++) 
*/