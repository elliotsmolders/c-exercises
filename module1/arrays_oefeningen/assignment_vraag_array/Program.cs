/* Maak een array die 6 strings kan bevatten. Ieder element van de array bevat een vraag (naar keuze te verzinnen) als string waar de 
gebruiker met een getal op moet antwoorden. Maak een array aan die tot 6 ints kan bevatten. Lees 1 voor 1 de vraag uit de string-array uit
 en toon deze op het scherm. Lees vervolgens het antwoord uit dat de gebruiker intypt en bewaar dit als int in de 2e array.

Na de 6 vragen toon je vervolgens de vragen opnieuw met achter iedere vraag het antwoord van de gebruiker. */
static int ReadNumber(){
    return Convert.ToInt32(Console.ReadLine());
}

string[] arrVragen = {"1+1?","2+2","3+3","4+4?","5+5","6+6"};
int[] arrAntwoorden = new int[6];

for(int i = 0; i<6; i++){
    System.Console.WriteLine(arrVragen[i]);
    arrAntwoorden[i] = ReadNumber();
}

for(int i = 0; i<6; i++){
    System.Console.WriteLine($"{arrVragen[i]} = {arrAntwoorden[i]}");
}