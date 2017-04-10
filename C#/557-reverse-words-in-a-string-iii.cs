public class Solution
{
    public string ReverseWords(string s)
    {
        if(s.Length < 1) {
            return s;
        }

        StringBuilder final = new StringBuilder();
        StringBuilder builder = new StringBuilder();
        char[] charArr = s.ToCharArray();
        for (int i = 0; i < charArr.Length; i++)
        {
            if (charArr[i] == ' ')
            {
                for (int j = builder.Length - 1; j >= 0; j--)
                {
                    final.Append(builder[j]);
                }
                final.Append(" ");
                builder.Clear();
            }
            else if(i == charArr.Length - 1)
            {
                builder.Append(charArr[i]);
                for (int j = builder.Length - 1; j >= 0; j--)
                {
                    final.Append(builder[j]);
                }
                final.Append(" ");
                builder.Clear();
            }
            else
            {
                builder.Append(charArr[i]);
            }
        }
        final.Remove(final.Length - 1, 1);
        return final.ToString();
    }
}