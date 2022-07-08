// Toon de som van alle oneven getallen van 1 tot n.
Console.WriteLine("geef n");
int n = Convert.ToInt32(Console.ReadLine());
int som = 0;
for(int i =1;i<=n;i++){
    if(i%2!=0){
        som+=i;
    }
}
Console.WriteLine(som);
