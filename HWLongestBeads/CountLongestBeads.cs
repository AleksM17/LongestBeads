using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWLongestBeads
{
    class CountLongestBeads
    {
        public int LongestSize(int[] arr)
        {
            int maxSize = 0;
            for (int i = 0; i < arr.Length-maxSize; i++)
            {
                List<int> temp = new List<int>();

                for (int j = i; j < arr.Length; )
                {
                    temp.Add(arr[j]);

                    if (arr[j] == i)
                    {
                        maxSize = temp.Count > maxSize ? temp.Count : maxSize;
                        break;
                    }
                    j = arr[j];
                }
            }
            return maxSize;
        }
    }
}
