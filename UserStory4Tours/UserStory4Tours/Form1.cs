using System;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using UserStory4Tours.models;

namespace UserStory4Tours
{
    public partial class Form1 : Form
    {
        public int indexRow = 0;
        public string text;
        public int countAmount = 0;
        public decimal s = 0;
        public decimal sum = 0;
        public int surCount = 0;
        public bool Prov = false;
        public decimal sSur = 0;
        public decimal sumSur = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Info_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Николаев В.А ИП-20-3", "Горящие туры 4 вариант",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void AddTool_Click(object sender, EventArgs e)
        {
            var InfoTours = new ToursInfoForm();

            if (InfoTours.ShowDialog() == DialogResult.OK)
            {
                int n = dataGridView1.Rows.Add();

                decimal Amount = int.Parse(InfoTours.Tours.NumberNight.ToString()) * int.Parse(InfoTours.Tours.NumberVac.ToString()) * InfoTours.Tours.CostVac - InfoTours.Tours.Surcharges;
                
                switch (InfoTours.Tours.direction)
                {
                    case Direction.Turkey:
                        text = "Турция";
                        break;
                    case Direction.Spain:
                        text = "Испания";
                        break;
                    case Direction.Italy:
                        text = "Италия";
                        break;
                    case Direction.France:
                        text = "Франция";
                        break;
                    case Direction.Shushary:
                        text = "Шушары";
                        break;
                }
                

                dataGridView1.Rows[n].Cells[0].Value = text;
                dataGridView1.Rows[n].Cells[1].Value = InfoTours.Tours.DateDeparture;
                dataGridView1.Rows[n].Cells[2].Value = InfoTours.Tours.NumberNight;
                dataGridView1.Rows[n].Cells[3].Value = InfoTours.Tours.CostVac;
                dataGridView1.Rows[n].Cells[4].Value = InfoTours.Tours.NumberVac;
                dataGridView1.Rows[n].Cells[5].Value = InfoTours.Tours.Wi_Fi;
                dataGridView1.Rows[n].Cells[6].Value = InfoTours.Tours.Surcharges;
                dataGridView1.Rows[n].Cells[7].Value = Amount;
                if (InfoTours.Tours.Surcharges != 0)
                {
                    surCount++;
                }
                Sum();
                SumSur();
                ChangeTool.Enabled = true;
                DeliteTool.Enabled = true;
                ChangeMenu.Enabled = true;
                DeliteMenu.Enabled = true;
                countAmount++;
                NumberToursStatus.Text = $"Кол-во туров {countAmount}";
                TotalAmount.Text = $"Общая сумма {sum}";
                NumerToursSurcharges.Text = $"Кол-во туров с доплатами {surCount}";
            }
        }

        private void DeliteTool_Click(object sender, EventArgs e)
        {
            if ((decimal)dataGridView1.Rows[indexRow].Cells[6].Value != 0m)
            {
                surCount--;
            }
            countAmount--;
            var rowIndex = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(rowIndex);
            var InfoTours = new ToursInfoForm();
            if (dataGridView1.Rows.Count == 0)
            {
                ChangeTool.Enabled = false;
                DeliteTool.Enabled = false;
                ChangeMenu.Enabled = false;
                DeliteMenu.Enabled = false;
               
            }

            Sum();
            SumSur();
            NumberToursStatus.Text = $"Кол-во туров {countAmount}";
            TotalAmount.Text = $"Общая сумма {sum}";
            NumerToursSurcharges.Text = $"Кол-во туров с доплатами {surCount}";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex;
        }
        private void ChangeTool_Click(object sender, EventArgs e)
        {
            var InfoTours = new ToursInfoForm();
            var n = dataGridView1.Rows[indexRow];
            switch (n.Cells[0].Value.ToString())
            {
                case "Турция":
                    text = "Turkey";
                    break;
                case "Испания":
                    text = "Spain";
                    break;
                case "Италия":
                    text = "Italy";
                    break;
                case "Франция":
                    text = "France";
                    break;
                case "Шушары":
                    text = "Shushary";
                    break;
            }
            InfoTours.DirectionBox.Text = text;
            InfoTours.dateTimePicker1.Value = (DateTime)n.Cells[1].Value;
            InfoTours.numericNumberNigth.Value = (int)n.Cells[2].Value;
            InfoTours.CostVacBox1.Text = n.Cells[3].Value.ToString();
            InfoTours.numericNumberVac.Value = (int)n.Cells[4].Value;
            InfoTours.Wi_FiChangheBox.Checked = (bool)n.Cells[5].Value;
            InfoTours.SurBox.Text = n.Cells[6].Value.ToString();

            if((decimal)n.Cells[6].Value != 0)
            {
                Prov = true;
            }
            else
            {
                Prov = false;
            }

            if (InfoTours.ShowDialog(this) == DialogResult.OK)
            {
                decimal Amount = int.Parse(InfoTours.Tours.NumberNight.ToString()) * int.Parse(InfoTours.Tours.NumberVac.ToString()) * InfoTours.Tours.CostVac - InfoTours.Tours.Surcharges;
                
                switch (InfoTours.Tours.direction)
                {
                    case Direction.Turkey:
                        text = "Турция";
                        break;
                    case Direction.Spain:
                        text = "Испания";
                        break;
                    case Direction.Italy:
                        text = "Италия";
                        break;
                    case Direction.France:
                        text = "Франция";
                        break;
                    case Direction.Shushary:
                        text = "Шушары";
                        break;
                }

                n.Cells[0].Value = text;
                n.Cells[1].Value = InfoTours.Tours.DateDeparture;
                n.Cells[2].Value = InfoTours.Tours.NumberNight;
                n.Cells[3].Value = InfoTours.Tours.CostVac;
                n.Cells[4].Value = InfoTours.Tours.NumberVac;
                n.Cells[5].Value = InfoTours.Tours.Wi_Fi;
                n.Cells[6].Value = InfoTours.Tours.Surcharges;
                n.Cells[7].Value = Amount;
                 if (InfoTours.Tours.Surcharges == 0 && Prov)
                 {
                    surCount--;               
                 }
                else if (InfoTours.Tours.Surcharges != 0 && !Prov)
                {
                    surCount++;
                }
                NumerToursSurcharges.Text = $"Кол-во туров с доплатами {surCount}";
                Sum();
                SumSur();
                if (dataGridView1.Rows.Count == 0)
                {
                    ChangeTool.Enabled = false;
                }

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

        private void Sum()
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                s += (decimal)dataGridView1.Rows[i].Cells[7].Value;
            }
            sum = s;
            s = 0;
            TotalAmount.Text = $"Общая сумма {sum}";
        }
        private void SumSur()
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                sSur += (decimal)dataGridView1.Rows[i].Cells[6].Value;
            }
            sumSur = sSur;
            sSur = 0;
            TotalAmountSurcharges.Text = $"Общая сумма доплат {sumSur}";
        }
    }
}
