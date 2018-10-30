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
            HashSet<int> onlyOne = new HashSet<int>();
            for (int i = 0; i < arr.Length-maxSize; i++)
            {
                List<int> temp = new List<int>();
                if (!onlyOne.Contains(arr[i]))
                {
                    for (int j = i; j < arr.Length;)
                    {
                        if (onlyOne.Add(arr[j]))
                        {
                            temp.Add(arr[j]);

                            if (arr[j] == i)
                            {
                                maxSize = temp.Count > maxSize ? temp.Count : maxSize;
                                break;
                            }
                            j = arr[j];
                        }
                        else j++;
                    }
                }
            }
            return maxSize;
        }
    }
}
