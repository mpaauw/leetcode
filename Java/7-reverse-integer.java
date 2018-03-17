class Solution {
    public int reverse(int x) {
        boolean isSigned = false;
        if(x < 0) {
            isSigned = true;
            x *= -1;
        }
        int reversed = 0;
        int power = 1;

        // find power:
        int temp = x;
        while(temp >= 10) {
            temp /= 10;
            power *= 10;
        }

        while(x >= 10) {
            reversed += (x % 10) * power;
            power /= 10;
            x /= 10;
        }

        return (isSigned) ? reversed * -1 : reversed;
    }
}