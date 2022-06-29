/* Maak 2 methoden Encrypt en Decrypt die als parameters telkens een chararray krijgen en een integer. Bedoeling is dat de Encrypt-methode de array van het type string versleuteld gegeven de sleutel x volgens het Caesar cipher (zie hieronder). Als resultaat komt er uit de methode de geëncrypteerde array.

De decrypt-methode doet hetzelfde maar omgekeerd: je kan er een versleutelde tekst insteken en de sleutel en de ontcijferde tekst komt terug (merk op dat je decrypt-methode gebruik kan maken van de encrypt-methode!).

Toon in je main aan dat je methoden werken (door bijvoorbeeld aan de gebruiker een stuk tekst als string te vragen en een sleutel en deze dan te encrypteren/de-crypteren). */

static string AskString(string str){
    System.Console.WriteLine($"Geef string {str}:");
    return Console.ReadLine();
}

static int AskInt(){
    System.Console.WriteLine("geef sleutel:");
    return Convert.ToInt32(Console.ReadLine());
}

static string CeasarEncryptString(string str, int sleutel){
    char[] arr = str.ToUpper().ToCharArray();
    for (int i = 0; i < arr.Length; i++)
    {
        int c = Convert.ToInt32(arr[i]);
        if(c+sleutel>90){
            arr[i] = Convert.ToChar(c+sleutel-26);
        }
        else{
            arr[i] = Convert.ToChar(c+sleutel);
        }
    }
    return new string(arr);
}

static string CeasarDecryptString(string str, int sleutel = 1){
    char[] arr = str.ToUpper().ToCharArray();
    for (int i = 0; i < arr.Length; i++)
    {
        int c = Convert.ToInt32(arr[i]);
        if(c-sleutel<65){
            arr[i] = Convert.ToChar(c-sleutel+26);
        }
        else{
            arr[i] = Convert.ToChar(c-sleutel);
        }
    }
    return new string(arr);
}
System.Console.WriteLine(CeasarEncryptString(str:AskString("om te encrypteren"),sleutel:AskInt()));
System.Console.WriteLine(CeasarDecryptString(str:AskString("om te decrypteren"),sleutel:AskInt()));



/* System.Console.WriteLine($"encrypt:abCdEfGhIjK key:/ => {CeasarEncryptString("abCdEfGhIjK")}");
System.Console.WriteLine($"encrypt:abCdEfGhIjK key: 2 => {CeasarEncryptString("abCdEfGhIjK",2)}");
System.Console.WriteLine($"decrypt:bcDefGh key:/ => {CeasarDecryptString("bcDefGh")}");
System.Console.WriteLine($"decryptt:cDefGhi key: 2 => {CeasarDecryptString("cDefGhi",2)}");
 */
