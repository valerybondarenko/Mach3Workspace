using Mach4;

namespace Mach3Control
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        
        private IMyScriptObject machInst;
        public IMyScriptObject MachInst { get; set; }
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_OUTS = new System.Windows.Forms.Label();
            this.lblOut_1 = new System.Windows.Forms.Label();
            this.lblOut_2 = new System.Windows.Forms.Label();
            this.lblOut_3 = new System.Windows.Forms.Label();
            this.lblOut_4 = new System.Windows.Forms.Label();
            this.lblOut_5 = new System.Windows.Forms.Label();
            this.lblOut_6 = new System.Windows.Forms.Label();
            this.lblIN_6 = new System.Windows.Forms.Label();
            this.lblIN_5 = new System.Windows.Forms.Label();
            this.lblIN_4 = new System.Windows.Forms.Label();
            this.lblIN_3 = new System.Windows.Forms.Label();
            this.lblIN_2 = new System.Windows.Forms.Label();
            this.lblIN_1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_OUTS
            // 
            this.lbl_OUTS.AutoSize = true;
            this.lbl_OUTS.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_OUTS.Location = new System.Drawing.Point(12, 9);
            this.lbl_OUTS.Name = "lbl_OUTS";
            this.lbl_OUTS.Size = new System.Drawing.Size(65, 18);
            this.lbl_OUTS.TabIndex = 1;
            this.lbl_OUTS.Text = "Выходы";
            // 
            // lblOut_1
            // 
            this.lblOut_1.AutoSize = true;
            this.lblOut_1.BackColor = System.Drawing.Color.Transparent;
            this.lblOut_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblOut_1.Location = new System.Drawing.Point(115, 9);
            this.lblOut_1.MinimumSize = new System.Drawing.Size(20, 20);
            this.lblOut_1.Name = "lblOut_1";
            this.lblOut_1.Size = new System.Drawing.Size(20, 20);
            this.lblOut_1.TabIndex = 2;
            this.lblOut_1.Text = "1";
            this.lblOut_1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblOut_1.Click += new System.EventHandler(this.togleLED);
            // 
            // lblOut_2
            // 
            this.lblOut_2.AutoSize = true;
            this.lblOut_2.BackColor = System.Drawing.Color.Transparent;
            this.lblOut_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblOut_2.Location = new System.Drawing.Point(165, 9);
            this.lblOut_2.MinimumSize = new System.Drawing.Size(20, 20);
            this.lblOut_2.Name = "lblOut_2";
            this.lblOut_2.Size = new System.Drawing.Size(20, 20);
            this.lblOut_2.TabIndex = 3;
            this.lblOut_2.Text = "2";
            this.lblOut_2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblOut_2.Click += new System.EventHandler(this.togleLED);
            // 
            // lblOut_3
            // 
            this.lblOut_3.AutoSize = true;
            this.lblOut_3.BackColor = System.Drawing.Color.Transparent;
            this.lblOut_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblOut_3.Location = new System.Drawing.Point(212, 9);
            this.lblOut_3.MinimumSize = new System.Drawing.Size(20, 20);
            this.lblOut_3.Name = "lblOut_3";
            this.lblOut_3.Size = new System.Drawing.Size(20, 20);
            this.lblOut_3.TabIndex = 4;
            this.lblOut_3.Text = "3";
            this.lblOut_3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblOut_3.Click += new System.EventHandler(this.togleLED);
            // 
            // lblOut_4
            // 
            this.lblOut_4.AutoSize = true;
            this.lblOut_4.BackColor = System.Drawing.Color.Transparent;
            this.lblOut_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblOut_4.Location = new System.Drawing.Point(257, 9);
            this.lblOut_4.MinimumSize = new System.Drawing.Size(20, 20);
            this.lblOut_4.Name = "lblOut_4";
            this.lblOut_4.Size = new System.Drawing.Size(20, 20);
            this.lblOut_4.TabIndex = 5;
            this.lblOut_4.Text = "4";
            this.lblOut_4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblOut_4.Click += new System.EventHandler(this.togleLED);
            // 
            // lblOut_5
            // 
            this.lblOut_5.AutoSize = true;
            this.lblOut_5.BackColor = System.Drawing.Color.Transparent;
            this.lblOut_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblOut_5.Location = new System.Drawing.Point(308, 9);
            this.lblOut_5.MinimumSize = new System.Drawing.Size(20, 20);
            this.lblOut_5.Name = "lblOut_5";
            this.lblOut_5.Size = new System.Drawing.Size(20, 20);
            this.lblOut_5.TabIndex = 6;
            this.lblOut_5.Text = "5";
            this.lblOut_5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblOut_5.Click += new System.EventHandler(this.togleLED);
            // 
            // lblOut_6
            // 
            this.lblOut_6.AutoSize = true;
            this.lblOut_6.BackColor = System.Drawing.Color.Transparent;
            this.lblOut_6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblOut_6.Location = new System.Drawing.Point(354, 9);
            this.lblOut_6.MinimumSize = new System.Drawing.Size(20, 20);
            this.lblOut_6.Name = "lblOut_6";
            this.lblOut_6.Size = new System.Drawing.Size(20, 20);
            this.lblOut_6.TabIndex = 7;
            this.lblOut_6.Text = "6";
            this.lblOut_6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblOut_6.Click += new System.EventHandler(this.togleLED);
            // 
            // lblIN_6
            // 
            this.lblIN_6.AutoSize = true;
            this.lblIN_6.BackColor = System.Drawing.Color.Transparent;
            this.lblIN_6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblIN_6.Location = new System.Drawing.Point(354, 46);
            this.lblIN_6.MinimumSize = new System.Drawing.Size(20, 20);
            this.lblIN_6.Name = "lblIN_6";
            this.lblIN_6.Size = new System.Drawing.Size(20, 20);
            this.lblIN_6.TabIndex = 14;
            this.lblIN_6.Text = "6";
            this.lblIN_6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblIN_5
            // 
            this.lblIN_5.AutoSize = true;
            this.lblIN_5.BackColor = System.Drawing.Color.Transparent;
            this.lblIN_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblIN_5.Location = new System.Drawing.Point(308, 46);
            this.lblIN_5.MinimumSize = new System.Drawing.Size(20, 20);
            this.lblIN_5.Name = "lblIN_5";
            this.lblIN_5.Size = new System.Drawing.Size(20, 20);
            this.lblIN_5.TabIndex = 13;
            this.lblIN_5.Text = "5";
            this.lblIN_5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblIN_4
            // 
            this.lblIN_4.AutoSize = true;
            this.lblIN_4.BackColor = System.Drawing.Color.Transparent;
            this.lblIN_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblIN_4.Location = new System.Drawing.Point(257, 46);
            this.lblIN_4.MinimumSize = new System.Drawing.Size(20, 20);
            this.lblIN_4.Name = "lblIN_4";
            this.lblIN_4.Size = new System.Drawing.Size(20, 20);
            this.lblIN_4.TabIndex = 12;
            this.lblIN_4.Text = "4";
            this.lblIN_4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblIN_3
            // 
            this.lblIN_3.AutoSize = true;
            this.lblIN_3.BackColor = System.Drawing.Color.Transparent;
            this.lblIN_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblIN_3.Location = new System.Drawing.Point(212, 46);
            this.lblIN_3.MinimumSize = new System.Drawing.Size(20, 20);
            this.lblIN_3.Name = "lblIN_3";
            this.lblIN_3.Size = new System.Drawing.Size(20, 20);
            this.lblIN_3.TabIndex = 11;
            this.lblIN_3.Text = "3";
            this.lblIN_3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblIN_2
            // 
            this.lblIN_2.AutoSize = true;
            this.lblIN_2.BackColor = System.Drawing.Color.Transparent;
            this.lblIN_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblIN_2.Location = new System.Drawing.Point(165, 46);
            this.lblIN_2.MinimumSize = new System.Drawing.Size(20, 20);
            this.lblIN_2.Name = "lblIN_2";
            this.lblIN_2.Size = new System.Drawing.Size(20, 20);
            this.lblIN_2.TabIndex = 10;
            this.lblIN_2.Text = "2";
            this.lblIN_2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblIN_1
            // 
            this.lblIN_1.AutoSize = true;
            this.lblIN_1.BackColor = System.Drawing.Color.Transparent;
            this.lblIN_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblIN_1.Location = new System.Drawing.Point(115, 46);
            this.lblIN_1.MinimumSize = new System.Drawing.Size(20, 20);
            this.lblIN_1.Name = "lblIN_1";
            this.lblIN_1.Size = new System.Drawing.Size(20, 20);
            this.lblIN_1.TabIndex = 9;
            this.lblIN_1.Text = "1";
            this.lblIN_1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(12, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 18);
            this.label7.TabIndex = 8;
            this.label7.Text = "Входы";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 80);
            this.Controls.Add(this.lblIN_6);
            this.Controls.Add(this.lblIN_5);
            this.Controls.Add(this.lblIN_4);
            this.Controls.Add(this.lblIN_3);
            this.Controls.Add(this.lblIN_2);
            this.Controls.Add(this.lblIN_1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblOut_6);
            this.Controls.Add(this.lblOut_5);
            this.Controls.Add(this.lblOut_4);
            this.Controls.Add(this.lblOut_3);
            this.Controls.Add(this.lblOut_2);
            this.Controls.Add(this.lblOut_1);
            this.Controls.Add(this.lbl_OUTS);
            this.Name = "Form2";
            this.Text = "`";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_OUTS;
        private System.Windows.Forms.Label lblOut_1;
        private System.Windows.Forms.Label lblOut_2;
        private System.Windows.Forms.Label lblOut_3;
        private System.Windows.Forms.Label lblOut_4;
        private System.Windows.Forms.Label lblOut_5;
        private System.Windows.Forms.Label lblOut_6;
        private System.Windows.Forms.Label lblIN_6;
        private System.Windows.Forms.Label lblIN_5;
        private System.Windows.Forms.Label lblIN_4;
        private System.Windows.Forms.Label lblIN_3;
        private System.Windows.Forms.Label lblIN_2;
        private System.Windows.Forms.Label lblIN_1;
        private System.Windows.Forms.Label label7;
    }
}