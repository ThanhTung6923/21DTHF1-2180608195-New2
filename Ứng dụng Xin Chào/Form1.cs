using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ứng_dụng_Xin_Chào
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTiepTuc_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Xin Chào :3" + txtNhapTen.Text + " !");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
