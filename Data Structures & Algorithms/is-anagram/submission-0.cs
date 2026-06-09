public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length) {
            return false;
        }

        var alfabet = new int[26];

        for(int i = 0; i < s.Length; i++) {
            alfabet[s[i] - 'a']++;
            alfabet[t[i] - 'a']--;
        }

        foreach(var el in alfabet) {
            if (el != 0) {
                return false;
            }
        }

        return true;
    }
}
