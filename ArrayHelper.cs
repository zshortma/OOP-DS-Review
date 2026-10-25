public class ArrayHelper
{
    public int GetSum(int[] numbers)
    {
        int count = 0;
        int i = 0;
        
        while( i < numbers.Count() ){

            count += numbers[i];
            i++;
        }
       
        return count;
    }

    public int GetMax(int[] numbers)
    {
        if (numbers == null) return 0;
        Array.Sort(numbers);
        Array.Reverse(numbers);
        return numbers[0];
    }

    public int CountOccurrences(int[] numbers, int target)
    {
        int occurs = 0;
        foreach (int num in numbers)
        {
            if(num == target)
            {
                occurs++;
            }
        }
        return occurs;
    }

    public bool Contains(int[] numbers, int target)
    {
        foreach (int num in numbers)
        {
            if(num == target)
            {
                return true;
            }
        }
        return false;
    }

    public int GetIndex(int[] numbers, int target)
    {
        for(int i= 0; i< numbers.Length; i++)
        {
            if(numbers[i] == target)
            {
                return i;
            }
        }
        return -1;
    }

    public int[] RemoveDuplicates(int[] numbers)
    {
        List<int> result = new List<int>();

        for(int i=0; i < numbers.Length; i++)
        {
            if(!result.Contains(numbers[i]))
            {
                result.Add(numbers[i]);
            }
        }

        return result.ToArray();
    }

    public int CountGreaterThan(int[] numbers, int index)
    {
        int counter = 0;
        for(int i = 0; i<numbers.Length; i++)
        {
            if(numbers[i] > index)
            {
                counter++;
            }
        }
        return counter;
    }

    public int CountOdd(int[] numbers)
    {
        int tracker = 0;
        for(int i =0; i< numbers.Length; i++)
        {
            if(!(numbers[i] % 2 == 0))
            {
                tracker++;
            }
        }
        return tracker;
    }

    public int[] TwoSum(int[] nums, int target) {

       if(nums == null) return [];
       for(int i = 0; i < nums.Length; i++)
        {
            for(int j = 1; j < nums.Length; j++)
            {
                if(nums[i] + nums[j] == target)
                {
                    return [i,j];
                }
            }
        }
        return [];
        
    }

    public int RemoveDuplicates_Two(int[] nums)
    {
     if(nums.Length ==0) return 0;
        
        int i = 0;
        
        for(int j = 1; j<nums.Length; j++){
            if(nums[j] != nums[i]){
                i++;
                nums[i] = nums[j];
            }
        }
        return i+1; 
    }

        public int[] FindDegrees(int[][] matrix) {
        
        if(matrix == null) return [0];
        List<int> total = new List<int>();
        foreach(int[] matri in matrix){
            int sum = 0;
            for(int i =0; i<matri.Length; i++)
            {
               sum += matri[i];
            }

            total.Add(sum);
        }

        return total.ToArray();
    }


        // 3512: Minimum Operations to Make Array Sum Divisible by K
        public int MinOperations(int[] nums, int k) {
        
        int interations = 0;

        while(getSum(nums, interations) % k != 0)
        {
            interations++;
        }

        return interations;

    }

    public int getSum(int[] nums, int interations) {
        int total = 0;

        for(int i = 0; i < nums.Length; i++) {
            total += nums[i];
        }

        return total - interations;
    }

}