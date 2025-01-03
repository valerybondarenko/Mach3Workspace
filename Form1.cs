﻿using System;
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
            isMachRun=false;
            isConnected=false;
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

        private void BtnConnect(object sender, EventArgs e)
        {
            if (isConnected)
            { 
                timer1.Stop();
                lblMSG.Text = "Нет подключения к Mach3";
                btnConnect.Text = "Подключить";
                isConnected = false;
                _mInst.DeActivateSignal(7);
                _mInst.DeActivateSignal(8);
                return;
            }
            else 
            {
                GetMachInstance(null);
                if (_mInst == null)
                {
                    lblMSG.Text = "Нет подключения к Mach3";
                    return;
                }
                lblMSG.Text = "Подключено " + (System.String)_mInst.GetActiveProfileName();
                timer1.Interval = 10;
                timer1.Start();
                btnConnect.Text = "Отключить";
                isConnected=true;
                _mInst.ActivateSignal(7);
                _mInst.ActivateSignal(8);
            }
            
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
                if (_mInst.GetOEMLed(821))
                {
                    if (!isFerstSelected)
                    {
                        isFerstSelected = true;
                    }
                    else 
                    {
                        if (!isMachRun&&isFerstReady)
                        {
                            _mInst.LoadRun("C:\\Mach3\\GCode\\tableA.tap");
                            isFerstSelected = false;
                            isFerstReady = false;
                            isMachRun = true;
                            return;
                        }
                        timer2.Interval = 3000;
                        timer2.Start();
                    }
                }

                if (_mInst.GetOEMLed(822))
                {
                    if (!isSecondSelected)
                    {
                        isSecondSelected = true;
                    }
                    else
                    {
                        if (!isMachRun&&isSecondReady) 
                        { 
                            _mInst.LoadRun("C:\\Mach3\\GCode\\tableB.tap");
                            isSecondSelected=false;
                            isSecondReady=false;
                            isMachRun=true;
                            return;
                        }
                        timer3.Interval = 3000;
                       timer3.Start();
                    }
                }

                if (!_mInst.GetOEMLed(804))
                {
                    if (isMachRun)
                    {
                        if (isFerstReady)
                        {
                            _mInst.LoadRun("C:\\Mach3\\GCode\\tableA.tap");
                            isFerstSelected = false;
                            isFerstReady = false;
                            isMachRun = true;
                            return;
                        }
                        if (isSecondReady)
                        {
                            _mInst.LoadRun("C:\\Mach3\\GCode\\tableB.tap");
                            isSecondSelected = false;
                            isSecondReady = false;
                            isMachRun = true;
                            return;
                        }
                    }
                    isMachRun = false;
                }
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            isFerstReady = true;
            timer2.Stop();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            isSecondReady = true;
            timer3.Stop();
        }
    }
}
