//Accepted - O(n) time complexity - O(1) space complexity

public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length==t.Length){
            int[] letterSeenS = new int[26];
            int[] letterSeenT = new int[26]; //space O(1)
            char letter;
            int len = s.Length;
            for(int i=0; i<len; i++){
                letter = s[i]; // Ascii 'a' = 97 : 'a'-'a'= 0, 'b'-'a' = 1...
                letterSeenS[letter - 'a'] = letterSeenS[letter - 'a'] + 1;

            }
            for(int i=0;i<len;i++){
                letter = t[i];
                letterSeenT[letter - 'a'] = letterSeenT[letter - 'a'] + 1;
            }
            for(int i=0;i<26;i++){
                if(letterSeenS[i]==letterSeenT[i]){
                    continue;
                }
                return false;
            }
            return true;
        }
        return false;
        }
       
        
    }
