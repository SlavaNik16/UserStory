using System;
using System.Windows.Forms;

namespace UserStrory
{
    public partial class Form1 : Form
    {
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
                MessageBox.Show($"{infoForm.Student.FullName}\r\nGender:{infoForm.Student.Gender}\r\nBirthDay:{infoForm.Student.BirthDay:dd:MM:yyyy}\r\nAvgRate: {infoForm.Student.AvgRate}\r\nDeduct: {infoForm.Student.Deduct}\r\nDebtor: {infoForm.Student.Debtor}\r\n");
            }
        }
    }
}
