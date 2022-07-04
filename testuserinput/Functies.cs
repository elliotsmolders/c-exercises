public class Functies
{
    public double VraagGetal(){
        System.Console.WriteLine($"geef een getal:");
        double getal = Int32.Parse(Console.ReadLine());
        return getal;
    }

    public void changeArray(int[] arr){
        arr[0] = 2;
    }
}
