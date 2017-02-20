using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XmlForm
{
    public partial class XmlForm : Form
    {
        public XmlForm()
        {
            //такие вещи нужно писать в отдельных методах
            int Count;
            string XmlString = XlmReader.FileReader("config.xml");
                  
            if (XmlString != "")
            {
                // Change form's properties
                foreach (var item in XlmReader.XReader(XmlString, "Form"))//с большой буквы локальные переменные лучше не называть. 
                {
                    this.Name = item.name;
                    this.Text = item.name;
                    this.BackColor = Color.FromArgb(item.rgbColor[0], item.rgbColor[1], item.rgbColor[2]);
                    this.Size = new Size(item.width, item.height);
                }
                // Load buttons to form
                var Buttons = new List<Button>();
                Count = 0;
                foreach (var Fobject in XlmReader.XReader(XmlString, "button"))
                {
                    Buttons.Add(ButtonLoader(Fobject));
                    this.Controls.Add(Buttons[Count++]);
                }
                // Load label to form
                var Labels = new List<Label>();
                Count = 0;
                foreach (ObjModel Fobject in XlmReader.XReader(XmlString, "label"))
                {
                    Labels.Add((Label)LabelLoader(Fobject));
                    this.Controls.Add(Labels[Count++]);
                }
            }
            InitializeComponent();
            //и потом вызывать после InitializeComponent. А еще лучше по событию form_load
        }

        /// <summary>
        /// Create form's buttons
        /// </summary>
        /// <param name="Fobj"></param>
        /// <returns></returns>
        Button ButtonLoader(ObjModel Fobj)
        {
            Button obj = new Button();

            obj.Location = new Point(Fobj.left, Fobj.top);
            obj.Name = Fobj.name;
            obj.Text = Fobj.name;
            obj.Size = new Size(Fobj.width, Fobj.height);
            obj.BackColor = Color.FromArgb(Fobj.rgbColor[0], Fobj.rgbColor[1], Fobj.rgbColor[2]);
            return obj;
        }

        /// <summary>
        /// Create form's labels
        /// </summary>
        /// <param name="Fobj"></param>
        /// <returns></returns>
        Label LabelLoader(ObjModel Fobj)//obj было бы более понятней что это такое
        {
            Label label = new Label();

            obj.Location = new Point(Fobj.left, Fobj.top);
            obj.Name = Fobj.name;
            obj.Text = Fobj.name;
            obj.Size = new Size(Fobj.width, Fobj.height);
            obj.BackColor = Color.FromArgb(Fobj.rgbColor[0], Fobj.rgbColor[1], Fobj.rgbColor[2]);
            return obj;
        }

    }
}
