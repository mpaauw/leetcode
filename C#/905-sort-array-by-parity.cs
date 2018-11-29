public class Solution
{
    public int[] SortArrayByParity(int[] A)
    {
        int[] resultArr = new int[A.Length];
        int frontIter = 0, tailIter = 0;
        for(int i = 0; i < A.Length; i++)
        {
            if(A[i] % 2 == 0)
            {
                resultArr[frontIter++] = A[i];
            }
            else
            {
                resultArr[(A.Length - 1) - tailIter++] = A[i];
            }
        }
        return resultArr;
    }
}