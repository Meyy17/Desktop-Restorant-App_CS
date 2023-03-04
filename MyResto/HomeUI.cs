using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyResto
{
    public partial class HomeUI : Form
    {
         public static int count = 0;
        public HomeUI()
        {
            InitializeComponent();
            countOrder.Text = count.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            dashboardAdmin f2 = new dashboardAdmin();
            f2.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 nav = new Form1();
            nav.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            count++;
            countOrder.Text = count.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            count--;
            countOrder.Text = count.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
