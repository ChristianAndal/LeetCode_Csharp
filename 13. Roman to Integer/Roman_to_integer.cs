public class Solution {

    private int Translate (char c){  
        /*
        Given Roman numeral characters (I, V, X, L, C, D, M), 
        the method returns the corresponding integer value. 
        Example: 'I' → 1, 'V' → 5, 'X' → 10, etc.
        */
        switch (c){
            case 'I': return 1;
            case 'V': return 5;
            case 'X': return 10;
            case 'L': return 50;
            case 'C': return 100;
            case 'D': return 500;
            case 'M': return 1000;
            default: return 0;
        }
    }

    public int RomanToInt(string s) {
        /*
        Given a Roman numeral string, this method converts it to an integer.
        
        Example: 
        Input: "IX" → Output: 9
        Explanation:
        The Roman numeral 'IX' represents 9.
        The rule is: if a smaller numeral comes before a larger numeral, subtract it (e.g., 'I' before 'X' means 10 - 1 = 9).
        
        Logic:
        - Loop through each character in the string 's'.
        - For each character, compare its value to the next character's value.
        - If the current character represents a smaller value than the next one, subtract its value.
        - Otherwise, add its value to the sum.
        
        Example:
        s = "IX"
        First iteration (i = 0):
            currentNumeral = Translate(s[0]) = 1 ('I')
            nextChar = Translate(s[1]) = 10 ('X')
            1 < 10 → subtract currentNumeral → sum = -1
        Second iteration (i = 1):
            currentNumeral = Translate(s[1]) = 10 ('X')
            nextChar = 0 (end of string) → add currentNumeral → sum = 9
        Final result is 9.

        */
        int sum = 0;

        for (int i = 0; i < s.Length; i++){
            int currentNumeral = Translate(s[i]);
            int nextChar = (i + 1 < s.Length)? Translate(s[i + 1]) : 0;

            if (currentNumeral < nextChar){
                sum -= currentNumeral;
            }
            else{
                sum += currentNumeral;
            }
        }

        return sum;
    }
}
