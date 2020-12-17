//Given an array of sorted 0s and 1s, count how many 1st exist
//Space complexity: O(1)
//Time complexity: O(log(N)) where N is the number of digits
//Example: [0,0,0,0,0,1,1,1] -> 3

 using System;
	public class Program
	{
		public static void Main()
		{
			int[] arr = { 0, 0, 0, 1, 1, 1, 1 };
			int n = arr.Length;
			Console.WriteLine("Count of 1's in given array is: " + CountOnes(arr, 0, n - 1));
		}

		public static int CountOnes(int[] arr, int left, int right)
		{
			//if last element of array is 0, no ones are present since its sorted
			if(arr[right] == 0)
      {
			  return 0;
      }
			//if first element of array is 1, all elements are 1 since its sorted
			if(arr[left] == 1)
      {
		    return (right - left + 1);
      }
			//divide array into left and right sub array
			int mid = (left + right) / 2;
			return CountOnes(arr, left, mid) + CountOnes(arr, mid + 1, right); 
		}
	}
