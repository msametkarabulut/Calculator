namespace Calculator
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            //this.metroContextMenu1 = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tSonuc = new System.Windows.Forms.TextBox();
            this.bTumu = new System.Windows.Forms.Button();
            this.bCikis = new System.Windows.Forms.Button();
            this.bSil = new System.Windows.Forms.Button();
            this.bEsittir = new System.Windows.Forms.Button();
            this.bCarp = new System.Windows.Forms.Button();
            this.bBol = new System.Windows.Forms.Button();
            this.bCikar = new System.Windows.Forms.Button();
            this.bTopla = new System.Windows.Forms.Button();
            this.b0 = new System.Windows.Forms.Button();
            this.b9 = new System.Windows.Forms.Button();
            this.b8 = new System.Windows.Forms.Button();
            this.b7 = new System.Windows.Forms.Button();
            this.b6 = new System.Windows.Forms.Button();
            this.b5 = new System.Windows.Forms.Button();
            this.b4 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.b1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroContextMenu1
            // 
            //this.metroContextMenu1.Name = "metroContextMenu1";
            //this.metroContextMenu1.Size = new System.Drawing.Size(61, 4);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tSonuc);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.Cyan;
            this.splitContainer1.Panel2.Controls.Add(this.bCikis);
            this.splitContainer1.Panel2.Controls.Add(this.bTumu);
            this.splitContainer1.Panel2.Controls.Add(this.bSil);
            this.splitContainer1.Panel2.Controls.Add(this.bEsittir);
            this.splitContainer1.Panel2.Controls.Add(this.bCarp);
            this.splitContainer1.Panel2.Controls.Add(this.bBol);
            this.splitContainer1.Panel2.Controls.Add(this.bCikar);
            this.splitContainer1.Panel2.Controls.Add(this.bTopla);
            this.splitContainer1.Panel2.Controls.Add(this.b0);
            this.splitContainer1.Panel2.Controls.Add(this.b9);
            this.splitContainer1.Panel2.Controls.Add(this.b8);
            this.splitContainer1.Panel2.Controls.Add(this.b7);
            this.splitContainer1.Panel2.Controls.Add(this.b6);
            this.splitContainer1.Panel2.Controls.Add(this.b5);
            this.splitContainer1.Panel2.Controls.Add(this.b4);
            this.splitContainer1.Panel2.Controls.Add(this.b3);
            this.splitContainer1.Panel2.Controls.Add(this.b2);
            this.splitContainer1.Panel2.Controls.Add(this.b1);
            this.splitContainer1.Size = new System.Drawing.Size(280, 485);
            this.splitContainer1.SplitterDistance = 88;
            this.splitContainer1.TabIndex = 3;
            // 
            // tSonuc
            // 
            this.tSonuc.Font = new System.Drawing.Font("Roboto", 50.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tSonuc.Location = new System.Drawing.Point(3, 3);
            this.tSonuc.Name = "tSonuc";
            this.tSonuc.Size = new System.Drawing.Size(274, 88);
            this.tSonuc.TabIndex = 0;
            this.tSonuc.TextChanged += new System.EventHandler(this.tSonuc_TextChanged);
            // 
            // bTumu
            // 
            this.bTumu.FlatAppearance.BorderSize = 0;
            this.bTumu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bTumu.Font = new System.Drawing.Font("Roboto", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bTumu.Location = new System.Drawing.Point(145, 319);
            this.bTumu.Name = "bTumu";
            this.bTumu.Size = new System.Drawing.Size(130, 65);
            this.bTumu.TabIndex = 16;
            this.bTumu.Text = "Tümünü Sil";
            this.bTumu.UseVisualStyleBackColor = true;
            this.bTumu.Click += new System.EventHandler(this.bTumu_Click);
            // 
            // bCikis
            // 
            this.bCikis.FlatAppearance.BorderSize = 0;
            this.bCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bCikis.Font = new System.Drawing.Font("Roboto", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCikis.Image = global::Calculator.Properties.Resources.exit__door__logout;
            this.bCikis.Location = new System.Drawing.Point(9, 319);
            this.bCikis.Name = "bCikis";
            this.bCikis.Size = new System.Drawing.Size(62, 65);
            this.bCikis.TabIndex = 17;
            this.bCikis.UseVisualStyleBackColor = true;
            this.bCikis.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // bSil
            // 
            this.bSil.FlatAppearance.BorderSize = 0;
            this.bSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSil.Font = new System.Drawing.Font("Roboto", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSil.Image = global::Calculator.Properties.Resources.delete;
            this.bSil.Location = new System.Drawing.Point(213, 38);
            this.bSil.Name = "bSil";
            this.bSil.Size = new System.Drawing.Size(62, 65);
            this.bSil.TabIndex = 15;
            this.bSil.UseVisualStyleBackColor = true;
            this.bSil.Click += new System.EventHandler(this.bSil_Click);
            // 
            // bEsittir
            // 
            this.bEsittir.FlatAppearance.BorderSize = 0;
            this.bEsittir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bEsittir.Font = new System.Drawing.Font("Roboto", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bEsittir.Image = global::Calculator.Properties.Resources.equal_sign_2;
            this.bEsittir.Location = new System.Drawing.Point(213, 251);
            this.bEsittir.Name = "bEsittir";
            this.bEsittir.Size = new System.Drawing.Size(62, 65);
            this.bEsittir.TabIndex = 14;
            this.bEsittir.UseVisualStyleBackColor = true;
            this.bEsittir.Click += new System.EventHandler(this.bEsittir_Click);
            // 
            // bCarp
            // 
            this.bCarp.FlatAppearance.BorderSize = 0;
            this.bCarp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bCarp.Font = new System.Drawing.Font("Roboto", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCarp.Image = global::Calculator.Properties.Resources.multiply_2;
            this.bCarp.Location = new System.Drawing.Point(145, 38);
            this.bCarp.Name = "bCarp";
            this.bCarp.Size = new System.Drawing.Size(62, 65);
            this.bCarp.TabIndex = 13;
            this.bCarp.UseVisualStyleBackColor = true;
            this.bCarp.Click += new System.EventHandler(this.bCarp_Click);
            // 
            // bBol
            // 
            this.bBol.FlatAppearance.BorderSize = 0;
            this.bBol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bBol.Font = new System.Drawing.Font("Roboto", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bBol.Image = global::Calculator.Properties.Resources.divide_2;
            this.bBol.Location = new System.Drawing.Point(77, 38);
            this.bBol.Name = "bBol";
            this.bBol.Size = new System.Drawing.Size(62, 65);
            this.bBol.TabIndex = 12;
            this.bBol.UseVisualStyleBackColor = true;
            this.bBol.Click += new System.EventHandler(this.bBol_Click);
            // 
            // bCikar
            // 
            this.bCikar.FlatAppearance.BorderSize = 0;
            this.bCikar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bCikar.Font = new System.Drawing.Font("Roboto", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCikar.Image = global::Calculator.Properties.Resources.minus_2_math;
            this.bCikar.Location = new System.Drawing.Point(213, 109);
            this.bCikar.Name = "bCikar";
            this.bCikar.Size = new System.Drawing.Size(62, 65);
            this.bCikar.TabIndex = 11;
            this.bCikar.UseVisualStyleBackColor = true;
            this.bCikar.Click += new System.EventHandler(this.bCikar_Click);
            // 
            // bTopla
            // 
            this.bTopla.FlatAppearance.BorderSize = 0;
            this.bTopla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bTopla.Font = new System.Drawing.Font("Roboto", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bTopla.Image = global::Calculator.Properties.Resources.plus_2_math;
            this.bTopla.Location = new System.Drawing.Point(213, 180);
            this.bTopla.Name = "bTopla";
            this.bTopla.Size = new System.Drawing.Size(62, 65);
            this.bTopla.TabIndex = 10;
            this.bTopla.UseVisualStyleBackColor = true;
            this.bTopla.Click += new System.EventHandler(this.bTopla_Click);
            // 
            // b0
            // 
            this.b0.FlatAppearance.BorderSize = 0;
            this.b0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b0.Font = new System.Drawing.Font("Roboto", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b0.Image = global::Calculator.Properties.Resources._0;
            this.b0.Location = new System.Drawing.Point(77, 319);
            this.b0.Name = "b0";
            this.b0.Size = new System.Drawing.Size(62, 65);
            this.b0.TabIndex = 9;
            this.b0.UseVisualStyleBackColor = true;
            this.b0.Click += new System.EventHandler(this.b0_Click);
            // 
            // b9
            // 
            this.b9.FlatAppearance.BorderSize = 0;
            this.b9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b9.Font = new System.Drawing.Font("Roboto", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b9.Image = global::Calculator.Properties.Resources._9;
            this.b9.Location = new System.Drawing.Point(145, 109);
            this.b9.Name = "b9";
            this.b9.Size = new System.Drawing.Size(62, 65);
            this.b9.TabIndex = 8;
            this.b9.UseVisualStyleBackColor = true;
            this.b9.Click += new System.EventHandler(this.b9_Click);
            // 
            // b8
            // 
            this.b8.FlatAppearance.BorderSize = 0;
            this.b8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b8.Font = new System.Drawing.Font("Roboto", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b8.Image = global::Calculator.Properties.Resources._8;
            this.b8.Location = new System.Drawing.Point(77, 109);
            this.b8.Name = "b8";
            this.b8.Size = new System.Drawing.Size(62, 65);
            this.b8.TabIndex = 7;
            this.b8.UseVisualStyleBackColor = true;
            this.b8.Click += new System.EventHandler(this.b8_Click);
            // 
            // b7
            // 
            this.b7.FlatAppearance.BorderSize = 0;
            this.b7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b7.Font = new System.Drawing.Font("Roboto", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b7.Image = global::Calculator.Properties.Resources._7;
            this.b7.Location = new System.Drawing.Point(9, 109);
            this.b7.Name = "b7";
            this.b7.Size = new System.Drawing.Size(62, 65);
            this.b7.TabIndex = 6;
            this.b7.UseVisualStyleBackColor = true;
            this.b7.Click += new System.EventHandler(this.b7_Click);
            // 
            // b6
            // 
            this.b6.FlatAppearance.BorderSize = 0;
            this.b6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b6.Font = new System.Drawing.Font("Roboto", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b6.Image = global::Calculator.Properties.Resources._6;
            this.b6.Location = new System.Drawing.Point(145, 180);
            this.b6.Name = "b6";
            this.b6.Size = new System.Drawing.Size(62, 65);
            this.b6.TabIndex = 5;
            this.b6.UseVisualStyleBackColor = true;
            this.b6.Click += new System.EventHandler(this.b6_Click);
            // 
            // b5
            // 
            this.b5.FlatAppearance.BorderSize = 0;
            this.b5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b5.Font = new System.Drawing.Font("Roboto", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b5.Image = global::Calculator.Properties.Resources._5;
            this.b5.Location = new System.Drawing.Point(77, 180);
            this.b5.Name = "b5";
            this.b5.Size = new System.Drawing.Size(62, 65);
            this.b5.TabIndex = 4;
            this.b5.UseVisualStyleBackColor = true;
            this.b5.Click += new System.EventHandler(this.b5_Click);
            // 
            // b4
            // 
            this.b4.FlatAppearance.BorderSize = 0;
            this.b4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b4.Font = new System.Drawing.Font("Roboto", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b4.Image = global::Calculator.Properties.Resources._4;
            this.b4.Location = new System.Drawing.Point(9, 180);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(62, 65);
            this.b4.TabIndex = 3;
            this.b4.UseVisualStyleBackColor = true;
            this.b4.Click += new System.EventHandler(this.b4_Click);
            // 
            // b3
            // 
            this.b3.FlatAppearance.BorderSize = 0;
            this.b3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b3.Font = new System.Drawing.Font("Roboto", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b3.Image = global::Calculator.Properties.Resources._3;
            this.b3.Location = new System.Drawing.Point(145, 251);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(62, 65);
            this.b3.TabIndex = 2;
            this.b3.UseVisualStyleBackColor = true;
            this.b3.Click += new System.EventHandler(this.button3_Click);
            // 
            // b2
            // 
            this.b2.FlatAppearance.BorderSize = 0;
            this.b2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b2.Font = new System.Drawing.Font("Roboto", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b2.Image = global::Calculator.Properties.Resources._2;
            this.b2.Location = new System.Drawing.Point(77, 251);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(62, 65);
            this.b2.TabIndex = 1;
            this.b2.UseVisualStyleBackColor = true;
            this.b2.Click += new System.EventHandler(this.button2_Click);
            // 
            // b1
            // 
            this.b1.FlatAppearance.BorderSize = 0;
            this.b1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b1.Font = new System.Drawing.Font("Roboto", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b1.Image = global::Calculator.Properties.Resources._1;
            this.b1.Location = new System.Drawing.Point(9, 251);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(62, 65);
            this.b1.TabIndex = 0;
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 485);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hesap Makinesi";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        //private MetroFramework.Controls.MetroContextMenu metroContextMenu1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button b4;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Button bCikar;
        private System.Windows.Forms.Button bTopla;
        private System.Windows.Forms.Button b0;
        private System.Windows.Forms.Button b9;
        private System.Windows.Forms.Button b8;
        private System.Windows.Forms.Button b7;
        private System.Windows.Forms.Button b6;
        private System.Windows.Forms.Button b5;
        private System.Windows.Forms.TextBox tSonuc;
        private System.Windows.Forms.Button bSil;
        private System.Windows.Forms.Button bEsittir;
        private System.Windows.Forms.Button bCarp;
        private System.Windows.Forms.Button bBol;
        private System.Windows.Forms.Button bTumu;
        private System.Windows.Forms.Button bCikis;
    }
}

