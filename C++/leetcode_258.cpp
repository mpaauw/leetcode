//LeetCode.com
//#258: Add Digits

class Solution {
public:
int addDigits(int num) {
	do
	{
		string raw = to_string(num);
		num = 0;
		for (int i = 0; i < raw.length(); i++)
		{
			num += raw[i] - '0';
		}
	} while (num >= 10);
	return num;
}
};