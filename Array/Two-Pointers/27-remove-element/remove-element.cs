public class Solution {
    public int RemoveElement(int[] nums, int val) {
        
        int insertPos = 0;

        for(int i=0; i<nums.Length; i++){

            if(nums[i] != val){
                nums[insertPos] = nums[i];
                insertPos++;
            }
        }

        return insertPos;
    }
}