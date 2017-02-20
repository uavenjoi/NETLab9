using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;

namespace XmlForm
{
    public class XlmReader
    {
        /// <summary>
        /// Convert array of string to array of int for RGBColor
        /// </summary>
        /// <param name="StringRGB"></param>
        /// <returns></returns>
        public static int[] rgbConvertor(string[] StringRGB)
        {
            int[] tempInt = new int[StringRGB.Length];

            for (int count = 0; count < StringRGB.Length; count++)
            {
                tempInt[count] = int.Parse(StringRGB[count]);
            }
            return tempInt;
        }

        /// <summary>
        /// Read XML file to string
        /// </summary>
        /// <param name="file"></param>
        /// <returns></returns>
        public static string FileReader(string file)
        {
            string str = "" ;
            try
            {
                str = File.ReadAllText(file);
            }
            catch (Exception ex)
            {
                string message = ex.ToString();
                string caption = "Error!!!";
                MessageBox.Show(message, caption, MessageBoxButtons.OK);
            }
            return str;
        }

        /// <summary>
        /// Fill models of object
        /// </summary>
        /// <param name="xmlString"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        public static List<ObjModel> XReader(string xmlString, string name)
        {
            ObjModel obj = new ObjModel();
            List<ObjModel> objs = new List<ObjModel>();
            XmlDocument doc = new XmlDocument();

            if (xmlString != "")
            {
                doc.LoadXml(xmlString);
                var count = 0;

                foreach (XmlNode node in doc.DocumentElement.SelectNodes("/Configuration/" + name))
                {
                    objs.Add(new ObjModel());
                    if (!name.Equals("Form", StringComparison.InvariantCultureIgnoreCase))
                    {   
                        objs[count].left = int.Parse(node.SelectSingleNode("left").InnerText);
                        objs[count].top = int.Parse(node.SelectSingleNode("top").InnerText);
                    }
                    objs[count].name = node.SelectSingleNode("name").InnerText;
                    objs[count].height = int.Parse(node.SelectSingleNode("height").InnerText);
                    objs[count].width = int.Parse(node.SelectSingleNode("width").InnerText);
                    objs[count].rgbColor = rgbConvertor(node.SelectSingleNode("RGBcolor").InnerText.Trim().Split(','));
                    count++;
                }
            }                
            return objs;
        }
    }
}
