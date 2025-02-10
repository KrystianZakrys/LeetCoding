using System;

public class BestTimeToBuyAndSellStock
{
    public class Solution
    {
        public int MaxProfit(int[] prices)
        {
            int min = int.MaxValue;
            int max = 0;

            for (int i = 0; i < prices.Length; i++)
            {
                min = prices[i] < min ? prices[i] : min;
                max = (prices[i] - min) > max ? prices[i] - min : max;
            }

            return max;
        }
    }
}
