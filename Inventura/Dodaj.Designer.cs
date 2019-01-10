namespace Inventura
{
    partial class Dodaj
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NazivIzdelkaTextBox = new System.Windows.Forms.TextBox();
            this.CenaIzdelkaTextBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DodajIzdelekButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.IdIzdelkaTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Naziv izdelka:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(418, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cena izdelka:";
            // 
            // NazivIzdelkaTextBox
            // 
            this.NazivIzdelkaTextBox.Location = new System.Drawing.Point(165, 22);
            this.NazivIzdelkaTextBox.Name = "NazivIzdelkaTextBox";
            this.NazivIzdelkaTextBox.Size = new System.Drawing.Size(247, 20);
            this.NazivIzdelkaTextBox.TabIndex = 2;
            // 
            // CenaIzdelkaTextBox
            // 
            this.CenaIzdelkaTextBox.Location = new System.Drawing.Point(567, 22);
            this.CenaIzdelkaTextBox.Name = "CenaIzdelkaTextBox";
            this.CenaIzdelkaTextBox.Size = new System.Drawing.Size(116, 20);
            this.CenaIzdelkaTextBox.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Programska oprema",
            "Računalnik",
            "Monitor",
            "Hardware"});
            this.comboBox1.Location = new System.Drawing.Point(526, 82);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(144, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(405, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Kategorija:";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // DodajIzdelekButton
            // 
            this.DodajIzdelekButton.Location = new System.Drawing.Point(688, 98);
            this.DodajIzdelekButton.Name = "DodajIzdelekButton";
            this.DodajIzdelekButton.Size = new System.Drawing.Size(75, 23);
            this.DodajIzdelekButton.TabIndex = 4;
            this.DodajIzdelekButton.Text = "Dodaj";
            this.DodajIzdelekButton.UseVisualStyleBackColor = true;
            this.DodajIzdelekButton.Click += new System.EventHandler(this.DodajIzdelekButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(12, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "ID izdelka:";
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // IdIzdelkaTextBox
            // 
            this.IdIzdelkaTextBox.Location = new System.Drawing.Point(131, 82);
            this.IdIzdelkaTextBox.Name = "IdIzdelkaTextBox";
            this.IdIzdelkaTextBox.Size = new System.Drawing.Size(100, 20);
            this.IdIzdelkaTextBox.TabIndex = 5;
            // 
            // Dodaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 133);
            this.Controls.Add(this.IdIzdelkaTextBox);
            this.Controls.Add(this.DodajIzdelekButton);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.CenaIzdelkaTextBox);
            this.Controls.Add(this.NazivIzdelkaTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "Dodaj";
            this.Text = "Dodaj";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NazivIzdelkaTextBox;
        private System.Windows.Forms.TextBox CenaIzdelkaTextBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button DodajIzdelekButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox IdIzdelkaTextBox;
    }
}