/**
 * // This is the interface that allows for creating nested lists.
 * // You should not implement it, or speculate about its implementation
 * interface NestedInteger {
 *
 *     // @return true if this NestedInteger holds a single integer, rather than a nested list.
 *     bool IsInteger();
 *
 *     // @return the single integer that this NestedInteger holds, if it holds a single integer
 *     // Return null if this NestedInteger holds a nested list
 *     int GetInteger();
 *
 *     // @return the nested list that this NestedInteger holds, if it holds a nested list
 *     // Return null if this NestedInteger holds a single integer
 *     IList<NestedInteger> GetList();
 * }
 */
public class Solution {
    public int DepthSum(IList<NestedInteger> nestedList) {
        return recurse(nestedList, 1);
    }

    private int recurse(IList<NestedInteger> list, int depth) {
        int sum = 0;
        foreach(NestedInteger item in list) {
            if(item.IsInteger()) {
                sum += item.GetInteger() * depth;
            }
            else {
                sum += recurse(item.GetList(), depth + 1);
            }
        }
        return sum;
    }
}