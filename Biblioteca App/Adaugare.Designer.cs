namespace Biblioteca_App
{
    partial class Adaugare
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
            this.isbn = new System.Windows.Forms.Label();
            this.numele = new System.Windows.Forms.Label();
            this.autorul = new System.Windows.Forms.Label();
            this.editura = new System.Windows.Forms.Label();
            this.isbnText = new System.Windows.Forms.TextBox();
            this.numeleText = new System.Windows.Forms.TextBox();
            this.autorulText = new System.Windows.Forms.TextBox();
            this.edituraText = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // isbn
            // 
            this.isbn.AutoSize = true;
            this.isbn.Location = new System.Drawing.Point(29, 32);
            this.isbn.Name = "isbn";
            this.isbn.Size = new System.Drawing.Size(35, 13);
            this.isbn.TabIndex = 0;
            this.isbn.Text = "ISBN:";
            // 
            // numele
            // 
            this.numele.AutoSize = true;
            this.numele.Location = new System.Drawing.Point(29, 55);
            this.numele.Name = "numele";
            this.numele.Size = new System.Drawing.Size(46, 13);
            this.numele.TabIndex = 1;
            this.numele.Text = "Numele:";
            // 
            // autorul
            // 
            this.autorul.AutoSize = true;
            this.autorul.Location = new System.Drawing.Point(29, 78);
            this.autorul.Name = "autorul";
            this.autorul.Size = new System.Drawing.Size(43, 13);
            this.autorul.TabIndex = 2;
            this.autorul.Text = "Autorul:";
            // 
            // editura
            // 
            this.editura.AutoSize = true;
            this.editura.Location = new System.Drawing.Point(29, 101);
            this.editura.Name = "editura";
            this.editura.Size = new System.Drawing.Size(43, 13);
            this.editura.TabIndex = 3;
            this.editura.Text = "Editura:";
            // 
            // isbnText
            // 
            this.isbnText.Location = new System.Drawing.Point(81, 25);
            this.isbnText.Name = "isbnText";
            this.isbnText.Size = new System.Drawing.Size(100, 20);
            this.isbnText.TabIndex = 4;
            this.isbnText.TextChanged += new System.EventHandler(this.isbnText_TextChanged);
            // 
            // numeleText
            // 
            this.numeleText.Location = new System.Drawing.Point(81, 48);
            this.numeleText.Name = "numeleText";
            this.numeleText.Size = new System.Drawing.Size(100, 20);
            this.numeleText.TabIndex = 5;
            this.numeleText.TextChanged += new System.EventHandler(this.numeleText_TextChanged);
            // 
            // autorulText
            // 
            this.autorulText.Location = new System.Drawing.Point(81, 71);
            this.autorulText.Name = "autorulText";
            this.autorulText.Size = new System.Drawing.Size(100, 20);
            this.autorulText.TabIndex = 6;
            this.autorulText.TextChanged += new System.EventHandler(this.autorulText_TextChanged);
            // 
            // edituraText
            // 
            this.edituraText.Location = new System.Drawing.Point(81, 94);
            this.edituraText.Name = "edituraText";
            this.edituraText.Size = new System.Drawing.Size(100, 20);
            this.edituraText.TabIndex = 7;
            this.edituraText.TextChanged += new System.EventHandler(this.edituraText_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(32, 130);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 32);
            this.button1.TabIndex = 8;
            this.button1.Text = "Adaugare\r\n";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Va rugam introduceti o carte:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(129, 130);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 32);
            this.button2.TabIndex = 12;
            this.button2.Text = "Iesire";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(32, 168);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(188, 29);
            this.button3.TabIndex = 13;
            this.button3.Text = "Revenire la meniul principal";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Adaugare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 208);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.edituraText);
            this.Controls.Add(this.autorulText);
            this.Controls.Add(this.numeleText);
            this.Controls.Add(this.isbnText);
            this.Controls.Add(this.editura);
            this.Controls.Add(this.autorul);
            this.Controls.Add(this.numele);
            this.Controls.Add(this.isbn);
            this.Name = "Adaugare";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Afisare";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label isbn;
        private System.Windows.Forms.Label numele;
        private System.Windows.Forms.Label autorul;
        private System.Windows.Forms.Label editura;
        private System.Windows.Forms.TextBox isbnText;
        private System.Windows.Forms.TextBox numeleText;
        private System.Windows.Forms.TextBox autorulText;
        private System.Windows.Forms.TextBox edituraText;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}