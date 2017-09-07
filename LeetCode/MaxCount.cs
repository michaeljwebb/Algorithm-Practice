using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class MaxCount
{
    public static void Main(String[] args)
    {
        int[] nums = { 2, 3, 4, 9, 5, 5, 8, 5, 0 };
        FindMaxCount(nums);
    }

    public static int FindMaxCount(int[] nums)
    {

        Dictionary<int, int> _maxCount = new Dictionary<int, int>();
        int maxKeyCount = 0;
        int count = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (!_maxCount.ContainsKey(nums[i]))
            {
                _maxCount.Add(nums[i], 1);
            }
            else
            {
                int tempCount = (int)_maxCount[nums[i]];
                tempCount++;
                _maxCount.Remove(nums[i]);
                _maxCount.Add(nums[i], tempCount);

                if (count < tempCount)
                {
                    count = tempCount;
                    maxKeyCount = nums[i];
                }
            }
        }
        Console.WriteLine("Max Count: " + maxKeyCount);
        Console.WriteLine("Occurences: " + count);
        return maxKeyCount;

    }
}