public class Solution {
    public bool CheckInclusion(string s1, string s2) {
    if (s1.Length > s2.Length) return false;

    var target = new Dictionary<char, int>();
    foreach (char c in s1) {
        target[c] = target.GetValueOrDefault(c, 0) + 1;
    }

    int left = 0;
    int matchedCount = 0; 

    for (int right = 0; right < s2.Length; right++) {
        char rChar = s2[right];
        if (target.ContainsKey(rChar)) {
            target[rChar]--; 
            if (target[rChar] == 0) matchedCount++; 
        }

        if (right >= s1.Length) {
            char lChar = s2[left];
            if (target.ContainsKey(lChar)) {
                if (target[lChar] == 0) matchedCount--; 
                target[lChar]++; 
            }
            left++;
        }

        if (matchedCount == target.Count) return true;
    }

    return false;
}
}