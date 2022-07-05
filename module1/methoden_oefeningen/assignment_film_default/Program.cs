/* Maak een methode FilmRuntime() die 3 parameters accepteert:

Een string die de naam van de film bevat
Een integer die duur in minuten van de film bevat
Een enum-type die het genre van de film bevat (Drama, Actie, etc.)
Indien de duur van de film niet wordt meegeven wordt een standaard lengte van 90 minuten ingesteld. Indien het genre niet wordt meegeven dan
 wordt deze default op Onbekend ingesteld.

De methode geeft niets terug maar toont eenvoudigweg de film op het scherm, gevolgd door z’n duur en genre in volgende formaat.

The Matrix (120minuten, Actie)
Toon aan in je main dat de methode werkt met zowel 1, 2 als 3 parameters. Toon ook aan dat je met ‘named arguments’ de methode kan aanroepen.
 */

 static string FilmRuntime(string naam, int duur =90,Genres genre = Genres.Onbekend){
    return $"{naam} ({duur}minuten, {genre})";
 }

 Console.WriteLine(FilmRuntime("The Matrix"));
 Console.WriteLine(FilmRuntime("The Matrix 2", 120));
 Console.WriteLine(FilmRuntime("The Matrix 2",genre: Genres.Actie));
 Console.WriteLine(FilmRuntime("Titanic",100,Genres.Drama));
 Console.WriteLine(FilmRuntime(genre:Genres.Drama,naam:"Titanic",duur:130));