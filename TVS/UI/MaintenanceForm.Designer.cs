namespace TVS.UI
{
    /// <summary>
    /// 
    /// </summary>
    partial class MaintenanceForm
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
            this.lbDefectTrams = new System.Windows.Forms.ListBox();
            this.lbTechnicus = new System.Windows.Forms.Label();
            this.lbDatum = new System.Windows.Forms.Label();
            this.btnOnderhoud = new System.Windows.Forms.Button();
            this.dtpOnderhoud = new System.Windows.Forms.DateTimePicker();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.ddbEmployees = new System.Windows.Forms.ComboBox();
            this.lbStatus = new System.Windows.Forms.Label();
            this.lbGeschiedenis = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbDefectTrams
            // 
            this.lbDefectTrams.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbDefectTrams.FormattingEnabled = true;
            this.lbDefectTrams.Location = new System.Drawing.Point(12, 12);
            this.lbDefectTrams.Name = "lbDefectTrams";
            this.lbDefectTrams.Size = new System.Drawing.Size(228, 342);
            this.lbDefectTrams.TabIndex = 0;
            // 
            // lbTechnicus
            // 
            this.lbTechnicus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTechnicus.AutoSize = true;
            this.lbTechnicus.Location = new System.Drawing.Point(290, 40);
            this.lbTechnicus.Name = "lbTechnicus";
            this.lbTechnicus.Size = new System.Drawing.Size(63, 13);
            this.lbTechnicus.TabIndex = 12;
            this.lbTechnicus.Text = "Technicus: ";
            // 
            // lbDatum
            // 
            this.lbDatum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbDatum.AutoSize = true;
            this.lbDatum.Location = new System.Drawing.Point(290, 15);
            this.lbDatum.Name = "lbDatum";
            this.lbDatum.Size = new System.Drawing.Size(52, 13);
            this.lbDatum.TabIndex = 11;
            this.lbDatum.Text = "Klaar op: ";
            // 
            // btnOnderhoud
            // 
            this.btnOnderhoud.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOnderhoud.Location = new System.Drawing.Point(371, 91);
            this.btnOnderhoud.Name = "btnOnderhoud";
            this.btnOnderhoud.Size = new System.Drawing.Size(200, 23);
            this.btnOnderhoud.TabIndex = 9;
            this.btnOnderhoud.Text = "Registreer onderhoudsbeurt";
            this.btnOnderhoud.UseVisualStyleBackColor = true;
            this.btnOnderhoud.Click += new System.EventHandler(this.btnOnderhoud_Click);
            // 
            // dtpOnderhoud
            // 
            this.dtpOnderhoud.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpOnderhoud.Location = new System.Drawing.Point(371, 12);
            this.dtpOnderhoud.Name = "dtpOnderhoud";
            this.dtpOnderhoud.Size = new System.Drawing.Size(200, 20);
            this.dtpOnderhoud.TabIndex = 8;
            // 
            // cbStatus
            // 
            this.cbStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "Schoonmaak",
            "Beschikbaar"});
            this.cbStatus.Location = new System.Drawing.Point(371, 64);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(200, 21);
            this.cbStatus.TabIndex = 16;
            // 
            // ddbEmployees
            // 
            this.ddbEmployees.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ddbEmployees.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddbEmployees.FormattingEnabled = true;
            this.ddbEmployees.Location = new System.Drawing.Point(371, 37);
            this.ddbEmployees.Name = "ddbEmployees";
            this.ddbEmployees.Size = new System.Drawing.Size(200, 21);
            this.ddbEmployees.TabIndex = 17;
            // 
            // lbStatus
            // 
            this.lbStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbStatus.AutoSize = true;
            this.lbStatus.Location = new System.Drawing.Point(293, 67);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(40, 13);
            this.lbStatus.TabIndex = 18;
            this.lbStatus.Text = "Status:";
            // 
            // lbGeschiedenis
            // 
            this.lbGeschiedenis.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbGeschiedenis.FormattingEnabled = true;
            this.lbGeschiedenis.Location = new System.Drawing.Point(260, 129);
            this.lbGeschiedenis.Name = "lbGeschiedenis";
            this.lbGeschiedenis.Size = new System.Drawing.Size(311, 225);
            this.lbGeschiedenis.TabIndex = 19;
            // 
            // MaintenanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 364);
            this.Controls.Add(this.lbGeschiedenis);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.ddbEmployees);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.lbTechnicus);
            this.Controls.Add(this.lbDatum);
            this.Controls.Add(this.btnOnderhoud);
            this.Controls.Add(this.dtpOnderhoud);
            this.Controls.Add(this.lbDefectTrams);
            this.Name = "MaintenanceForm";
            this.Text = "Onderhoud";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbDefectTrams;
        private System.Windows.Forms.Label lbTechnicus;
        private System.Windows.Forms.Label lbDatum;
        private System.Windows.Forms.Button btnOnderhoud;
        private System.Windows.Forms.DateTimePicker dtpOnderhoud;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.ComboBox ddbEmployees;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.ListBox lbGeschiedenis;
    }
}