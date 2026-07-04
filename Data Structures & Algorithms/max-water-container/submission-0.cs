public class Solution {
    public int MaxArea(int[] heights) {
        var left = 0;
        var right = heights.Length - 1;
        var maxArea = (right - left) * Math.Min(heights[left], heights[right]);

        while(left < right)
        {
            if(heights[right] > heights[left])
            {
                left++;
            } 
            else 
            {
                right--;
            }

            maxArea = Math.Max(
                maxArea, 
                (right - left) * Math.Min(heights[left], heights[right])
            );
        }

        return maxArea;
    }
}