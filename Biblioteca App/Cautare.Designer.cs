namespace Biblioteca_App
{
    partial class Cautare
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.afisareListaCarti = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.imprumutare = new System.Windows.Forms.Button();
            this.returnare = new System.Windows.Forms.Button();
            this.iesire = new System.Windows.Forms.Button();
            this.revenire = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(16, 77);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(268, 147);
            this.listBox1.TabIndex = 0;
            // 
            // afisareListaCarti
            // 
            this.afisareListaCarti.Location = new System.Drawing.Point(16, 48);
            this.afisareListaCarti.Name = "afisareListaCarti";
            this.afisareListaCarti.Size = new System.Drawing.Size(268, 23);
            this.afisareListaCarti.TabIndex = 1;
            this.afisareListaCarti.Text = "Afisare Lista Carti";
            this.afisareListaCarti.UseVisualStyleBackColor = true;
            this.afisareListaCarti.Click += new System.EventHandler(this.afisareListaCarti_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Selectati o metoda de sortare:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "NUME",
            "ISBN",
            "AUTOR",
            "EDITURA"});
            this.comboBox1.Location = new System.Drawing.Point(167, 21);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(117, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.Text = "NUME";
            // 
            // imprumutare
            // 
            this.imprumutare.Location = new System.Drawing.Point(16, 230);
            this.imprumutare.Name = "imprumutare";
            this.imprumutare.Size = new System.Drawing.Size(85, 31);
            this.imprumutare.TabIndex = 4;
            this.imprumutare.Text = "Imprumutare\r";
            this.imprumutare.UseVisualStyleBackColor = true;
            this.imprumutare.Click += new System.EventHandler(this.imprumutare_Click);
            // 
            // returnare
            // 
            this.returnare.Location = new System.Drawing.Point(107, 230);
            this.returnare.Name = "returnare";
            this.returnare.Size = new System.Drawing.Size(85, 31);
            this.returnare.TabIndex = 5;
            this.returnare.Text = "Returnare";
            this.returnare.UseVisualStyleBackColor = true;
            this.returnare.Click += new System.EventHandler(this.returnare_Click);
            // 
            // iesire
            // 
            this.iesire.Location = new System.Drawing.Point(198, 230);
            this.iesire.Name = "iesire";
            this.iesire.Size = new System.Drawing.Size(86, 31);
            this.iesire.TabIndex = 6;
            this.iesire.Text = "Iesire";
            this.iesire.UseVisualStyleBackColor = true;
            this.iesire.Click += new System.EventHandler(this.iesire_Click);
            // 
            // revenire
            // 
            this.revenire.Location = new System.Drawing.Point(16, 268);
            this.revenire.Name = "revenire";
            this.revenire.Size = new System.Drawing.Size(268, 30);
            this.revenire.TabIndex = 7;
            this.revenire.Text = "Revenire la meniul principal";
            this.revenire.UseVisualStyleBackColor = true;
            this.revenire.Click += new System.EventHandler(this.revenire_Click);
            // 
            // Cautare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 310);
            this.Controls.Add(this.revenire);
            this.Controls.Add(this.iesire);
            this.Controls.Add(this.returnare);
            this.Controls.Add(this.imprumutare);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.afisareListaCarti);
            this.Controls.Add(this.listBox1);
            this.Name = "Cautare";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cautare";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button afisareListaCarti;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button imprumutare;
        private System.Windows.Forms.Button returnare;
        private System.Windows.Forms.Button iesire;
        private System.Windows.Forms.Button revenire;
    }
}