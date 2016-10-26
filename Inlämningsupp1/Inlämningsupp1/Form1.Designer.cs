namespace Inlämningsupp1
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
            this.label2 = new System.Windows.Forms.Label();
            this.lblLine = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAvbryt = new System.Windows.Forms.Button();
            this.lstboxPersoner = new System.Windows.Forms.ListBox();
            this.btTaBortKontakt = new System.Windows.Forms.Button();
            this.btSparaAndringar = new System.Windows.Forms.Button();
            this.btNyKontakt = new System.Windows.Forms.Button();
            this.txtSök = new System.Windows.Forms.TextBox();
            this.lblEpost = new System.Windows.Forms.Label();
            this.lblTelenr = new System.Windows.Forms.Label();
            this.lblpostort = new System.Windows.Forms.Label();
            this.lblPostnr = new System.Windows.Forms.Label();
            this.lblGatuadr = new System.Windows.Forms.Label();
            this.lblNamn = new System.Windows.Forms.Label();
            this.txtEpost = new System.Windows.Forms.TextBox();
            this.txtTelenr = new System.Windows.Forms.TextBox();
            this.txtPostort = new System.Windows.Forms.TextBox();
            this.txtPostnr = new System.Windows.Forms.TextBox();
            this.txtGatuadr = new System.Windows.Forms.TextBox();
            this.txtNamn = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(226, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(2, 260);
            this.label2.TabIndex = 59;
            // 
            // lblLine
            // 
            this.lblLine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLine.Location = new System.Drawing.Point(12, 291);
            this.lblLine.Name = "lblLine";
            this.lblLine.Size = new System.Drawing.Size(560, 2);
            this.lblLine.TabIndex = 58;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 17);
            this.label1.TabIndex = 57;
            this.label1.Text = "Sök via namn/postort";
            // 
            // txtAvbryt
            // 
            this.txtAvbryt.Location = new System.Drawing.Point(435, 305);
            this.txtAvbryt.Margin = new System.Windows.Forms.Padding(4);
            this.txtAvbryt.Name = "txtAvbryt";
            this.txtAvbryt.Size = new System.Drawing.Size(127, 33);
            this.txtAvbryt.TabIndex = 56;
            this.txtAvbryt.Text = "Avbryt";
            this.txtAvbryt.UseVisualStyleBackColor = true;
            this.txtAvbryt.Click += new System.EventHandler(this.txtAvbryt_Click);
            // 
            // lstboxPersoner
            // 
            this.lstboxPersoner.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstboxPersoner.FormattingEnabled = true;
            this.lstboxPersoner.ItemHeight = 18;
            this.lstboxPersoner.Location = new System.Drawing.Point(12, 64);
            this.lstboxPersoner.Name = "lstboxPersoner";
            this.lstboxPersoner.Size = new System.Drawing.Size(200, 220);
            this.lstboxPersoner.TabIndex = 55;
            this.lstboxPersoner.SelectedIndexChanged += new System.EventHandler(this.lstboxPersoner_SelectedIndexChanged);
            // 
            // btTaBortKontakt
            // 
            this.btTaBortKontakt.Location = new System.Drawing.Point(31, 305);
            this.btTaBortKontakt.Margin = new System.Windows.Forms.Padding(4);
            this.btTaBortKontakt.Name = "btTaBortKontakt";
            this.btTaBortKontakt.Size = new System.Drawing.Size(127, 33);
            this.btTaBortKontakt.TabIndex = 54;
            this.btTaBortKontakt.Text = "Ta Bort";
            this.btTaBortKontakt.UseVisualStyleBackColor = true;
            this.btTaBortKontakt.Click += new System.EventHandler(this.btTaBortKontakt_Click);
            // 
            // btSparaAndringar
            // 
            this.btSparaAndringar.Location = new System.Drawing.Point(165, 305);
            this.btSparaAndringar.Margin = new System.Windows.Forms.Padding(4);
            this.btSparaAndringar.Name = "btSparaAndringar";
            this.btSparaAndringar.Size = new System.Drawing.Size(127, 33);
            this.btSparaAndringar.TabIndex = 53;
            this.btSparaAndringar.Text = "Uppdatera";
            this.btSparaAndringar.UseVisualStyleBackColor = true;
            this.btSparaAndringar.Click += new System.EventHandler(this.btSparaAndringar_Click);
            // 
            // btNyKontakt
            // 
            this.btNyKontakt.Location = new System.Drawing.Point(300, 305);
            this.btNyKontakt.Margin = new System.Windows.Forms.Padding(4);
            this.btNyKontakt.Name = "btNyKontakt";
            this.btNyKontakt.Size = new System.Drawing.Size(127, 33);
            this.btNyKontakt.TabIndex = 52;
            this.btNyKontakt.Text = "Ny";
            this.btNyKontakt.UseVisualStyleBackColor = true;
            this.btNyKontakt.Click += new System.EventHandler(this.btNyKontakt_Click);
            // 
            // txtSök
            // 
            this.txtSök.Location = new System.Drawing.Point(12, 32);
            this.txtSök.Margin = new System.Windows.Forms.Padding(4);
            this.txtSök.Name = "txtSök";
            this.txtSök.Size = new System.Drawing.Size(200, 22);
            this.txtSök.TabIndex = 51;
            this.txtSök.TextChanged += new System.EventHandler(this.txtSök_TextChanged);
            // 
            // lblEpost
            // 
            this.lblEpost.AutoSize = true;
            this.lblEpost.Location = new System.Drawing.Point(235, 228);
            this.lblEpost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEpost.Name = "lblEpost";
            this.lblEpost.Size = new System.Drawing.Size(44, 17);
            this.lblEpost.TabIndex = 50;
            this.lblEpost.Text = "Epost";
            // 
            // lblTelenr
            // 
            this.lblTelenr.AutoSize = true;
            this.lblTelenr.Location = new System.Drawing.Point(235, 196);
            this.lblTelenr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelenr.Name = "lblTelenr";
            this.lblTelenr.Size = new System.Drawing.Size(69, 17);
            this.lblTelenr.TabIndex = 49;
            this.lblTelenr.Text = "Telefonnr";
            // 
            // lblpostort
            // 
            this.lblpostort.AutoSize = true;
            this.lblpostort.Location = new System.Drawing.Point(235, 164);
            this.lblpostort.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblpostort.Name = "lblpostort";
            this.lblpostort.Size = new System.Drawing.Size(53, 17);
            this.lblpostort.TabIndex = 48;
            this.lblpostort.Text = "Postort";
            // 
            // lblPostnr
            // 
            this.lblPostnr.AutoSize = true;
            this.lblPostnr.Location = new System.Drawing.Point(235, 132);
            this.lblPostnr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPostnr.Name = "lblPostnr";
            this.lblPostnr.Size = new System.Drawing.Size(87, 17);
            this.lblPostnr.TabIndex = 47;
            this.lblPostnr.Text = "Postnummer";
            // 
            // lblGatuadr
            // 
            this.lblGatuadr.AutoSize = true;
            this.lblGatuadr.Location = new System.Drawing.Point(235, 100);
            this.lblGatuadr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGatuadr.Name = "lblGatuadr";
            this.lblGatuadr.Size = new System.Drawing.Size(82, 17);
            this.lblGatuadr.TabIndex = 46;
            this.lblGatuadr.Text = "Gatuadress";
            // 
            // lblNamn
            // 
            this.lblNamn.AutoSize = true;
            this.lblNamn.Location = new System.Drawing.Point(235, 68);
            this.lblNamn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNamn.Name = "lblNamn";
            this.lblNamn.Size = new System.Drawing.Size(45, 17);
            this.lblNamn.TabIndex = 45;
            this.lblNamn.Text = "Namn";
            // 
            // txtEpost
            // 
            this.txtEpost.Location = new System.Drawing.Point(327, 225);
            this.txtEpost.Margin = new System.Windows.Forms.Padding(4);
            this.txtEpost.Name = "txtEpost";
            this.txtEpost.Size = new System.Drawing.Size(235, 22);
            this.txtEpost.TabIndex = 44;
            // 
            // txtTelenr
            // 
            this.txtTelenr.Location = new System.Drawing.Point(327, 193);
            this.txtTelenr.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelenr.Name = "txtTelenr";
            this.txtTelenr.Size = new System.Drawing.Size(235, 22);
            this.txtTelenr.TabIndex = 43;
            // 
            // txtPostort
            // 
            this.txtPostort.Location = new System.Drawing.Point(327, 161);
            this.txtPostort.Margin = new System.Windows.Forms.Padding(4);
            this.txtPostort.Name = "txtPostort";
            this.txtPostort.Size = new System.Drawing.Size(235, 22);
            this.txtPostort.TabIndex = 42;
            // 
            // txtPostnr
            // 
            this.txtPostnr.Location = new System.Drawing.Point(327, 129);
            this.txtPostnr.Margin = new System.Windows.Forms.Padding(4);
            this.txtPostnr.Name = "txtPostnr";
            this.txtPostnr.Size = new System.Drawing.Size(235, 22);
            this.txtPostnr.TabIndex = 41;
            // 
            // txtGatuadr
            // 
            this.txtGatuadr.Location = new System.Drawing.Point(327, 97);
            this.txtGatuadr.Margin = new System.Windows.Forms.Padding(4);
            this.txtGatuadr.Name = "txtGatuadr";
            this.txtGatuadr.Size = new System.Drawing.Size(235, 22);
            this.txtGatuadr.TabIndex = 40;
            // 
            // txtNamn
            // 
            this.txtNamn.Location = new System.Drawing.Point(327, 65);
            this.txtNamn.Margin = new System.Windows.Forms.Padding(4);
            this.txtNamn.Name = "txtNamn";
            this.txtNamn.Size = new System.Drawing.Size(235, 22);
            this.txtNamn.TabIndex = 39;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(327, 255);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(117, 22);
            this.dateTimePicker1.TabIndex = 60;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(236, 260);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 61;
            this.label3.Text = "Födelsedag";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 351);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblLine);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAvbryt);
            this.Controls.Add(this.lstboxPersoner);
            this.Controls.Add(this.btTaBortKontakt);
            this.Controls.Add(this.btSparaAndringar);
            this.Controls.Add(this.btNyKontakt);
            this.Controls.Add(this.txtSök);
            this.Controls.Add(this.lblEpost);
            this.Controls.Add(this.lblTelenr);
            this.Controls.Add(this.lblpostort);
            this.Controls.Add(this.lblPostnr);
            this.Controls.Add(this.lblGatuadr);
            this.Controls.Add(this.lblNamn);
            this.Controls.Add(this.txtEpost);
            this.Controls.Add(this.txtTelenr);
            this.Controls.Add(this.txtPostort);
            this.Controls.Add(this.txtPostnr);
            this.Controls.Add(this.txtGatuadr);
            this.Controls.Add(this.txtNamn);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblLine;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button txtAvbryt;
        private System.Windows.Forms.ListBox lstboxPersoner;
        private System.Windows.Forms.Button btTaBortKontakt;
        private System.Windows.Forms.Button btSparaAndringar;
        private System.Windows.Forms.Button btNyKontakt;
        private System.Windows.Forms.TextBox txtSök;
        private System.Windows.Forms.Label lblEpost;
        private System.Windows.Forms.Label lblTelenr;
        private System.Windows.Forms.Label lblpostort;
        private System.Windows.Forms.Label lblPostnr;
        private System.Windows.Forms.Label lblGatuadr;
        private System.Windows.Forms.Label lblNamn;
        private System.Windows.Forms.TextBox txtEpost;
        private System.Windows.Forms.TextBox txtTelenr;
        private System.Windows.Forms.TextBox txtPostort;
        private System.Windows.Forms.TextBox txtPostnr;
        private System.Windows.Forms.TextBox txtGatuadr;
        private System.Windows.Forms.TextBox txtNamn;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
    }
}

