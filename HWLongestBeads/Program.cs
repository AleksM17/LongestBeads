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
            int[] myArr = { 1, 2, 3, 0, 5, 6, 7, 8, 4, 10, 9, 12, 13, 14, 15, 16, 17, 18, 11 };
            Console.WriteLine(LongestSize(myArr));
        }
        public static int LongestSize(int[] arr)
        {
            List<int> sizes = new List<int>();
            Dictionary<int, int> bead = new Dictionary<int, int>();
            for (int i = 0; i < arr.Length; i++)
            {
                bead.Add(i, arr[i]);
                if (bead.ContainsKey(arr[i]))
                {
                    sizes.Add(bead.Count);
                    bead.Clear();
                }
            }
            return sizes.Max();
        }
    }
}

