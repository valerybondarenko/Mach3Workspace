using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mach4;



namespace Mach3Control
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
         private void togleLED(object sender, EventArgs e)
        {
            Label label = (sender as Label);
            int output = Convert.ToInt32(label.Text);
            output += 6;
            if (MachInst != null)
            {
                if (MachInst.IsOutputActive((short)output))
                {
                    MachInst.DeActivateSignal((short)output);
                    label.BackColor = Color.Transparent;
                }
                else 
                {
                    MachInst.ActivateSignal((short)output);
                    label.BackColor = Color.LawnGreen;
                }
            }
        }
    }
}
