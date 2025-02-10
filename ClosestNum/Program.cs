
var result = new Solution().FindClosestNumber([-1,2,3,4]);

Console.WriteLine(result);
public class Solution
{
    public int FindClosestNumber(int[] nums)
    {
        int currentClosest = int.MaxValue;

        for (int i = 0; i < nums.Length; i++)
        {
            int absValue = Math.Abs(nums[i]);
            int closestAbsValue = Math.Abs(currentClosest);

            if (absValue < closestAbsValue)
            {
                currentClosest = nums[i];
            }

            if (absValue == closestAbsValue)
                currentClosest = currentClosest > nums[i] ? currentClosest : nums[i];

        }

        return currentClosest;
    }
}