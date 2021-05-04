using System;
using Palindrome;

namespace Palindrome.CLI
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Please enter a word: ");
      string userWord = Console.ReadLine();

      Word.Reverse(userWord);
      Console.WriteLine(Word.IsPalindrome(userWord));
    }
  }
}