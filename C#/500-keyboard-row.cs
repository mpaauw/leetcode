public class Solution {

    string topRow = "qwertyuiopQWERTYUIOP";
    string midRow = "asdfghjklASDFGHJKL";
    string bottomRow = "zxcvbnmZXCVBNM";

    public string[] FindWords(string[] words) {
        List<string> results = new List<string>();
        
        
        for(int i = 0; i < words.Length; i++) {
            bool add = true;
            char[] currentWordArr = words[i].ToCharArray();
            int actualRow = findRow(currentWordArr[0]);
            for(int j = 1; j < currentWordArr.Length; j++) {
                int currentRow = findRow(currentWordArr[j]);
                if(currentRow != actualRow) {
                    add = false;
                    break;
                }
            }
            if(add){
                results.Add(words[i]);
            }
            
        }
        return results.ToArray();
    }

    private int findRow(char c) {
        if(topRow.Contains(c)) {
            return 0;
        }
        else if(midRow.Contains(c)) {
            return 1;
        }
        else {
            return 2;
        }
    }
}