using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void Welcome_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Medicine f1 = new Medicine();
            f1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Client c1 = new Client();
            c1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Supplier s2 = new Supplier();
            s2.Show();
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SalesOrder s1 = new SalesOrder();
            s1.Show();
        }
    }
}
