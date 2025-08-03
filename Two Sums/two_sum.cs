public class Solution {

    public int[] TwoSum(int[] nums, int target) {
        /*
        given 
        nums = [2,7,11,15]
        target = 9
        Solution 
        nums i 2 + nums j = 7 == target 9

        Logic 
        so the logic is to loop the [i] + [j] and if its equal to the target retun the 
        indices of both numbers.
        First iteration (i = 0):
            Outer loop: i = 0 → nums[i] = 2
            Inner loop: j = 1 → nums[j] = 7
            Check: 2 + 7 = 9, which is equal to the target! So, we return the indices [0, 1].
        */
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] == target)
                    return new int[] { i, j };
            }

        }
        return nums;
    }
}