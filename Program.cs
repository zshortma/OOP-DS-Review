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

Console.WriteLine(arrays.GetSum(numbers));
Console.WriteLine(arrays.GetMax(numbers));
Console.WriteLine(arrays.CountOccurrences(numbers, 3));
Console.WriteLine(arrays.Contains(numbers, 3));