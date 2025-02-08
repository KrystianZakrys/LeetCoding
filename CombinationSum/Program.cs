
var solution = new Solution();
solution.CombinationSum([2,3,6,7], 7);
public class Solution
{
    List<List<int>> result;
    public IList<IList<int>> CombinationSum(int[] candidates, int target)
    {
        result = new List<List<int>>();

        if (candidates.Length == 1 && candidates[0] > target)
        {
            return result.Cast<IList<int>>().ToList();
        }

        Recursion(0, candidates, target, new List<int>());

        return result.Cast<IList<int>>().ToList();
    }


    public void Recursion(int index, int[] candidates, int target, List<int> innerResult)
    {
        if (target == 0)
        {
            result.Add(new List<int>(innerResult));
            return;
        }

        for (int i = index; i < candidates.Length; i++)
        {
            {
                if (candidates[i] <= target)
                {
                    innerResult.Add(candidates[i]);
                    Recursion(i, candidates, target - candidates[i], innerResult);
                    innerResult.RemoveAt(innerResult.Count - 1);
                }
            }
        }
    }
}