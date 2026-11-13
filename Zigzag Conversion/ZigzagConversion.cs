public class Solution {
    public string Convert(string s, int numRows) {
        if (numRows == 1 || numRows >= s.Length) return s;

        var rows = new System.Text.StringBuilder[numRows];
        for (int i = 0; i < numRows; i++) {
            rows[i] = new System.Text.StringBuilder();
        }

        int row = 0;
        int step = 1;

        foreach (char c in s) {
            rows[row].Append(c);

            if (row == 0) step = 1;
            else if (row == numRows - 1) step = -1;

            row += step;
        }

        var result = new System.Text.StringBuilder();
        foreach (var sb in rows) {
            result.Append(sb);
        }

        return result.ToString();
    }
}
