/* Paswoord generator methode
Maak een paswoord generator die paswoorden van bepaalde lengte genereert en bestaat uit willekeurige letters, hoofdletters en cijfers. Plaats
 deze code in een methode die 1 parameter aanvaardt namelijk de lengte van het paswoord dat gemaakt moet worden. De methode geeft het 
 gegenereerde paswoord terug als resultaat. (tip gebruik een random number generator(s) om getallen te genereren die je ook kan casten 
 naar chars dankzij de unicode waarde van chars). 
 48-57 nummers
 65-90 hoofdletters
 97-122 kleine letters
 */

 static string PasswoordGenerator(int lengte){
    Random myRandom = new Random();
    string password = "";
    for(int i=lengte;i>0;i--){
        int randomRange = myRandom.Next(1,4);
        int randomChar =0;
        switch(randomRange){
            case 1:{
                randomChar = myRandom.Next(48,57);
                break;
            }
            case 2:{
                randomChar = myRandom.Next(65,90);
                break;
            }
            case 3:{
                randomChar = myRandom.Next(97,122);
                break;
            }
        }
        password += Convert.ToString(Convert.ToChar(randomChar));
    }
    return password;
 }
 System.Console.WriteLine(PasswoordGenerator(10));