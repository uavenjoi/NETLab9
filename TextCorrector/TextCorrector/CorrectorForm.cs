using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextCorrector
{
    public partial class CorrectorForm : Form
    {

        public CorrectorForm()
        {
            InitializeComponent();
        }

        private void CorrectButton_Click(object sender, EventArgs e)
        {
            Dictionary<int, int> WWIndex;
            string[] TextB;

            TextB = CorrectText.Lines;
            WWIndex = CorrectorClass.StringCorrector(TextB);
            if (WWIndex != null)
            {
                foreach (int pos in WWIndex.Keys)
                {
                    CorrectText.SelectionStart = pos;
                    CorrectText.SelectionLength = WWIndex[pos];
                    CorrectText.SelectionColor = Color.Red;
                    CorrectText.SelectionFont = new Font("Times New Roman", 10.2F, ((FontStyle)((FontStyle.Bold | FontStyle.Italic | FontStyle.Underline))));
                }
            }
        }
    }
}
