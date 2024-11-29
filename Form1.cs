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
using System.IO;
using System.Security.Cryptography;
using System.Xml.Linq;
using Mach3Control.Properties;


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
            openFileDialog1.InitialDirectory = folderName;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                label1.Text = openFileDialog1.FileName;
                using (StreamReader read = new StreamReader(openFileDialog1.FileName))
                {
                    while (true)
                    {
                        // Read the text from the file
                        string line = read.ReadLine();
                        if (line == null)
                            break;
                        richTextBox1.AppendText(line);
                        richTextBox1.AppendText("\n");
                    }
                }
            }
        }

        private void table_2_button_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory=folderName;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                label3.Text = openFileDialog1.FileName;
            }
        }

        private void MachineOptionsMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void WorkFolderMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            folderBrowserDialog1.SelectedPath = folderName; 
            if (result == DialogResult.OK)
            {
                folderName = folderBrowserDialog1.SelectedPath;
                Settings.Default["WorkFolder"] = folderName;
                Settings.Default.Save();
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            timer1.Interval = 10;
            timer1.Start();
        }

        private void inputStateToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form2 form2 = new Form2();
            form2.MachInst = _mInst;
            form2.Show();

        }



        private void Form1_Load(object sender, EventArgs e)
        {
            folderName = Settings.Default.WorkFolder;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Settings.Default["WorkFolder"] = folderName;
            Settings.Default.Save();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (_mInst != null)
            {
                
            }
        }
    }
}
