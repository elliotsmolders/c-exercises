/* Given a string s. You have to return another string such that even-indexed and odd-indexed characters of s are grouped and groups are space-separated (see sample below) */

public class Kata
{
  public static string SortMyString(string s)
  {
   string even ="";
   string odd ="";

   for (int i = 0; i < s.Length; i++)
   {
    if(i%2==0){
        even += s[i];
    }
    else{
        odd += s[i];
    }
   }

   return even +" " +odd;
  }
}

/* answer with linq

using System.Linq;

public class Kata
{
  public static string SortMyString(string s)
  {
    return $"{string.Concat(s.Where((x, i) => i % 2 == 0))} {string.Concat(s.Where((x, i) => i % 2 != 0))}";
  }
} */