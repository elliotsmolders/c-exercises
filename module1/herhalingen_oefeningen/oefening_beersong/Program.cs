/* Schrijf een BeerSong-generator zoals onderstaande output. Merk op dat de laatste 5 zinnen anders zijn: */

int countBottles = 99;
while(true){
    if(countBottles>1){
        Console.WriteLine($"{countBottles} bottles of beer on the wall, {countBottles} bottles of beer.");
        Console.WriteLine($"Take one down and pass it around, {countBottles-1} bottles of beer on the wall.");
        countBottles --;
    }
    else{
        Console.WriteLine($"Take one down and pass it around, 1 bottle of beer on the wall.");
        Console.WriteLine("1 bottle of beer on the wall, 1 bottle of beer.");
        Console.WriteLine("Take it down and pass it around, no more bottles of beer on the wall.");
        Console.WriteLine("No more bottles of beer on the wall, no more bottles of beer.");
        Console.WriteLine("Go to the store and buy some more, 99 bottles of beer on the wall.");
        countBottles = 99;
        Console.ReadLine();
    }

}


/* 99 bottles of beer on the wall, 99 bottles of beer.
Take one down and pass it around, 98 bottles of beer on the wall.
 */