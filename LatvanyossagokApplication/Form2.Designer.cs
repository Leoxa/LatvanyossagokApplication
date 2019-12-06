namespace LatvanyossagokApplication
{
    partial class Form2
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnChange = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lar = new System.Windows.Forms.NumericUpDown();
            this.lleir = new System.Windows.Forms.TextBox();
            this.lnev = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.lar)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 52;
            this.label2.Text = "Látványosság módosít";
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(174, 163);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(75, 23);
            this.btnChange.TabIndex = 51;
            this.btnChange.Text = "Változtat";
            this.btnChange.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(67, 132);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(37, 13);
            this.label13.TabIndex = 50;
            this.label13.Text = "Leírás";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(67, 95);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(17, 13);
            this.label12.TabIndex = 49;
            this.label12.Text = "Ár";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(64, 62);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 13);
            this.label11.TabIndex = 48;
            this.label11.Text = "Látványosság";
            // 
            // lar
            // 
            this.lar.Location = new System.Drawing.Point(150, 95);
            this.lar.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.lar.Name = "lar";
            this.lar.Size = new System.Drawing.Size(100, 20);
            this.lar.TabIndex = 47;
            // 
            // lleir
            // 
            this.lleir.Location = new System.Drawing.Point(150, 132);
            this.lleir.Name = "lleir";
            this.lleir.Size = new System.Drawing.Size(100, 20);
            this.lleir.TabIndex = 46;
            // 
            // lnev
            // 
            this.lnev.Location = new System.Drawing.Point(150, 62);
            this.lnev.Name = "lnev";
            this.lnev.Size = new System.Drawing.Size(100, 20);
            this.lnev.TabIndex = 45;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 268);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lar);
            this.Controls.Add(this.lleir);
            this.Controls.Add(this.lnev);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.lar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown lar;
        private System.Windows.Forms.TextBox lleir;
        private System.Windows.Forms.TextBox lnev;
    }
}