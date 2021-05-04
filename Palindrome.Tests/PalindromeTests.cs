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
      Assert.AreEqual(true, testPalindrome.IsPalindrome("hello"));
    }
  }
}