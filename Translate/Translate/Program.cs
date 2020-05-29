using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Translate
{
    class Program
    {
        public static Dictionary<string, string> dictionaryWords = new Dictionary<string, string>();

        static void Main()
        {
            var line = "";
            try
            {
                using (StreamReader sr = new StreamReader("latin-russian_dict.txt", Encoding.Default))
                {
                    while ((line = sr.ReadLine()) != null)
                        ParseLine(line);
                }

            }
            catch { }


            string word = " ";
            while (word != "exit")
            {
                Console.WriteLine("Введите слово");
                word = Console.ReadLine();

                if (dictionaryWords.ContainsKey(word))
                    Console.WriteLine("Перевод - " + dictionaryWords[word]);
                else
                    Console.WriteLine("данного слова нет в словаре");
            }
        }

        private static void ParseLine(string line)
        {
           
            var words = line.Split('-');
            var value = words[0].Trim(' ');
            var keys = words[1].Split(',');

            foreach (var e in keys)
            {
                var key = e.Trim(' ');
                dictionaryWords.Add(key, value);
            }
        }
    }
}
