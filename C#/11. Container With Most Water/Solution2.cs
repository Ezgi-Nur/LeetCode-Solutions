//Time Limit Exceeded - O(n) time complexity - O(1) space complexity

public class Solution {
    public int MaxArea(int[] height) {
       int n= height.Length;
       int max=0;
       int current=0;
       int pointerL=0;
       int pointerR=n-1;
       while(pointerL<pointerR){
        if(height[pointerL]<height[pointerR]){
            current=(pointerR-pointerL)*height[pointerL];
            pointerL++;  
        }else if(height[pointerR]<=height[pointerL]){
            current=(pointerR-pointerL)*height[pointerR];  
            pointerR--;
        }
        if(current>max){
            max = current;
        }
       }
       return max;
    }
}
