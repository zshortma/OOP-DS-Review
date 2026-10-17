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
}