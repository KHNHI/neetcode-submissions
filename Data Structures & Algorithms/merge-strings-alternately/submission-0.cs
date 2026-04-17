public class Solution {
    public string MergeAlternately(string word1, string word2) {
        StringBuilder alterString = new StringBuilder();
        int i = 0, j = 0;
        int n = word1.Length, m = word2.Length;
        while(i< n || j<m){
            if(i<n){
                alterString.Append(word1[i]);
            }
            if(j<m){
                alterString.Append(word2[j]);
            }
            i++;
            j++;
        }
        return alterString.ToString();
    }
}