using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class MaxCount
    {

        public static void Main(String[] args)
        {
            int[] nums = {2, 3, 4, 4, 5, 7, 9};
            Console.WriteLine(FindMaxCount(nums));
        }


        public static int FindMaxCount(int[] nums)
        {
            
            Dictionary<int, int> _maxCount = new Dictionary<int, int>();
            int maxIndex = 0;
            int count = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (_maxCount.ContainsKey(nums[i]))
                {
                    
                }



            }







            return maxIndex;
        }

    }
}
