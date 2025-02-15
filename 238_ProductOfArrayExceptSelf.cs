using System;

public class ProductOfArrayExceptSelf
{
    public class FastSolution
    {
        public int[] ProductExceptSelf(int[] nums)
        {
            int n = nums.Length;

            int[] result = new int[n];

            int l = 1;
            int r = 1;

            for (int i = 0; i < n; i++)
            {
                if (i > 0)
                {
                    l *= nums[i - 1];
                }

                result[i] = l;
            }

            for (int i = n - 1; i >= 0; i--)
            {
                if (i < n - 1)
                {
                    r *= nums[i + 1];
                }
                result[i] *= r;
            }

            return result;
        }
    }

    public class SlowSolution
    {
        public int[] ProductExceptSelf(int[] nums)
        {
            int n = nums.Length;

            int[] result = new int[n];
            Array.Fill(result, 1);

            int[] prefix = new int[n];
            int[] suffix = new int[n];
            Array.Fill(prefix, 1);
            Array.Fill(suffix, 1);

            for (int i = 1; i < n; i++)
            {
                prefix[i] = prefix[i - 1] * nums[i - 1];
            }

            for (int i = n - 2; i >= 0; i--)
            {
                suffix[i] = suffix[i + 1] * nums[i + 1];
            }

            for (int i = 0; i < n; i++)
            {
                result[i] = prefix[i] * suffix[i];
            }

            return result;
        }
    }
}
