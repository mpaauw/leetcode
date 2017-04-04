public class Solution
{
    public IList<string> GeneratePossibleNextMoves(string s)
    {
        IList<string> combos = new List<string>();
        StringBuilder builder = new StringBuilder();
        for (int i = 0; i < s.Length - 1; i++)
        {
            if (s[i] == '+')
            {
                if (s[i + 1] == '+')
                {
                    builder.Append(s);
                    builder[i] = '-';
                    builder[i + 1] = '-';
                    combos.Add(builder.ToString());
                    builder.Clear();
                }
            }
        }
        return combos;
    }
}