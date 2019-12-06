namespace LatvanyossagokApplication
{
    partial class ModositasForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.btnChangeVaros = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.nudujlakossag = new System.Windows.Forms.NumericUpDown();
            this.vnev = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudujlakossag)).BeginInit();
            this.SuspendLayout();
            // 
            // btnChangeVaros
            // 
            this.btnChangeVaros.Location = new System.Drawing.Point(140, 130);
            this.btnChangeVaros.Name = "btnChangeVaros";
            this.btnChangeVaros.Size = new System.Drawing.Size(75, 23);
            this.btnChangeVaros.TabIndex = 35;
            this.btnChangeVaros.Text = "Változtat";
            this.btnChangeVaros.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(27, 92);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 34;
            this.label10.Text = "Lakosság";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 33;
            this.label9.Text = "Város Név";
            // 
            // nudujlakossag
            // 
            this.nudujlakossag.Location = new System.Drawing.Point(116, 92);
            this.nudujlakossag.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.nudujlakossag.Name = "nudujlakossag";
            this.nudujlakossag.Size = new System.Drawing.Size(100, 20);
            this.nudujlakossag.TabIndex = 32;
            // 
            // vnev
            // 
            this.vnev.Location = new System.Drawing.Point(116, 57);
            this.vnev.Name = "vnev";
            this.vnev.Size = new System.Drawing.Size(100, 20);
            this.vnev.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Város módiítás";
            // 
            // ModositasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 240);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnChangeVaros);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.nudujlakossag);
            this.Controls.Add(this.vnev);
            this.Name = "ModositasForm";
            this.Text = "ModositasForm";
            ((System.ComponentModel.ISupportInitialize)(this.nudujlakossag)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChangeVaros;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown nudujlakossag;
        private System.Windows.Forms.TextBox vnev;
        private System.Windows.Forms.Label label1;
    }
}