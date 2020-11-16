using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HistoryCollections;

namespace HistoryTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            History<int> history = new History<int>(100);
            for (int i = 0; i < 100; i++)
            {
                history.Add(i+1);
            }

            foreach (int item in history)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
