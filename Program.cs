int[] nums = { 3, 7, 9, 2 };
int target = 5;
for (int i = 0; i < nums.Length; i++)
{
    for (int j = 0; j < nums.Length; j++)
    {
        int sum = nums[i] + nums[j];
        if (sum == target)
        {
            Console.WriteLine(nums[i]);
            Console.WriteLine(nums[j]);
            return;
        }
    }
}