using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics" };
            var wordsContainingTH = words.Where(w => w.Contains("th"));
            foreach (var word in wordsContainingTH)
            {
                Console.WriteLine(word);
                Console.ReadLine();
            }
        }
    }
}
