public class Solution {

    private readonly string[] Codes = {".-","-...","-.-.","-..",".","..-.","--.","....","..",".---","-.-",".-..","--","-.","---",".--.","--.-",".-.","...","-","..-","...-",".--","-..-","-.--","--.."};

    private const int BaseAsciiRef = 97;

    /// <summary>
    /// Finds the number of unique morse code transformations based on standard language input strings.
    /// </summary>
    /// <param name="words">Input array of strings to translate</param>
    /// <returns>Unique number of morse code translations</returns>
    public int UniqueMorseRepresentations(string[] words) {

        List<string> translations = new List<string>();
        HashSet<string> transformations = new HashSet<string>();
        int count = 0;

        // create morse code translations of each word in input string array
        foreach(string word in words)
        {
            translations.Add(translate(word));
        }

        // create hash set of morse code translations to track how many distinct translations exist
        foreach(string translation in translations)
        {
            if(transformations.Add(translation))
            {
                count++;
            }
        }

        return count;
    }

    /// <summary>
    /// Converts a given string to a morse code translation.
    /// </summary>
    /// <param name="word">Input string to translate.</param>
    /// <returns>Translated string in morse code.</returns>
    private string translate(string word)
    {
        StringBuilder builder = new StringBuilder();
        foreach(char c in word.ToCharArray())
        {
            int index = (int)c - BaseAsciiRef;
            builder.Append(Codes[index]);
        }

        return builder.ToString();
    }
}