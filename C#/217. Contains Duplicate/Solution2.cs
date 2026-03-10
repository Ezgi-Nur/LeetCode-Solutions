//Accepted - O(nlogn) time complexity - O(logn) space complexity

public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        Array.Sort(nums);  //recursive sorting function leads to O(nlogn) time and O(logn) space complexity
        for(int i =0; i+1< nums.Length;i++){  //O(n) time O(1) space
            if(nums[i]==nums[i+1]){
                return true;
            }
        }
        return false;
    }
}
