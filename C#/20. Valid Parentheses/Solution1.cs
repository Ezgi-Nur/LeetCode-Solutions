//Accepted - O(n) time complexity - O(n) space complexity

public class Solution {
    public bool IsValid(string s) {
        Stack stackObj = new Stack();
        for(int i = 0;i <s.Length;i++){
            switch(s[i]){
                case '(':
                stackObj.Push('('); 
                break;
                case '{':
                stackObj.Push('{'); 
                break;
                case '[':
                stackObj.Push('['); 
                break;
                case ')':
                if(stackObj.Count!=0){
                if((char)stackObj.Peek()=='('){
                    stackObj.Pop();
                    break;
                }
                return false;}
                return false;
                case '}':
                if(stackObj.Count!=0){
                if((char)stackObj.Peek()=='{'){
                    stackObj.Pop();
                    break;
                }
                return false;}
                return false;
                case ']':
                if(stackObj.Count!=0){
                if((char)stackObj.Peek()=='['){
                    stackObj.Pop();
                    break;
                }
                return false;}
                return false;
            }
        }
        if(stackObj.Count==0){
        return true;}
        return false;
    }
}
