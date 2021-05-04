namespace Palindrome
{
  public class PalindromeWord
  {
    public string ReverseWord(string word)
    {
      string newString = "";
      string userInput = word;

      for (int index = 0; index < userInput.Length; index++)
      {
        string letter = userInput.Substring(index, 1);
        newString = letter + newString;
      }
      return newString;
    }
    public bool IsPalindrome(string word)
    {
      if (true)
      {
        return true;
      }
      else
      {
        return false;
      }
    }
  }
}
// newString = ""
// whatever = "Hello"

// letter = whatever.Substring(0,1)
// whatever = whatever.Substring(1,length - 2)
// newString = letter + newString 

// "" = "H" + "" -> "H"
// "H" = "e" + "H" -> "eH"

// "eH"