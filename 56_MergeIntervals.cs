using System;

public class MergeIntervals
{
    public int[][] Merge(int[][] intervals)
    {
        if (intervals.Length == 0)
            return new int[0][];

        Array.Sort(intervals, (a, b) => a[0].CompareTo(b[0]));
        List<int[]> result = new List<int[]>();
        result.Add(intervals[0]);

        for (int i = 1; i < intervals.Length; i++)
        {
            int[] interval = intervals[i];
            if (interval[0] <= result[result.Count - 1][1])
            {
                result[result.Count - 1][1] = Math.Max(interval[1], result[result.Count - 1][1]);
            }
            else
            {
                result.Add(interval);
            }
        }

        return result.ToArray();
    }
}