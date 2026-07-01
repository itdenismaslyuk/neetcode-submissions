public class Solution {
        public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length)
        {
            return false;
        }
        var dicS = new Dictionary<char, int>();
        var dicT = new Dictionary<char, int>();

        for(int i = 0; i < s.Length; i++)
        {
            if(!dicS.TryAdd(s[i], 1)){
                dicS[s[i]]++;
            }

            if(!dicT.TryAdd(t[i], 1)){
                dicT[t[i]]++;
            }
        }

        foreach(var item in dicS)
        {
            if(!dicT.ContainsKey(item.Key) || dicT[item.Key] != item.Value)
            {
                return false;
            }
        }

        return true;
    }
}
