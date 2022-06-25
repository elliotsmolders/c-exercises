/* Deel 1: Teken de flowchart van het volgende programma.
Deel 2: Pas het programma zo aan dat de tekst die verschijnt bij het inlezen van de volgende poging het resterende interval aangeeft.
 Gebruik hiervoor twee extra variabelen “ondergrens” en “bovengrens” die als beginwaarden respectievelijk 0 en 100 krijgen. 
 Bij het inlezen van de volgende waarde voor poging zal deze toegekend worden aan ondergrens of bovengrens naargelang ze groter dan wel
  kleiner dan het te zoeken getal is. Zie hieronder een voorbeeldoutput: 

Deel 3: Bouw in het programma een controle in die er voor zorgt dat je geen waarde meer kan ingeven die buiten het opgegeven interval ligt
 (dus ook indien de grenzen aangepast worden moet deze controle blijven werken!).

Deel 4: Pas het programma aan zodat er een maximum aantal pogingen is toegestaan. Om dit maximum te bepalen moet je uitgaan van de 
beginwaarden van “ondergrens” en “bovengrens”. Ga dus na hoeveel pogingen er in het ideale geval (bij het zoeken telkens de middelste waarde 
als nieuwe poging ingeven) maximaal nodig zijn om een interval te doorzoeken. */

int getal;
int poging= 0;
int aantalPogingen= 0;
int bovengrens = 100;
int ondergrens = 0;
string pogingString;
bool gevonden= false;
Random rand= new Random();
getal= rand.Next(ondergrens, bovengrens);
int maxPogingen = (int)Math.Log2(bovengrens-ondergrens);
Console.WriteLine($"maximum toegelaten pogingen = {maxPogingen}");
while(!gevonden && aantalPogingen < maxPogingen)
{
    aantalPogingen++;
    do{
        Console.WriteLine($"Geef een getal tussen {ondergrens} en {bovengrens}");
        pogingString = Console.ReadLine(); 
        poging = int.Parse(pogingString);
    }while(ondergrens > poging || poging > bovengrens);

    if(getal > poging)
    {
        Console.WriteLine("Het gezochte getal is groter, probeer opnieuw.");
        ondergrens = poging;
    }
    else if(getal < poging)
    {
        Console.WriteLine("Het gezochte getal is kleiner, probeer opnieuw.");
        bovengrens = poging;
    }
    else 
        gevonden = true;
}
if(gevonden){
    Console.WriteLine($"Gevonden! Het te zoeken getal was inderdaad {getal} je had er {aantalPogingen} pogingen voor nodig.");
}
else{
    Console.WriteLine($"Niet gevonden binnen de maximum toegelaten gokken ({maxPogingen}).\nHet getal dat we zochten was {getal}");
}
