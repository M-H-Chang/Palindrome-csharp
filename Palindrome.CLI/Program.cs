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

      if (Word.IsPalindrome(userWord))
      {
        Console.WriteLine($"{userWord} is a palindrome!");
      }
      else
      {
        Console.WriteLine($"{userWord} is not a palindrome, it is spelled {Word.Reverse(userWord)} in reverse!");
      }
    }
  }
}