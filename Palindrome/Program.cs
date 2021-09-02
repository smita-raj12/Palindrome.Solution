using System;
using System.Collections.Generic;
using Palindrome.Models;


namespace Palindrome
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Enter a word");
      string PolinWord = Console.ReadLine();
      PalindromeWord palindromes = new PalindromeWord(PolinWord);
      Console.WriteLine(palindromes.PalindromeCheck());
    }
  }
}    