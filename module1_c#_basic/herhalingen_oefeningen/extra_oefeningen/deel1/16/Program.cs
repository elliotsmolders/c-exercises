/* Toon de reeks van Fibonacci tot n termen. Fibonacci getal n is som van twee voorgaande termen,n = (n-1) + (n-2)
Fibonacci 0,1,1,2,3,5,8,13,21...
 */
Console.WriteLine("geef n:");
int n = Convert.ToInt32(Console.ReadLine());
//startwaardes
int first = 0; 
int second = 1;
int current =0;
Console.WriteLine("0");
Console.WriteLine("1");
for(int i = 2; i<n;i++){
    current = first+second;
    first = second;
    second = current;
    Console.WriteLine(current);
}