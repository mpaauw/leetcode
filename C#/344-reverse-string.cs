public class Solution {
    public string ReverseString(string s) {
        char[] sRaw = s.ToCharArray();
        StringBuilder builder = new StringBuilder();
        for(int i = sRaw.Length - 1; i >= 0; i--) {
            builder.Append(sRaw[i]);
        }
        return builder.ToString();
    }
}