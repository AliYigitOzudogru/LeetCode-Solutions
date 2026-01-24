public class Solution {
    public int RemoveDuplicates(int[] nums) {
        if (nums.Length == 0) return 0;
        int validconuter = 0;
        
        for(int i = 0; i < nums.Length; i++)
        {
            bool isfind = false;
            // Kendinden SONRA bu sayıdan bir tane daha var mı?
            for(int j = i + 1; j < nums.Length; j++)
            {
                if (nums[j] == nums[i])
                {
                    isfind = true;
                    break;   
                }
            }


            if (!isfind)
            {
                nums[validconuter] = nums[i];
                validconuter++;
            }
        }
        return validconuter;
    }
}