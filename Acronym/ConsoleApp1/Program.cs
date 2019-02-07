using System;


namespace Acronym
{
    class Program
    {
        static void Main(string[] args)
        {
            var text1 = "";

            var text2 = " Double-click any :   element listed, to find and select it in the editor. ";

           var text3 = " ";

            var myAcronym1 = new AcronymSingleUse(text1);

            var myAcronym2 = new AcronymSingleUse(text2);

            var myAcronym3 = new AcronymSingleUse(text3);

            Console.WriteLine(myAcronym1.ToString());

            Console.WriteLine();

            Console.WriteLine(myAcronym2.ToString());

            Console.WriteLine(myAcronym3.ToString());
        }
    }
}
