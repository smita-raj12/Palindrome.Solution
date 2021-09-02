using System;

namespace Palindrome.Models
{
  public class PalindromeWord
  {
    public string Word { get; set; }

    public PalindromeWord(string word)
    {
      Word = word;
    }
    public bool PalindromeCheck()
    {
      string ReverseString = "";
      for (int i = Word.Length-1; i>-1 ; i--)
      {
        ReverseString = ReverseString + Word[i];
      }
      if(Word == ReverseString)
      {
        return true;
      }
      else{
        return false;
      }
    }
  }
}
