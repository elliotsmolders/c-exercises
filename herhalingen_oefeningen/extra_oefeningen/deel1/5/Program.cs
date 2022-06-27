// Toon de som van alle getallen van 1 tot n (dus 1+2+3+4+…+n).
int som = 0;
Console.WriteLine("geef n");
int n = Convert.ToInt32(Console.ReadLine());
for(int i =1;i<=n;i++){
    som +=i;
}
Console.WriteLine(som);