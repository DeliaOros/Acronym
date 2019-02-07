using System;
using System.Collections.Generic;
using System.Text;

namespace Acronym
{
    public class AcronymSingleUse
    {
        private readonly string acronym;

        public string Acronym { get; }


        public AcronymSingleUse(string text)
        {

            this.acronym = GetAcronym(text).ToUpper();

        }

        public override string ToString()
        {
            return acronym.ToString();
        }

        private string GetAcronym(string text)
        {
            var textTemp = text.Trim();
            if (textTemp != "")
            {
                var tempText = text.TrimStart().TrimEnd().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                StringBuilder acronym = new StringBuilder();

                foreach (var item in tempText)
                {

                    var myItem = item.TrimStart(';', ',', '.', ' ');
                    
                    acronym.Append(myItem[0]);
                                                                          
                }

                return acronym.ToString().ToUpper();
            }
            Console.WriteLine("No input or a blank space was provided, you got nothing");
            return "";
        }




    }
}
