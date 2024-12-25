public class Solution {
    public bool IsPalindrome(string s) {
        int start = 0, end = s.Length-1;
        while(start < end)
        {
            if(!char.IsLetterOrDigit(s[start]))
            {
                // if the letter at start index is not an alphanumeric then skip it by increasing the start index
                start++;
                continue;
            }
            if(!char.IsLetterOrDigit(s[end]))
            {
                // if the letter at end index is not an alphanumeric then skip it by decreasing the end index
                end--;
                continue;
            }

            if(char.ToLower(s[start]) != char.ToLower(s[end]))
            {
                // if the letters at start and end indices doesn't match than return false
                return false;
            }
            start++;
            end--;
        }
        return true;
    }
}
