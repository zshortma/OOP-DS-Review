Console.WriteLine("Hello, World!");


NumberHelper helper = new NumberHelper();

Console.WriteLine($"Is 4 even? {helper.IsEven(4)}");
Console.WriteLine($"Is 1 even? {helper.IsEven(1)}");

Console.WriteLine($"Double of 5 is {helper.DoubleNumber(5)}");
Console.WriteLine($"Double of 2 is {helper.DoubleNumber(2)}");

Console.WriteLine($"Absolute Value of -5 is {helper.GetAbsoluteValue(-5)}");
Console.WriteLine($"Absolute Value of 34 {helper.GetAbsoluteValue(34)}");

ArrayHelper arrays = new ArrayHelper();

int[] numbers = { 2, 5, 2, 8, 3 };

Console.WriteLine($"The sum of the array is: {arrays.GetSum(numbers)}");
Console.WriteLine($"The max number of this array is: {arrays.GetMax(numbers)}");
Console.WriteLine($"How many times: {arrays.CountOccurrences(numbers, 2)}");
Console.WriteLine($"How many times: {arrays.CountOccurrences(numbers, 8)}");
Console.WriteLine($"How many times: {arrays.CountOccurrences(numbers, 0)}");
Console.WriteLine($"Number in this array: {arrays.Contains(numbers, 3)}");
Console.WriteLine($"Number in this array: {arrays.Contains(numbers, 9)}");

Console.WriteLine($"Index of 5: {arrays.GetIndex(numbers, 5)}");
Console.WriteLine($"Index of 2: {arrays.GetIndex(numbers, 2)}");
Console.WriteLine($"Index of 9: {arrays.GetIndex(numbers, 9)}");

Console.WriteLine($"array with no duplicates: {string.Join(", ", arrays.RemoveDuplicates(numbers))}");

Console.WriteLine($"Odd values: {arrays.CountOdd(numbers)}");
Console.WriteLine($"Amount greater than: {arrays.CountGreaterThan(numbers, 2)}");

int[] numbers2 = { 2,7,11,15 };
Console.WriteLine($"nums = [2,7,11,15], target = 9 {string.Join(", ",arrays.TwoSum(numbers2, 9))}");

ListHelper listHelper = new ListHelper();
Console.WriteLine($"Sum of [2, 3, 4]: {listHelper.GetSum(new List<int> { 2, 3, 4 })}"); // 9
Console.WriteLine($"Sum of [5, 5]: {listHelper.GetSum(new List<int> { 5, 5 })}");    // 10

Console.WriteLine($"Contains 7: {listHelper.ContainsNumber(new List<int> { 3, 7, 9 }, 7)}"); // true
Console.WriteLine($"Contains 2: {listHelper.ContainsNumber(new List<int> { 3, 7, 9 }, 2)}");

Console.WriteLine($"Largest in [4, 9, 2, 6]: {listHelper.FindLargest(new List<int> { 4, 9, 2, 6 })}"); // 9
Console.WriteLine($"Largest in [-5, -2, -8]: {listHelper.FindLargest(new List<int> { -5, -2, -8 })}"); // -2

