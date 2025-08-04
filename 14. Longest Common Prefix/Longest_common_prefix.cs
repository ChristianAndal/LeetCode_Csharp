public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        /*
        Given a list of strings, this method finds the longest common prefix among them.
        
        Example:
        Input: ["flower", "flow", "flight"]
        Output: "fl"
        
        Logic:
        - If the list is empty, return an empty string since there are no strings to compare.
        - Start by assuming the first string in the list is the longest common prefix.
        - Loop through the rest of the strings, comparing each with the current prefix.
        - For each string, check if the current prefix is a prefix of the string.
        - If not, reduce the prefix one character at a time until a match is found.
        - The result will be the longest common prefix shared by all strings.

        Steps:
        1. Start with the first string as the initial prefix.
        2. Loop through each subsequent string in the array.
        3. For each string, check if the prefix is a prefix of the string using `IndexOf(Prefix)`.
        4. If the prefix is not a valid prefix, shorten the prefix by one character until it matches.
        5. Return the final prefix after processing all strings.

        Example:
        strs = ["flower", "flow", "flight"]
        Initial Prefix = "flower"
        
        First iteration (i = 1, "flow"):
            - Check if "flower" is a prefix of "flow" → no
            - Shorten prefix to "flow"
        
        Second iteration (i = 2, "flight"):
            - Check if "flow" is a prefix of "flight" → no
            - Shorten prefix to "flo"
            - Check if "flo" is a prefix of "flight" → no
            - Shorten prefix to "fl"
            - Check if "fl" is a prefix of "flight" → yes
            
        Final result: "fl"

        */
        
        if (strs.Length == 0) return "";
        string Prefix = strs[0]; // Initialize the prefix with the first string
        for (int i = 1; i < strs.Length; i++){
            // Reduce prefix length until it is a prefix of strs[i]
            while (strs[i].IndexOf(Prefix) != 0){
                Prefix = Prefix.Substring(0, Prefix.Length-1); // Remove last character from prefix
            }
        }
        return Prefix; // Return the longest common prefix
    }
}
