public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        if(strs == null) return "";
        string maxPre = strs[0];
        for(int i =1; i<strs.Length; i++){
            while(strs[i].IndexOf(maxPre)!=0){
                maxPre = maxPre.Substring(0, maxPre.Length -1 );
                if (maxPre == "") return "";
            };
        };
        return maxPre;
    }
}