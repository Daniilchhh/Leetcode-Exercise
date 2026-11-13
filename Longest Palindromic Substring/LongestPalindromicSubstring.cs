public class Solution {
    public string LongestPalindrome(string s) {
        int start = 0;
        int maxLength = 1;

        for (int center = 0; center < s.Length; center++) {
            int len1 = Expand(s, center, center);
            int len2 = Expand(s, center, center + 1);
            int len = Math.Max(len1, len2);

            if (len > maxLength) {
                maxLength = len;
                start = center - (len - 1) / 2;
            }
        }

        return s.Substring(start, maxLength);
    }

    private int Expand(string s, int left, int right) {
        while (left >= 0 && right < s.Length && s[left] == s[right]) {
            left--;
            right++;
        }
        return right - left - 1;
    }
}
