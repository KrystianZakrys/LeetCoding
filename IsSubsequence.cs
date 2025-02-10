using System;

public class IsSubsequence
{
    public class Solution
    {
        public bool IsSubsequence(string s, string t)
        {
            int i = 0;
            while (s.Length > 0 && i < t.Length)
            {
                if (s[0] == t[i])
                {
                    s = s.Substring(1);
                }
                i++;
            }

            return s.Length == 0;
        }
    }
}
