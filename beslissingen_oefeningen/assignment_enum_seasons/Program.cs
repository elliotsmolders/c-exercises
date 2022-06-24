/* Maak een enum die de seizoenen van het jaar bevat. Vraag aan de gebruiker om een maandnummer in te voeren. Gebruik vervolgens een switch
 om te bepalen in welk seizoen deze maand (grotendeels) ligt. Wijs deze enum toe aan een variabele in de switch. Vervolgens gebruik je een if
  om,gebaseerd op deze enum-variabele, te tonen of het om een koud seizoen (winter en herfst) of een warm seizoen (zomer en lente) gaat.

Voor de maanden mag je er van uitgaan dat maand 1 tot en met 3 winter is, 4 tot en met 6 lente enzoverder.

Doordenker: Wat gebeurt er als we nadat de enum aangemaakt is en geruime tijd in gebruik is een nieuwe value ‘onbekend’ willen toevoegen?
 Sommige mensen klagen bijvoorbeeld dat ze deze informatie prive willen houden. Als we van een persoon de geboortedatum niet weten, betekent
  dat dan dat deze persoon in de winter geboren is?

Een default enum waarde toevoegen kan hierin een oplossing zijn. Voegen we deze vooraan of achteraan toe? Welke invloed heeft dit op bestaande
 code? Kan dit iets kapotmaken en zoja, kan je 2 oplossingen bedenken hoe je deze value kan toevoegen zonder bestaande functionaliteit te
  breken? achteraan toevoegen, of enums waarden geven

Voeg een nieuwe value Onbekend toe, en zorg ervoor dat het toevoegen van deze value geen impact heeft op de bestaande applicatie.

Extra: Kan je de code zo schrijven dat de applicatie blijft vragen naar het maandnummer en de juiste output geeft totdat de gebruiker 0 
ingeeft? */
Console.WriteLine("Geef een maandnummer in:");
bool continueAsking = true;
Seasons chosenSeason = Seasons.Unknown;
while(continueAsking){
    int maandnummer = Convert.ToInt32(Console.ReadLine());
    switch(maandnummer){
        case 0:{
            continueAsking = false;
            break;
        }
        case 1:
        case 2:
        case 3:{
            chosenSeason = Seasons.Winter;
            break;
        }
        case 4:
        case 5:
        case 6:{
            chosenSeason = Seasons.Spring;
           break;
        }
        case 7:
        case 8:
        case 9:{
            chosenSeason = Seasons.Summer;
            break;
        }
        case 10:
        case 11:
        case 12:{
            chosenSeason = Seasons.Autumn;
            break;
        }
        default:{
            chosenSeason=Seasons.Unknown;
            break;
        }
    }
    if(chosenSeason == Seasons.Winter || chosenSeason == Seasons.Autumn){
    Console.WriteLine("Koude maand");
    }
    else if (chosenSeason == Seasons.Summer || chosenSeason == Seasons.Spring){
    Console.WriteLine("Warme maand");
    }
    else{
    Console.WriteLine("Onbekende");
    }
}

