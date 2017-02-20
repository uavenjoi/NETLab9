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
            int Count;
            string XmlString;
                  
            XmlString = XlmReader.FileReader("config.xml");
            if (XmlString != "")
            {
                // Change form's properties
                foreach (ObjModel Fobject in XlmReader.XReader(XmlString, "Form"))
                {
                    this.Name = Fobject.name;
                    this.Text = Fobject.name;
                    this.BackColor = Color.FromArgb(Fobject.rgbColor[0], Fobject.rgbColor[1], Fobject.rgbColor[2]);
                    this.Size = new Size(Fobject.width, Fobject.height);
                }
                // Load buttons to form
                var Buttons = new List<Button>();
                Count = 0;
                foreach (ObjModel Fobject in XlmReader.XReader(XmlString, "button"))
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
        Label LabelLoader(ObjModel Fobj)
        {
            Label obj = new Label();

            obj.Location = new Point(Fobj.left, Fobj.top);
            obj.Name = Fobj.name;
            obj.Text = Fobj.name;
            obj.Size = new Size(Fobj.width, Fobj.height);
            obj.BackColor = Color.FromArgb(Fobj.rgbColor[0], Fobj.rgbColor[1], Fobj.rgbColor[2]);
            return obj;
        }

    }
}
