using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextTransformer
{
    public partial class TransformerForm : Form
    {
        public TransformerForm()
        {
            InitializeComponent();
        }

        private void TransForm_Load(object sender, EventArgs e)
        {

        }

        private void Transbutton_Click(object sender, EventArgs e)
        {
            TransString TrString = new TransString();
            string[] TrLines;
            int len;

            TrLines = OriginalText.Lines;
            len = TrLines.Length;
            for (int count = 0; count < len; count++)
            {
                if (UpperCheck.Checked && len > 0)
                {
                    TrLines[count] = TrString.StrFormat[0](TrLines[count]);
                }
                if (InsertCheck.Checked && len > 0)
                { 
                    TrLines[count] = TrString.StrFormat[1](TrLines[count]);
                }
                if (ReversCheck.Checked && len > 0)
                {
                 TrLines[count] = TrString.StrFormat[2](TrLines[count]);
                }
            }
            TansformedText.Lines = TrLines;
        }
    }
}
