using System;

public class SummaryRanges
{
	public class WorstSolution()
	{
        public IList<string> SummaryRanges(int[] nums)
        {
            List<string> result = new List<string>();
            Stack<int> stack = new Stack<int>();
            if (nums.Length == 0)
            {
                return result;
            }
            stack.Push(nums[0]);
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] == stack.Peek() + 1)
                {
                    if (stack.Count() > 1)
                        stack.Pop();

                    stack.Push(nums[i]);
                }
                else if (nums[i] > stack.Peek() + 1)
                {
                    if (stack.Count() > 1)
                    {
                        var end = stack.Pop();
                        var start = stack.Pop();
                        result.Add($"{start}->{end}");
                    }
                    else
                    {
                        result.Add(stack.Pop().ToString());
                    }

                    stack.Push(nums[i]);
                }
            }

            while (stack.Count() > 0)
            {
                if (stack.Count() > 1)
                {
                    var end = stack.Pop();
                    var start = stack.Pop();
                    result.Add($"{start}->{end}");
                }
                else
                {
                    result.Add(stack.Pop().ToString());
                }
            }

            return result;
        }
    }

    public class BestSolution
    {
        public IList<string> SummaryRanges(int[] nums)
        {
            List<string> result = new List<string>();
            for (int i = 0; i < nums.Length; i++)
            {
                int start = nums[i];
                while (i + 1 < nums.Length && nums[i] + 1 == nums[i + 1])
                {
                    i++; //Skip elements if in range or until end of nums
                }

                if (start < nums[i])
                {
                    result.Add(start.ToString() + "->" + nums[i].ToString());
                }

                if (start == nums[i])
                {
                    result.Add(start.ToString());
                }
            }

            return result;
        }
    }
}
