using System;
using System.Text;

namespace Acronym
{
    class Program
    {
        static void Main(string[] args)
        {
            string expression = "Text message, a short electronic message designed for communication between short electronic message mobile phone users. Nowadays, text messages can include media (such as photos, music and videos) and are also called media messages.";
            string myString = "short electronic message";
            AcronymBuilder myText = new AcronymBuilder(myString, expression);
        }

    }
}
