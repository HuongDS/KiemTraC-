class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(nums([0]));
    }

    public static int nums(int[] nums)
    {
        nums = nums.OrderBy(x => x).ToArray();
        for (int i = 0; i < nums.Length - 1; i++)
        {
            if (nums[i + 1] - nums[i] != 1) return nums[i] + 1;
        }
        return nums[nums.Length - 1] + 1;
    }
}