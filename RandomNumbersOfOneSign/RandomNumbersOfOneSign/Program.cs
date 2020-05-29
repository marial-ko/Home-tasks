using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;

namespace RandomNumbersOfOneSign
{
    class Program
    {
        private static int count = 0;
        private static string maxSequence;
        private static int countElement = 0;

        static void Main()
        {
            var text = new List<string>();
            
            try
            {
                using (StreamReader sr = new StreamReader("random_integers.txt"))
                {

                    var i = 0;
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        i++;
                        var date = ParserStiring(line);
                        foreach (var element in date)
                            text.Add(ConvertToNewFormat(element));
                    }
                }
            }
            catch{}

            WriteTextToFile(text);

            Console.WriteLine("Количество последовательностей чисел одного знака: " + count);
            Console.WriteLine("Самая длинная последовательность:");
            Console.WriteLine(maxSequence);
            Console.ReadLine();
        }

     
        private static string Sign(string number)
        {
            if (int.Parse(number) > 0)
                return "+ :";
            return "- :";
        }

   
        private static string ConvertToNewFormat(List<string> str)
        {
            var result = new StringBuilder();
            result.Append(str.Count);
            result.Append(Sign(str[0]));
            foreach (var element in str)
                result.Append(element + " ");
            if(countElement < result.Length)
            {
                countElement = result.Length;
                maxSequence = result.ToString();
            }
            return result.ToString();
        }

       
        private static List<List<string>> ParserStiring(string line)
        {
            var str = line.Split(' ');
            var result = new List<List<string>>();
            var j = 0;
            var lastElement = str[j];
            result.Add(new List<string>());
            result[j].Add(lastElement);
            for(var i = 1; i < str.Length - 1; i++)
            {
                var element = str[i];
                if (int.Parse(element) > 0)
                    if (int.Parse(lastElement) > 0)
                        result[j].Add(element);
                    else
                    {
                        j++;
                        result.Add(new List<string>());
                        result[j].Add(element);
                    }
                else
                    if (int.Parse(lastElement) < 0)
                        result[j].Add(element);
                    else
                    {
                        j++;
                        result.Add(new List<string>());
                        result[j].Add(element);
                    }
                lastElement = element;
            }
            count += result.Count;
            return result;
        }

       
        private static void WriteTextToFile(List<string> text)
        {
            try
            {
                using(StreamWriter sr = new StreamWriter("result.txt", false, Encoding.Default))
                {
                    foreach (var element in text)
                        sr.WriteLine(element);
                }
            }
            catch{}
        }
    }
}
