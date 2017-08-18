public class Solution {
    public void ReverseWords(char[] s) {

        // first, reverse string:
        for(int i = 0; i < (s.Length - 1) / 2; i++) {
            char temp = s[i];
            s[i] = s[(s.Length - 1) - i];
            s[(s.Length - 1) - i] = temp;
        }

        //  next, re-reverse each individual word in the reversed string:
        int index = 0;
        for(int i = 0; i < s.Length; i++) {
            if(s[i] == ' ') {
                for(int j = index; index < (i - 1) / 2; index++) {
                    char temp = s[index];
                    s[index] = s[(i - 1) / 2 - index];
                    s[(i - 1) / 2 - index] = temp;
                }
                index++; // skip the space
                continue;
            }
        }
    }
}