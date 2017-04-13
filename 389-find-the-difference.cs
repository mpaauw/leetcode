public class Solution
{
    public char FindTheDifference(string s, string t)
    {
        char[] sChars = s.ToCharArray();
        char[] tChars = t.ToCharArray();
        int trackS = 0, trackT = 0;
        for (int i = 0; i < sChars.Length; i++)
        {
            trackS += (int)sChars[i];
        }
        for (int i = 0; i < tChars.Length; i++)
        {
            trackT += (int)tChars[i];
        }

        return (char)(trackT - trackS);
    }
}