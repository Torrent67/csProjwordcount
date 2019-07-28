using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;

namespace WordCounter.Tests
{
    [TestClass]
    public class CounterTest
    {
        [TestMethod]
        public void wordCounter_CatchOneWord_1()
        {
            Counter userInput = new Counter();
            Assert.AreEqual(1, userInput.wordCounter("coffee", "coffee"));
        }
        [TestMethod]
        public void wordCounter_CatchOneInString_1()
        {
            Counter userInput = new Counter();
            Assert.AreEqual(1, userInput.wordCounter("more coffee please", "coffee"));
        }
     
  
    }
}