namespace WordCount
{

    public class Counter
    {
      public int wordCount (string setence, string word)
      {
        int wordNum = 0;
        string userSetence = setence.ToLower();
        string userWord = word.ToLower();  
        string[] setenceArr = setence.Split(" ");
        for (int i = 0; i < setenceArr.Length; i++)
        {
          if (setenceArr[i] == word)
          {
            wordNum += 1;
          }
        }
        return wordNum;
      }
    }
}