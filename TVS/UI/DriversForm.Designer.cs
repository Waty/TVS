namespace TVS.UI
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
            this.lbTramNummer = new System.Windows.Forms.Label();
            this.lbTram = new System.Windows.Forms.Label();
            this.tbTramNummer = new System.Windows.Forms.TextBox();
            this.lbWagenNummer = new System.Windows.Forms.Label();
            this.cbVervuild = new System.Windows.Forms.CheckBox();
            this.cbDefect = new System.Windows.Forms.CheckBox();
            this.btnVerzend = new System.Windows.Forms.Button();
            this.lbSpoor = new System.Windows.Forms.Label();
            this.lbSpoorNummer = new System.Windows.Forms.Label();
            this.lbSector = new System.Windows.Forms.Label();
            this.lbSectorNummer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbTramNummer
            // 
            this.lbTramNummer.BackColor = System.Drawing.SystemColors.Window;
            this.lbTramNummer.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTramNummer.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lbTramNummer.Location = new System.Drawing.Point(5, 52);
            this.lbTramNummer.Name = "lbTramNummer";
            this.lbTramNummer.Size = new System.Drawing.Size(205, 139);
            this.lbTramNummer.TabIndex = 17;
            this.lbTramNummer.Text = "806";
            this.lbTramNummer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbTram
            // 
            this.lbTram.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTram.Location = new System.Drawing.Point(12, 9);
            this.lbTram.Name = "lbTram";
            this.lbTram.Size = new System.Drawing.Size(100, 37);
            this.lbTram.TabIndex = 18;
            this.lbTram.Text = "Tram";
            // 
            // tbTramNummer
            // 
            this.tbTramNummer.Location = new System.Drawing.Point(81, 239);
            this.tbTramNummer.Name = "tbTramNummer";
            this.tbTramNummer.Size = new System.Drawing.Size(87, 20);
            this.tbTramNummer.TabIndex = 20;
            // 
            // lbWagenNummer
            // 
            this.lbWagenNummer.AutoSize = true;
            this.lbWagenNummer.Location = new System.Drawing.Point(4, 242);
            this.lbWagenNummer.Name = "lbWagenNummer";
            this.lbWagenNummer.Size = new System.Drawing.Size(71, 13);
            this.lbWagenNummer.TabIndex = 21;
            this.lbWagenNummer.Text = "Tramnummer:";
            // 
            // cbVervuild
            // 
            this.cbVervuild.AutoSize = true;
            this.cbVervuild.Location = new System.Drawing.Point(81, 280);
            this.cbVervuild.Name = "cbVervuild";
            this.cbVervuild.Size = new System.Drawing.Size(64, 17);
            this.cbVervuild.TabIndex = 22;
            this.cbVervuild.Text = "Vervuild";
            this.cbVervuild.UseVisualStyleBackColor = true;
            // 
            // cbDefect
            // 
            this.cbDefect.AutoSize = true;
            this.cbDefect.Location = new System.Drawing.Point(81, 303);
            this.cbDefect.Name = "cbDefect";
            this.cbDefect.Size = new System.Drawing.Size(58, 17);
            this.cbDefect.TabIndex = 23;
            this.cbDefect.Text = "Defect";
            this.cbDefect.UseVisualStyleBackColor = true;
            // 
            // btnVerzend
            // 
            this.btnVerzend.Location = new System.Drawing.Point(81, 339);
            this.btnVerzend.Name = "btnVerzend";
            this.btnVerzend.Size = new System.Drawing.Size(56, 23);
            this.btnVerzend.TabIndex = 24;
            this.btnVerzend.Text = "Verzend";
            this.btnVerzend.UseVisualStyleBackColor = true;
            this.btnVerzend.Click += new System.EventHandler(this.btnVerzend_Click);
            // 
            // lbSpoor
            // 
            this.lbSpoor.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSpoor.Location = new System.Drawing.Point(431, 9);
            this.lbSpoor.Name = "lbSpoor";
            this.lbSpoor.Size = new System.Drawing.Size(100, 37);
            this.lbSpoor.TabIndex = 25;
            this.lbSpoor.Text = "Spoor";
            // 
            // lbSpoorNummer
            // 
            this.lbSpoorNummer.BackColor = System.Drawing.SystemColors.Window;
            this.lbSpoorNummer.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSpoorNummer.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lbSpoorNummer.Location = new System.Drawing.Point(394, 52);
            this.lbSpoorNummer.Name = "lbSpoorNummer";
            this.lbSpoorNummer.Size = new System.Drawing.Size(163, 139);
            this.lbSpoorNummer.TabIndex = 26;
            this.lbSpoorNummer.Text = "14";
            this.lbSpoorNummer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbSector
            // 
            this.lbSector.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSector.Location = new System.Drawing.Point(431, 202);
            this.lbSector.Name = "lbSector";
            this.lbSector.Size = new System.Drawing.Size(100, 37);
            this.lbSector.TabIndex = 27;
            this.lbSector.Text = "Sector";
            // 
            // lbSectorNummer
            // 
            this.lbSectorNummer.BackColor = System.Drawing.SystemColors.Window;
            this.lbSectorNummer.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSectorNummer.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lbSectorNummer.Location = new System.Drawing.Point(394, 239);
            this.lbSectorNummer.Name = "lbSectorNummer";
            this.lbSectorNummer.Size = new System.Drawing.Size(163, 139);
            this.lbSectorNummer.TabIndex = 28;
            this.lbSectorNummer.Text = "4";
            this.lbSectorNummer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DriversForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 412);
            this.Controls.Add(this.lbSectorNummer);
            this.Controls.Add(this.lbSector);
            this.Controls.Add(this.lbSpoorNummer);
            this.Controls.Add(this.lbSpoor);
            this.Controls.Add(this.btnVerzend);
            this.Controls.Add(this.cbDefect);
            this.Controls.Add(this.cbVervuild);
            this.Controls.Add(this.lbWagenNummer);
            this.Controls.Add(this.tbTramNummer);
            this.Controls.Add(this.lbTram);
            this.Controls.Add(this.lbTramNummer);
            this.Name = "DriversForm";
            this.Text = "In_en_uit_rijden";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbTramNummer;
        private System.Windows.Forms.Label lbTram;
        private System.Windows.Forms.TextBox tbTramNummer;
        private System.Windows.Forms.Label lbWagenNummer;
        private System.Windows.Forms.CheckBox cbVervuild;
        private System.Windows.Forms.CheckBox cbDefect;
        private System.Windows.Forms.Button btnVerzend;
        private System.Windows.Forms.Label lbSpoor;
        private System.Windows.Forms.Label lbSpoorNummer;
        private System.Windows.Forms.Label lbSector;
        private System.Windows.Forms.Label lbSectorNummer;
    }
}