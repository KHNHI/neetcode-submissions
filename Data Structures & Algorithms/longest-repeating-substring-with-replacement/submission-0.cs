public class Solution {
    public int CharacterReplacement(string s, int k) {
        Dictionary<char,int> count = new Dictionary<char,int>();
        int res=0, left=0, maxf=0;
        for(int right=0; right<s.Length; right++){
            if(count.ContainsKey(s[right])){
                count[s[right]]++;
            }else{
                count[s[right]]=1;
            }
            maxf= Math.Max(maxf, count[s[right]]);
            while((right-left+1)-maxf >k){
                count[s[left]]--;
                left++;
            }
            res = Math.Max(res, right-left+1);
        }
        return res;
    }
}
