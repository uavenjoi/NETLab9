using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyrilicTranslator
{
    class TransLiteral
    {
        /// <summary>
        /// array of Cyrilic characters
        /// </summary>
        string CyrilicChar = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯабвгдеёжзийклмнопрстуфхцчшщъыьэюя";
        /// <summary>
        /// array of Latin strings
        /// </summary>
        string[] LatinChars = {"A","B","V","G","D","E","Yo","Zh","Z","I","J","K","L","M","N","O","P","R",
                           "S","T","U","F","X","Cz","Ch","Sh","Shh","``","Y`","`","E`","Yu","Ya",
                           "a","b","v","g","d","e","yo","zh","z","i","j","k","l","m","n","o","p","r",
                           "s","t","u","f","x","cz","ch","sh","shh","``","y`","`","e`","yu","ya"};
        /// <summary>
        /// Converts one Cyrilic character to Latin character or characters. 
        /// </summary>
        /// <param name="InChar"></param>
        /// <returns></returns>
        string OutputChars(char InChar)
        {
            string OutChars;

            OutChars = string.Empty;
            OutChars += InChar;
            
            for (int i = 0; i < CyrilicChar.Length; i++)
            {
                if (CyrilicChar[i] == InChar)
                {
                    OutChars = LatinChars[i];
                    return OutChars;
                }
            }
            return OutChars;
        }

        /// <summary>
        /// Сonverts all Cyrilic characters from InpString to
        /// Latin characters and writes them to OutString
        /// </summary>
        /// <param name="InpString"></param>
        /// <returns></returns>
        public string TranslatorString(string InpString)
        {
            string OutString = string.Empty;

            for (int CountChar = 0; CountChar < InpString.Length; CountChar++)
            {
                OutString += OutputChars(InpString[CountChar]);
            }

            return OutString;
        }

    }

    class ConsoleTranslator
    {
        static void Main(string[] args)
        {          
           TransLiteral Translator_ = new TransLiteral();

           do
           {
               Console.WriteLine("\nEnter your sentences in Cyrilic, please:\n");
               Console.WriteLine("\nYour sentenses in Latin:\n\n" + 
                                  Translator_.TranslatorString(Console.ReadLine()));
               Console.Write("\nIf you want to continue, please, press 'y', else any key -  ");

           } while (string.Compare(Console.ReadLine(), "y",true)==0);

    }
}
}
