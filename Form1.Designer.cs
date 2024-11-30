using Mach4;

namespace Mach3Control
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private IMach4 _mach;
        private IMyScriptObject _mInst;
        private bool isMachRun;
       
        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.table_1_button = new System.Windows.Forms.Button();
            this.table_2_button = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            System.Windows.Forms.Button button = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.lblMSG = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.MachineOptionsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WorkFolderMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inputStateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(118, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Программа для стола 1 не выбрана";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(118, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(259, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Программа для стола 2 не выбрана";
            // 
            // table_1_button
            // 
            this.table_1_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.table_1_button.Location = new System.Drawing.Point(20, 55);
            this.table_1_button.Name = "table_1_button";
            this.table_1_button.Size = new System.Drawing.Size(75, 31);
            this.table_1_button.TabIndex = 2;
            this.table_1_button.Text = "Стол 1";
            this.table_1_button.UseVisualStyleBackColor = true;
            this.table_1_button.Click += new System.EventHandler(this.table_1_button_Click);
            // 
            // table_2_button
            // 
            this.table_2_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.table_2_button.Location = new System.Drawing.Point(20, 92);
            this.table_2_button.Name = "table_2_button";
            this.table_2_button.Size = new System.Drawing.Size(75, 31);
            this.table_2_button.TabIndex = 3;
            this.table_2_button.Text = "Стол 2";
            this.table_2_button.UseVisualStyleBackColor = true;
            this.table_2_button.Click += new System.EventHandler(this.table_2_button_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Cross;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(121, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 26);
            this.label4.TabIndex = 4;
            this.label4.Text = "Mach3Control";
            // 
            // btnConnect
            // 
            this.btnConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnConnect.Location = new System.Drawing.Point(12, 697);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(109, 26);
            this.btnConnect.TabIndex = 5;
            this.btnConnect.Text = "Подключить";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.BtnConnect);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.richTextBox2);
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Location = new System.Drawing.Point(0, 134);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(661, 557);
            this.panel1.TabIndex = 6;
            // 
            // richTextBox2
            // 
            this.richTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox2.Location = new System.Drawing.Point(319, 3);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(339, 564);
            this.richTextBox2.TabIndex = 1;
            this.richTextBox2.Text = "";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox1.Location = new System.Drawing.Point(3, 3);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(310, 564);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // lblMSG
            // 
            this.lblMSG.AutoSize = true;
            this.lblMSG.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMSG.Location = new System.Drawing.Point(147, 702);
            this.lblMSG.Name = "lblMSG";
            this.lblMSG.Size = new System.Drawing.Size(193, 18);
            this.lblMSG.TabIndex = 7;
            this.lblMSG.Text = "Нет подключения к Mach3";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.controlToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(661, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MachineOptionsMenuItem,
            this.WorkFolderMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(79, 20);
            this.toolStripMenuItem1.Text = "Настройки";
            // 
            // MachineOptionsMenuItem
            // 
            this.MachineOptionsMenuItem.Name = "MachineOptionsMenuItem";
            this.MachineOptionsMenuItem.Size = new System.Drawing.Size(173, 22);
            this.MachineOptionsMenuItem.Text = "Настройки станка";
            this.MachineOptionsMenuItem.Click += new System.EventHandler(this.MachineOptionsMenuItem_Click);
            // 
            // WorkFolderMenuItem
            // 
            this.WorkFolderMenuItem.Name = "WorkFolderMenuItem";
            this.WorkFolderMenuItem.Size = new System.Drawing.Size(173, 22);
            this.WorkFolderMenuItem.Text = "Рабочий каталог";
            this.WorkFolderMenuItem.Click += new System.EventHandler(this.WorkFolderMenuItem_Click);
            // 
            // controlToolStripMenuItem
            // 
            this.controlToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inputStateToolStripMenuItem});
            this.controlToolStripMenuItem.Name = "controlToolStripMenuItem";
            this.controlToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.controlToolStripMenuItem.Text = "Управление";
            // 
            // inputStateToolStripMenuItem
            // 
            this.inputStateToolStripMenuItem.Name = "inputStateToolStripMenuItem";
            this.inputStateToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.inputStateToolStripMenuItem.Text = "Входы / Выходы";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 735);
            this.Controls.Add(this.lblMSG);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.table_2_button);
            this.Controls.Add(this.table_1_button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Mach3 Worklist";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button table_1_button;
        private System.Windows.Forms.Button table_2_button;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label lblMSG;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem MachineOptionsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem WorkFolderMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ToolStripMenuItem controlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inputStateToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        
    }
}

