namespace TVS
{
    partial class DriversForm
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
            this.tbSpoor = new System.Windows.Forms.TextBox();
            this.lbSpoor = new System.Windows.Forms.Label();
            this.lbTramNummer = new System.Windows.Forms.Label();
            this.lbTram = new System.Windows.Forms.Label();
            this.btnWijzigSpoor = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbWagenNummer = new System.Windows.Forms.Label();
            this.cbVervuild = new System.Windows.Forms.CheckBox();
            this.cbDefect = new System.Windows.Forms.CheckBox();
            this.btnVerzend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLoguit
            // 
            this.btnLoguit.Location = new System.Drawing.Point(362, 12);
            this.btnLoguit.Name = "btnLoguit";
            this.btnLoguit.Size = new System.Drawing.Size(75, 23);
            this.btnLoguit.TabIndex = 14;
            this.btnLoguit.Text = "Log uit";
            this.btnLoguit.UseVisualStyleBackColor = true;
            // 
            // tbSpoor
            // 
            this.tbSpoor.Location = new System.Drawing.Point(59, 15);
            this.tbSpoor.Name = "tbSpoor";
            this.tbSpoor.Size = new System.Drawing.Size(100, 20);
            this.tbSpoor.TabIndex = 15;
            // 
            // lbSpoor
            // 
            this.lbSpoor.AutoSize = true;
            this.lbSpoor.Location = new System.Drawing.Point(18, 17);
            this.lbSpoor.Name = "lbSpoor";
            this.lbSpoor.Size = new System.Drawing.Size(41, 13);
            this.lbSpoor.TabIndex = 16;
            this.lbSpoor.Text = "Spoor: ";
            // 
            // lbTramNummer
            // 
            this.lbTramNummer.BackColor = System.Drawing.SystemColors.Window;
            this.lbTramNummer.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTramNummer.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lbTramNummer.Location = new System.Drawing.Point(88, 86);
            this.lbTramNummer.Name = "lbTramNummer";
            this.lbTramNummer.Size = new System.Drawing.Size(163, 139);
            this.lbTramNummer.TabIndex = 17;
            this.lbTramNummer.Text = "806";
            this.lbTramNummer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbTramNummer.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbTram
            // 
            this.lbTram.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTram.Location = new System.Drawing.Point(124, 49);
            this.lbTram.Name = "lbTram";
            this.lbTram.Size = new System.Drawing.Size(100, 37);
            this.lbTram.TabIndex = 18;
            this.lbTram.Text = "Tram";
            // 
            // btnWijzigSpoor
            // 
            this.btnWijzigSpoor.Location = new System.Drawing.Point(174, 13);
            this.btnWijzigSpoor.Name = "btnWijzigSpoor";
            this.btnWijzigSpoor.Size = new System.Drawing.Size(75, 23);
            this.btnWijzigSpoor.TabIndex = 19;
            this.btnWijzigSpoor.Text = "Wijzig spoor";
            this.btnWijzigSpoor.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(337, 95);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 20;
            // 
            // lbWagenNummer
            // 
            this.lbWagenNummer.AutoSize = true;
            this.lbWagenNummer.Location = new System.Drawing.Point(260, 98);
            this.lbWagenNummer.Name = "lbWagenNummer";
            this.lbWagenNummer.Size = new System.Drawing.Size(71, 13);
            this.lbWagenNummer.TabIndex = 21;
            this.lbWagenNummer.Text = "Tramnummer:";
            // 
            // cbVervuild
            // 
            this.cbVervuild.AutoSize = true;
            this.cbVervuild.Location = new System.Drawing.Point(337, 132);
            this.cbVervuild.Name = "cbVervuild";
            this.cbVervuild.Size = new System.Drawing.Size(64, 17);
            this.cbVervuild.TabIndex = 22;
            this.cbVervuild.Text = "Vervuild";
            this.cbVervuild.UseVisualStyleBackColor = true;
            // 
            // cbDefect
            // 
            this.cbDefect.AutoSize = true;
            this.cbDefect.Location = new System.Drawing.Point(337, 155);
            this.cbDefect.Name = "cbDefect";
            this.cbDefect.Size = new System.Drawing.Size(58, 17);
            this.cbDefect.TabIndex = 23;
            this.cbDefect.Text = "Defect";
            this.cbDefect.UseVisualStyleBackColor = true;
            // 
            // btnVerzend
            // 
            this.btnVerzend.Location = new System.Drawing.Point(337, 178);
            this.btnVerzend.Name = "btnVerzend";
            this.btnVerzend.Size = new System.Drawing.Size(75, 23);
            this.btnVerzend.TabIndex = 24;
            this.btnVerzend.Text = "Verzend";
            this.btnVerzend.UseVisualStyleBackColor = true;
            // 
            // In_en_uit_rijden
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 247);
            this.Controls.Add(this.btnVerzend);
            this.Controls.Add(this.cbDefect);
            this.Controls.Add(this.cbVervuild);
            this.Controls.Add(this.lbWagenNummer);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnWijzigSpoor);
            this.Controls.Add(this.lbTram);
            this.Controls.Add(this.lbTramNummer);
            this.Controls.Add(this.lbSpoor);
            this.Controls.Add(this.tbSpoor);
            this.Controls.Add(this.btnLoguit);
            this.Name = "DriversForm";
            this.Text = "In_en_uit_rijden";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoguit;
        private System.Windows.Forms.TextBox tbSpoor;
        private System.Windows.Forms.Label lbSpoor;
        private System.Windows.Forms.Label lbTramNummer;
        private System.Windows.Forms.Label lbTram;
        private System.Windows.Forms.Button btnWijzigSpoor;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbWagenNummer;
        private System.Windows.Forms.CheckBox cbVervuild;
        private System.Windows.Forms.CheckBox cbDefect;
        private System.Windows.Forms.Button btnVerzend;
    }
}