using System.Diagnostics.Metrics;

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

    public int CountGreaterThan(List<int> nums, int target)
    {
        int count = 0;
        foreach (int num in nums)
        {
            if (num > target)
            {
                count++;
            }
        }
        return count;
    }

    public List<int> ReverseList(List<int> nums)
    {
        List<int> result = [];
        for (int i = nums.Count - 1; i >= 0; i--)
        {
            result.Add(nums[i]);
        }
        return result;
    }

    public List<int> RemoveDuplicates(List<int> nums)
    {
        List<int> result = [];
        foreach (int num in nums)
        {
            if (!result.Contains(num))
            {
                result.Add(num);
            }
        }
        return result;
    }

    public int FindSmallest(List<int> nums)
    {
        if (nums.Count == 0) { return 0; }
        int k = nums[0];

        for (int i = 0; i < nums.Count; i++)
        {
            if (nums[i] < k)
            {
                k = nums[i];
            }
        }
        return k;
    }

    public int CountEven(List<int> nums)
    {
        int counter = 0;
        foreach (int num in nums)
        {
            if (num % 2 == 0)
            {
                counter++;
            }
        }

        return counter;
    }

    public List<int> GetLessThan(List<int> nums, int target)
    {
        for (int i = 0; i < nums.Count(); i++)
        {
            if (nums[i] > target)
            {
                nums.Remove(nums[i]);
            }
        }
        return nums;
    }

        /* 
        876. Middle of the Linked List
        public ListNode MiddleNode(ListNode head) {

        int counter = 1;

        ListNode countCopy = head;
        while(countCopy.next != null) {
            counter++;
            countCopy = countCopy.next;
        }

        if(counter % 2 == 0) counter++;
        counter = counter / 2 ;

        while(counter != 0) {
           head = head.next; 
           counter--;
        }

        return head;
    }

    // Try again
    1290. Convert Binary Number in a Linked List to Integer
    public int GetDecimalValue(ListNode head) {

        string sum = "";
        while(head != null){
            sum += head.val;
            head = head.next;
        }
        return Convert.ToInt32(sum,2);
    }
    */


}