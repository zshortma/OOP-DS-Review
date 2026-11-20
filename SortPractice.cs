public class SortPractice
{
//Selection Sort
  public void SortColors(int[] nums) {
        
        // Basic tracker to iterate array
        for(int i=0; i<nums.Length; i++)
        {
            // track min. start with i
            int min = i;
            
            // compare tracker to iterate array
            for(int j = i+1; j<nums.Length; j++)
            {
                // if compare is less that num at min then min becomes j
                if(nums[j] < nums[min]){
                    min = j;
                }
            }
            
            int temp = nums[i]; // track i
            nums[i] = nums[min]; // main int set to min
            nums[min] = temp; // min num set to OG value
        }
        
    }


}