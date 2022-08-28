using DivideAndConquer;

List<int> nums = new List<int> () { 2, 4, 6};

Console.WriteLine(Calculator.SumUsingLoop(nums));
Console.WriteLine(Calculator.SumUsingRecursion(nums));

int[] bigArray = new int[100];
Console.WriteLine(Calculator.Count(bigArray));

List<int> list = new List<int> () { 2, 3, 55, 64, 153, 154};
Console.WriteLine(Calculator.FindBiggest(list));

Console.WriteLine(Calculator.BinarySearch(list.ToArray(), 55));
Console.WriteLine(Calculator.BinarySearch(list.ToArray(), 2));
Console.WriteLine(Calculator.BinarySearch(list.ToArray(), 153));
Console.WriteLine(Calculator.BinarySearch(list.ToArray(), 153));
Console.WriteLine(Calculator.BinarySearch(list.ToArray(), 1));
Console.WriteLine(Calculator.BinarySearch(list.ToArray(), 155));
