using Microsoft.VisualStudio.TestTools.UnitTesting;
using Palindrome;

namespace Palindrome.Test
{
  [TestClass]
  public class PalindromeWordTests
  {
    [TestMethod]
    public void IsPalindrome_AWord_True()
    {
      PalindromeWord testPalindrome = new PalindromeWord();
      Assert.AreEqual(true, testPalindrome.IsPalindrome("noon"));
    }
    [TestMethod]
    public void IsPalindrom_AWord_False()
    {
      PalindromeWord testPalindrome = new PalindromeWord();
      Assert.AreEqual(false, testPalindrome.IsPalindrome("hello"));
    }
  }
}