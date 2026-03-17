//Accepted - O(n) time complexity - O(n) space complexity

public class Solution {
    public bool IsPalindrome(string s) {
        List<char> sNew = new List<char>();
        s = s.ToLower();
        for(int i=0;i<s.Length;i++){
            if(s[i]<='z' && s[i]>='a'){
                sNew.Add(s[i]);
            }else if(s[i]<='9' && s[i]>='0'){
                sNew.Add(s[i]);
            }
        }
        for(int i=0;i<sNew.Count;i++){
            if(sNew[i]!=sNew[sNew.Count-i-1]){
                return false;
            }
        }
        return true;
        
    }
}
