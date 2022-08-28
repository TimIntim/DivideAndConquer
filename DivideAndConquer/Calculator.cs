namespace DivideAndConquer
{
    public static class Calculator
    {
        public static int SumUsingLoop(List<int> nums)
        {
            int result = 0;
            foreach (int i in nums)
                result += i;

            return result;
        }

        public static int SumUsingRecursion(IEnumerable<int> nums)
        {
            if (!nums.Any()) return 0;
            if (nums.Count() == 1) return nums.First();

            int item = nums.Last();
            return item + SumUsingRecursion(nums.SkipLast(1));
        }

        public static int Count<T>(IEnumerable<T> list)
        {
            if (!list.Any()) return 0;

            return 1 + Count(list.Skip(1));
        }

        public static int FindBiggest(IEnumerable<int> nums)
        {
            if (!nums.Any()) return 0;
            if (nums.Count() == 1) return nums.First();

            int firstInt = nums.First();
            int nextInt = FindBiggest(nums.Skip(1));

            return firstInt > nextInt ? firstInt : nextInt;
        }

        public static int BinarySearch(int[] sortedArr, int value, int? left = null, int? right = null)
        {
            left ??= 0;
            right ??= sortedArr.Length - 1;
            
            if (left.Value > right.Value || !sortedArr.Any())
                return -1;

            int mid = (left.Value + right.Value) / 2;

            if (sortedArr[mid] == value)
                return mid;
            else if (sortedArr[mid] < value)
                left = mid + 1;
            else
                right = mid - 1;
            
            return BinarySearch(sortedArr, value, left, right);   
        }
    }
}
