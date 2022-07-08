    public class Helpers{


    public void Fill2DArrayWithInt(int[,]arr, int filler){
    int columns = arr.GetLength(1);
    int rows = arr.GetLength(0);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            arr[i,j]=0;
        }
    }
}
public int AskInt(string variableName){
    System.Console.WriteLine($"Give a {variableName}");
    return Int32.Parse(Console.ReadLine());
}
public char AskChar(){
    System.Console.WriteLine("a:Good action b:Bad action");
    return Char.Parse(Console.ReadLine());
}

public void AdjustPlayerArray(int[,]arr,int playerNumber,char typeAction, int actionAmount,int[]resultArray){
    int columnn;
    if(typeAction == 'a'){
        columnn = 0;
    }
    else{columnn = 1;}
    arr[playerNumber-1,columnn] += actionAmount;
    resultArray[playerNumber-1] = (arr[playerNumber-1,0]-arr[playerNumber-1,1]);
}

public void VisualiseResults(int[,] arr,int[]resultArray){
    int rows = arr.GetLength(0);
    int columns = arr.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < 4; j++)
        {

            
            if(j==3){
                System.Console.Write(resultArray[i]);
                System.Console.WriteLine();
            }
            else if(j==0){
                System.Console.Write(i+1);
                System.Console.Write("\t\t");
            }
            else{
                System.Console.Write(arr[i,j-1]);
                System.Console.Write("\t\t");
            }
        }
    }
}
public int HighestValueInArray(int[]arr){
    int highestValue = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if(highestValue<arr[i]){
            highestValue = arr[i];
        }
    }
    return highestValue;
}
public int LowestValueInArray(int[]arr){
    int lowestValue = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if(lowestValue>arr[i]){
            lowestValue = arr[i];
        }
    }
    return lowestValue;
}
public int MostNeutralValueInArray(int[]arr){
    int neutralValue = Math.Abs(arr[0]);
    for (int i = 1; i < arr.Length; i++)
    {
        if(Math.Abs(neutralValue)>Math.Abs(arr[i])){
            neutralValue =  arr[i];
        }
    }
    return neutralValue;
}

public int[] FindIndexesOfValue(int valueToFind,int[] arrToSearch){
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


}

