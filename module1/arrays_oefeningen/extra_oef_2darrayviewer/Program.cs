/* Breid het ArrayViewer programma uit zodat ook 2-dimensionale arrays gevisualiseerd kunnen worden. (Hint: gebruik de GetLength() methode van een array).

Voorbeeld van main:

int [,] array = { {15, 6, 9}, {1, 2, 3}, {6, 9, 12}};
VisualiseerArray(array);
Output:

15  6  9
1   2  3
6   9  12 */
static void VisualiseerArray(int[,] arr){
    int widthArr = arr.GetLength(0);
    int heightArr = arr.GetLength(1);

    for (int i = 0; i < heightArr; i++)
    {
        for (int j = 0; j < widthArr; j++)
        {
            System.Console.Write(arr[i,j]);
            if(j==widthArr-1){
                System.Console.WriteLine();
            }
            else{
                System.Console.Write("\t");
            }
        }
    }


}

int [,] arr = { {15, 6, 9}, {1, 2, 3}, {6, 9, 12}};
VisualiseerArray(arr);