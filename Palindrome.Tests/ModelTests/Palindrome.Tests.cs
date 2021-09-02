using Microsoft.VisualStudio.TestTools.UnitTesting;
using Palindrome.Models;

namespace Palindrome.Tests
{
  [TestClass]
  public class PalindromeTests
  {
    [TestMethod]
    public void PalindromeWord_ContainsInputValues()
    {
      PalindromeWord testPalindromeWord = new PalindromeWord("redivider");
      Assert.AreEqual( "redivider",testPalindromeWord.Word);
    }
    [TestMethod]
    public void IsPalindromeWord_Returns_Palindrome_Word_True()
    {
      PalindromeWord testPalindromeWord = new PalindromeWord("level");
      Assert.AreEqual( true, testPalindromeWord.PalindromeCheck());
    }
    [TestMethod]
    public void IsPalindromeWord_Returns_Palindrome_Word_False()
    {
      PalindromeWord testPalindromeWord = new PalindromeWord("abcd");
      Assert.AreEqual( false, testPalindromeWord.PalindromeCheck());
    }
  }
} 



