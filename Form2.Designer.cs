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
            this.lbl_INUTS = new System.Windows.Forms.Label();
            this.lbl_IN1 = new System.Windows.Forms.Label();
            this.lbl_IN2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_INUTS
            // 
            this.lbl_INUTS.AutoSize = true;
            this.lbl_INUTS.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_INUTS.Location = new System.Drawing.Point(12, 9);
            this.lbl_INUTS.Name = "lbl_INUTS";
            this.lbl_INUTS.Size = new System.Drawing.Size(65, 18);
            this.lbl_INUTS.TabIndex = 1;
            this.lbl_INUTS.Text = "Выходы";
            // 
            // lbl_IN1
            // 
            this.lbl_IN1.AutoSize = true;
            this.lbl_IN1.BackColor = System.Drawing.Color.Transparent;
            this.lbl_IN1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_IN1.Location = new System.Drawing.Point(115, 9);
            this.lbl_IN1.MinimumSize = new System.Drawing.Size(20, 20);
            this.lbl_IN1.Name = "lbl_IN1";
            this.lbl_IN1.Size = new System.Drawing.Size(20, 20);
            this.lbl_IN1.TabIndex = 2;
            this.lbl_IN1.Text = "1";
            this.lbl_IN1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_IN1.Click += new System.EventHandler(this.togleLED);
            // 
            // lbl_IN2
            // 
            this.lbl_IN2.AutoSize = true;
            this.lbl_IN2.BackColor = System.Drawing.Color.Transparent;
            this.lbl_IN2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_IN2.Location = new System.Drawing.Point(165, 9);
            this.lbl_IN2.MinimumSize = new System.Drawing.Size(20, 20);
            this.lbl_IN2.Name = "lbl_IN2";
            this.lbl_IN2.Size = new System.Drawing.Size(20, 20);
            this.lbl_IN2.TabIndex = 3;
            this.lbl_IN2.Text = "2";
            this.lbl_IN2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_IN2.Click += new System.EventHandler(this.togleLED);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(212, 9);
            this.label1.MinimumSize = new System.Drawing.Size(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "3";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.togleLED);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(257, 9);
            this.label2.MinimumSize = new System.Drawing.Size(20, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "4";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Click += new System.EventHandler(this.togleLED);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(308, 9);
            this.label3.MinimumSize = new System.Drawing.Size(20, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "5";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.Click += new System.EventHandler(this.togleLED);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(354, 9);
            this.label4.MinimumSize = new System.Drawing.Size(20, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "6";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label4.Click += new System.EventHandler(this.togleLED);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 79);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_IN2);
            this.Controls.Add(this.lbl_IN1);
            this.Controls.Add(this.lbl_INUTS);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_INUTS;
        private System.Windows.Forms.Label lbl_IN1;
        private System.Windows.Forms.Label lbl_IN2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}