/* Ontwerp een methode waarmee je een Belgisch ondernemingsnummer kan controleren. Een Belgisch ondernemingsnummer is als volgt opgebouwd: BE 0xxx.xxx.xxx waarbij BE de landcode is die standaard gevolgd wordt door een spatie en dan een 0. Wanneer je de volgende 7 cijfers deelt door 97 in een gehele deling, dan is het getal gevormd door de laatste 2 cijfers gelijk aan 97 minus de rest van deze gehele deling. Bij een geldig ondernemingsnummer verschijnt de tekst “Geldig ondernemingsnummer.”, bij een ongeldig ondernemingsnummer “Ongeldig ondernemingsnummer.”. De methode aanvaardt een string waarin je het ondernemingsnummer staat. */

static bool IsGeldigOndernemingsnummer (string str){
    string getalString = str.Substring(3).Replace(".","");
    int laatste2 = Convert.ToInt32(getalString.Substring(getalString.Length-2));
    int teDelen = Convert.ToInt32(getalString.Substring(0,7));
    return 97-teDelen%97 == laatste2;
}
System.Console.WriteLine(IsGeldigOndernemingsnummer("BE0123.456.749"));//BE0123.456.749 zou geldig moeten zijn 1234567 % 97 = 48,97-48 = 49; dus BE0123456749
System.Console.WriteLine(IsGeldigOndernemingsnummer("BE0123.456.748"));