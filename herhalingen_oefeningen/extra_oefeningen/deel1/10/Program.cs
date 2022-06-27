/* Schrijf een programma dat alle ascii karakters en hun waarde toont van 10 tot n (tip: char c = Convert.ToChar(65); zal hoofdletter
 A tonen). */
 Console.WriteLine("geef n:");
 int n = Convert.ToInt32(Console.ReadLine());
 for(int i =10;i <=n ;i++){
    Console.WriteLine($"waarde :{i} karakter:{Convert.ToChar(i)}");
 }