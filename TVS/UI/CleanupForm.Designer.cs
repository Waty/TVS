namespace TVS.UI
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
            this.lbCleanupTasks = new System.Windows.Forms.ListBox();
            this.btnRefreshCleanupList = new System.Windows.Forms.Button();
            this.dtpCleanupDate = new System.Windows.Forms.DateTimePicker();
            this.btnRegisterCleanup = new System.Windows.Forms.Button();
            this.lCleanupDate = new System.Windows.Forms.Label();
            this.lEmployeeName = new System.Windows.Forms.Label();
            this.ddbEmployees = new System.Windows.Forms.ComboBox();
            this.lType = new System.Windows.Forms.Label();
            this.ddbCleanupType = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbCleanupTasks
            // 
            this.lbCleanupTasks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbCleanupTasks.FormattingEnabled = true;
            this.lbCleanupTasks.Location = new System.Drawing.Point(12, 12);
            this.lbCleanupTasks.Name = "lbCleanupTasks";
            this.lbCleanupTasks.Size = new System.Drawing.Size(320, 290);
            this.lbCleanupTasks.TabIndex = 1;
            // 
            // btnRefreshCleanupList
            // 
            this.btnRefreshCleanupList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefreshCleanupList.Location = new System.Drawing.Point(485, 279);
            this.btnRefreshCleanupList.Name = "btnRefreshCleanupList";
            this.btnRefreshCleanupList.Size = new System.Drawing.Size(134, 23);
            this.btnRefreshCleanupList.TabIndex = 2;
            this.btnRefreshCleanupList.Text = "Update de TODO list";
            this.btnRefreshCleanupList.UseVisualStyleBackColor = true;
            this.btnRefreshCleanupList.Click += new System.EventHandler(this.LoadCleanupData);
            // 
            // dtpCleanupDate
            // 
            this.dtpCleanupDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpCleanupDate.Location = new System.Drawing.Point(419, 12);
            this.dtpCleanupDate.Name = "dtpCleanupDate";
            this.dtpCleanupDate.Size = new System.Drawing.Size(200, 20);
            this.dtpCleanupDate.TabIndex = 3;
            // 
            // btnRegisterCleanup
            // 
            this.btnRegisterCleanup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegisterCleanup.Location = new System.Drawing.Point(419, 91);
            this.btnRegisterCleanup.Name = "btnRegisterCleanup";
            this.btnRegisterCleanup.Size = new System.Drawing.Size(200, 23);
            this.btnRegisterCleanup.TabIndex = 4;
            this.btnRegisterCleanup.Text = "Registreer schoonmaakbeurt";
            this.btnRegisterCleanup.UseVisualStyleBackColor = true;
            this.btnRegisterCleanup.Click += new System.EventHandler(this.btnRegisterCleanup_Click);
            // 
            // lCleanupDate
            // 
            this.lCleanupDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lCleanupDate.AutoSize = true;
            this.lCleanupDate.Location = new System.Drawing.Point(338, 15);
            this.lCleanupDate.Name = "lCleanupDate";
            this.lCleanupDate.Size = new System.Drawing.Size(75, 13);
            this.lCleanupDate.TabIndex = 6;
            this.lCleanupDate.Text = "Datum en tijd: ";
            // 
            // lEmployeeName
            // 
            this.lEmployeeName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lEmployeeName.AutoSize = true;
            this.lEmployeeName.Location = new System.Drawing.Point(338, 40);
            this.lEmployeeName.Name = "lEmployeeName";
            this.lEmployeeName.Size = new System.Drawing.Size(76, 13);
            this.lEmployeeName.TabIndex = 7;
            this.lEmployeeName.Text = "Schoonmaker:";
            // 
            // ddbEmployees
            // 
            this.ddbEmployees.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddbEmployees.FormattingEnabled = true;
            this.ddbEmployees.Location = new System.Drawing.Point(419, 37);
            this.ddbEmployees.Name = "ddbEmployees";
            this.ddbEmployees.Size = new System.Drawing.Size(200, 21);
            this.ddbEmployees.TabIndex = 8;
            // 
            // lType
            // 
            this.lType.AutoSize = true;
            this.lType.Location = new System.Drawing.Point(338, 67);
            this.lType.Name = "lType";
            this.lType.Size = new System.Drawing.Size(34, 13);
            this.lType.TabIndex = 9;
            this.lType.Text = "Type:";
            // 
            // ddbCleanupType
            // 
            this.ddbCleanupType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddbCleanupType.FormattingEnabled = true;
            this.ddbCleanupType.Location = new System.Drawing.Point(419, 64);
            this.ddbCleanupType.Name = "ddbCleanupType";
            this.ddbCleanupType.Size = new System.Drawing.Size(200, 21);
            this.ddbCleanupType.TabIndex = 10;
            // 
            // CleanupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 312);
            this.Controls.Add(this.ddbCleanupType);
            this.Controls.Add(this.lType);
            this.Controls.Add(this.ddbEmployees);
            this.Controls.Add(this.lEmployeeName);
            this.Controls.Add(this.lCleanupDate);
            this.Controls.Add(this.btnRegisterCleanup);
            this.Controls.Add(this.dtpCleanupDate);
            this.Controls.Add(this.btnRefreshCleanupList);
            this.Controls.Add(this.lbCleanupTasks);
            this.Name = "CleanupForm";
            this.Text = "Schoonmaak";
            this.Load += new System.EventHandler(this.LoadCleanupData);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lbCleanupTasks;
        private System.Windows.Forms.Button btnRefreshCleanupList;
        private System.Windows.Forms.DateTimePicker dtpCleanupDate;
        private System.Windows.Forms.Button btnRegisterCleanup;
        private System.Windows.Forms.Label lCleanupDate;
        private System.Windows.Forms.Label lEmployeeName;
        private System.Windows.Forms.ComboBox ddbEmployees;
        private System.Windows.Forms.Label lType;
        private System.Windows.Forms.ComboBox ddbCleanupType;
    }
}