/* 
Oefening 4
Maak minstens 2 methoden naar keuze: iedere methode zal een liedje beginnen spelen dat je zelf hebt gemaakt (bv. een bestaand kinderliedje). 
Hier bijvoorbeeld het begin van “You are my sunshine”:
 */

static void Do(string tekst="",int lengte=500, int octaaf=1){
    if(!String.IsNullOrEmpty(tekst)){
    Console.WriteLine(tekst);
    }
    Console.Beep(264*octaaf, lengte);
}
static void Re(string tekst="",int lengte=500, int octaaf=1){
    if(!String.IsNullOrEmpty(tekst)){
    Console.WriteLine(tekst);
    }
    Console.Beep(297*octaaf, lengte);
}
static void Mi(string tekst="",int lengte=500, int octaaf=1){
    if(!String.IsNullOrEmpty(tekst)){
    Console.WriteLine(tekst);
    }
    Console.Beep(330*octaaf, lengte);
}
static void Fa(string tekst="",int lengte=500, int octaaf=1){
    if(!String.IsNullOrEmpty(tekst)){
    Console.WriteLine(tekst);
    }
    Console.Beep(352*octaaf, lengte);
}
static void Sol(string tekst="",int lengte=500, int octaaf=1){
    if(!String.IsNullOrEmpty(tekst)){
    Console.WriteLine(tekst);
    }
    Console.Beep(396*octaaf, lengte);
}
static void La(string tekst="",int lengte=500, int octaaf=1){
    if(!String.IsNullOrEmpty(tekst)){
    Console.WriteLine(tekst);
    }
    Console.Beep(440*octaaf, lengte);
}
static void Si(string tekst="",int lengte=500, int octaaf=1){
    if(!String.IsNullOrEmpty(tekst)){
    Console.WriteLine(tekst);
    }
    Console.Beep(495*octaaf, lengte);
}
static void Do2(string tekst="",int lengte=500, int octaaf=1){
    if(!String.IsNullOrEmpty(tekst)){
    Console.WriteLine(tekst);
    }
    Console.Beep(528*octaaf, lengte);
}
static void SpeelLondonBridge(){
    Sol("London");
    La();
    Sol("Bridge");
    Fa("is");
    Mi("falling");
    Fa();
    Sol("down,");
    Re("Falling");
    Mi();
    Fa("down,");
    Mi("falling");
    Fa();
    Sol("down");
    Sol("London");
    La();
    Sol("Bridge");
    Fa("is");
    Mi("falling");
    Fa();
    Sol("down,");
    Re("My");
    Sol("fair");
    Mi("lady");
    Do();
}

static void SpeelYouAreMySunshine(){
Re();
Sol();
La();
Si();
Si();
Si();
La();
Si();
Sol();
Sol();
Sol();
La();
Si();
Do();
Mi();
Mi();
Re();
Do();
Si();
}
/* 
Oefening 5
Bij het opstarten van het programma krijg je een menu te zien waaruit de gebruiker een liedje kan kiezen dat gespeeld moet worden.
 Vervolgens wordt dit liedje gespeeld en nadien wordt de vraag terug gesteld (oneindige loop).
 */
 static void ShowMenu(){
    Console.WriteLine("1.You are my sunshine\n2.London Bridge");
 }
 static int GetUserInput(){
    Console.WriteLine("Choose a song:");
    return Convert.ToInt32(Console.ReadLine());
 }
 static void PlaySong(int choice){
    switch(choice){
        case 1:{SpeelYouAreMySunshine();break;}
        case 2:{SpeelLondonBridge();break;}
        default:{System.Console.WriteLine("Invalid input");break;}
    }
 }
/* 
Oefening 6
Wanneer een liedje werd afgespeeld dan dient de methode terug te geven (als double) hoe lang het liedje heeft geduurd. Het hoofdmenu toont 
dit aan het einde van het afspelen.

Je kan de duur van een methode heel eenvoudig meten als volgt, gebruikmakende van de StopWatch: */

 while(true){
    ShowMenu();
    int input = GetUserInput();
    var stopwatch = System.Diagnostics.Stopwatch.StartNew();
    PlaySong(input);
    stopwatch.Stop();
    System.Console.WriteLine($"song duration: {stopwatch.Elapsed.TotalSeconds:F2} seconds");
 }