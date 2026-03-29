public class Solution {
    public int LengthOfLongestSubstring(string s) {
      Dictionary<char, int> map = new Dictionary<char,int>();
      int left =0, res=0;
      for(int right=0; right<s.Length; right++){
        if(map.ContainsKey(s[right])){
            left = Math.Max(map[s[right]]+1, left);
        }
        map[s[right]]=right;
        res = Math.Max(res, right-left+1);
      }
      return res;
    }
}
