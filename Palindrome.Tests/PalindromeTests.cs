using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Palindrome.Test
{
  [TestClass]
  public class WordTests
  {
    [TestMethod]
    public void IsPalindrome_AWord_True()
    {
      Assert.AreEqual(true, Word.IsPalindrome("noon"));
    }
    // [TestMethod]
    // public void IsPalindrome_AWord_False()
    // {
    //   PalindromeWord testPalindrome = new PalindromeWord();
    //   Assert.AreEqual(false, testPalindrome.IsPalindrome("hello"));
    // }
    [TestMethod]
    public void ReverseWord_ReverseWordOrder_True()
    {
      Assert.AreEqual("olleh", Word.Reverse("hello"));
    }
  }
}
