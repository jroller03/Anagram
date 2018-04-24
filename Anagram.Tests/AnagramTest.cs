using Microsoft.VisualStudio.TestTools.UnitTesting;
using Anagram;

namespace Anagram.Tests
{
  [TestClass]
  public class AnagramTest
  {
    [TestMethod]
    public void AreCharactersGreaterThanEachOther()
    {
      Anagram testAnagram = new Anagram();
      Assert.AreEqual(true, testAnagram.BIsGreaterThanA('a', 'b'));
    }
    [TestMethod]
    public void AreCharactersLessThanEachOther()
    {
      Anagram testAnagram = new Anagram();
      Assert.AreEqual(true, testAnagram.AIsLessThanA('a', 'b'));
    }
  }
}
