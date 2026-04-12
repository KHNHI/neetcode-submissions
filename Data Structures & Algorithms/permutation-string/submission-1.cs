public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        Dictionary<char, int> count1 = new Dictionary<char, int>();
        foreach (char c in s1) {
            if (count1.ContainsKey(c)) {
                count1[c]++;
            } else {
                count1[c] = 1;
            }
        }

        int need = count1.Count;
        for (int i = 0; i < s2.Length; i++) {
        Dictionary<char, int> count2 = new Dictionary<char, int>();
            int cur = 0;
            for (int j = i; j < s2.Length; j++) {
                if (count2.ContainsKey(s2[j])) {
                    count2[s2[j]]++;
                } else {
                    count2[s2[j]] = 1;
                }

                if (!count1.ContainsKey(s2[j]) || count1[s2[j]] < count2[s2[j]]) {
                    break;
                }

                if (count1[s2[j]] == count2[s2[j]]) {
                    cur++;
                }

                if (cur == need) {
                    return true;
                }
            }
        }
        return false;
    }
}