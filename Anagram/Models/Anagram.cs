namespace Anagram
{
  public class Anagram
  {
    public bool BIsGreaterThanA(char FirstChar, char SecondChar)
    {
      if (FirstChar < SecondChar)
      {
        return true;
      } else {
        return false;
      }
    }
    public bool AIsLessThanA(char FirstString, char SecondString)
    {
      if (FirstString > SecondString)
      {
        return false;
      } else {
        return true;
      }
    }
 }
}
