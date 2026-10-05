public class Solution {

    public string Encode(IList<string> strs) {
        StringBuilder sb = new StringBuilder();

        foreach(var str in strs){
            sb.Append(str.Replace("#", "##")).Append(" # ");
        }

        return sb.ToString();
    }

    public List<string> Decode(string s) {
        List<string> result = new List<string>();

        string[] array = s.Split(" # ");
        for(int i=0; i<array.Length - 1; i++){
            result.Add(array[i].Replace("##", "#"));
        }

        return result;
   }
}
