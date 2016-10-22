namespace Biblioteca_App
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.cautare = new System.Windows.Forms.Button();
            this.returnare = new System.Windows.Forms.Button();
            this.imprumutare = new System.Windows.Forms.Button();
            this.AfisareListaCarti = new System.Windows.Forms.Button();
            this.iesire = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(-143, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(764, 127);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(32, 145);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 60);
            this.button1.TabIndex = 1;
            this.button1.Text = "Adaugare \rCarte";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cautare
            // 
            this.cautare.Location = new System.Drawing.Point(172, 145);
            this.cautare.Name = "cautare";
            this.cautare.Size = new System.Drawing.Size(135, 60);
            this.cautare.TabIndex = 2;
            this.cautare.Text = "Cautare \rCarte";
            this.cautare.UseVisualStyleBackColor = true;
            this.cautare.Click += new System.EventHandler(this.cautare_Click);
            // 
            // returnare
            // 
            this.returnare.Location = new System.Drawing.Point(313, 145);
            this.returnare.Name = "returnare";
            this.returnare.Size = new System.Drawing.Size(134, 60);
            this.returnare.TabIndex = 3;
            this.returnare.Text = "Returnare \r\nCarte";
            this.returnare.UseVisualStyleBackColor = true;
            this.returnare.Click += new System.EventHandler(this.returnare_Click);
            // 
            // imprumutare
            // 
            this.imprumutare.Location = new System.Drawing.Point(32, 234);
            this.imprumutare.Name = "imprumutare";
            this.imprumutare.Size = new System.Drawing.Size(134, 60);
            this.imprumutare.TabIndex = 4;
            this.imprumutare.Text = "Imprumutare\r\nCarte";
            this.imprumutare.UseVisualStyleBackColor = true;
            this.imprumutare.Click += new System.EventHandler(this.imprumutare_Click);
            // 
            // AfisareListaCarti
            // 
            this.AfisareListaCarti.Location = new System.Drawing.Point(173, 234);
            this.AfisareListaCarti.Name = "AfisareListaCarti";
            this.AfisareListaCarti.Size = new System.Drawing.Size(134, 60);
            this.AfisareListaCarti.TabIndex = 5;
            this.AfisareListaCarti.Text = "Afisare Lista\r\nCarti";
            this.AfisareListaCarti.UseVisualStyleBackColor = true;
            this.AfisareListaCarti.Click += new System.EventHandler(this.AfisareListaCarti_Click);
            // 
            // iesire
            // 
            this.iesire.Location = new System.Drawing.Point(313, 234);
            this.iesire.Name = "iesire";
            this.iesire.Size = new System.Drawing.Size(134, 60);
            this.iesire.TabIndex = 6;
            this.iesire.Text = "Iesire";
            this.iesire.UseVisualStyleBackColor = true;
            this.iesire.Click += new System.EventHandler(this.iesire_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(32, 211);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(411, 17);
            this.panel2.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(480, 306);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.iesire);
            this.Controls.Add(this.AfisareListaCarti);
            this.Controls.Add(this.imprumutare);
            this.Controls.Add(this.returnare);
            this.Controls.Add(this.cautare);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button cautare;
        private System.Windows.Forms.Button returnare;
        private System.Windows.Forms.Button imprumutare;
        private System.Windows.Forms.Button AfisareListaCarti;
        private System.Windows.Forms.Button iesire;
        private System.Windows.Forms.Panel panel2;
    }
}

