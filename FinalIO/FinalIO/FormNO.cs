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
    public partial class FormNO : Form
    {
        public FormNO()
        {
            InitializeComponent();
        }

        private void FormNO_Load(object sender, EventArgs e)
        {
            ClassNO LgNO = new FinalIO.ClassNO();
            LgNO.LlenadoNO(label3, label6, tn1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16, t17, t18, t19, t20, t21, t22, t23, t24, t25, d1, d2, d3, d4, d5, o1, o2, o3, o4, o5);
            LgNO.PrimerPaso(label3, label6, r1, r2, r3, r4, r5, r6, r7, r8, r9, r10, r11, r12, r13, r14, r15, r16, r17, r18, r19, r20, r21, r22, r23, r24, r25, d1, d2, d3, d4, d5, o1, o2, o3, o4, o5);
            LgNO.SegundoPaso(label3, label6, p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16, p17, p18, p19, p20, p21, p22, p23, p24, p25, d1, d2, d3, d4, d5, o1, o2, o3, o4, o5);
            a1.Text = d1.Text; a2.Text = d2.Text; a3.Text = d3.Text; a4.Text = d4.Text; a5.Text = d5.Text;
            b1.Text = o1.Text; b2.Text = o2.Text; b3.Text = o3.Text; b4.Text = o4.Text; b5.Text = o5.Text;

            n1.Text = d1.Text; n2.Text = d2.Text; n3.Text = d3.Text; n4.Text = n4.Text; n5.Text = d5.Text;
            m1.Text = o1.Text; m2.Text = o2.Text; m3.Text = o3.Text; m4.Text = m4.Text; m5.Text = o5.Text;

            if(label3.Text=="2")
            {
                if(label6.Text=="3")
                {
                    a1.Visible = true; a2.Visible = true; a3.Visible = true; a4.Visible = false; a5.Visible = false;
                    b1.Visible = true; b2.Visible = true; b3.Visible = false; b4.Visible = false; b5.Visible = false;

                    n1.Visible = true; n2.Visible = true; n3.Visible = true; n4.Visible = false; n5.Visible = false;
                    m1.Visible = true; m2.Visible = true; m3.Visible = false; m4.Visible = false; m5.Visible = false;
                }
            }
        }
    }
}
