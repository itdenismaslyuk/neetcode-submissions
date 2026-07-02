public class Solution {
    public int LongestConsecutive(int[] nums) {
        var set = new HashSet<int>(nums);

        var result = 0;

        for(int i = 0; i < nums.Length; i++)
        {
            var flag = true;
            var counter = nums[i];

            while(flag)
            {
                if(set.Contains(counter))
                {
                    counter++;
                }
                else 
                {
                    flag = false;
                } 
            }

            result = Math.Max(result, counter - nums[i]);
        }

        return result;
    }
}