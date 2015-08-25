namespace TVS
{
    /// <summary>
    /// 
    /// </summary>
    partial class Onderhoud
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
            this.lbOnderhoud = new System.Windows.Forms.ListBox();
            this.lbTechnicus = new System.Windows.Forms.Label();
            this.lbDatum = new System.Windows.Forms.Label();
            this.tbOnderhoud = new System.Windows.Forms.TextBox();
            this.btnOnderhoud = new System.Windows.Forms.Button();
            this.dtOnderhoud = new System.Windows.Forms.DateTimePicker();
            this.btnLoguit = new System.Windows.Forms.Button();
            this.btnOnderhoudLijst = new System.Windows.Forms.Button();
            this.btnStatus = new System.Windows.Forms.Button();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbOnderhoud
            // 
            this.lbOnderhoud.FormattingEnabled = true;
            this.lbOnderhoud.Location = new System.Drawing.Point(12, 12);
            this.lbOnderhoud.Name = "lbOnderhoud";
            this.lbOnderhoud.Size = new System.Drawing.Size(210, 290);
            this.lbOnderhoud.TabIndex = 0;
            // 
            // lbTechnicus
            // 
            this.lbTechnicus.AutoSize = true;
            this.lbTechnicus.Location = new System.Drawing.Point(230, 40);
            this.lbTechnicus.Name = "lbTechnicus";
            this.lbTechnicus.Size = new System.Drawing.Size(63, 13);
            this.lbTechnicus.TabIndex = 12;
            this.lbTechnicus.Text = "Technicus: ";
            // 
            // lbDatum
            // 
            this.lbDatum.AutoSize = true;
            this.lbDatum.Location = new System.Drawing.Point(230, 15);
            this.lbDatum.Name = "lbDatum";
            this.lbDatum.Size = new System.Drawing.Size(52, 13);
            this.lbDatum.TabIndex = 11;
            this.lbDatum.Text = "Klaar op: ";
            // 
            // tbOnderhoud
            // 
            this.tbOnderhoud.Location = new System.Drawing.Point(311, 38);
            this.tbOnderhoud.Name = "tbOnderhoud";
            this.tbOnderhoud.Size = new System.Drawing.Size(200, 20);
            this.tbOnderhoud.TabIndex = 10;
            // 
            // btnOnderhoud
            // 
            this.btnOnderhoud.Location = new System.Drawing.Point(311, 64);
            this.btnOnderhoud.Name = "btnOnderhoud";
            this.btnOnderhoud.Size = new System.Drawing.Size(200, 23);
            this.btnOnderhoud.TabIndex = 9;
            this.btnOnderhoud.Text = "Registreer onderhoudsbeurt";
            this.btnOnderhoud.UseVisualStyleBackColor = true;
            // 
            // dtOnderhoud
            // 
            this.dtOnderhoud.Location = new System.Drawing.Point(311, 12);
            this.dtOnderhoud.Name = "dtOnderhoud";
            this.dtOnderhoud.Size = new System.Drawing.Size(200, 20);
            this.dtOnderhoud.TabIndex = 8;
            // 
            // btnLoguit
            // 
            this.btnLoguit.Location = new System.Drawing.Point(533, 10);
            this.btnLoguit.Name = "btnLoguit";
            this.btnLoguit.Size = new System.Drawing.Size(75, 23);
            this.btnLoguit.TabIndex = 13;
            this.btnLoguit.Text = "Log uit";
            this.btnLoguit.UseVisualStyleBackColor = true;
            // 
            // btnOnderhoudLijst
            // 
            this.btnOnderhoudLijst.Location = new System.Drawing.Point(233, 277);
            this.btnOnderhoudLijst.Name = "btnOnderhoudLijst";
            this.btnOnderhoudLijst.Size = new System.Drawing.Size(75, 23);
            this.btnOnderhoudLijst.TabIndex = 14;
            this.btnOnderhoudLijst.Text = "Haal lijst op";
            this.btnOnderhoudLijst.UseVisualStyleBackColor = true;
            // 
            // btnStatus
            // 
            this.btnStatus.Location = new System.Drawing.Point(396, 100);
            this.btnStatus.Name = "btnStatus";
            this.btnStatus.Size = new System.Drawing.Size(115, 23);
            this.btnStatus.TabIndex = 15;
            this.btnStatus.Text = "Status aanpassen";
            this.btnStatus.UseVisualStyleBackColor = true;
            // 
            // cbStatus
            // 
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "Onderhoud",
            "Technische problemen",
            "Schoonmaak"});
            this.cbStatus.Location = new System.Drawing.Point(233, 102);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(157, 21);
            this.cbStatus.TabIndex = 16;
            // 
            // Onderhoud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 312);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.btnStatus);
            this.Controls.Add(this.btnOnderhoudLijst);
            this.Controls.Add(this.btnLoguit);
            this.Controls.Add(this.lbTechnicus);
            this.Controls.Add(this.lbDatum);
            this.Controls.Add(this.tbOnderhoud);
            this.Controls.Add(this.btnOnderhoud);
            this.Controls.Add(this.dtOnderhoud);
            this.Controls.Add(this.lbOnderhoud);
            this.Name = "Onderhoud";
            this.Text = "Onderhoud";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbOnderhoud;
        private System.Windows.Forms.Label lbTechnicus;
        private System.Windows.Forms.Label lbDatum;
        private System.Windows.Forms.TextBox tbOnderhoud;
        private System.Windows.Forms.Button btnOnderhoud;
        private System.Windows.Forms.DateTimePicker dtOnderhoud;
        private System.Windows.Forms.Button btnLoguit;
        private System.Windows.Forms.Button btnOnderhoudLijst;
        private System.Windows.Forms.Button btnStatus;
        private System.Windows.Forms.ComboBox cbStatus;
    }
}