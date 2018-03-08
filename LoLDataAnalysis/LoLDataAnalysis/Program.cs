using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoLDataAnalysis
{
    class Program
    {
        static void Main(string[] args)
        {
            SearchWrapper search = new SearchWrapper();
            string searchResponse = search.GetChampion(6);
            Console.WriteLine(searchResponse);
        }
    }
}
