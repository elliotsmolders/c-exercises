/* 
The MOD-operator % (aka mod/modulus/remainder):

Returns the remainder of a division operation.
The sign of the result is the same as the sign of the first operand.
 */

public class Kata
{
  public static int Mod256WithoutMod(int number)
  {
    int wholeDivision = number/256;
    return number - (256*wholeDivision);
  }
}