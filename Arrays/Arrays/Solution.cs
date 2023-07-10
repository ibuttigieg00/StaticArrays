using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Solution
    {
        // Reads all of the elements in the array
        public string ReadAllElements(int[]nums)
        {
            StringBuilder sb = new StringBuilder();

            for(int i = 0; i < nums.Length; i++)
            {
                sb.Append(nums[i]);
            }
            return sb.ToString();
        }
        // Remove the last index of the array
        public int[] RemoveLastElement(int[]nums)
        {
            nums[nums.Length - 1] = 0;
            return nums;
        }

        // Make an un-ordered list ordered
        public int[] OrderList(int[]nums)
        {
            int replaced = 0;
            bool replacementsMade = true;

            while (replacementsMade)
            {
                replacementsMade = false;
                for (int i = 1; i < nums.Length; i++)
                {
                    if (nums[i] < nums[i - 1])
                    {
                        replaced = nums[i];
                        nums[i] = nums[i - 1];
                        nums[i - 1] = replaced;
                        replacementsMade = true;
                    }
                }
            }           
            return nums;
        }
        
        public int RemoveElement(int[] nums, int val)
        {
            int k = 0;

            for(int i = 0; i < nums.Length; i++)
            {
                if(nums[i] != val)
                {
                    nums[k] = nums[i];
                    k++;
                }
            }
            return k;
        }
    }
}
