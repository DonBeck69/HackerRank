using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace HackerRank
{
    class Program
    {
        static void Main(string[] args)
        {

            BetweenTwoSetsFactors bf = new BetweenTwoSetsFactors();
            List<int> a = new List<int> { 3, 9, 6};
            List<int> b = new List<int> { 36, 72 };
            List<int> result = bf.getBetweenNumbers(a, b);
            foreach(int bn in result)
            {
                Console.WriteLine(bn);
            }
            Console.WriteLine(result.Count);


            //Kangaroo k = new Kangaroo();
            //string result = k.kangaroo(0, 3, 4, 2);
            //string result = k.kangaroo(0,2,5,3);
            //string result = k.kangaroo(43, 2, 70, 2);
            //43 2 70 2
            //Console.WriteLine(result);

            //ApplesOranges ao = new ApplesOranges();
            //ao.countApplesAndOranges(2, 3, 1, 5, new int[] { 2 }, new int[] { -2 });


            //VowelCounter vc = new VowelCounter();
            //string result = vc.findSubstring("caberqiitefg", 5);
            //Console.WriteLine(result);


            //GradingStudents gs = new GradingStudents();
            //List<int> grades = 
            //List<int> grades = gs.GetGrades(new int[] { 4, 73, 67, 38, 33 }.ToList());
            //Console.WriteLinfindSubstringe(String.Join(',', grades));
            //Console.WriteLine(result);
        }



    }
}

