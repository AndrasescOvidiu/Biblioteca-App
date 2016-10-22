namespace Biblioteca_App
{
    partial class Returnare
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.returnareCarte = new System.Windows.Forms.Button();
            this.iesire = new System.Windows.Forms.Button();
            this.revenireMeniu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Va rugam selectati persoana din lista:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 25);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(272, 134);
            this.listBox1.TabIndex = 1;
            // 
            // returnareCarte
            // 
            this.returnareCarte.Location = new System.Drawing.Point(13, 165);
            this.returnareCarte.Name = "returnareCarte";
            this.returnareCarte.Size = new System.Drawing.Size(133, 33);
            this.returnareCarte.TabIndex = 2;
            this.returnareCarte.Text = "Returnare";
            this.returnareCarte.UseVisualStyleBackColor = true;
            this.returnareCarte.Click += new System.EventHandler(this.returnareCarte_Click);
            // 
            // iesire
            // 
            this.iesire.Location = new System.Drawing.Point(151, 165);
            this.iesire.Name = "iesire";
            this.iesire.Size = new System.Drawing.Size(133, 33);
            this.iesire.TabIndex = 3;
            this.iesire.Text = "Iesire";
            this.iesire.UseVisualStyleBackColor = true;
            this.iesire.Click += new System.EventHandler(this.iesire_Click);
            // 
            // revenireMeniu
            // 
            this.revenireMeniu.Location = new System.Drawing.Point(13, 205);
            this.revenireMeniu.Name = "revenireMeniu";
            this.revenireMeniu.Size = new System.Drawing.Size(271, 34);
            this.revenireMeniu.TabIndex = 4;
            this.revenireMeniu.Text = "Revenire la meniul principal";
            this.revenireMeniu.UseVisualStyleBackColor = true;
            this.revenireMeniu.Click += new System.EventHandler(this.revenireMeniu_Click);
            // 
            // Returnare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 249);
            this.Controls.Add(this.revenireMeniu);
            this.Controls.Add(this.iesire);
            this.Controls.Add(this.returnareCarte);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Name = "Returnare";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Returnare";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button returnareCarte;
        private System.Windows.Forms.Button iesire;
        private System.Windows.Forms.Button revenireMeniu;
    }
}