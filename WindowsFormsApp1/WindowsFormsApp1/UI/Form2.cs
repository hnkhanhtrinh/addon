using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            Form2 FM2 = new Form2();
            FM2.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            TXTUSER.Focus();
            TXTPASS.Focus();
            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BTN_CANCLE_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
