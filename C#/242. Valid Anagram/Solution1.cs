//Accepted - O(n^2) time complexity - O(n) space complexity

public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length==t.Length){
            int len = s.Length;
            char[] letterList= new char[len]; //O(n) space yeni dizi oluşturuldu
           for(int i=0;i<len;i++){
            letterList[i]=s[i];
            }
            for(int a=0;a<len;a++){ //O(n) time
                if(Array.Exists(letterList, x => x==t[a])){ //O(n) time
                    letterList[Array.IndexOf(letterList,t[a])] = ' '; //O(n) time
                    continue;
                } // if(O(n)) --> do O(n) = 2n
                return false;
            } //total time complexity n*2n = 2n^2 = O(n^2)
            return true;
           }
           return false;
        }
       
        
    }
