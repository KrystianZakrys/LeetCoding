
foreach (var number in Solution.TwoSum([1, 2, 3, 4, 5, 6, 7, 8, 9], 9))
{
    Console.WriteLine(number);
}
public static class Solution
{
    public static int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int,int> map = new Dictionary<int,int>();
        for (int i = 0; i < nums.Length; i++)
        {
            var currentCheck = nums[i]; //bierzesz liczbe z tablicy
            if (map.ContainsKey(target - currentCheck)) //sprawdzasz czy istnieje wartośc komplementarna do target
            {
                return [map[target - currentCheck], i]; // jeżeli tak to wypisz
            }

            map[currentCheck] = i; // jeżeli nie to dodaj do słownika sprawdzony element
        }
        return [];
    }

}
