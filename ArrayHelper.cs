public class ArrayHelper
{
    public int GetSum(int[] numbers)
    {
<<<<<<< HEAD
        int count;
        int i = 0;
        // TODO: Add every number
        while( i <= numbers.count ){
=======
        int count = 0;
        int i = 0;
        
        while( i < numbers.Count() ){
>>>>>>> cb7cbd7 (Implement GetSum)

            count += numbers[i];
            i++;
        }
       
        return count;
    }

    public int GetMax(int[] numbers)
    {
        // TODO: Find the largest number
        return 0;
    }

    public int CountOccurrences(int[] numbers, int target)
    {
        // TODO: Count how often target appears
        return 0;
    }

    public bool Contains(int[] numbers, int target)
    {
        // TODO: Return true if target exists
        return false;
    }
}