namespace Inventura
{
    partial class PregledInventure
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
            this.IzpisButton_Inventura = new System.Windows.Forms.Button();
            this.SpremeniButton_inventura = new System.Windows.Forms.Button();
            this.DodajButton_Inventura = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // IzpisButton_Inventura
            // 
            this.IzpisButton_Inventura.Location = new System.Drawing.Point(78, 44);
            this.IzpisButton_Inventura.Name = "IzpisButton_Inventura";
            this.IzpisButton_Inventura.Size = new System.Drawing.Size(75, 23);
            this.IzpisButton_Inventura.TabIndex = 0;
            this.IzpisButton_Inventura.Text = "Izpis";
            this.IzpisButton_Inventura.UseVisualStyleBackColor = true;
            this.IzpisButton_Inventura.Click += new System.EventHandler(this.IzpisButton_Inventura_Click);
            // 
            // SpremeniButton_inventura
            // 
            this.SpremeniButton_inventura.Location = new System.Drawing.Point(78, 102);
            this.SpremeniButton_inventura.Name = "SpremeniButton_inventura";
            this.SpremeniButton_inventura.Size = new System.Drawing.Size(75, 23);
            this.SpremeniButton_inventura.TabIndex = 2;
            this.SpremeniButton_inventura.Text = "Spremeni";
            this.SpremeniButton_inventura.UseVisualStyleBackColor = true;
            this.SpremeniButton_inventura.Click += new System.EventHandler(this.SpremeniButton_inventura_Click);
            // 
            // DodajButton_Inventura
            // 
            this.DodajButton_Inventura.Location = new System.Drawing.Point(78, 73);
            this.DodajButton_Inventura.Name = "DodajButton_Inventura";
            this.DodajButton_Inventura.Size = new System.Drawing.Size(75, 23);
            this.DodajButton_Inventura.TabIndex = 3;
            this.DodajButton_Inventura.Text = "Dodaj";
            this.DodajButton_Inventura.UseVisualStyleBackColor = true;
            this.DodajButton_Inventura.Click += new System.EventHandler(this.DodajButton_Inventura_Click);
            // 
            // PregledInventure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 178);
            this.Controls.Add(this.DodajButton_Inventura);
            this.Controls.Add(this.SpremeniButton_inventura);
            this.Controls.Add(this.IzpisButton_Inventura);
            this.Name = "PregledInventure";
            this.Text = "PregledInventure";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button IzpisButton_Inventura;
        
        private System.Windows.Forms.Button SpremeniButton_inventura;
        private System.Windows.Forms.Button DodajButton_Inventura;
    }
}