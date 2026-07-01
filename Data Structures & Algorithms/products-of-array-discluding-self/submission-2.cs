public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        var nod = 1;
        var haveZero = false;
        var result = new List<int>();
        for(int i = 0; i < nums.Length; i++)
        {
            if(nums[i] == 0 && haveZero == true)
            {
                nod = 0;
            }
            if(nums[i] == 0)
            {
                haveZero = true;
            } else 
            {
                nod *= nums[i];
            }
        }
        for(int i = 0; i < nums.Length; i++)
        {
            if(!haveZero)
            {
                result.Add(nod/nums[i]);
            } else
            {
                if(nums[i] == 0)
                {
                    result.Add(nod);   
                }
                else
                {
                    result.Add(0);
                }
            }
        }
        return result.ToArray();
    }
}
