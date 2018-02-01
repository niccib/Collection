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
    public partial class MediumToppings : Form
    {
        public MediumToppings()
        {
            InitializeComponent();
        }

        private void Anchovy_Click(object sender, EventArgs e)
        {
            MedOrder.Text = MedOrder.Text + " Anchovy,";
        }

        private void MediumToppings_Load(object sender, EventArgs e)
        {

        }

        private void MedOrder_TextChanged(object sender, EventArgs e)
        {

        }

        private void Bacon_Click(object sender, EventArgs e)
        {
            MedOrder.Text = MedOrder.Text + " Bacon,";
        }

        private void No_Click(object sender, EventArgs e)
        {
            MedOrder.Text = MedOrder.Text + " NO ";
        }
    }
}
