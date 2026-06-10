public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var dict = new Dictionary<string, List<string>>();

        foreach (var str in strs) {
            var alfabet = new int[26];
            for (var i = 0; i < str.Length; i++) {
                alfabet[str[i] - 'a']++;
            }

            string key = string.Join(",", alfabet);
            if (dict.ContainsKey(key)) {
                dict[key].Add(str);
            } else {
                dict.Add(key, new List<string> { str });
            }
        }

        var result = new List<List<string>>();
        foreach (var el in dict) {
            result.Add(el.Value);
        }

        return result;
    }
}