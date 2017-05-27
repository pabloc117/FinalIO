using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalIO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClassTamano LgTamano = new ClassTamano();
            LgTamano.combos(comboBox1, comboBox2, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16, t17, t18, t19, t20, t21, t22, t23, t24, t25, d1, d2, d3, d4, d5, o1, o2, o3, o4, o5);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClassTamano LgTamano = new ClassTamano();
            LgTamano.combos(comboBox1, comboBox2, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16, t17, t18, t19, t20, t21, t22, t23, t24, t25, d1, d2, d3, d4, d5, o1, o2, o3, o4, o5);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormNO frm = new FinalIO.FormNO();
            string f = comboBox1.Text;
            string c = comboBox2.Text;
            frm.label3.Text = f;
            frm.label6.Text = c;
            int of1, of2, of3, of4, of5;
            int de1, de2, de3, de4, de5;
            int sumo, sumd;
            of1 = Convert.ToInt32(o1.Text);
            of2 = Convert.ToInt32(o2.Text);
            of3 = Convert.ToInt32(o3.Text);
            of4 = Convert.ToInt32(o4.Text);
            of5 = Convert.ToInt32(o5.Text);

            de1 = Convert.ToInt32(d1.Text);
            de2 = Convert.ToInt32(d2.Text);
            de3 = Convert.ToInt32(d3.Text);
            de4 = Convert.ToInt32(d4.Text);
            de5 = Convert.ToInt32(d5.Text);

            sumo = of1 + of2 + of3 + of4 + of5;
            sumd = de1 + de2 + de3 + de4 + de5;

            if (sumo == sumd)
            {
                frm.Show();
            }
            else
            {
                MessageBox.Show("Ofertas y Demandas no coinciden");
            }
        }
    }
}
