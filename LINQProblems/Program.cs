using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            //var words = new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics" };
            //var wordsContainingTH = words.Where(w => w.Contains("th"));
            ////foreach (var word in wordsContainingTH)
            ////{
            ////    Console.WriteLine(word);
            ////    Console.ReadLine();
            ////}

            //var names = new List<string>() { "Mike", "Brad", "Nevin", "Zack", "Mike" };
            //var copiedList = names.Distinct();
            //foreach (var name in copiedList)
            //{
            //    Console.WriteLine(name);
            //    Console.ReadLine();
            //}

            //List<string> classGrades = new List<string>()
            //{"80,100,92,89,65",
            // "93,81,78,84,69",
            // "73,88,83,99,64",
            // "98,100,66,74,55"};
            //var newGrades = classGrades.Where(g => g.;

            // for each string
            // make string into an array
            // remove the min of the array

            string grades = "80,100,92,89,65";
            string[] split = grades.Split(new Char[] { ',' });
            
            foreach (var grade in split)
            {
                Convert.ToInt32(grade);
            }
            int lowerGrade = split.Min();

        }
    }
}
