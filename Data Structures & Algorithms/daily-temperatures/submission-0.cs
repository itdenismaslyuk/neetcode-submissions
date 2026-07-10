public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        var result = new int[temperatures.Length];
        for(int i = 0; i < temperatures.Length; i++)
        {
            var counter = 0;
            var j = i + 1;
            while(j < temperatures.Length)
            {
                if(temperatures[j] > temperatures[i])
                {
                    j = temperatures.Length;
                }
                
                if(j == temperatures.Length - 1)
                {
                    counter = 0;
                } else 
                {
                    counter++;
                }
                j++;
            }
            result[i] = counter;
            counter = 0;
        }
        return result;
    }
}
