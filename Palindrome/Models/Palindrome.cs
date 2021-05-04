namespace Palindrome
{
  public class Word
  {
    public static string Reverse(string word)
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
    public static bool IsPalindrome(string word)
    {
      return word == Word.Reverse(word);
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