//LeetCode.com
//#283: Move Zeroes

#include <iostream>
#include <vector>

class Solution {
public:
void moveZeroes(vector<int>& nums) {
	int flag = 0, subtract = 0;
	for (int i = 0; i < nums.size() - subtract; i++)
	{
		if (flag == 1)
		{
			i -= 1;
		}
		flag = 0;
		if (nums[i] == 0)
		{
			nums.push_back(nums[i]);
			nums.erase(nums.begin() + i);
			flag = 1;
			subtract += 1;
		}
	}
}
};