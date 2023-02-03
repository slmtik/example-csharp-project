namespace Primer;
public class Searcher
{
    static public int[] FindPrimes(int max)
    {
        Dictionary<int, bool> primeNumberCheck = new();

        for (int i = 4; i < max; i++)
            if (!primeNumberCheck.ContainsKey(i))
            {
                primeNumberCheck.Add(i, true);

                for (int j = i + i; j <= max; j += i)
                    if (!primeNumberCheck.ContainsKey(j))
                        primeNumberCheck.Add(j, false);
            }

        return primeNumberCheck
            .Where(n => n.Value)
            .Select(n => n.Key)
            .ToArray();
    }
}