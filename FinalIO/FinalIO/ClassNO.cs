using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalIO
{
    public class ClassNO
    {
        public void NO(TextBox o1, TextBox o2, TextBox o3, TextBox o4, TextBox o5, TextBox d1, TextBox d2, TextBox d3, TextBox d4, TextBox d5)
        {
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
                FormNO frm = new FinalIO.FormNO();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Ofertas y Demandas no coinciden");
            }
        }
    }
}
