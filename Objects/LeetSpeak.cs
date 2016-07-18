using System;
namespace LeetSpeakList.Objects
{
  public class LeetSpeak
  {
    private string _word;
    public LeetSpeak(string word)
    {
      _word = word;
    }

    public string GetWord()
    {
      return _word;
    }
    public void SetWord(string newWord)
    {
      _word = newWord;
    }

    public string LeetSpeakGenerator()
    {
      string leetWord= this.GetWord();
      string resultWord=leetWord;

      if(leetWord.Contains("I")){
        resultWord = leetWord.Replace("I", "1");
      }

      resultWord = resultWord.ToLower();

      if(leetWord.Contains("e") || leetWord.Contains("o") || leetWord.Contains("s"))
      {
        resultWord=resultWord.Replace("e","3");
        resultWord=resultWord.Replace("o","0");
        resultWord=resultWord.Replace("s","z");

        leetWord = leetWord.ToLower();
        if(leetWord.IndexOf("s")==0)
        {
          Console.WriteLine(leetWord.IndexOf("s"));
          Console.WriteLine(leetWord);
          char[] array =resultWord.ToCharArray();
          array[0]='s';
          Console.WriteLine(array);
          resultWord=string.Join("",array);
        }

      }
      return resultWord;
    }

  }
}
