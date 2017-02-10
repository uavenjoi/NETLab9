using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextCorrector
{
    class DictionaryCL
    {
        /// <summary>
        /// Creates dictionary of right words
        /// </summary>
        internal static bool DictCreate(ref List<string> DictC)//лучше делать обычные не статик методы
        {
            try
            {
                DictC =  File.ReadAllLines("dic.txt").ToList();
                return true;
            }
            catch (Exception ex)
            {
                string message = ex.ToString();
                string caption = "Error!!!";
                MessageBox.Show(message,caption, MessageBoxButtons.OK);
                return false;
            }

        }
 
        /// <summary>
        /// Checks Word in dictionary
        /// </summary>
        /// <param name="Word"></param>
        /// <returns></returns>
       internal static bool WrongWord(string Word, List<string> Dict)//параметры лучше писать с маленькой буквы
        {
            foreach (string WDict in Dict)
            {
                if (WDict.Trim() == Word) { return false; }//String.Compare() лучше, и регистр можно упустить из виду
            }
            return true;
        }
            
    }
    class CorrectorClass
    {

        /// <summary>
        /// word separators in line 
        /// </summary>
        static char[] WordSeparator = {' ', ',', '.','!', '?', ':', ';', '"'};

        /// <summary>
        /// indexes and lengths of wrong word
        /// </summary>
        static Dictionary<int, int> WrongWordIndex = new Dictionary<int, int>();

        

        /// <summary>
        /// Finds wrong words in text and returns their indexes in text and lengths
        /// </summary>
        /// <param name="TexTCor"></param>
        /// <returns></returns>
        internal static  Dictionary<int,int> StringCorrector(string[] TextCor)
        {
            int StringPos = 0;
            string[] Temp;
            string TempStr;
            List<string> DictC = new List<string>();

            if (DictionaryCL.DictCreate(ref DictC))//без лишенй необходимости лучше не использовать ref параметры.
                                                      //dict=DictionaryCL.DictCreate() смотрится лучше
            {
                for (int Index = 0; Index < TextCor.Length; Index++)
                {
                    Temp = TextCor[Index].Trim().ToLower().Split(WordSeparator);
                    for(int Count = 0; Count < Temp.Length; Count++)
                    {
                        TempStr = Temp[Count];
                        if (DictionaryCL.WrongWord(TempStr, DictC))
                        {
                             WrongWordIndex.Add(StringPos,TempStr.Length);
                        }
                        StringPos += TempStr.Length + 1;
                    }
                }

            } return WrongWordIndex;
        }
    }

}
