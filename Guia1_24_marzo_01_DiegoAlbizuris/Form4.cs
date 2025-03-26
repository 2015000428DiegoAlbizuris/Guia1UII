using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guia1_24_marzo_01_DiegoAlbizuris
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] v1 = {1,2,3,4};
            int[] v2 = {5,6,7,8};

            for (int i = 0; i < 4; i++)
            {
                int suma = v1[i] + v2[i];
                dataGridView1.Rows.Add(v1[i], v2[i], suma);
            }
        }
    }
}
