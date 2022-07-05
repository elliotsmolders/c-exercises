/* Galgje
Maak een spel, vergelijkbaar met galgje, waarin de speler een woord moet raden. Zie Wiki voor de spelregels indien je deze niet kent. */
Helpers helper = new Helpers();
Variables variables = new Variables();

string wordString = variables.arrOfWords[helper.RandomGen(0,variables.arrOfWords.Length-1)];
char[] arrOfWord = wordString.ToCharArray();

char[] arrOfCorrectLetters = new char[wordString.Length];
helper.FillCharArr(arrToFill:arrOfCorrectLetters,fillWith:'_');

/* System.Console.WriteLine($"the word is: {wordString}"); */

while(variables.wrongGuesses < variables.allowedWrongGuesses && variables.isWordGuessed == false){

    System.Console.WriteLine($"wrong guesses remaining: {variables.allowedWrongGuesses-variables.wrongGuesses}");
    helper.PrintArr(arrOfCorrectLetters);
    helper.PrintWrongLetters(variables.wrongLetters);
    char userInput = helper.GetChar();
/*     helper.ValidateInput(userInput:userInput,arrOfCorrectLetters:arrOfCorrectLetters,arrOfWrongLetters:variables.wrongLetters); */



    if(wordString.Contains(userInput)){
       int[] foundAt = helper.FindIndexesOfValue(valueToFind:userInput,arrToSearch:arrOfWord);
       helper.UpdateCorrectGuessesArray(arrOfIndexes:foundAt,arrToUpdate:arrOfCorrectLetters,arrWithAnswer:arrOfWord);
       System.Console.WriteLine("Correct guess");

       if(wordString == String.Join("",arrOfCorrectLetters)){
        variables.isWordGuessed = true;
        helper.PrintArr(arrOfCorrectLetters);
        System.Console.WriteLine("word guessed");
       }
    }

    else{
        variables.wrongGuesses ++;
        variables.wrongLetters = helper.AddToWrongLetters(wrongLetter:userInput,arrToUpdate:variables.wrongLetters);
        System.Console.WriteLine("Wrong guess");
    }
}

