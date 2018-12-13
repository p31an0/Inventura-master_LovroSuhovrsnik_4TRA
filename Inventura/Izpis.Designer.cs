namespace Inventura
{
    partial class Izpis
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kategorija_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemIDtextBox = new System.Windows.Forms.TextBox();
            this.ItemNametextBox = new System.Windows.Forms.TextBox();
            this.PricetextBox = new System.Windows.Forms.TextBox();
            this.KategorijaTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.UpdateIzpis_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemID,
            this.ItemName,
            this.Price,
            this.kategorija_id});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(444, 426);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // ItemID
            // 
            this.ItemID.HeaderText = "ItemID";
            this.ItemID.Name = "ItemID";
            // 
            // ItemName
            // 
            this.ItemName.HeaderText = "ItemName";
            this.ItemName.Name = "ItemName";
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            // 
            // kategorija_id
            // 
            this.kategorija_id.HeaderText = "kategorija_id";
            this.kategorija_id.Name = "kategorija_id";
            // 
            // ItemIDtextBox
            // 
            this.ItemIDtextBox.Location = new System.Drawing.Point(556, 58);
            this.ItemIDtextBox.Name = "ItemIDtextBox";
            this.ItemIDtextBox.Size = new System.Drawing.Size(170, 20);
            this.ItemIDtextBox.TabIndex = 1;
            // 
            // ItemNametextBox
            // 
            this.ItemNametextBox.Location = new System.Drawing.Point(556, 84);
            this.ItemNametextBox.Name = "ItemNametextBox";
            this.ItemNametextBox.Size = new System.Drawing.Size(170, 20);
            this.ItemNametextBox.TabIndex = 1;
            // 
            // PricetextBox
            // 
            this.PricetextBox.Location = new System.Drawing.Point(556, 110);
            this.PricetextBox.Name = "PricetextBox";
            this.PricetextBox.Size = new System.Drawing.Size(170, 20);
            this.PricetextBox.TabIndex = 1;
            // 
            // KategorijaTextBox
            // 
            this.KategorijaTextBox.Location = new System.Drawing.Point(556, 136);
            this.KategorijaTextBox.Name = "KategorijaTextBox";
            this.KategorijaTextBox.Size = new System.Drawing.Size(170, 20);
            this.KategorijaTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(515, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "ItemID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(498, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "ItemName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(522, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(485, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Kategorija_id";
            // 
            // UpdateIzpis_button
            // 
            this.UpdateIzpis_button.Location = new System.Drawing.Point(556, 162);
            this.UpdateIzpis_button.Name = "UpdateIzpis_button";
            this.UpdateIzpis_button.Size = new System.Drawing.Size(75, 23);
            this.UpdateIzpis_button.TabIndex = 4;
            this.UpdateIzpis_button.Text = "Posodobi";
            this.UpdateIzpis_button.UseVisualStyleBackColor = true;
            this.UpdateIzpis_button.Click += new System.EventHandler(this.UpdateIzpis_button_Click);
            // 
            // Izpis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UpdateIzpis_button);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.KategorijaTextBox);
            this.Controls.Add(this.PricetextBox);
            this.Controls.Add(this.ItemNametextBox);
            this.Controls.Add(this.ItemIDtextBox);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Izpis";
            this.Text = "Izpis";
            this.Load += new System.EventHandler(this.Izpis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn kategorija_id;
        private System.Windows.Forms.TextBox ItemIDtextBox;
        private System.Windows.Forms.TextBox ItemNametextBox;
        private System.Windows.Forms.TextBox PricetextBox;
        private System.Windows.Forms.TextBox KategorijaTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button UpdateIzpis_button;
    }
}