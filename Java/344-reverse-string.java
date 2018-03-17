class Solution {
    // Time: O(n), Space: O(n)
    // Explanation: store string in character array, swap values from front and end while moving towards center of array. Return swapped char array as a string.
    public String reverseString(String s) {
        char[] charArr = s.toCharArray();
        int begin = 0, end = charArr.length - 1;
        while(begin <= end) {
            char temp = charArr[begin];
            charArr[begin] = charArr[end];
            charArr[end] = temp;
            begin++;
            end--;
        }
        return new String(charArr);
    }
}