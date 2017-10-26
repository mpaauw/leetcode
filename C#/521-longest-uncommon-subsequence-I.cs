// simplified solution (must be an april fools question):
public class Solution {
    public int FindLUSlength(string a, string b) {
        return (a.Equals(b)) ? -1 : Math.Max(a.Length, b.Length);
    }
}

// lol this actually works
public class Solution {
    public int FindLUSlength(string a, string b) {
        // edge cases:
        if((a == null && b == null) || (a.Length == 0 && b.Length == 0)) {
            return -1;
        }
        else if((a.Length > 0 && b == null) || (a.Length > 0 && b.Length == 0)) {
            return a.Length;
        }
        else if((b.Length > 0 && a == null) || (b.Length > 0 && a.Length == 0)) {
            return b.Length;
        }
        else if(a.Length > b.Length) {
            return a.Length;
        }
        else if(b.Length > a.Length) {
            return b.Length;
        }

        if(a.Length > b.Length) {
            return a.Length;
        }
        else if(a.Length < b.Length) {
            return b.Length;
        }
        else if(a.Length == b.Length) {
            if(!a.Equals(b)) {
                return a.Length;
            }
            else {
                return -1;
            }
        }
        else{
            return -1;
        }
    }
}