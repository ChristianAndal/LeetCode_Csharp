public class Solution {
    public bool IsPalindrome(int x) {
          /*
        Given a number x, the goal is to determine if x is a palindrome. A number is a palindrome if it reads the same backward as forward.

        Example:
        Input: x = 121
        Output: true
        Explanation: 121 is a palindrome because it reads the same backward and forward.

        Example:
        Input: x = -121
        Output: false
        Explanation: -121 is not a palindrome because the negative sign is not the same at the end.

        Logic:
        1. Check if the number is negative or ends with a zero (and is not 0 itself). If so, it's not a palindrome.
        2. Reverse the second half of the number by extracting its digits one by one and constructing a reversed version.
        3. Compare the first half of the number with the reversed second half to check if they are the same.
        4. If they are the same, the number is a palindrome, otherwise it is not.

        First iteration (x = 121):
        1. Check if x is negative or ends with a zero (but isn't 0) → it's not.
        2. Start the while loop: reverse the second half of the number.
        3. After reversing, check if the first half of the number (x) is the same as the reversed second half (half).
        4. Return true because the number is a palindrome.
        */

      if (x < 0 || (x != 0 && x % 10 == 0))
        {
            return false;
        }
    
         int half = 0;
         while (x > half) {
            half = ( half * 10 ) + (x % 10);
            x = x / 10;
         
         
      }
       return x == half || x == half / 10;
    }
}