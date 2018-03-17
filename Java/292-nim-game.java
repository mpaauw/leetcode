class Solution {

    // Explanation: If n is less than or equal to three, or is not a multiple of four, the game is winnable.
    // Otherwise, if n is a multiple of four, you will always lose.
    public boolean canWinNim(int n) {
        return n <= 3 || n % 4 != 0;
    }
}