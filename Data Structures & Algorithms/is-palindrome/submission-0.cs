public class Solution {
    public bool IsPalindrome(string s) {
        
        int start = 0, end = s.Length -1;
        //s = s.ToLower();
         Console.WriteLine($"atozASCII {s}");
        while(start < end){
           if (!AlphaNum(s[start])) {
                start++;
                continue;
            }

            if (!AlphaNum(s[end])) {
                end--;
                continue;
            }
            if(char.ToLower(s[start])!= char.ToLower(s[end])){
                return false;
            }

            start++;
            end--;
        }
        return true;
    }

    public bool AlphaNum(char c) {
        return (c >= 'A' && c <= 'Z' ||
                c >= 'a' && c <= 'z' ||
                c >= '0' && c <= '9');
    }
}
