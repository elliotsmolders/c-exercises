/* Gebruik de random generator om een orakel/waarzegger te maken, namelijk de kleine broer of zus van het Orakel van Delphi. 
Het programma zal aan de gebruiker vertellen hoe lang deze nog zal leven. Bijvoorbeeld: “Je zal nog 15 jaar leven.”.

Het orakel zal enkel realistische getallen geven. M.a.w., getallen tussen de 5 en 125 jaar (onder de 5 zou grof zijn). */
Random randomGenerator = new Random();
int minLeeftijd = 5;
int maxLeeftijd = 125;
Console.WriteLine($"Je zal nog {randomGenerator.Next(minLeeftijd,maxLeeftijd)} jaar leven.");
