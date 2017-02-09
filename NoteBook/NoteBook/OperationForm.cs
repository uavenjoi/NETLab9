using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteBook
{
    
    public partial class OperationForm : Form
    {
        NoteBookForm form;
        public OperationForm(NoteBookForm fr)
        {
            InitializeComponent();
            form = fr;
            int ind = form.IndexR;

            if (ind != -1)
            {
                NameTextBox.Text = form.Persons[ind].PersonName;
                AgeTextBox.Text = form.Persons[ind].PersonAge.ToString();
                AdressTextBox.Text = form.Persons[ind].PersonAddress;
                PhoneTextBox.Text = form.Persons[ind].PersonPhone;
                form.Persons.RemoveAt(ind);
            }
        }

        private void OperationButton_Click(object sender, EventArgs e)
        {
            int Itemp = 0;

            if(int.TryParse(this.AgeTextBox.Text, out Itemp) && this.NameTextBox.Text != "" && 
                this.AdressTextBox.Text != "" && this.PhoneTextBox.Text != "")
            {
             form.Persons.Add(new Person(this.NameTextBox.Text, Itemp, this.AdressTextBox.Text, this.PhoneTextBox.Text));
             this.Hide();
            }
            else
            {
                string message = "Illegal format of data!";
                string caption = "Error!!!";
                MessageBox.Show(message, caption, MessageBoxButtons.OK);
            }

        }
    }
}
