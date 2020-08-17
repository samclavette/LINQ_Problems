using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
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
            //foreach (var word in wordsContainingTH)
            //{
            //    Console.WriteLine(word);
            //    Console.ReadLine();
            //}

            //var names = new List<string>() { "Mike", "Brad", "Nevin", "Zack", "Mike" };
            //var copiedList = names.Distinct();
            //foreach (var name in copiedList)
            //{
            //    Console.WriteLine(name);
            //    Console.ReadLine();
            //}

            // for each string
            // make string into an array of elements
            // convert elements to doubles
            // order by lowest to highest
            // remove the first of the array
            // average the remaining array
            // average all 4 array averages

            List<string> classGrades = new List<string>()
            {"80,100,92,89,65",
             "93,81,78,84,69",
             "73,88,83,99,64",
             "98,100,66,74,55"};
            var newClassGrades = new List<double>();
            foreach (var set in classGrades)
            {
                var gradeList = set.Split(',');
                var newGradeList = new List<double>();
                foreach (var grade in gradeList)
                {
                    var newGrade = Convert.ToDouble(grade);
                    newGradeList.Add(newGrade);
                }
                newGradeList.Sort();
                newGradeList.RemoveAt(0);
                var averageGrade = newGradeList.Average();
                newClassGrades.Add(averageGrade);
            }

            var classAverage = newClassGrades.Average();
            Console.WriteLine(classAverage);
            Console.ReadLine();

            var mike = "TERRILL";
            var array = mike.ToCharArray();
            foreach (var c in array)
            {
                
            }
        }
    }
}
