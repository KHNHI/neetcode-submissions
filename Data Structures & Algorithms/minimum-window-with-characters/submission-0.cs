public class Solution {
    public string MinWindow(string s, string t) {
        if (t == "") return "";
        Dictionary<char,int> countT = new Dictionary<char,int>();
        Dictionary<char,int> window = new Dictionary<char,int>();
        foreach(char c in t){
            if(countT.ContainsKey(c)){
                countT[c]++;
            }else{
                countT[c]=1;
            }
        }
        int left =0, need = countT.Count, have =0;
        int[] res ={-1, -1};
        int resLen = int.MaxValue;
        for(int r=0; r<s.Length; r++){
            if(window.ContainsKey(s[r])){
                window[s[r]]++;
            }else{
                window[s[r]]=1;
            }
            if(countT.ContainsKey(s[r])&& window[s[r]]==countT[s[r]]){
                have++;
            }
            while(have==need){
                if((r-left +1)<resLen){
                    resLen = r-left+1;
                    res[0]=left;
                    res[1]=r;
                }

            char leftChar = s[left];
            window[leftChar]--;
            if(countT.ContainsKey(leftChar)&& window[leftChar]<countT[leftChar]){
                have--;
            }
            left++;
        }
    }
        return resLen== int.MaxValue?"": s.Substring(res[0], resLen);
    }
}
