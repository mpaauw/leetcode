public class Solution
{
    public int DistributeCandies(int[] candies)
    {
        if (candies.Length < 1)
        { // edge case
            return -1;
        }

        int n = candies.Length;
        int numUniqueCandies = 0;
        HashSet<int> hashCandies = new HashSet<int>();

        // move through array, for each unique number not yet tracked in sisters uniques, add the candy to her uniques and increment her total possible unique count
        for (int i = 0; i < n; i++)
        {
            if (numUniqueCandies >= n / 2)
            { // if maximum numbers of candies available to sis has been reached, break (answer found; can't be more than n / 2 candies)
                break;
            }
            int candy = candies[i];
            if (!hashCandies.Contains(candy))
            { // if unique candy found, add to uniques list and increment total count of uniques.
                hashCandies.Add(candy);
                numUniqueCandies += 1;
            }
        }
        return numUniqueCandies;
    }
}