namespace TVS.UI
{
    /// <summary>
    /// 
    /// </summary>
    partial class NewTramForm
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
            this.tbRemiseId = new System.Windows.Forms.TextBox();
            this.cbConducteur = new System.Windows.Forms.CheckBox();
            this.cbBeschikbaar = new System.Windows.Forms.CheckBox();
            this.tbNummer = new System.Windows.Forms.TextBox();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.lbRemise = new System.Windows.Forms.Label();
            this.lbNummer = new System.Windows.Forms.Label();
            this.lbType = new System.Windows.Forms.Label();
            this.btnNieuw = new System.Windows.Forms.Button();
            this.tbLengte = new System.Windows.Forms.TextBox();
            this.lbLengte = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbRemiseId
            // 
            this.tbRemiseId.Location = new System.Drawing.Point(77, 15);
            this.tbRemiseId.Name = "tbRemiseId";
            this.tbRemiseId.Size = new System.Drawing.Size(100, 20);
            this.tbRemiseId.TabIndex = 1;
            // 
            // cbConducteur
            // 
            this.cbConducteur.AutoSize = true;
            this.cbConducteur.Location = new System.Drawing.Point(20, 122);
            this.cbConducteur.Name = "cbConducteur";
            this.cbConducteur.Size = new System.Drawing.Size(124, 17);
            this.cbConducteur.TabIndex = 5;
            this.cbConducteur.Text = "Conducteur geschikt";
            this.cbConducteur.UseVisualStyleBackColor = true;
            // 
            // cbBeschikbaar
            // 
            this.cbBeschikbaar.AutoSize = true;
            this.cbBeschikbaar.Location = new System.Drawing.Point(20, 145);
            this.cbBeschikbaar.Name = "cbBeschikbaar";
            this.cbBeschikbaar.Size = new System.Drawing.Size(85, 17);
            this.cbBeschikbaar.TabIndex = 6;
            this.cbBeschikbaar.Text = "Beschikbaar";
            this.cbBeschikbaar.UseVisualStyleBackColor = true;
            // 
            // tbNummer
            // 
            this.tbNummer.Location = new System.Drawing.Point(77, 39);
            this.tbNummer.Name = "tbNummer";
            this.tbNummer.Size = new System.Drawing.Size(100, 20);
            this.tbNummer.TabIndex = 7;
            // 
            // cbType
            // 
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(77, 63);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(100, 21);
            this.cbType.TabIndex = 8;
            // 
            // lbRemise
            // 
            this.lbRemise.AutoSize = true;
            this.lbRemise.Location = new System.Drawing.Point(17, 18);
            this.lbRemise.Name = "lbRemise";
            this.lbRemise.Size = new System.Drawing.Size(54, 13);
            this.lbRemise.TabIndex = 9;
            this.lbRemise.Text = "RemiseId:";
            // 
            // lbNummer
            // 
            this.lbNummer.AutoSize = true;
            this.lbNummer.Location = new System.Drawing.Point(17, 42);
            this.lbNummer.Name = "lbNummer";
            this.lbNummer.Size = new System.Drawing.Size(49, 13);
            this.lbNummer.TabIndex = 10;
            this.lbNummer.Text = "Nummer:";
            // 
            // lbType
            // 
            this.lbType.AutoSize = true;
            this.lbType.Location = new System.Drawing.Point(17, 66);
            this.lbType.Name = "lbType";
            this.lbType.Size = new System.Drawing.Size(34, 13);
            this.lbType.TabIndex = 11;
            this.lbType.Text = "Type:";
            // 
            // btnNieuw
            // 
            this.btnNieuw.Location = new System.Drawing.Point(91, 168);
            this.btnNieuw.Name = "btnNieuw";
            this.btnNieuw.Size = new System.Drawing.Size(86, 23);
            this.btnNieuw.TabIndex = 12;
            this.btnNieuw.Text = "Nieuwe Tram";
            this.btnNieuw.UseVisualStyleBackColor = true;
            this.btnNieuw.Click += new System.EventHandler(this.btnNieuw_Click);
            // 
            // tbLengte
            // 
            this.tbLengte.Location = new System.Drawing.Point(77, 90);
            this.tbLengte.Name = "tbLengte";
            this.tbLengte.Size = new System.Drawing.Size(100, 20);
            this.tbLengte.TabIndex = 13;
            // 
            // lbLengte
            // 
            this.lbLengte.AutoSize = true;
            this.lbLengte.Location = new System.Drawing.Point(17, 93);
            this.lbLengte.Name = "lbLengte";
            this.lbLengte.Size = new System.Drawing.Size(43, 13);
            this.lbLengte.TabIndex = 14;
            this.lbLengte.Text = "Lengte:";
            // 
            // NewTramForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(191, 201);
            this.Controls.Add(this.lbLengte);
            this.Controls.Add(this.tbLengte);
            this.Controls.Add(this.btnNieuw);
            this.Controls.Add(this.lbType);
            this.Controls.Add(this.lbNummer);
            this.Controls.Add(this.lbRemise);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.tbNummer);
            this.Controls.Add(this.cbBeschikbaar);
            this.Controls.Add(this.cbConducteur);
            this.Controls.Add(this.tbRemiseId);
            this.Name = "NewTramForm";
            this.Text = "NewTramForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbRemiseId;
        private System.Windows.Forms.CheckBox cbConducteur;
        private System.Windows.Forms.CheckBox cbBeschikbaar;
        private System.Windows.Forms.TextBox tbNummer;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.Label lbRemise;
        private System.Windows.Forms.Label lbNummer;
        private System.Windows.Forms.Label lbType;
        private System.Windows.Forms.Button btnNieuw;
        private System.Windows.Forms.TextBox tbLengte;
        private System.Windows.Forms.Label lbLengte;
    }
}