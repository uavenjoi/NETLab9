using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlForm
{
    /// <summary>
    /// Model of form and controls
    /// </summary>
    public class ObjModel
    {
        public string type { get; set; }
        public int top { get; set; }
        public int left { get; set; }
        public string name { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int[] rgbColor { get; set; }

        public ObjModel()
        {
        }
    }
}
