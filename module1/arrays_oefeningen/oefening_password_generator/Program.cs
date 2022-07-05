/* Ontwerp een consoletoepassing waarmee je een wachtwoord genereert voor een gebruiker. Het wachtwoord is opgebouwd uit:

de 2 eerste letters van de familienaam: de 1ste letter is een hoofdletter, de 2de letter is een kleine letter. Daarna worden de 2 letters
 gewisseld; het zonenummer van het telefoonnummer zonder de 0; het eerste cijfer van de postcode in het kwadraat. */

static void SwapInArray(int index1, int index2, char[]arr){
    char temp = arr[index1];
    arr[index1] = arr[index2];
    arr[index2] = temp;
}

static string GetString(string variable = "string"){
    System.Console.WriteLine($"geef {variable}:");
    return Console.ReadLine();
}
string familieNaam = GetString("familienaam");
string telefoonnummer = GetString("telefoonnummer");
string postcode = GetString("postcode");

string stringPassword = Convert.ToString(familieNaam[0]).ToUpper() + Convert.ToString(familieNaam[1]).ToLower() + telefoonnummer.Substring(1,2) + Convert.ToString(Math.Pow(Convert.ToInt32(postcode[0])-48,2));

char[] arrPassword = stringPassword.ToCharArray();
SwapInArray(index1:0,index2:1,arr:arrPassword);

System.Console.WriteLine($"password: {String.Join("",arrPassword)}");
