public class Solution {
    public string LongestPalindrome(string s) {
        string best = string.Empty;
        for(int i=0; i< s.Length; i++){
            string odd = Expand(s, i, i);
            string even = Expand(s, i, i+1);
            if(odd.Length > best.Length){
                best = odd;
            }
            if (even.Length > best.Length){
                best = even;
            }
        }
        return best;
    }

    private string Expand(string s, int left, int right){
        string p = string.Empty;
        while(left >= 0 && right < s.Length && s[left]==s[right]){
            p = s.Substring(left, (right - left) + 1);
            left--;
            right++;
        }
        return  p;
    }
}
