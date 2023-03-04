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
    public partial class dashboardAdmin : Form
    {
        public dashboardAdmin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 nav = new Form1();
            nav.Show();
            this.Hide();
        }
    }
}
