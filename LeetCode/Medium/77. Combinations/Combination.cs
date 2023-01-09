using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAndAlgo.LeetCode.Medium._77._Combinations
{
    internal class Combination
    {

            public IList<IList<int>> Combine(int n, int k)
            {
                List<IList<int>> result = new List<IList<int>>();
                Subsets(1, n, new List<int>(), result, k);
                return result;
            }
            public void Subsets(int start, int end, List<int> currentComnbination, List<IList<int>> result, int size)
            {
                if (currentComnbination.Count == size)
                {
                    result.Add(new List<int>(currentComnbination));
                    return;
                }
                for (int i = start; i <= end; i++)
                {
                    currentComnbination.Add(i);
                    Subsets(i + 1, end, currentComnbination, result, size);
                    currentComnbination.RemoveAt(currentComnbination.Count - 1);
                }


            }

    }
}
