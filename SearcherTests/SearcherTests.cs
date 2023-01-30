using Primer;

namespace Primer.SearcherTests;

[TestClass]
public class SearcherTests
{
    [TestMethod()]
    public void FindPrimes100Test()
    {
        int[] expected = {2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37,
            41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97 };

        int[] actual = Searcher.FindPrimes(100);
        CollectionAssert.AreEqual(expected, actual);
    }
}