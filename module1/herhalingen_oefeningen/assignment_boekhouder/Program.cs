/* Maak een ‘boekhoud-programma’: de gebruiker kan continu positieve en negatieve getallen invoeren. Telkens hij op enter duwt wordt de
 huidige invoer aan de balans bijgevoegd. Je houdt volgende zaken bij:

De balans van alle ingevoerde getallen: dit is gewoon de som van de getallen. Als de gebruiker dus de getallen 4, -10 en 8
 invoerde dan zal de balans op +2 staan (4 -10 + 8).
De som van alle negatieve invoeren. Als de gebruiker dus 4, -10, 8 en -6 invoerde dan zal dit getal op -16 staan (= -10 -6).
De som van alle positieve invoeren. Als de gebruiker dus 4, -10, 8 en -6 invoerde dan zal dit getal op +12 staan (= 4 + 8).
Het gemiddelde van alle ingevoerde getallen.
Deze 4 getallen worden steeds geüpdate en getoond wanneer de gebruiker een nieuw getal invoert en op enter duwt. */

double somPositieve = 0;
double somNegatieve =0;
double somTotaal =0;
double gemiddelde = 0;
int aantalInputs =0;


Console.WriteLine("Voer een bedrag in of voer 0 in om te stoppen");
double getalInput = Convert.ToDouble(Console.ReadLine());

while(getalInput!=0){
    aantalInputs ++;   
    if(getalInput>0){
        somPositieve+=getalInput;
    }
    else{
        somNegatieve+=getalInput;
    }
    somTotaal += getalInput;
    gemiddelde = somTotaal/aantalInputs;
    Console.Clear();
    Console.WriteLine($"som positieve bedragen = {somPositieve}\nsom negatieve bedragen = {somNegatieve}\ntotaal = {somTotaal}\ngemiddelde = {gemiddelde:F2}");

    Console.WriteLine("Voer een bedrag in of voer 0 in om te stoppen");
    getalInput = Convert.ToDouble(Console.ReadLine());

}

