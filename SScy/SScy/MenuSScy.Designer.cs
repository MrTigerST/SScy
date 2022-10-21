namespace SScy
{
    partial class MenuSScy
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.id_txbx = new System.Windows.Forms.TextBox();
            this.codice = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.selectLanguage = new System.Windows.Forms.ComboBox();
            this.codesscytext = new System.Windows.Forms.Label();
            this.infotext1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(316, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "MENU";
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button1.Location = new System.Drawing.Point(224, 257);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(294, 28);
            this.button1.TabIndex = 1;
            this.button1.Text = "REQUEST CONNECTION";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(-253, 72);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(1499, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "_________________________________________________________________________________" +
    "__________________";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(354, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "SSCY";
            // 
            // id_txbx
            // 
            this.id_txbx.Location = new System.Drawing.Point(224, 181);
            this.id_txbx.Name = "id_txbx";
            this.id_txbx.Size = new System.Drawing.Size(302, 20);
            this.id_txbx.TabIndex = 4;
            // 
            // codice
            // 
            this.codice.AutoSize = true;
            this.codice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codice.ForeColor = System.Drawing.Color.Yellow;
            this.codice.Location = new System.Drawing.Point(319, 400);
            this.codice.Name = "codice";
            this.codice.Size = new System.Drawing.Size(138, 24);
            this.codice.TabIndex = 5;
            this.codice.Text = "000000-00000";
            this.codice.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label5.Location = new System.Drawing.Point(339, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 24);
            this.label5.TabIndex = 3;
            this.label5.Text = "SScy";
            // 
            // selectLanguage
            // 
            this.selectLanguage.DisplayMember = "ftg";
            this.selectLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectLanguage.FormattingEnabled = true;
            this.selectLanguage.Items.AddRange(new object[] {
            "ENGLISH",
            "ITALIAN"});
            this.selectLanguage.Location = new System.Drawing.Point(676, 9);
            this.selectLanguage.Name = "selectLanguage";
            this.selectLanguage.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.selectLanguage.Size = new System.Drawing.Size(112, 21);
            this.selectLanguage.TabIndex = 6;
            this.selectLanguage.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // codesscytext
            // 
            this.codesscytext.AutoSize = true;
            this.codesscytext.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codesscytext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.codesscytext.Location = new System.Drawing.Point(320, 365);
            this.codesscytext.Name = "codesscytext";
            this.codesscytext.Size = new System.Drawing.Size(108, 16);
            this.codesscytext.TabIndex = 7;
            this.codesscytext.Text = "Your SScy code:";
            // 
            // infotext1
            // 
            this.infotext1.AutoSize = true;
            this.infotext1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infotext1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.infotext1.Location = new System.Drawing.Point(191, 443);
            this.infotext1.Name = "infotext1";
            this.infotext1.Size = new System.Drawing.Size(394, 15);
            this.infotext1.TabIndex = 8;
            this.infotext1.Text = "This code allows other users to connect to you to perform HACK checks!";
            // 
            // MenuSScy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(800, 467);
            this.Controls.Add(this.infotext1);
            this.Controls.Add(this.codesscytext);
            this.Controls.Add(this.selectLanguage);
            this.Controls.Add(this.codice);
            this.Controls.Add(this.id_txbx);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MenuSScy";
            this.Text = "SScy";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox id_txbx;
        private System.Windows.Forms.Label codice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox selectLanguage;
        private System.Windows.Forms.Label codesscytext;
        private System.Windows.Forms.Label infotext1;
    }
}

