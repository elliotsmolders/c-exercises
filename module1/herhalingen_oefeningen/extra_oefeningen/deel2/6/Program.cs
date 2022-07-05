//Vraag aan de gebruiker getallen tot hij -1 invoert. Toon het gemiddelde van de ingevoerde getallen.
int som=0;
int count = -1;
int input=0;
while(input!=-1){
    count ++;
    som += input;
    Console.WriteLine("geef een getal, -1 om te stoppen");
    input = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine($"Som: {som}\naantal nummers: {count}\ngemiddelde: {(double)som/count:F2}");