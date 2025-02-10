using System.Text;

public class Solution
{
    public string MergeAlternately(string word1, string word2)
    {
        StringBuilder sb = new StringBuilder("");
        int maxLength = word1.Length > word2.Length ? word1.Length : word2.Length;
        for (int i = 0; i < maxLength; i++)
        {
            if (i < word1.Length)
            {
                sb.Append(word1[i]);
            }

            if (i < word2.Length)
            {
                sb.Append(word2[i]);
            }
        }

        return sb.ToString();
    }
}

//Faster
public class FasterSolution
{
    public string MergeAlternately(string word1, string word2)
    {
        StringBuilder sb = new StringBuilder("");
        int w1 = word1.Length;
        int w2 = word2.Length;
        int minLength = word1.Length < word2.Length ? word1.Length : word2.Length;
        for (int i = 0; i < minLength; i++)
        {
            sb.Append(word1[i]);
            sb.Append(word2[i]);
        }

        if (w1 > w2)
        {
            sb.Append(word1.Substring(w2));
        }

        if (w2 > w1)
        {
            sb.Append(word2.Substring(w1));
        }

        return sb.ToString();
    }
}