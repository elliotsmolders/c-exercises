/* RNA Transscriptie
DNA heeft steeds een RNA-complement (DNA is het gevolg van RNA transscriptie). Schrijf een programma dat een ingevoerde DNA-string omzet
 naar een RNA-string. De gebruiker voert steeds 1 DNA-nucleotide in per keer en duwt op enter, de RNA string wordt steeds groter.
  De omzetting is als volgt:

G wordt C
C wordt G
T wordt A
A wordt U
Als de gebruiker dus ACGTGGTCTTAA heeft ingevoerd moet het resultaat: UGCACCAGAAUU zijn.

Ga er van uit dat de gebruiker letter per letter invoert (telkens dus enter na een letter) en je de omgezette string doet groeien 
(m.b.v. +=). */


string userInput;
string rnaComplement="";
do{
    Console.WriteLine("Voer 1 DNA-nucleotide in of voer \"stop\" in om te stoppen. ");
    userInput = Console.ReadLine().ToLower();
    switch(userInput){
        case "g":{
            rnaComplement += "C";
            break;
        }
        case "c":{
            rnaComplement += "G";
            break;
        }
        case "t":{
            rnaComplement += "A";
            break;
        }
        case "a":{
            rnaComplement += "T";
            break;
        }
        case "stop":{
            Console.WriteLine($"RNA string = {rnaComplement}");
            break;
        }
        default:{
            Console.WriteLine("Invalid input");
            break;
        }
    }

}while(userInput !="stop");

