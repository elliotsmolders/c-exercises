/* Maak een console-applicatie voor een assistent voetbaltrainer (of een sport naar keuze).

De voetbalcoach wil na de match iedere knappe en domme actie van een speler weten. Op die manier weet hij aan het einde van de match wie er de meeste goede en slechte acties doet. De spelers hebben rugnummers 1 tot en met 12. (het gaat om een voetbal variant waar m’n geen elftal maar een twaalftal gebruikt :p)

Wanneer de coach een rugnummer intypt kan hij vervolgens ingeven of hij (a) een knappe actie of (b) een domme actie wil ingeven. Vervolgens geeft hij een getal in. Gebruik een 2dimensionale array die per speler het aantal domme en goede acties bijhoudt (de array is dus 12 bij 2 groot: 1 lijn per speler, bestaande uit 2 kolommen voor goede en domme actie. De index van de lijn is de rugnummer van speler -1).

Een typische invoer kan dus zijn:

2
a
6
De coach kiest dus de speler met rugnummer 2, hij kiest voor een knappe actie, en voert 6 in als aantal goede acties.

In de array op index 1 (rugnummer -1) zal in de 0’de kolom (0 = goede, 1 = slechte) het getal 6 geplaatst worden.

Vervolgens kan de coach een ander rugnummer (of hetzelfde) invoeren en zo verder.

Wanneer de coach 99 invoert stopt het programma en worden de finale statistieken getoond: per speler/rugnummer wordt het aantal goede en domme acties getoond, met daarnaast het verschil tussen beide:

(gebruik \t om goede tabs te zetten tussen de data)

Rugnummer   Goede   Domme   Verschil
1               5       2        3
2               6       7       -1
Het programma toont ook welke speler(s) het meest performant waren, namelijk zij met het grootste positieve verschil tussen goede en domme acties, alsook de minst performante en de meeste “gemiddelde” speler (i.e. verschil == 0 ) */

Helpers helper = new Helpers();

int[,]arrOfPlayerScores = new int[12,2];
helper.Fill2DArrayWithInt(arrOfPlayerScores,1);

int[]arrOfPlayerScoresTotal = new int[12];

int NumberInput = helper.AskInt("Player number 1-12\npress 99 to finish");
while(NumberInput!=99){
    helper.AdjustPlayerArray(arr:arrOfPlayerScores, playerNumber:NumberInput,typeAction:helper.AskChar(),actionAmount:helper.AskInt("amount of actions:"),resultArray:arrOfPlayerScoresTotal);
    NumberInput = helper.AskInt("Player number 1-12\npress 99 to finish");
}


int maxValue = helper.HighestValueInArray(arrOfPlayerScoresTotal);
int[]playersWithHighest = helper.FindIndexesOfValue(maxValue,arrOfPlayerScoresTotal);

int minValue = helper.LowestValueInArray(arrOfPlayerScoresTotal);
int[]playersWithLowest = helper.FindIndexesOfValue(minValue,arrOfPlayerScoresTotal);

int mostNeutralValue = helper.MostNeutralValueInArray(arrOfPlayerScoresTotal);
int[]playersWithNeutral = helper.FindIndexesOfValue(mostNeutralValue,arrOfPlayerScoresTotal);

System.Console.WriteLine($"Speler\tGoede Acties\tSlechte Acties\tResultaat");
helper.VisualiseResults(arrOfPlayerScores,arrOfPlayerScoresTotal);
System.Console.WriteLine($"Meest performante speler(s):{String.Join(',',playersWithHighest)} met score van:{maxValue}");
System.Console.WriteLine($"Minst performante speler(s):{String.Join(',',playersWithLowest)} met score van:{minValue}");
System.Console.WriteLine($"Meest gemiddelde speler(s):{String.Join(',',playersWithNeutral)} met score van:{mostNeutralValue}");