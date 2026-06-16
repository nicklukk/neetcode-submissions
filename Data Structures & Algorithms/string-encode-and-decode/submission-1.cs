public class Solution {
    private const char delimeter = '#';

    public string Encode(IList<string> strs) {
        var builder = new System.Text.StringBuilder();

        foreach (var str in strs) {
            builder.Append($"{str.Length}{delimeter}{str}");
        }

        return builder.ToString();
    }

    public List<string> Decode(string s) {
        var result = new List<string>();

        var pointer = 0;
        while (pointer < s.Length) {
            var delimeterIndex = s.IndexOf(delimeter, pointer);
            var length = int.Parse(s[pointer..delimeterIndex]);
            var str = s.Substring(delimeterIndex + 1, length);

            result.Add(str);
            pointer = delimeterIndex + 1 + length;
        }

        return result;
    }
}
