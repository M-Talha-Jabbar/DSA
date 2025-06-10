public class Solution {
    public void MoveZeroes(int[] nums) {

        int insertPos = 0;
        
        // First pass: move non-zero elements to the front
        for(int i=0; i<nums.Length; i++){

            if(nums[i] != 0){
                nums[insertPos] = nums[i];
                insertPos++;
            }
        }

        // Second pass: fill the rest with zeros
        for(int i=insertPos; i<nums.Length; i++){
            nums[i] = 0;
        }

    }
}