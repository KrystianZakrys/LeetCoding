using System;

public class Solution
{
    public List<string> result = new List<string>();
    public int N;
    public IList<string> GenerateParenthesis(int n)
    {
        this.N = n;
        //DFS(1, 0, "(");
        DFS_WithChecking(1, 0, "(");
        return result;
    }

    public void DFS(int l, int r, string combination)
    {
        if (l > N || r > N || r > l)
        {
            return;
        }

        if (l == N && r == N)
        {
            result.Add(combination);
        }

        DFS(l + 1, r, combination + "(");
        DFS(l, r + 1, combination + ")");

    }

    public void DFS_WithChecking(int l, int r, string combination)
    {
        if(combination.length == N * 2)
        {
            result.AddRange(combination);
        }

        if (l < N) {
            DFS_WithChecking(l + 1, r, combination + "(");
        }

        if(r < l)
        {
            DFS_WithChecking(l, r + 1, combination + ")");
        }
}
