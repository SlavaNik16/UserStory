using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserStory4Tours.models;
using static System.Net.Mime.MediaTypeNames;

namespace UserStory4Tours
{
    public partial class ToursInfoForm : Form
    {
        private readonly Tours tours;
        public string text = "Турция";

        public ToursInfoForm()
        {
            InitializeComponent();
            FillDirection();
            tours = new Tours
            {
                direction = Direction.Turkey,
                DateDeparture = DateTime.Now.AddDays(5),
                NumberNight = (int)numericNumberNigth.Value,
                CostVac = decimal.Parse(CostVacBox1.Text),
                NumberVac = (int)numericNumberVac.Value,
                Surcharges = decimal.Parse(SurBox.Text),
            };
            DirectionBox.SelectedItem = tours.direction;
            dateTimePicker1.Value = tours.DateDeparture;
            numericNumberNigth.Value = tours.NumberNight;
            CostVacBox1.Text = tours.CostVac.ToString();
            numericNumberVac.Value = tours.NumberVac;
            SurBox.Text = tours.Surcharges.ToString();


        }
        public Tours Tours => tours;

        private void FillDirection()
        {
            foreach(Direction dir in Enum.GetValues(typeof(Direction)))
            {
                DirectionBox.Items.Add(dir);

            }
        }

        private void DirectionBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            var parent = sender as ComboBox;
            if(parent != null)
            {
                e.DrawBackground();
                Brush brush = new SolidBrush(parent.ForeColor);
                if((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                {
                    brush = SystemBrushes.HighlightText;
                }
                if(e.Index >= 0)
                {
                    if (parent.Items[e.Index] is Direction direction)
                    {
                        switch (direction)
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

        private void DirectionBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(DirectionBox.SelectedIndex >= 0)
            {
                tours.direction = (Direction)DirectionBox.SelectedItem;
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            tours.DateDeparture = dateTimePicker1.Value;
        }

        private void numericNumberNigth_ValueChanged(object sender, EventArgs e)
        {
            tours.NumberNight = (int)numericNumberNigth.Value;
        }

        private void CostVacBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
        private void CostVacBox1_TextChanged(object sender, EventArgs e)
        {
            if(CostVacBox1.Text.Length > 0)
            {
                tours.CostVac = decimal.Parse(CostVacBox1.Text);
            }
           
        }

        private void numericNumberVac_ValueChanged(object sender, EventArgs e)
        {
            tours.NumberVac = (int)numericNumberVac.Value;
        }

        private void Wi_FiChangheBox_CheckedChanged(object sender, EventArgs e)
        {
            tours.Wi_Fi = Wi_FiChangheBox.Checked;
        }

        private void SurBox_TextChanged(object sender, EventArgs e)
        {
            if (SurBox.Text.Length > 0)
            {
                tours.Surcharges = decimal.Parse(SurBox.Text);
            }
        }

        private void SurBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
    }
}
