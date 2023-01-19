using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZigZagSequence.Models;

namespace ZigZagSequence.Helpers
{
    internal static class Helper
    {
        public static List<int> Calculate(TestCase model)
        {
            List<int> caseArray = new List<int>();
            List<int> decrease = new List<int>();
            List<int> increase = new List<int>();

            string[] splittedArr = model.CaseArray.Split(' ');
            caseArray = GetLists(splittedArr);
            int k = (caseArray.Count + 1) / 2;

            caseArray.Sort();
            increase.AddRange(caseArray.Take(k - 1));
            decrease.AddRange(caseArray.TakeLast(k));

            decrease.Sort();
            decrease.Reverse();
            caseArray.Clear();

            if (increase.First() < decrease.First())
            {
                caseArray.AddRange(increase);
                caseArray.AddRange(decrease);
            }
            else
            {
                caseArray.AddRange(decrease);
                caseArray.AddRange(increase);
            }

            return caseArray;
        }

        static List<int> GetLists<T>(T[] array)
        {
            List<int> value = new List<int>();

            foreach (var item in array)
            {
                value.Add(int.Parse(item.ToString()));
            }

            return value;
        }

        public static List<string> ConvertList(List<int> list){
            List<string> result = new List<string>();

            foreach (int item in list)
            {
                result.Add(item.ToString());
            }

            result.Add(@"/n");

            return result;
        }
    }
}
