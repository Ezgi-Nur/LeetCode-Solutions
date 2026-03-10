//Time Limit Exceeded - O(n^2) time complexity - O(1) space complexity

public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        int a;
        for(int i =0; i< nums.Length;i++){
            a = nums[i];
            for(int j=i+1;j<nums.Length;j++){
                if(nums[j]==a){
                    return true;
                }
            }
        }
        return false;
    }
}
