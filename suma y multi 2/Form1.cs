using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace suma_y_multi_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
        InitializeComponent();
        }

        private void btnsuma_Click(object sender, EventArgs e)
        {
            int suma = int.Parse(txtnum1.Text) + int.Parse(txtnum2.Text);
            MessageBox.Show("La suma es: " + suma);

            
        }

        private void btnmulti_Click(object sender, EventArgs e)
        {
            int multi = int.Parse(txtnum1.Text) * int.Parse(txtnum2.Text);

            MessageBox.Show("La multiplicación es: " + multi);

        
        }
    }
}
