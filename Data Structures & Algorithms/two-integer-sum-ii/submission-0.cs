public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        var dic = new Dictionary<int, int>();
        for(int i = 0; i < numbers.Length; i++)
        {
            var d = target - numbers[i];
            if(dic.ContainsKey(d))
            {
                
                return [dic[d]+1, i+1];
            }
            dic.TryAdd(numbers[i], i);
        }
        return [0,1];
    }
}
