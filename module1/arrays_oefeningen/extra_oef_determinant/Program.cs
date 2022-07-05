/* Schrijf een programma dat een methode BerekenDeterminant heeft. Deze methode heeft één paramater als input: een 2 bij 2 array van integers. Als resultaat geeft de methode de determinant als integer terug. Zoek zelf op hoe je de determinant van een matrix kunt berekenen.

Volgende voorbeeld-main dient te werken,int[,] aMatrix = { 
                  {2, 4},
                  {3, 5}
                 };
Console.WriteLine($"Determinant van matrix is {BerekenDeterminant(aMatrix)}");
geeft als output:

Determinant van matrix is -2
Extra: Breid uit zodat de BerekenDeterminant-methode ook werkt voor 3-bij-3 matrices. De methodeaanroep blijft dezelfde, enkel de interne code van de methode zal nu rekening moeten houden met de grootte van de matrix . */

static int BerekenDeterminant(int[,] multiDimensionalArr){
    if(multiDimensionalArr.GetLength(0) == 2 && multiDimensionalArr.GetLength(1) == 2){
        return multiDimensionalArr[0,0]*multiDimensionalArr[1,1] - multiDimensionalArr[0,1]*multiDimensionalArr[1,0];
    }
    else {
        int[,] tussenMatrix1 = {{multiDimensionalArr[1,1],multiDimensionalArr[1,2]},{multiDimensionalArr[2,1],multiDimensionalArr[2,2]}};
        int tussenResultaat1 = multiDimensionalArr[0,0]*BerekenDeterminant(tussenMatrix1);

        int[,] tussenMatrix2 = {{multiDimensionalArr[1,0],multiDimensionalArr[1,2]},{multiDimensionalArr[2,0],multiDimensionalArr[2,2]}};
        int tussenResultaat2 = -multiDimensionalArr[0,1]*BerekenDeterminant(tussenMatrix2);

        int[,] tussenMatrix3 = {{multiDimensionalArr[1,0],multiDimensionalArr[1,1]},{multiDimensionalArr[2,0],multiDimensionalArr[2,1]}};
        int tussenResultaat3 = multiDimensionalArr[0,2]*BerekenDeterminant(tussenMatrix3);

        return tussenResultaat1+tussenResultaat2+tussenResultaat3;
    }
}
int[,] arr1={{2,4} , {3,5}};
int[,] arr2={{1,5,3} , {2,4,7} , {4,6,2}};
System.Console.WriteLine(BerekenDeterminant(arr1));
System.Console.WriteLine(BerekenDeterminant(arr2));