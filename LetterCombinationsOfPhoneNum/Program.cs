

using System.Globalization;


var combinations = Solution.LetterCombinations("237");
foreach (string combination in combinations)
{
    Console.WriteLine(combination);
}

public static class Solution
{
    static readonly Dictionary<char, string> keyPadMap = new() {
    { '2', "abc" },
    { '3', "def" },
    { '4', "ghi" },
    { '5', "jkl" },
    { '6', "mno" },
    { '7', "pqrs" },
    { '8', "tuv" },
    { '9', "wxyz" }
};

    static List<string> letterCombinations = new List<string>();
    public static IList<string> LetterCombinations(string digits, Delegate func)
    {

        if (string.IsNullOrEmpty(digits))
            return letterCombinations;

        //This method of recursion is names Backtracking because you backtrack from the end node of the recursion.
        //CombineLetters(digits, 0, "");

        //More elegant way to do this recursive backtracking
        CombineLettersWithSubstring("", digits);        

        return letterCombinations;
    }

    private static void CombineLetters(string digits, int digitsIndex, string innerResult)
    {
        if(digits.Length == digitsIndex)
        {
            letterCombinations.Add(innerResult);
            return ;
        }
        
        string inputResult = innerResult;
        
        foreach (char letter in keyPadMap[digits[digitsIndex]])
        {
            if (digits.Length > 1)
            {
               CombineLetters(digits, digitsIndex + 1, innerResult + letter);
            }
            else
            {
                letterCombinations.Add(innerResult + letter);
            }

            innerResult = inputResult;
        }

    }

    private static void CombineLettersWithSubstring(string combination, string digits)
    {
        if(digits.Length == 0)
        {
            letterCombinations.Add(combination);
        }
        else
        {
            foreach (char letter in keyPadMap[digits[0]])
            {
                CombineLettersWithSubstring(combination + letter, digits.Substring(1));
            }
        }
    }
}
