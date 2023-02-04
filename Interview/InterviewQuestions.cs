
using System;
using System.Text;
using System.Text.RegularExpressions;

namespace Interview
{
    public class InterviewQuestions
    {
        public InterviewQuestions() { }

        public string ReverseWordsInString(string text)
        {
            StringBuilder result = new StringBuilder();
            Stack<char> rev = new Stack<char>();

            if (text[text.Length-1]!= ' ')//since empty space is the delimiter,
            {                                // add one if there isnt one already
                text = text + " ";
            }
           
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] != ' ')
                {
                    rev.Push(text[i]);
                   
                }
                else   
                {
                    while (rev.Count > 0)
                    {
                        result.Append(rev.Pop().ToString());
                    }
                    result.Append(text[i]);
                    

                }
               
            }
            return result.ToString();
        }

        public int SecondLargest(int[] ar)
        {
            int largest = ar[0];
            int second = ar[0];
            for(int i=0; i < ar.Length; i++)
            {
                if (ar[i]> largest)
                {
                    second=largest;
                    largest = ar[i];
                }
            }
            return second;
        }

        public string CountVowelsAndCosonants(string text)
        {
            StringBuilder result = new StringBuilder();

            string cleanText = Regex.Replace(text, @"[^a-zA-Z]", "");

            int vowelCount=0;
            for(int i=0; i<cleanText.Length-1; i++)
            {
                if (char.ToLower(cleanText[i]) == 'a' || char.ToLower(cleanText[i]) == 'e'|| char.ToLower(cleanText[i]) == 'i' 
                    || char.ToLower(cleanText[i]) == 'o' || char.ToLower(cleanText[i]) == 'u')
                {
                    vowelCount++;   
                }
            }
            int consonants = cleanText.Length - vowelCount;
            result.Append("There are " + vowelCount + " vowels, and " +consonants + " consonants in : \n"+ text);

            return result.ToString();

        }

        public string countMultipleElem(List<int> list)
        {
            StringBuilder result = new StringBuilder();
            Dictionary<int, int> counts = new Dictionary<int, int>();
            foreach(int i in list)
            {
                if (counts.ContainsKey(i))
                {
                    counts[i]++;
                }
                else
                {
                    counts.Add(i, 1);
                }
            }
            foreach(var count in counts)
            {
                if (count.Value> 1)
                {
                    result.Append(count.Key.ToString() +" - "+count.Value.ToString()+"\n");
                }
            }

            return result.ToString();
        }

        public bool IsAnagram(string text1, string text2)
        {
            if(text1.Length != text2.Length)
            {
                return false;
            }
            else
            {
                char[] chars1 = text1.ToCharArray();
                char[] chars2 = text2.ToCharArray();    
                Array.Sort(chars1);
                Array.Sort(chars2);

                if(chars1 == chars2)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        
    }
}

