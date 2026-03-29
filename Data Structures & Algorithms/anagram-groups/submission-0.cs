public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
   var groups = new Dictionary<string, List<string>>();

    foreach (string s in strs) {
        char[] characters = s.ToCharArray();
        Array.Sort(characters);
        
        string key = new string(characters);

        if (!groups.ContainsKey(key)) {
            groups[key] = new List<string>();
        }

        groups[key].Add(s);
    }

    return groups.Values.Cast<List<string>>().ToList();
}
}
