
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteBook
{
   static class FileOperator
    {
       private static string FileName = "NotebookText.txt";
        /// <summary>
        /// Read NotebookText.txt file and load data to persons
        /// </summary>
        /// <param name="listP"></param>
        /// <returns></returns>
       public static bool FileRead(ref List<Person> listP)
       {
            string[] FileP, Tstring;
            int TempI = 0;

            try
            {
                FileP = File.ReadAllLines(FileName);
                foreach (var temp in FileP)
                {
                    Tstring = temp.Split(';');
                    if(Tstring!= null && Tstring.Length == 4)
                    {
                        if (int.TryParse(Tstring[1], out TempI))
                        {
                            listP.Add(new Person(Tstring[0],TempI,Tstring[2],Tstring[3]));
                        }
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                string message = ex.ToString();
                string caption = "Error!!!";
                MessageBox.Show(message, caption, MessageBoxButtons.OK);
                return false;
            }
       }

        /// <summary>
        /// Writes data from persons to file NotebookText.txt
        /// </summary>
        /// <param name="listP"></param>
        /// <returns></returns>
        public static bool FileWrite(List<Person> listP)
        {
            var FileP = new string[listP.Count]; 
            int TempI = 0;

            if (listP.Count > 0)
            {
                try
                {
                    foreach (var Pers_ in listP)
                    {
                        FileP[TempI] = Pers_.PersonName + ';' + Pers_.PersonAge + ';' + Pers_.PersonAddress + ';' + Pers_.PersonPhone;
                        TempI++;
                    }
                    File.WriteAllLines(FileName, FileP);
                    return true;
                }
                catch (Exception ex)
                {
                    string message = ex.ToString();
                    string caption = "Error!!!";
                    MessageBox.Show(message, caption, MessageBoxButtons.OK);
                    return false;
                }
            }
            else return false;
        }

    }
}
