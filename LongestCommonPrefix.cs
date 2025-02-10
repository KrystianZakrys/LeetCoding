using System;

public class LongestCommonPrefix
{
    public class Solution
    {
        string prefix = "";
        public string LongestCommonPrefix(string[] strs)
        {
            for (int i = 0; i < strs[0].Length; i++)
            {
                for (int j = 0; j < strs.Length; j++)
                {
                    if (i >= strs[j].Length || strs[j][i] != strs[0][i])
                    {
                        return prefix;
                    }
                }
                prefix += strs[0][i];
            }
            return prefix;
        }
    }
}
