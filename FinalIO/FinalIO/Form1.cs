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

            frm.tn1.Text = t1.Text; frm.t2.Text = t2.Text; frm.t3.Text = t3.Text; frm.t4.Text = t4.Text; frm.t5.Text = t5.Text;
            frm.t6.Text = t6.Text; frm.t7.Text = t7.Text; frm.t8.Text = t8.Text; frm.t9.Text = t9.Text; frm.t10.Text = t10.Text;
            frm.t11.Text = t11.Text; frm.t12.Text = t12.Text; frm.t13.Text = t13.Text; frm.t14.Text = t14.Text; frm.t15.Text = t15.Text;
            frm.t16.Text = t16.Text; frm.t17.Text = t17.Text; frm.t18.Text = t18.Text; frm.t19.Text = t19.Text; frm.t20.Text = t20.Text;
            frm.t21.Text = t21.Text; frm.t22.Text = t22.Text; frm.t23.Text = t23.Text; frm.t24.Text = t24.Text; frm.t25.Text = t25.Text;

            frm.d1.Text = d1.Text; frm.d2.Text = d2.Text; frm.d3.Text = d3.Text; frm.d4.Text = d4.Text; frm.d5.Text = d5.Text;
            frm.o1.Text = o1.Text; frm.o2.Text = o2.Text; frm.o3.Text = o3.Text; frm.o4.Text = o4.Text; frm.o5.Text = o5.Text;

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
