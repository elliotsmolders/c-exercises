/* “Bob is a lackadaisical teenager. In conversation, his responses are very limited.

Bob answers ‘Sure.’ if you ask him a question.

He answers ‘Whoa, chill out!’ if you yell at him.

He answers ‘Calm down, I know what I’m doing!’ if you yell a question at him. I assume yell a question == ending with "!?"

He says ‘Fine. Be that way!’ if you address him without actually saying anything.

He answers ‘Whatever.’ to anything else.”

Bekijk steeds de laatste 2 tekens die de gebruiker invoert om de response van Bob te bepalen.

Kan je een gesofisticeerdere bot maken? (tip: myInputstring.Contains(somestring) geeft een bool terug indien somestring voorkomt in de
 variabele myInputstring van het type string )

Gebruik een array om de antwoorden in te bewaren. */
string[] arrAnswers = {
    "Sure",
    "Whoa, chill out!",
    "Calm down, I know what I’m doing!",
    "Fine. Be that way!",
    "Whatever."
};

static string GetLast2(string str){

    return str.Length>1? str.Substring(str.Length-2) : str;
}
static int BobResponse(string str){
    if(String.IsNullOrEmpty(str)){return 3;}
    if(str[str.Length-1] == '?'){return str[0] == '!' ? 2 : 0;}
    if(str[str.Length-1] == '!'){return 1;}
    return 4;
}

while(true){
    System.Console.WriteLine("Say something to Bob:");
    string input = Console.ReadLine()??"";
    System.Console.WriteLine($"{arrAnswers[BobResponse(GetLast2(input))]}");
}