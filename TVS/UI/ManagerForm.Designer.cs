namespace TVS.UI
{
    partial class ManagerForm
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
            this.btnCleanup = new System.Windows.Forms.Button();
            this.btnMaintenance = new System.Windows.Forms.Button();
            this.btnDriver = new System.Windows.Forms.Button();
            this.btnRemise = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCleanup
            // 
            this.btnCleanup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCleanup.Location = new System.Drawing.Point(3, 3);
            this.btnCleanup.Name = "btnCleanup";
            this.btnCleanup.Size = new System.Drawing.Size(147, 48);
            this.btnCleanup.TabIndex = 0;
            this.btnCleanup.Text = "Schoonmaak";
            this.btnCleanup.UseVisualStyleBackColor = true;
            // 
            // btnMaintenance
            // 
            this.btnMaintenance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMaintenance.Location = new System.Drawing.Point(156, 3);
            this.btnMaintenance.Name = "btnMaintenance";
            this.btnMaintenance.Size = new System.Drawing.Size(148, 48);
            this.btnMaintenance.TabIndex = 1;
            this.btnMaintenance.Text = "Onderhoud";
            this.btnMaintenance.UseVisualStyleBackColor = true;
            // 
            // btnDriver
            // 
            this.btnDriver.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDriver.Location = new System.Drawing.Point(3, 57);
            this.btnDriver.Name = "btnDriver";
            this.btnDriver.Size = new System.Drawing.Size(147, 48);
            this.btnDriver.TabIndex = 2;
            this.btnDriver.Text = "Bestuurder";
            this.btnDriver.UseVisualStyleBackColor = true;
            // 
            // btnRemise
            // 
            this.btnRemise.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRemise.Location = new System.Drawing.Point(156, 57);
            this.btnRemise.Name = "btnRemise";
            this.btnRemise.Size = new System.Drawing.Size(148, 48);
            this.btnRemise.TabIndex = 3;
            this.btnRemise.Text = "Remise";
            this.btnRemise.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnCleanup, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnRemise, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnMaintenance, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnDriver, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(307, 108);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 108);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ManagerForm";
            this.Text = "ManagerForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCleanup;
        private System.Windows.Forms.Button btnMaintenance;
        private System.Windows.Forms.Button btnDriver;
        private System.Windows.Forms.Button btnRemise;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}