/* Vervolledig deze code zodat ook getoond wordt welke de grootste waarde is die werd ingevoerd. */

int x= 0;
int y= 0;
int grootste = 0;
do
{
    if(x>grootste){
        grootste = x;
    }
    y = y + x;
    Console.WriteLine("Voer gehele waarden in (32767=stop)");
    string instring= Console.ReadLine();
    x = Convert.ToInt32(instring);
}while (x != 32767);
Console.WriteLine($"Grootst ingegeven getal is: {grootste}");
Console.WriteLine($"Som is {y}");