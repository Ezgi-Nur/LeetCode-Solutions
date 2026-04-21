//Time Limit Exceeded - O(n^2) time complexity - O(1) space complexity

public class Solution {
    public int MaxArea(int[] height) {
       int n= height.Length;
       int max=0;
       int current;
       for(int i=0;i<n-1;i++){
        for(int j=i+1;j<n;j++){
            if(height[j]<height[i]){
                current= (j-i)*height[j];
                if(current>max){
                    max = current;
                }
            }
            if(height[i]<=height[j]){
                current= (j-i)*height[i];
                if(current>max){
                    max = current;
                }
            }
            
        }
       }
       
       return max;
    }
}
