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
    public partial class NoteBookForm : Form
    {
        public BindingSource NotebookSource = new BindingSource();
        public List<Person> Persons = new List<Person>();
        public int IndexR = -1;

        public NoteBookForm()
        {
            InitializeComponent();
            if (FileOperator.FileRead(ref Persons))
            {
                CreateNbookGrid(Persons);            
            }
        }

        private void CreateNbookGrid(List<Person> Persons)
        {
            NotebookSource = new BindingSource();
            foreach (var Pers in Persons)
            {
                NotebookSource.Add(Pers);
            }
            NBookGridView.DataSource = NotebookSource;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {

            OperationForm OpF = new OperationForm(this);
            OpF.Owner = this;
            OpF.ShowDialog();          
            FileOperator.FileWrite(Persons);
            CreateNbookGrid(Persons);
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            OperationForm OpF = new OperationForm(this);
            OpF.Owner = this;
            IndexR = NBookGridView.SelectedCells[0].RowIndex;
            OpF.ShowDialog();
            FileOperator.FileWrite(Persons);
            CreateNbookGrid(Persons);
            IndexR = -1;
        }

        private void DelButton_Click(object sender, EventArgs e)
        {
            IndexR = NBookGridView.SelectedCells[0].RowIndex;
            NBookGridView.Rows.RemoveAt(IndexR);
            Persons.RemoveAt(IndexR);
            FileOperator.FileWrite(Persons);
        }

    }
}
