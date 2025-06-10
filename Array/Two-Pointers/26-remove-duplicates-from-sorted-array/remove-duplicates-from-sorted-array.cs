public class Solution {
    public int RemoveDuplicates(int[] nums) {

        int insertPos = 1; // start from 1 because the first element is always unique
        
        for(int i=1; i<nums.Length; i++){

            if(nums[i] != nums[i-1]){
                nums[insertPos] = nums[i];
                insertPos++;
            }
        }

        return insertPos;
    }
}