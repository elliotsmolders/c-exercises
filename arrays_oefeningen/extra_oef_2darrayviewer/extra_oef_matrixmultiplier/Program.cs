/* Schrijf een methode VermenigvuldigMatrix die 2 matrices als invoer verwacht en als resultaat een nieuwe matrix teruggeeft die het product van beide matrices bevat. */

static int[,] MatrixMultiplier(int[,]arr1,int[,]arr2){
    int columns = arr1.GetLength(0);
    int rows= arr1.GetLength(1);
    int[,] resultArr = new int[rows,columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            resultArr[i,j] = arr1[i,j] * arr2[i,j];
        }
    }
    return resultArr;
}

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
System.Console.WriteLine();
VisualiseerArray(MatrixMultiplier(arr,arr));