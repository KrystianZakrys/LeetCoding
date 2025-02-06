

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
    public static IList<string> LetterCombinations(string digits)
    {


        List<string> letterCombinations = new List<string>();

        if (digits.Length == 0)
            return letterCombinations;

        //This method of recursion is names Backtracking because you backtrack from the end node of the recursion.
        CombineLetters(digits, 0, "", ref letterCombinations);

        return letterCombinations;
    }

    private static string CombineLetters(string digits, int digitsIndex, string innerResult, ref List<String> result)
    {
        if(digits.Length == digitsIndex)
        {
            result.Add(innerResult);
            return innerResult;
        }
        
        string inputResult = innerResult;
        string keyLetters = keyPadMap[digits[digitsIndex]];

        for (int i = 0; i < keyLetters.Length; i++)
        {
            innerResult += keyLetters[i];

            if (digits.Length > 1)
            {
                innerResult = CombineLetters(digits, digitsIndex + 1, innerResult, ref result);
            }
            else
            {
                result.Add(innerResult);
            }
            
            innerResult = inputResult;
        }

        return innerResult;
    }

}
