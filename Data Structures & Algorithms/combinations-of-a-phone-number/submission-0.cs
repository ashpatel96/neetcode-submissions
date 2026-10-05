public class Solution {
    /*
        Create Map for digit to characters.
        start with emptry string
        iterate each character of digit from map
        base case if indx == length of digits.length then record result.
    */
    public List<string> LetterCombinations(string digits) {
        if(string.IsNullOrEmpty(digits) || digits.Length == 0){
            return new List<string>();
        }
        List<string> result = new List<string>();
        Dictionary<char,string> map = new Dictionary<char, string>
        {
            {'2', "abc"},
            {'3', "def"},
            {'4', "ghi"},
            {'5', "jkl"},
            {'6', "mno"},
            {'7', "pqrs"},
            {'8', "tuv"},
            {'9', "wxyz"},
        };
        LetterCombinations(digits, "", 0, result, map);
        return result;
        
    }
    private void LetterCombinations(string digits, string path, int indx, List<string> result,
                                    Dictionary<char, string> map){
        //base case
        if(indx == digits.Length){
            Console.WriteLine($"digists indx: {indx},and path: {path}");
            result.Add(path);            
        } else {

            foreach(var chr in map[digits[indx]]){
                Console.WriteLine($"digists indx: {indx}, char: {chr}");
                LetterCombinations(digits, path + chr, indx + 1, result, map);
            }
        }
    }
}
