public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int l =0;
        int res = 0;
        HashSet<char> unique = new HashSet<char>();
        for(int r =0; r<s.Length; r++){
            while(unique.Contains(s[r])){
                unique.Remove(s[l]);
                l++;
            }
            unique.Add(s[r]);
            res = Math.Max(res, r-l+1);
        }
        return res;
    }
}
