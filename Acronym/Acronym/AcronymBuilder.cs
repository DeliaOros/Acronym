using System;
using System.Collections.Generic;
using System.Text;

namespace Acronym
{
    public class AcronymBuilder
    {
        public string Text { get; set; }
        public string Expression { get; set; }

        public AcronymBuilder(string text, string expression)
        {
            StringBuilder tempAcronym = new StringBuilder();

            if (!String.IsNullOrEmpty(text))
            {
                foreach (string item in text.Split(" "))
                {
                    item.TrimStart(' ', ',', ';').TrimEnd(' ', ',', ';', '.');
                    tempAcronym.Append(item[0]);
                }
                string acronym = tempAcronym.ToString().TrimStart(' ', ',', ';').TrimEnd(' ', ',', ';', '.').ToUpper();
                //Console.WriteLine(acronym);
                Console.WriteLine(expression.Replace(text, acronym.ToString()));
            }
            else
            {
                Console.WriteLine("No content");
            }

        }

        public static bool IsUpperCase(string word)
        {
            string wordIsUpperCase = word.ToUpper();
            if (wordIsUpperCase == word)
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
