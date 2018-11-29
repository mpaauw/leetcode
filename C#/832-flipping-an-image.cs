public class Solution
{
    public int[][] FlipAndInvertImage(int[][] A)
    {
        // setup
        int numRows = A.Length;
        int numCols = A[0].Length; // avoid null ref

        // flip image horizontally + invert in a single pass
        //  -> swap elements along a row
        //      -> once swap is done for two elements, inverse them.
        //          -> continue until entire matrix is swapped and inverted.
        for (int row = 0; row < numRows; row++)
        {
            for (int col = 0; col < (numCols / 2) - 1; col++)
            {
                // swap
                int temp = A[row][col];
                A[row][col] = A[row][(numCols - col) - 1];
                A[row][(numCols - col) - 1] = temp;
            }
        }

        // invert:
        for(int row = 0; row < numRows; row++)
        {
            for(int col = 0; col < numCols; col++)
            {
                if(A[row][col] == 1)
                {
                    A[row][col] = 0;
                }
                else if(A[row][col] == 0)
                {
                    A[row][col] = 1;
                }
            }
        }

        // return swapped/inverted matrix
        return A;
    }

    public int invert(int val)
    {
        return (val == 0) ? 1 : 0;
    }
}