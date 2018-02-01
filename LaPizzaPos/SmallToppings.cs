using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaPizzaPos
{
    public partial class SmallToppings : Form
    {

        public SmallToppings()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void rightHalfTopping_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void addBtn_Click(object sender, EventArgs e)
        {

            if (wholeToppingList.CheckedItems != null)
            {

                foreach (string item in wholeToppingList.CheckedItems)
                {
                    tBox.AppendText(" " + item + ", ");
                }
            }
            if (leftHalfTopping.CheckedItems != null)
            { 
                foreach (string half in leftHalfTopping.CheckedItems)
                {
                    tBox.AppendText(" " + half + ", ");
                }
            }
            if (rightHalfTopping.CheckedItems != null)
            {
                foreach (string rhalf in rightHalfTopping.CheckedItems)
                {
                    tBox.AppendText(" " + rhalf + ", ");
                }
            }

            else
            {
                tBox.Text = tBox.Text;
            }
            
            
        }

        private void SmallToppings_Load(object sender, EventArgs e)
        {

        }
    }
}
