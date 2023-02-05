using System;

namespace Interview
{
    public class Program
    {
        public static void Main()
       {
            InterviewQuestions iq = new InterviewQuestions();
            int[]ar = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] ar2 = { 1, 1, 2, 2, 3, 3, 3, 4 };
            int[][] envelopes = new int[4][]
            {
                new int []{5,4},
                new int []{6,4},
                new int []{6,7},
                new int []{2,3}

            };

            
           List<int>list = ar2.ToList();
            Console.WriteLine(iq.SecondLargest(ar));
            Console.WriteLine(iq.ReverseWordsInString("Hello world"));
            Console.WriteLine(iq.CountVowelsAndCosonants("hello world!!"));
            Console.WriteLine(iq.countMultipleElem(list));
            Console.WriteLine(iq.RussianDollEnvelopes(envelopes));

        }
    }
}