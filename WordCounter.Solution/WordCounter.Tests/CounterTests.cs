using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCount;

namespace WordCount.Tests
{
    [TestClass]
    public class CounterTest
    {
        [TestMethod]
        public void wordCount_CatchOneWord_1()
        {
            Counter userInput = new Counter();
            Assert.AreEqual(1, userInput.wordCount("coffee", "coffee"));
        }
        [TestMethod]
        public void wordCount_CatchOneInString_1()
        {
            Counter userInput = new Counter();
            Assert.AreEqual(1, userInput.wordCount("gib coffee pls", "coffee"));
        }
        [TestMethod]
        public void wordCount_CatchTwoInString_2()
        {
            Counter userInput = new Counter();
            Assert.AreEqual(2, userInput.wordCount("what would you like in your coffee I like black coffee", "coffee"));
        }
      
       
    }
}
