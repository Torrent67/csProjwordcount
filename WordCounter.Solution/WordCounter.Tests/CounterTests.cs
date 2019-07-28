using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCount;

namespace WordCount.Tests
{
    [TestClass]
    public class CounterTest
    {
        [TestMethod]
        public void wordCount_OneWord_1()
        {
            Counter userInput = new Counter();
            Assert.AreEqual(1, userInput.wordCount("cat cathedral", "cathedral"));
        }
        [TestMethod]
        public void wordCount_OneWordInString_1()
        {
            Counter userInput = new Counter();
            Assert.AreEqual(1, userInput.wordCount("gib coffee pls", "coffee"));
        }
        [TestMethod]
        public void wordCount_TwoWordsInString2()
        {
            Counter userInput = new Counter();
            Assert.AreEqual(2, userInput.wordCount("Please put more coffee in my coffee mug", "coffee"));
        }
        [TestMethod]
        public void wordCount_WordsInString3()
        {
            Counter userInput = new Counter();
            Assert.AreEqual(1, userInput.wordCount("she sells sea shells by the seashore", "sea"));
        }
         [TestMethod]
        public void wordCount_TwoWordsInString4()
        {
            Counter userInput = new Counter();
            Assert.AreEqual(2, userInput.wordCount("she sells sea shells by the seashore she sells sea shells so well", "sells"));
        }
        [TestMethod]
        public void wordCount_FourWordsInString5()
        {
            Counter userInput = new Counter();
            Assert.AreEqual(4, userInput.wordCount("that movie was better than the other movie but I like this movie more than that movie", "movie"));
        }
      
       
       
       
    }
}
