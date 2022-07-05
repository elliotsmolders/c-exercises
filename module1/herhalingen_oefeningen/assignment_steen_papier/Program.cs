/* Maak een applicatie waarbij de gebruiker steen-schaar-papier met de computer kan spelen. De gebruiker kiest telkens steen, schaar of papier
 en drukt op enter. Vervolgens kiest de computer willekeurig steen, schaar of papier (gebruik de Random.Next() methode, waarbij je deze 
 tussen 1 en 3 laat varieren). Vervolgens krijgt de winnaar 1 punt:

Steen wint van schaar, verliest van papier.
Papier wint van steen, verliest van schaar.
Schaar wint van papier, verliest van steen.
Indien beide hetzelfde hebben wint niemand een punt.
Op het scherm wordt telkens getoond wie de huidige ronde heeft gewonnen en hoeveel de tussenscore is. De eerste (pc of gebruiker) die 
10 punten haalt wint.

Teken een flowchart van je applicatie. Voeg deze als .png toe aan je project. */

Random myRandom = new Random();
int scoreGebruiker = 0;
int scoreComputer = 0;


while(scoreComputer <10 && scoreGebruiker<10){
    Console.WriteLine("\nselecteer 1:blad 2:schaar 3:steen");
    int keuzeGebruiker = Convert.ToInt32(Console.ReadLine());
    Console.Clear();
    int keuzeComputer = myRandom.Next(1,4);
    string winnaarRonde = "";
    if(keuzeComputer == keuzeGebruiker){
        winnaarRonde = "niemand";
    }
    else{
        switch(keuzeGebruiker){
            case 1:{
                if(keuzeComputer==2){
                    scoreComputer++;
                    winnaarRonde = "computer";
                }
                else{
                    scoreGebruiker++;
                    winnaarRonde ="gebruiker";
                }
                break;
            }
            case 2:{
                if(keuzeComputer==3){
                    scoreComputer++;
                    winnaarRonde = "computer";
                }
                else{
                    scoreGebruiker++;
                    winnaarRonde = "gebruiker";
                }
                break;
            }
            case 3:{
                if(keuzeComputer==1){
                    scoreComputer++;
                    winnaarRonde = "computer";
                }
                else{
                    scoreGebruiker++;
                    winnaarRonde = "gebruiker";
                }
                break;
            }
        }
    }
    Console.WriteLine($"winnaar van deze ronde = {winnaarRonde}");
    Console.WriteLine($"Tussenstand: \nGebruiker: {scoreGebruiker}\nComputer: {scoreComputer}");
}
string winnaar = scoreGebruiker>scoreComputer?"gebruiker":"computer";
Console.WriteLine($"Winnaar= {winnaar}\neindscore: Gebruiker:{scoreGebruiker} Computer:{scoreComputer}");
