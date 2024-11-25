using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Mach4;

namespace Mach3Control
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            GetMachInstance(null);
        }

        private string folderName;

        public void GetMachInstance(IMach4 _mach)
        {
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
        private void table_1_button_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                label1.Text = openFileDialog1.FileName;
            }

        }

        private void table_2_button_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                label3.Text = openFileDialog1.FileName;
            }
        }

        private void MachineOptionsMenuItem_Click(object sender, EventArgs e)
        {
            label5.Text = folderName;
        }

        private void WorkFolderMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                folderName = folderBrowserDialog1.SelectedPath;
                
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (_mInst == null)
            {
                return;
            }
            else
            {
                _mInst.LoadFile(label3.Text);
               // _mInst.DeActivateSignal(Convert.ToInt16(this.comboBox1.Text));
            }
        }
    }
}
