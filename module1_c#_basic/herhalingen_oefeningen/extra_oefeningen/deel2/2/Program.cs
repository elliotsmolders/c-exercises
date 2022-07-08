// Toon alle machten tot 5 van n.
Console.WriteLine("geef n:");
int n = Convert.ToInt32(Console.ReadLine());
for(int i = 0; i<=5;i++){
    Console.WriteLine($"{n} tot de macht {i} = {Math.Pow(n,i)}");
}