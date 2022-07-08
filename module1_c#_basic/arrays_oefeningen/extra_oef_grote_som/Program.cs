/* Grote Som
Maak een methode Som() die eender welke hoeveelheid parameters van het type int aanvaardt en vervolgens de som van al deze parameters teruggeeft (als int).

Toon in je main aan dat de methode werkt door onder andere 1, 3, 5 en 10 als gehele getalen mee te geven.

Toon ook aan dat je een array van 50 ints als parameter kan meegeven aan de methode. (hint: je moet het params keyword gebruiken) 

aggregate = reduce van c#
*/
Helpers helpers = new Helpers();

System.Console.WriteLine(helpers.GroteSom(1));
System.Console.WriteLine(helpers.GroteSom(1,2));
System.Console.WriteLine(helpers.GroteSom(1,2,3));
System.Console.WriteLine(helpers.GroteSom(1,2,3,4));
System.Console.WriteLine(helpers.GroteSom(1,2,3,4,5));
System.Console.WriteLine(helpers.GroteSom(1,2,3,4,5,6));
System.Console.WriteLine(helpers.GroteSom(1,2,3,4,5,6,7));
