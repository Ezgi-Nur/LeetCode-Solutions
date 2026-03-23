//Accepted - O(n) time complexity - O(n) space complexity
//önceki çözüme göre runtime azaldı
public class Solution {
    public bool IsValid(string s) {
        if(String.IsNullOrEmpty(s)){
            return false;
        }
        Stack<char> stackCh = new Stack<char>();
    
        
        for(int i=0 ; i<s.Length;i++){
            if(s[i]=='('){
                stackCh.Push(')');
            }
            else if(s[i]=='{'){
                stackCh.Push('}');
            }
            else if(s[i]=='['){
                stackCh.Push(']');
            }
            else if(stackCh.Count==0 || stackCh.Peek()!=s[i]){
                return false;
            }
            else{
                stackCh.Pop();}
        }
        if(stackCh.Count==0){
            return true;
        }
        return false;
}}
