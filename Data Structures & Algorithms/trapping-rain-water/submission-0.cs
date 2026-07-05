public class Solution {
    public int Trap(int[] height) {
        var total = 0;
        var left = 0;
        var right = height.Length - 1;
        var leftMax = 0;
        var rightMax = 0;

        while (left < right)
        {
            if (height[left] < height[right])
            {
                leftMax = Math.Max(leftMax, height[left]);
                total += leftMax - height[left];
                left++;
            }
            else
            {
                rightMax = Math.Max(rightMax, height[right]);
                total += rightMax - height[right];
                right--;
            }
        }

        return total;
    }
}