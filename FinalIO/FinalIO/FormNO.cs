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
        }
    }
}
