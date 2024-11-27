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
            try
            {
                _mach = (IMach4)Marshal.GetActiveObject("Mach4.Document");
                _mInst = (IMyScriptObject)_mach.GetScriptDispatch();
                //  _mInst.LoadFile("C:/Mach3/GCode/tableA.tap");

            }
            catch
            {
                _mach = null;
                _mInst = null;
            }

        }

        private void lbl_IN1_Click(object sender, EventArgs e)
        {
            if (lbl_IN1.BackColor == Color.LawnGreen)
            {
                lbl_IN1.BackColor = Color.Transparent;
            }
            else
            {
                lbl_IN1.BackColor = Color.LawnGreen;
            }
        }

        private void lbl_IN2_Click(object sender, EventArgs e)
        {
            if (lbl_IN2.BackColor == Color.LawnGreen)
            {
                lbl_IN2.BackColor = Color.Transparent;
            }
            else
            {
                lbl_IN2.BackColor = Color.LawnGreen;
            }
        }
    }
}
