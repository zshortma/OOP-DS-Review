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