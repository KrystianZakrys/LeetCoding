public class Solution
{
    public int[] TwoSum(int[] nums, int target)
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