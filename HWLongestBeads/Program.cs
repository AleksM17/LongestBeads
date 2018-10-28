using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWLongestBeads
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArr = { 3, 2, 1, 4, 5, 6, 0, 8, 9, 10, 11, 12, 13, 7 };
            Console.WriteLine(LongestSize(myArr));
        }
        public static int LongestSize(int[] arr)
        {
            List<int> sizes = new List<int>();
            Dictionary<int, Dictionary<int, int>> names = new Dictionary<int, Dictionary<int, int>>();
            for (int i = 0; i < arr.Length; i++)
            {
                names[i] = new Dictionary<int, int>();
                int k = i;
                int val = arr[k];
                names[i].Add(k++, val);

                while (arr[val] != i)
                {
                    val = arr[val];
                    names[i].Add(k++, val);
                }
                names[i].Add(k++, arr[val]);

                sizes.Add(names[i].Count);
            }
            return sizes.Max();
        }
    }
}

