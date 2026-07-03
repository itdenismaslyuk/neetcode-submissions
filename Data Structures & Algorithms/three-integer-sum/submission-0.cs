public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        var result = new List<List<int>>();
        var seen = new HashSet<string>(); // для отслеживания уникальных троек
        
        for(int i = 0; i < nums.Length; i++)
        {
            for(int j = 0; j < nums.Length; j++)
            {
                for(int q = 0; q < nums.Length; q++)
                {
                    if(nums[i] + nums[j] + nums[q] == 0 && i != j && i != q && j != q)
                    {
                        // Сортируем тройку для уникальности
                        var triple = new List<int>(){nums[i], nums[j], nums[q]};
                        triple.Sort();
                        
                        // Создаем строковый ключ для проверки дубликатов
                        string key = $"{triple[0]},{triple[1]},{triple[2]}";
                        
                        if (!seen.Contains(key))
                        {
                            seen.Add(key);
                            result.Add(new List<int>(){nums[i], nums[j], nums[q]});
                        }
                    }
                }
            }
        }
        return result;
    }
}