using System;
using System.Windows.Forms;
using UserStrory.Models;

namespace UserStrory
{
    public partial class Form1 : Form
    {
        public int indexRow;
        public Form1()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Progam_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программа","Школьный журнал", MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void Add1tool_Click(object sender, EventArgs e)
        {
            var infoForm = new StudentInfoForm();
            infoForm.Text = "Добавления студента";
            if (infoForm.ShowDialog(this) == DialogResult.OK)
            {
                int n = View1.Rows.Add();
                DateTime thisDay = DateTime.Today;
                var Day = thisDay.Year - infoForm.Student.BirthDay.Year;
                Day += (thisDay.Month >= infoForm.Student.BirthDay.Month && thisDay.Day >= infoForm.Student.BirthDay.Day) ? 0 : -1;

                var sex = infoForm.Student.Gender == Models.Gender.Male ? "Мужской" : "Женский";

                View1.Rows[n].Cells[0].Value = infoForm.Student.FullName;
                View1.Rows[n].Cells[1].Value = sex;
                View1.Rows[n].Cells[2].Value = infoForm.Student.BirthDay;
                View1.Rows[n].Cells[3].Value = Day;
                View1.Rows[n].Cells[4].Value = infoForm.Student.AvgRate;
                View1.Rows[n].Cells[5].Value = infoForm.Student.Deduct;
                View1.Rows[n].Cells[6].Value = infoForm.Student.Debtor;
                Delitetool.Enabled = true;
                Changetool.Enabled = true;
            }
        }

        private void Delitetool_Click(object sender, EventArgs e)
        {
            var rowIndex = View1.CurrentCell.RowIndex;
            View1.Rows.RemoveAt(rowIndex);
            if (View1.Rows.Count == 0)
            {
                Delitetool.Enabled = false;
                Changetool.Enabled = false;
            }
        }

       
        private void View1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex;

        }

        private void Changetool_Click(object sender, EventArgs e)
        {
            var infoForm = new StudentInfoForm(); 
            var n = View1.Rows[indexRow];
            infoForm.Name.Text = n.Cells[0].Value.ToString();
            infoForm.comboBox1.Text = n.Cells[0].Value.ToString();
            infoForm.dateTimePicker1.Value = (DateTime)n.Cells[2].Value;
            infoForm.numericUpDown1.Value = (decimal)n.Cells[4].Value;
            infoForm.Deduct1.Checked = (bool)n.Cells[5].Value;
            infoForm.Debtor1.Checked = (bool)n.Cells[6].Value;
            if (infoForm.ShowDialog(this) == DialogResult.OK)
            {

                DateTime thisDay = DateTime.Today;
                var Day = thisDay.Year - infoForm.Student.BirthDay.Year;
                Day += (thisDay.Month >= infoForm.Student.BirthDay.Month && thisDay.Day >= infoForm.Student.BirthDay.Day) ? 0 : -1;

                var sex = infoForm.Student.Gender == Models.Gender.Male ? "Мужской" : "Женский";

                n.Cells[0].Value = infoForm.Student.FullName;
                n.Cells[1].Value = sex;
                n.Cells[2].Value = infoForm.Student.BirthDay;
                n.Cells[3].Value = Day;
                n.Cells[4].Value = infoForm.Student.AvgRate;
                n.Cells[5].Value = infoForm.Student.Deduct;
                n.Cells[6].Value = infoForm.Student.Debtor;
                if (View1.Rows.Count == 0)
                {
                    Changetool.Enabled = false;
                }

            }

        }
    }
}
