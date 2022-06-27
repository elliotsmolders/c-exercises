/* Schrijf een programma dat de som van de serie 9+99+999+9999+99999+999999 berekent (mét loop uiteraard). */
Console.WriteLine("geef n:");
int n = Convert.ToInt32(Console.ReadLine());
int temp = 9;
int som =0;
for(int i = 0; i<n;i++){
    //Console.WriteLine(temp);
    som += temp;
    Console.Write($"{temp} + ");
    temp = (temp*10)+9;
}
Console.Write($"som = {som}");