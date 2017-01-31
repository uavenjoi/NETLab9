using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyrilicTranslator_1_1
{
    class CyrilicTranslator
    {
       /// <summary>
       /// Dictionary collection contains Cyrilic - Latins characters pairs
       /// </summary>
      static Dictionary<char, string> CyrilicToLatinDictionary = new Dictionary<char, string>() {
            { 'А', "A"  }, { 'Б', "B"  }, { 'В', "V"   }, { 'Г', "G"  }, { 'Д', "D"  }, { 'Е', "E"  },
            { 'Ё', "YO" }, { 'Ж', "ZH" }, { 'З', "Z"   }, { 'И', "I"  }, { 'Й', "J"  }, { 'К', "K"  },
            { 'Л', "L"  }, { 'М', "M"  }, { 'Н', "N"   }, { 'О', "O"  }, { 'П', "P"  }, { 'Р', "R"  },
            { 'С', "S"  }, { 'Т', "T"  }, { 'У', "U"   }, { 'Ф', "F"  }, { 'Х', "X"  }, { 'Ц', "CZ" },
            { 'Ч', "CH" }, { 'Ш', "SH" }, { 'Щ', "SHH" }, { 'Ъ', "``" }, { 'Ы', "Y`" }, { 'Ь', "`"  },
            { 'Э', "E`" }, { 'Ю', "YU" }, { 'Я', "YA"  } };
        
        /// <summary>
        /// Сonverts all Cyrilic characters from InputString to
        /// Latin characters, doesn't change non-Cyrilic characters 
        /// and writes all of them to OutputString
        /// </summary>
        /// <param name="InputString"></param>
        /// <returns></returns>
        public static string TranslateString(string InputString)
        {
            string OutputString = string.Empty;
            string value;

            for (int CountChar = 0; CountChar < InputString.Length; CountChar++)
            {
                if (CyrilicToLatinDictionary.TryGetValue(Char.ToUpper(InputString[CountChar]),  out value ))
                {
                    if (Char.IsLower(InputString[CountChar]))
                    {
                        value = value.ToLower();
                    }
                    OutputString += value;
                }
                else
                {
                    OutputString += InputString[CountChar];
                }
            }
            return OutputString;
        }

    }
    class Translator
    {
        static void Main(string[] args)
        {
           
            do
            {
                Console.WriteLine("\nEnter your sentences in Cyrilic, please:\n");
                Console.WriteLine("\nYour sentenses in Latin:\n\n" +
                                  CyrilicTranslator.TranslateString(Console.ReadLine()));
                Console.Write("\nIf you want to continue, please, press 'y', else any key -  ");

            } while (string.Compare(Console.ReadLine(), "y", true) == 0);

        }
    }
}
