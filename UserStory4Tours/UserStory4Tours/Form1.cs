using System;
using System.Linq;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using UserStory4Tours.models;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Reflection.Emit;

namespace UserStory4Tours
{
    public partial class Form1 : Form
    {
        private readonly List<Tours> tours;

        private readonly BindingSource BinSource;
        private decimal sum = 0;
        public Form1()
        {
            InitializeComponent();
         
            ToursGridViev.AutoGenerateColumns = false;
            tours = new List<Tours>();
            
            BinSource = new BindingSource();
            BinSource.DataSource = tours;
            ToursGridViev.DataSource = BinSource;
        }
        

       

        private void Info_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Николаев В.А ИП-20-3", "Горящие туры 4 вариант",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void AddTool_Click(object sender, EventArgs e)
        {
            var infoForm = new ToursInfoForm();
            
            if (infoForm.ShowDialog(this) == DialogResult.OK)
            {
                tours.Add(infoForm.Tours);
                BinSource.ResetBindings(false);
                CalculatScroll();
               
            }
            
        }

        private void DeliteTool_Click(object sender, EventArgs e)
        {
            var id = (Tours)ToursGridViev.Rows[ToursGridViev.SelectedRows[0].Index].DataBoundItem;
            if(MessageBox.Show($"Вы действительно хотите удалить {id.DateDeparture:D}",
                "Удаление записи", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                tours.Remove(id);
                BinSource.ResetBindings(false);
                CalculatScroll();
               
                

            }
        }

       
        private void ChangeTool_Click(object sender, EventArgs e)
        {
            var id = (Tours)ToursGridViev.Rows[ToursGridViev.SelectedRows[0].Index].DataBoundItem;
            var infoForm = new ToursInfoForm(id);
            if (infoForm.ShowDialog(this) == DialogResult.OK)
            {
                id.direction = infoForm.Tours.direction;
                id.DateDeparture = infoForm.Tours.DateDeparture;
                id.NumberNight = infoForm.Tours.NumberNight;
                id.CostVac = infoForm.Tours.CostVac;
                id.NumberVac = infoForm.Tours.NumberVac;
                id.Wi_Fi = infoForm.Tours.Wi_Fi;
                id.Surcharges = infoForm.Tours.Surcharges;
                
                BinSource.ResetBindings(false);
                CalculatScroll();
                
                
            }
        }

        private void AddMenu_Click(object sender, EventArgs e)
        {
            AddTool_Click(sender, e);
        }

        private void DeliteMenu_Click(object sender, EventArgs e)
        {
            DeliteTool_Click(sender, e);
        }

        private void ChangeMenu_Click(object sender, EventArgs e)
        {
            ChangeTool_Click(sender, e);
        }

        private void ToursGridViev_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (ToursGridViev.Columns[e.ColumnIndex].Name == "AmountAllColumn")
            {
                var data = (Tours)ToursGridViev.Rows[e.RowIndex].DataBoundItem;
                sum += (data.NumberNight * data.NumberVac * data.CostVac) + data.Surcharges;
                e.Value = sum;
                sum = 0;
            }

            if (ToursGridViev.Columns[e.ColumnIndex].Name == "DirectColumn")
            {
                var val = (Direction)e.Value;
                switch (val)
                {
                    case Direction.Turkey:
                        e.Value = "Турция";
                        break;
                    case Direction.Israel:
                        e.Value = "Израиль";
                        break;
                    case Direction.Abkhazia:
                        e.Value = "Абхазия";
                        break;
                    case Direction.Cyprus:
                        e.Value = "Кипр";
                        break;
                    case Direction.Shushary:
                        e.Value = "Шушары";
                        break;
                    case Direction.Thailand:
                        e.Value = "Таиланд";
                        break;
                }
            }
            if (ToursGridViev.Columns[e.ColumnIndex].Name == "Wi_FiColumn")
            {
                var val = (bool)e.Value;
                switch (val)
                {
                    case true:
                        e.Value = "Есть";
                        break;
                    case false:
                        e.Value = "Нет";
                        break;
                   
                }
            }


        }

        private void ToursGridViev_SelectionChanged(object sender, EventArgs e)
        {
            DeliteMenu.Enabled =
            ChangeMenu.Enabled =
            DeliteTool.Enabled = 
            ChangeTool.Enabled = 
            ToursGridViev.SelectedRows.Count > 0;
        }
        private void CalculatScroll()
        {
            NumberToursStatus.Text = $"Всего туров {tours.Count.ToString()}";

            decimal sumAll = tours.Sum(x=>(x.NumberNight * x.NumberVac * x.CostVac) + x.Surcharges);
            decimal sumAllSur = tours.Sum(x => x.Surcharges);

            TotalAmount.Text = $"Общая сумма {sumAll}";
            int SurCount = tours.Where(x => x.Surcharges != 0).Count();
            NumerToursSurcharges.Text = $"Кол-во туров с доплатами {SurCount}";
            TotalAmountSurcharges.Text = $"Общая сумма доплат {sumAllSur}";



           
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
