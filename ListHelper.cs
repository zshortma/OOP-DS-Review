public class ListHelper
{
    public int GetSum(List<int> nums)
    {
    int sum = 0;

    foreach (int number in nums)
    {
        sum += number;
    }

    return sum;
    }
    
    public bool ContainsNumber(List<int> nums, int target)
    {
    foreach (int number in nums)
    {
        if (number == target)
        {
            return true;
        }
    }

    return false;
    }

    public int FindLargest(List<int> nums)
    {
    int largest = nums[0];

    foreach (int number in nums)
    {
        if (number > largest)
        {
            largest = number;
        }
    }

    return largest;
    }
}