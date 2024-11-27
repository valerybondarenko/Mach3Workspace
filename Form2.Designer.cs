using Mach4;

namespace Mach3Control
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private IMach4 _mach;
        private IMyScriptObject _mInst;

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
            this.SuspendLayout();
            // 
            // lbl_INUTS
            // 
            this.lbl_INUTS.AutoSize = true;
            this.lbl_INUTS.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_INUTS.Location = new System.Drawing.Point(12, 9);
            this.lbl_INUTS.Name = "lbl_INUTS";
            this.lbl_INUTS.Size = new System.Drawing.Size(54, 18);
            this.lbl_INUTS.TabIndex = 1;
            this.lbl_INUTS.Text = "Входы";
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
            this.lbl_IN1.Click += new System.EventHandler(this.lbl_IN1_Click);
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
            this.lbl_IN2.Click += new System.EventHandler(this.lbl_IN2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 140);
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
    }
}