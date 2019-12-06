namespace LatvanyossagokApplication
{
    partial class Form1
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
            this.tbVarosNev = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ndLakossagSzama = new System.Windows.Forms.NumericUpDown();
            this.btnFelvesz = new System.Windows.Forms.Button();
            this.varosLista = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.latvanyossagok = new System.Windows.Forms.ListBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btnDelVaros = new System.Windows.Forms.Button();
            this.tbLatvanyossagNev = new System.Windows.Forms.TextBox();
            this.tbLeiras = new System.Windows.Forms.TextBox();
            this.nudAr = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnLatvanyossagFelv = new System.Windows.Forms.Button();
            this.btnvarosvalzotatas = new System.Windows.Forms.Button();
            this.btnlatvvaltoztatas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ndLakossagSzama)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAr)).BeginInit();
            this.SuspendLayout();
            // 
            // tbVarosNev
            // 
            this.tbVarosNev.Location = new System.Drawing.Point(102, 31);
            this.tbVarosNev.Name = "tbVarosNev";
            this.tbVarosNev.Size = new System.Drawing.Size(100, 20);
            this.tbVarosNev.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Város név";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Lakosság";
            // 
            // ndLakossagSzama
            // 
            this.ndLakossagSzama.Location = new System.Drawing.Point(102, 73);
            this.ndLakossagSzama.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.ndLakossagSzama.Name = "ndLakossagSzama";
            this.ndLakossagSzama.Size = new System.Drawing.Size(100, 20);
            this.ndLakossagSzama.TabIndex = 4;
            // 
            // btnFelvesz
            // 
            this.btnFelvesz.Location = new System.Drawing.Point(127, 109);
            this.btnFelvesz.Name = "btnFelvesz";
            this.btnFelvesz.Size = new System.Drawing.Size(75, 23);
            this.btnFelvesz.TabIndex = 5;
            this.btnFelvesz.Text = "Felvesz";
            this.btnFelvesz.UseVisualStyleBackColor = true;
            this.btnFelvesz.Click += new System.EventHandler(this.btnFelvesz_Click);
            // 
            // varosLista
            // 
            this.varosLista.FormattingEnabled = true;
            this.varosLista.Location = new System.Drawing.Point(320, 37);
            this.varosLista.Name = "varosLista";
            this.varosLista.Size = new System.Drawing.Size(143, 95);
            this.varosLista.TabIndex = 6;
            this.varosLista.SelectedIndexChanged += new System.EventHandler(this.varosLista_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Város felvétel";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(259, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Látványosság felvétel";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(259, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Város név";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(614, 192);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Törlés";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // latvanyossagok
            // 
            this.latvanyossagok.FormattingEnabled = true;
            this.latvanyossagok.Location = new System.Drawing.Point(533, 37);
            this.latvanyossagok.Name = "latvanyossagok";
            this.latvanyossagok.Size = new System.Drawing.Size(155, 95);
            this.latvanyossagok.TabIndex = 29;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(569, 163);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(119, 13);
            this.label14.TabIndex = 31;
            this.label14.Text = "Látványosság kijelölése";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(259, 168);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(63, 13);
            this.label15.TabIndex = 32;
            this.label15.Text = "Város kijelöl";
            // 
            // btnDelVaros
            // 
            this.btnDelVaros.Location = new System.Drawing.Point(386, 163);
            this.btnDelVaros.Name = "btnDelVaros";
            this.btnDelVaros.Size = new System.Drawing.Size(75, 23);
            this.btnDelVaros.TabIndex = 33;
            this.btnDelVaros.Text = "Töröl";
            this.btnDelVaros.UseVisualStyleBackColor = true;
            this.btnDelVaros.Click += new System.EventHandler(this.btnDelVaros_Click);
            // 
            // tbLatvanyossagNev
            // 
            this.tbLatvanyossagNev.Location = new System.Drawing.Point(363, 196);
            this.tbLatvanyossagNev.Name = "tbLatvanyossagNev";
            this.tbLatvanyossagNev.Size = new System.Drawing.Size(100, 20);
            this.tbLatvanyossagNev.TabIndex = 10;
            // 
            // tbLeiras
            // 
            this.tbLeiras.Location = new System.Drawing.Point(363, 269);
            this.tbLeiras.Name = "tbLeiras";
            this.tbLeiras.Size = new System.Drawing.Size(100, 20);
            this.tbLeiras.TabIndex = 11;
            // 
            // nudAr
            // 
            this.nudAr.Location = new System.Drawing.Point(363, 234);
            this.nudAr.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudAr.Name = "nudAr";
            this.nudAr.Size = new System.Drawing.Size(99, 20);
            this.nudAr.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(262, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Látványosság neve";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(262, 234);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Belépő";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(265, 269);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Leírás";
            // 
            // btnLatvanyossagFelv
            // 
            this.btnLatvanyossagFelv.Location = new System.Drawing.Point(344, 308);
            this.btnLatvanyossagFelv.Name = "btnLatvanyossagFelv";
            this.btnLatvanyossagFelv.Size = new System.Drawing.Size(119, 23);
            this.btnLatvanyossagFelv.TabIndex = 16;
            this.btnLatvanyossagFelv.Text = "Látványosság felvesz";
            this.btnLatvanyossagFelv.UseVisualStyleBackColor = true;
            this.btnLatvanyossagFelv.Click += new System.EventHandler(this.btnLatvanyossagFelv_Click);
            // 
            // btnvarosvalzotatas
            // 
            this.btnvarosvalzotatas.Location = new System.Drawing.Point(388, 349);
            this.btnvarosvalzotatas.Name = "btnvarosvalzotatas";
            this.btnvarosvalzotatas.Size = new System.Drawing.Size(75, 23);
            this.btnvarosvalzotatas.TabIndex = 34;
            this.btnvarosvalzotatas.Text = "Változtatás";
            this.btnvarosvalzotatas.UseVisualStyleBackColor = true;
            this.btnvarosvalzotatas.Click += new System.EventHandler(this.btnvarosvalzotatas_Click);
            // 
            // btnlatvvaltoztatas
            // 
            this.btnlatvvaltoztatas.Location = new System.Drawing.Point(612, 230);
            this.btnlatvvaltoztatas.Name = "btnlatvvaltoztatas";
            this.btnlatvvaltoztatas.Size = new System.Drawing.Size(75, 23);
            this.btnlatvvaltoztatas.TabIndex = 35;
            this.btnlatvvaltoztatas.Text = "Változtatás";
            this.btnlatvvaltoztatas.UseVisualStyleBackColor = true;
            this.btnlatvvaltoztatas.Click += new System.EventHandler(this.btnlatvvaltoztatas_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 458);
            this.Controls.Add(this.btnlatvvaltoztatas);
            this.Controls.Add(this.btnvarosvalzotatas);
            this.Controls.Add(this.btnDelVaros);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.latvanyossagok);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnLatvanyossagFelv);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nudAr);
            this.Controls.Add(this.tbLeiras);
            this.Controls.Add(this.tbLatvanyossagNev);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.varosLista);
            this.Controls.Add(this.btnFelvesz);
            this.Controls.Add(this.ndLakossagSzama);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbVarosNev);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ndLakossagSzama)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbVarosNev;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown ndLakossagSzama;
        private System.Windows.Forms.Button btnFelvesz;
        private System.Windows.Forms.ListBox varosLista;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ListBox latvanyossagok;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnDelVaros;
        private System.Windows.Forms.TextBox tbLatvanyossagNev;
        private System.Windows.Forms.TextBox tbLeiras;
        private System.Windows.Forms.NumericUpDown nudAr;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnLatvanyossagFelv;
        private System.Windows.Forms.Button btnvarosvalzotatas;
        private System.Windows.Forms.Button btnlatvvaltoztatas;
    }
}

