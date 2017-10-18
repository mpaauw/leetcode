public class Solution
{
    public bool JudgeCircle(string moves)
    {
        int x = 0, y = 0;

        char[] charArr = moves.ToCharArray();

        for(int i = 0; i < charArr.Length; i++) {
            if(charArr[i] == 'U') {
                y++;
            }
            else if(charArr[i] == 'D') {
                y--;
            }
            else if(charArr[i] == 'L') {
                x--;
            }
            else if(charArr[i] == 'R') {
                x++;
            }
            else {
                // do nothing...
            }
        }

        return x == 0 && y == 0;
    }
}