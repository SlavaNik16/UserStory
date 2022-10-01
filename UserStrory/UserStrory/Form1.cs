using System;
using System.Linq;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using UserStrory.Models;

namespace UserStrory
{
    public partial class Form1 : Form
    {
        private readonly List<Student> students;
        private readonly BindingSource BSourse;
        private int age = 0;
        public Form1()
        {
            InitializeComponent();
            View1.AutoGenerateColumns = false;
            students = new List<Student>();

            BSourse = new BindingSource();
            BSourse.DataSource = students;
            View1.DataSource = BSourse;

            
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
            
            if (infoForm.ShowDialog(this) == DialogResult.OK)
            {
                students.Add(infoForm.Student);
                BSourse.ResetBindings(false);
                CalculateScrol();
            }
        }

        private void View1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            if(View1.Columns[e.ColumnIndex].Name == "AgeColumn")
            {
                var data = (Student)View1.Rows[e.RowIndex].DataBoundItem;
                int i = (bool)(DateTime.Now.Day > data.BirthDay.Day && DateTime.Now.Month >= data.BirthDay.Month) ? -1 : 0;
                age += DateTime.Now.Year - data.BirthDay.Year + i;
                e.Value = age;
                age = 0;
            }
            if (View1.Columns[e.ColumnIndex].Name == "SexColim")
            {
                var val = (Gender)e.Value;
                switch (val)
                {
                    case Gender.Male:
                        e.Value = "Мужской";
                        break;
                    case Gender.Female:
                        e.Value = "Женский";
                        break;
                   

                }
            }
            if (View1.Columns[e.ColumnIndex].Name == "DebuctColumn" || View1.Columns[e.ColumnIndex].Name == "DebtorColumn")
            {
                var val = (bool)e.Value;
                switch (val)
                {
                    case true:
                        e.Value = "Да";
                        break;
                    case false:
                        e.Value = "";
                        break;


                }
            }
          
        }

        private void View1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex >= 0 &&
                e.ColumnIndex >= 0 &&
                View1.Columns[e.ColumnIndex].Name == "AvrRateColumn")
            {
                e.PaintBackground(e.ClipBounds, true);
                if (decimal.TryParse(e.Value.ToString(), out decimal val))
                {
                   
                    
                    var result_width = (float)(val * e.CellBounds.Width) / 5.0f;
                    var rect = new RectangleF(
                         e.CellBounds.X,
                         e.CellBounds.Y,
                         result_width+1,
                         e.CellBounds.Height);

                    LinearGradientBrush gradBrush;
                    
                   
                    if(val >= 2 && val < 4)
                    {
                        gradBrush = new LinearGradientBrush(rect,
                        Color.DarkOrange,
                        Color.Yellow,
                        0f);
                    }
                    else if (val >=4 && val <= 5)
                    {
                       gradBrush = new LinearGradientBrush(rect,
                       Color.DarkGreen,
                       Color.Green,
                       0f);
                    }
                    else
                    {
                        gradBrush = new LinearGradientBrush(rect,
                        Color.DarkRed,
                        Color.Red,
                        0f);
                    }
                        

                    e.Graphics.FillRectangle(gradBrush,
                       rect);

                    e.Handled = true;
                } 
            }
        }

        private void View1_SelectionChanged(object sender, EventArgs e)
        {
            Changetool.Enabled =
            Delitetool.Enabled =
            View1.SelectedRows.Count > 0;
        }

        private void Delitetool_Click(object sender, EventArgs e)
        {
            var id = (Student)View1.Rows[View1.SelectedRows[0].Index].DataBoundItem;
            if (MessageBox.Show($"Вы действительно хотите удалить {id.FullName}",
                "Удаление записи",MessageBoxButtons.YesNo)  == DialogResult.Yes)
            {
                students.Remove(id);
                BSourse.ResetBindings(false);
                CalculateScrol();
            }
        }

        private void Changetool_Click(object sender, EventArgs e)
        {
            var id = (Student)View1.Rows[View1.SelectedRows[0].Index].DataBoundItem;
            var infoForm = new StudentInfoForm(id);
            
            if (infoForm.ShowDialog(this) == DialogResult.OK)
            {
                id.FullName = infoForm.Student.FullName;
                id.Gender = infoForm.Student.Gender;
                id.BirthDay = infoForm.Student.BirthDay;
                id.AvgRate = infoForm.Student.AvgRate;
                id.Deduct = infoForm.Student.Deduct;
                id.Debtor = infoForm.Student.Debtor;
                CalculateScrol();

                BSourse.ResetBindings(false);
            }
        }
        private void CalculateScrol()
        {
            Boys.Text = $"Всего учащихся {students.Count.ToString()}";
            var maleCount = students.Where(x => x.Gender == Gender.Male).Count();
            var femaleCount = students.Count(x => x.Gender == Gender.Female);
            Girls.Text = $"M: {maleCount} Ж: {femaleCount}";
        }
    }
}
