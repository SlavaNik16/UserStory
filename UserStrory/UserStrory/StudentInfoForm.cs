using System;
using System.Drawing;
using System.Windows.Forms;
using UserStrory.Models;

namespace UserStrory
{
    public partial class StudentInfoForm : Form
    {
        private readonly Student student;
        public StudentInfoForm()
        {
            InitializeComponent();
            FillGender();
            student = new Student
            {
                BirthDay = DateTime.Now.AddYears(-16),
                Gender = Gender.Male,
            };
            comboBox1.SelectedItem = student.Gender;
            dateTimePicker1.Value = student.BirthDay;
        }

        public Student Student => student;
            

        private void FillGender()
        {
            foreach(Gender item in Enum.GetValues(typeof(Gender)))
            {
                comboBox1.Items.Add(item);
            }
           
        }

        private void comboBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
            var parent = sender as ComboBox;
            if (parent != null)
            {
                e.DrawBackground();
                Brush brush = new SolidBrush(parent.ForeColor);
                if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                {
                    brush = SystemBrushes.HighlightText;
                }

                if (e.Index >= 0)
                {
                    if(parent.Items[e.Index] is Gender gender)
                    {
                        var text = gender == Gender.Male
                            ? "Мужской"
                            : "Женский";
                        e.Graphics.DrawString(
                            text,
                            parent.Font,
                            brush,
                            e.Bounds);
                    }
                    else
                    {
                        e.Graphics.DrawString(
                          parent.Items[e.Index].ToString(),
                          parent.Font,
                          brush,
                          e.Bounds);
                    }   
                }

            }
        }

        private void Name_TextChanged(object sender, EventArgs e)
        {
            student.FullName = Name.Text.Trim();
            Validate();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex >= 0)
            {
                student.Gender = (Gender)comboBox1.SelectedItem;
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            student.BirthDay = dateTimePicker1.Value;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            student.AvgRate = numericUpDown1.Value; 
        }

        private void Deduct1_CheckedChanged(object sender, EventArgs e)
        {
            student.Deduct = Deduct1.Checked;
        }

        private void Debtor1_CheckedChanged(object sender, EventArgs e)
        {
            student.Debtor = Debtor1.Checked;
        }

        public void Validate()
        {
            butSave.Enabled = !string.IsNullOrWhiteSpace(student.FullName);
        }
    }
}
