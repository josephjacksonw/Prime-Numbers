using Microsoft.VisualStudio.TestTools.UnitTesting;
using Prime.Models;

namespace Prime.Models.Tests
{
  [TestClass]
  public class CheckerTests
  {
    [TestMethod]
    public void showPrimes_listOutPrimes_True()
    {
			int userInput = 15;
      Checker testVar = new Checker();
      Assert.AreEqual("2, 3, 5, 7, 11, 13", testVar.showPrimes(userInput));
    }
  }
}