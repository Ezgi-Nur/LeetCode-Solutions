//Accepted - O(n) time complexity - O(n) space complexity

public class Solution {
    public bool ContainsDuplicate(int[] nums) {
       HashSet<int> HS = new HashSet<int>();
       foreach(int i in nums){
        if(HS.Add(i)==false){
            return true;
        };
       }
      
       return false;

    }
}
