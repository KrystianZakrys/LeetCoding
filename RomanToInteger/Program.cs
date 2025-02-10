public class BetterSolution
{
    Dictionary<char, int> romanMap = new Dictionary<char, int>(){
        {'I', 1},
        {'V', 5},
        {'X', 10},
        {'L', 50},
        {'C', 100},
        {'D', 500},
        {'M', 1000},
    };

    public int RomanToInt(string s)
    {
        int value = 0;
        int prev = 0;

        for (int i = s.Length - 1; i >= 0; i--)
        {
            var curr = romanMap[s[i]];

            if (curr < prev)
            {
                value -= curr;
            }
            else
            {
                value += curr;
            }

            prev = curr;
        }

        return value;
    }
}

public class Worst_Solution
{
    Dictionary<char, int> romanMap = new Dictionary<char, int>(){
        {'I', 1},
        {'V', 5},
        {'X', 10},
        {'L', 50},
        {'C', 100},
        {'D', 500},
        {'M', 1000},
    };

    public int RomanToInt(string s)
    {
        int value = 0;

        for (int i = s.Length - 1; i >= 0; i--)
        {
            var letter = s[i];
            if (i > 0)
            {
                var prev = s[i - 1];
                var addition = romanMap[letter];
                if (prev == 'I' && (letter == 'V' || letter == 'X'))
                {
                    addition -= romanMap[prev];
                    i -= 1;
                }


                if (prev == 'X' && (letter == 'C' || letter == 'L'))
                {
                    addition -= romanMap[prev];
                    i -= 1;
                }


                if (prev == 'C' && (letter == 'M' || letter == 'D'))
                {
                    addition -= romanMap[prev];
                    i -= 1;
                }
                Console.WriteLine($"Checking: {letter},{prev}: {addition}");
                value += addition;
            }
            else
            {
                value += romanMap[letter];
            }
        }

        return value;
    }
}