using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarahiAssignment
{
    internal class ExponentialNumber
    {
        static void Main(string[] args)
        {
            HashSet<int> distinctTerm = new HashSet<int>();

            for (int a = 2; a <= 5; a++)
            {
                for (int b = 2; b <= 5; b++)
                {
                    int result = (int)Math.Pow(a, b);
                    distinctTerm.Add(result);
                }
            }
            int[] sortedDistinctTerms = new int[distinctTerm.Count];
            distinctTerm.CopyTo(sortedDistinctTerms);
            Array.Sort(sortedDistinctTerms);

            Console.WriteLine("Sequence of distinct terms:");
            foreach (int term in sortedDistinctTerms)
            {
                Console.WriteLine(term);
            }
        }
    }
}
