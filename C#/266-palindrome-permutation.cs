public class Solution
{
    public bool CanPermutePalindrome(string s)
    {
        // edge cases:
        if (s == null)
        {
            return false;
        }
        if (s.Length <= 1)
        {
            return true;
        }

        Dictionary<char, int> dict = new Dictionary<char, int>();
        // move through string, add chars and counts to dictionary.
        for (int i = 0; i < s.Length; i++)
        {
            char c = s.ElementAt(i);
            if (dict.ContainsKey(c))
            { // if dictionary already contains character, increment its count.
                dict[c]++;
            }
            else
            { // if dictionary does not yet contain character, insert.
                dict.Add(c, 1);
            }
        }

        // examine dictionary:
        //      if string is odd-length, all char counts greater than 1 require an even count of characters except for one
        //      if string is even-length, all char counts greater than 1 require an even count of all characters
        bool foundSingle = false; // variable used to track single-count char for odd-length strings of size > 1.
        bool isOdd = (s.Length % 2 == 0) ? false : true;
        if (isOdd)
        { // handle odd-length strings, starting with length 3
            foreach (char key in dict.Keys)
            {
                if (dict[key] % 2 != 0)
                {
                    if (foundSingle)
                    {
                        return false;
                    }
                    foundSingle = true;
                }
            }
        }
        else
        { // handle even-length strings, starting wtih length 2
            foreach (char key in dict.Keys)
            {
                if (dict[key] % 2 != 0)
                {
                    return false;
                }
            }
        }

        return true; // passed all checks, string does contain a palindrome permutation.
    }
}