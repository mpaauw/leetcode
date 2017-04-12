public class Solution
{
    public int ShortestDistance(string[] words, string word1, string word2)
    {
        List<int> word1Indexes = new List<int>();
        List<int> word2Indexes = new List<int>();

        for (int i = 0; i < words.Length; i++)
        {
            if (words[i] == word1)
            {
                word1Indexes.Add(i);
            }
        }

        for (int i = 0; i < words.Length; i++)
        {
            if (words[i] == word2)
            {
                word2Indexes.Add(i);
            }
        }

        int min = Int32.MaxValue;
        for (int i = 0; i < word1Indexes.Count; i++)
        {
            for (int j = 0; j < word2Indexes.Count; j++)
            {
                int diff = Math.Abs(word1Indexes[i] - word2Indexes[j]);
                if (diff < min)
                {
                    min = diff;
                }
            }
        }

        return min;
    }
}