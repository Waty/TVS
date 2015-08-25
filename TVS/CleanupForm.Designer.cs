namespace TVS
{
    /// <summary>
    /// 
    /// </summary>
    partial class CleanupForm
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
            this.btnLoguit = new System.Windows.Forms.Button();
            this.lbSchoonmaak = new System.Windows.Forms.ListBox();
            this.btnSchoonmaakLijst = new System.Windows.Forms.Button();
            this.dtSchoonmaak = new System.Windows.Forms.DateTimePicker();
            this.btnSchoonmaak = new System.Windows.Forms.Button();
            this.tbSchoonmaak = new System.Windows.Forms.TextBox();
            this.lbDatum = new System.Windows.Forms.Label();
            this.lbSchoonmaker = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLoguit
            // 
            this.btnLoguit.Location = new System.Drawing.Point(533, 10);
            this.btnLoguit.Name = "btnLoguit";
            this.btnLoguit.Size = new System.Drawing.Size(75, 23);
            this.btnLoguit.TabIndex = 0;
            this.btnLoguit.Text = "Log uit";
            this.btnLoguit.UseVisualStyleBackColor = true;
            // 
            // lbSchoonmaak
            // 
            this.lbSchoonmaak.FormattingEnabled = true;
            this.lbSchoonmaak.Location = new System.Drawing.Point(12, 12);
            this.lbSchoonmaak.Name = "lbSchoonmaak";
            this.lbSchoonmaak.Size = new System.Drawing.Size(210, 290);
            this.lbSchoonmaak.TabIndex = 1;
            // 
            // btnSchoonmaakLijst
            // 
            this.btnSchoonmaakLijst.Location = new System.Drawing.Point(233, 279);
            this.btnSchoonmaakLijst.Name = "btnSchoonmaakLijst";
            this.btnSchoonmaakLijst.Size = new System.Drawing.Size(75, 23);
            this.btnSchoonmaakLijst.TabIndex = 2;
            this.btnSchoonmaakLijst.Text = "Haal lijst op";
            this.btnSchoonmaakLijst.UseVisualStyleBackColor = true;
            this.btnSchoonmaakLijst.Click += new System.EventHandler(this.btnSchoonmaakLijst_Click);
            // 
            // dtSchoonmaak
            // 
            this.dtSchoonmaak.Location = new System.Drawing.Point(311, 12);
            this.dtSchoonmaak.Name = "dtSchoonmaak";
            this.dtSchoonmaak.Size = new System.Drawing.Size(200, 20);
            this.dtSchoonmaak.TabIndex = 3;
            // 
            // btnSchoonmaak
            // 
            this.btnSchoonmaak.Location = new System.Drawing.Point(311, 64);
            this.btnSchoonmaak.Name = "btnSchoonmaak";
            this.btnSchoonmaak.Size = new System.Drawing.Size(200, 23);
            this.btnSchoonmaak.TabIndex = 4;
            this.btnSchoonmaak.Text = "Registreer schoonmaakbeurt";
            this.btnSchoonmaak.UseVisualStyleBackColor = true;
            // 
            // tbSchoonmaak
            // 
            this.tbSchoonmaak.Location = new System.Drawing.Point(311, 38);
            this.tbSchoonmaak.Name = "tbSchoonmaak";
            this.tbSchoonmaak.Size = new System.Drawing.Size(200, 20);
            this.tbSchoonmaak.TabIndex = 5;
            // 
            // lbDatum
            // 
            this.lbDatum.AutoSize = true;
            this.lbDatum.Location = new System.Drawing.Point(230, 15);
            this.lbDatum.Name = "lbDatum";
            this.lbDatum.Size = new System.Drawing.Size(75, 13);
            this.lbDatum.TabIndex = 6;
            this.lbDatum.Text = "Datum en tijd: ";
            // 
            // lbSchoonmaker
            // 
            this.lbSchoonmaker.AutoSize = true;
            this.lbSchoonmaker.Location = new System.Drawing.Point(230, 40);
            this.lbSchoonmaker.Name = "lbSchoonmaker";
            this.lbSchoonmaker.Size = new System.Drawing.Size(76, 13);
            this.lbSchoonmaker.TabIndex = 7;
            this.lbSchoonmaker.Text = "Schoonmaker:";
            // 
            // CleanupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 312);
            this.Controls.Add(this.lbSchoonmaker);
            this.Controls.Add(this.lbDatum);
            this.Controls.Add(this.tbSchoonmaak);
            this.Controls.Add(this.btnSchoonmaak);
            this.Controls.Add(this.dtSchoonmaak);
            this.Controls.Add(this.btnSchoonmaakLijst);
            this.Controls.Add(this.lbSchoonmaak);
            this.Controls.Add(this.btnLoguit);
            this.Name = "CleanupForm";
            this.Text = "Schoonmaak";
            this.Load += new System.EventHandler(this.Schoonmaak_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoguit;
        private System.Windows.Forms.ListBox lbSchoonmaak;
        private System.Windows.Forms.Button btnSchoonmaakLijst;
        private System.Windows.Forms.DateTimePicker dtSchoonmaak;
        private System.Windows.Forms.Button btnSchoonmaak;
        private System.Windows.Forms.TextBox tbSchoonmaak;
        private System.Windows.Forms.Label lbDatum;
        private System.Windows.Forms.Label lbSchoonmaker;
    }
}