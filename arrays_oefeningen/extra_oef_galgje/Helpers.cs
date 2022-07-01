public class Helpers
{
    public int RandomGen(int minValue,int maxValue){
        Random myRandom = new Random();
        return myRandom.Next(minValue,maxValue);
    }
    public char GetChar(){
        System.Console.WriteLine("Guess a letter");
        return Char.Parse(Console.ReadLine());
    }
/*     public void ValidateInput(char userInput, char[]arrOfCorrectLetters,char[]arrOfWrongLetters){
        while(arrOfWrongLetters.Contains(userInput) || arrOfCorrectLetters.Contains(userInput)){
        System.Console.WriteLine("you have already guessed this letter");
        userInput = GetChar();
    }
    } */

    public char[] FillCharArr(char[] arrToFill, char fillWith){
        Array.Fill(arrToFill,fillWith);
        return arrToFill;
    }

    public void PrintArr(char[] arrayToPrint){
        System.Console.WriteLine(String.Join(" ",arrayToPrint));
    }
    public void PrintWrongLetters(char[] wrongLettersArray){
        System.Console.WriteLine($"Wrong Letters: [{String.Join(',',wrongLettersArray)}]");
    }
    public int[] FindIndexesOfValue(char valueToFind,char[] arrToSearch){
    int[]results = new int[0];
    for (int i = 0; i < arrToSearch.Length; i++)
    {
        if(arrToSearch[i] == valueToFind){
            Array.Resize(ref results, results.Length+1);
            results[results.Length-1] = i+1;
        }
    }
    return results;
    }
    public char[] AddToWrongLetters(char wrongLetter, char[] arrToUpdate){
        Array.Resize(ref arrToUpdate,arrToUpdate.Length+1);
        arrToUpdate[arrToUpdate.Length-1] = wrongLetter;
        return arrToUpdate;
    }
    public char[] UpdateCorrectGuessesArray(int[] arrOfIndexes, char[]arrToUpdate, char[]arrWithAnswer){
        for (int i = 0; i < arrOfIndexes.Length; i++)
        {
            arrToUpdate[arrOfIndexes[i]-1] = arrWithAnswer[arrOfIndexes[i]-1];
            System.Console.WriteLine(arrOfIndexes.Length);
        }
        return arrToUpdate;
    }
}