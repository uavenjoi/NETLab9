using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextTransformer
{
    delegate string StringFormat(string InStr);
    class TransString
    {
        /// <summary>
        /// Collection of delegate to methods UpperString, InsertSpace and ReversString
        /// </summary>
        public List<StringFormat> StrFormat = new List<StringFormat>();
       
        public TransString()
        {
            StrFormat.Add(UpperString);
            StrFormat.Add(InsertSpace);
            StrFormat.Add(ReversString);
        }

        /// <summary>
        /// Convert to upper-case all character of InpString
        /// </summary>
        /// <param name="InpString"></param>
        /// <returns></returns>
        public string UpperString(string InpString)
        {
            string ResString = string.Empty;

            ResString = InpString.ToUpper();
            return ResString;
        }

        /// <summary>
        /// Revers InpString
        /// </summary>
        /// <param name="InpString"></param>
        /// <returns></returns>
        public string ReversString(string InpString)
        {
            string ResString = string.Empty;

            for (int count = InpString.Length - 1; count >=0; count--)
            {
                    ResString += InpString[count];
            }
            return ResString;
        }

        /// <summary>
        /// Insert spaces after each character of InpString
        /// </summary>
        /// <param name="InpString"></param>
        /// <returns></returns>
        public string InsertSpace(string InpString)
        {
            string ResString = string.Empty;

            for (int count = 0; count < InpString.Length; count++)
            {
                ResString += InpString[count];
                ResString += ' ';
            }
            return ResString;
        }

    }
}
