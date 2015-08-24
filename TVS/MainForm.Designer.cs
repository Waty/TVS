namespace TVS
{
    partial class MainForm
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
            this.tbLoginNaam = new System.Windows.Forms.TextBox();
            this.tbLoginWachtwoord = new System.Windows.Forms.TextBox();
            this.lbGebruikersNaam = new System.Windows.Forms.Label();
            this.lbWachtwoord = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lbGebruiker = new System.Windows.Forms.Label();
            this.btnLoguit = new System.Windows.Forms.Button();
            this.lbLijst = new System.Windows.Forms.ListBox();
            this.btnSchoonmaaklijst = new System.Windows.Forms.Button();
            this.btnStatus = new System.Windows.Forms.Button();
            this.btnReparatie = new System.Windows.Forms.Button();
            this.btnSchoonmaakbeurt = new System.Windows.Forms.Button();
            this.btnService = new System.Windows.Forms.Button();
            this.btnRemise = new System.Windows.Forms.Button();
            this.btnStatusAanpassen = new System.Windows.Forms.Button();
            this.btnBlokkeer = new System.Windows.Forms.Button();
            this.btnDeblokkeer = new System.Windows.Forms.Button();
            this.btnWagenToevoegen = new System.Windows.Forms.Button();
            this.btnWagens = new System.Windows.Forms.Button();
            this.btnSporen = new System.Windows.Forms.Button();
            this.btnWijsToe = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pnMain = new System.Windows.Forms.Panel();
            this.pnMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbLoginNaam
            // 
            this.tbLoginNaam.Location = new System.Drawing.Point(616, 13);
            this.tbLoginNaam.Name = "tbLoginNaam";
            this.tbLoginNaam.Size = new System.Drawing.Size(100, 20);
            this.tbLoginNaam.TabIndex = 0;
            // 
            // tbLoginWachtwoord
            // 
            this.tbLoginWachtwoord.Location = new System.Drawing.Point(616, 39);
            this.tbLoginWachtwoord.Name = "tbLoginWachtwoord";
            this.tbLoginWachtwoord.Size = new System.Drawing.Size(100, 20);
            this.tbLoginWachtwoord.TabIndex = 1;
            // 
            // lbGebruikersNaam
            // 
            this.lbGebruikersNaam.AutoSize = true;
            this.lbGebruikersNaam.Location = new System.Drawing.Point(520, 16);
            this.lbGebruikersNaam.Name = "lbGebruikersNaam";
            this.lbGebruikersNaam.Size = new System.Drawing.Size(90, 13);
            this.lbGebruikersNaam.TabIndex = 2;
            this.lbGebruikersNaam.Text = "Gebruikersnaam: ";
            // 
            // lbWachtwoord
            // 
            this.lbWachtwoord.AutoSize = true;
            this.lbWachtwoord.Location = new System.Drawing.Point(536, 42);
            this.lbWachtwoord.Name = "lbWachtwoord";
            this.lbWachtwoord.Size = new System.Drawing.Size(71, 13);
            this.lbWachtwoord.TabIndex = 3;
            this.lbWachtwoord.Text = "Wachtwoord:";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(616, 65);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(100, 23);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lbGebruiker
            // 
            this.lbGebruiker.AutoSize = true;
            this.lbGebruiker.Location = new System.Drawing.Point(616, 16);
            this.lbGebruiker.Name = "lbGebruiker";
            this.lbGebruiker.Size = new System.Drawing.Size(35, 13);
            this.lbGebruiker.TabIndex = 5;
            this.lbGebruiker.Text = "label1";
            this.lbGebruiker.Visible = false;
            // 
            // btnLoguit
            // 
            this.btnLoguit.Location = new System.Drawing.Point(616, 36);
            this.btnLoguit.Name = "btnLoguit";
            this.btnLoguit.Size = new System.Drawing.Size(100, 23);
            this.btnLoguit.TabIndex = 6;
            this.btnLoguit.Text = "Log uit";
            this.btnLoguit.UseVisualStyleBackColor = true;
            this.btnLoguit.Visible = false;
            this.btnLoguit.Click += new System.EventHandler(this.btnLoguit_Click);
            // 
            // lbLijst
            // 
            this.lbLijst.FormattingEnabled = true;
            this.lbLijst.Location = new System.Drawing.Point(101, 12);
            this.lbLijst.Name = "lbLijst";
            this.lbLijst.Size = new System.Drawing.Size(202, 316);
            this.lbLijst.TabIndex = 7;
            // 
            // btnSchoonmaaklijst
            // 
            this.btnSchoonmaaklijst.Location = new System.Drawing.Point(314, 273);
            this.btnSchoonmaaklijst.Name = "btnSchoonmaaklijst";
            this.btnSchoonmaaklijst.Size = new System.Drawing.Size(108, 23);
            this.btnSchoonmaaklijst.TabIndex = 8;
            this.btnSchoonmaaklijst.Text = "Schoonmaaklijst";
            this.btnSchoonmaaklijst.UseVisualStyleBackColor = true;
            // 
            // btnStatus
            // 
            this.btnStatus.Location = new System.Drawing.Point(314, 11);
            this.btnStatus.Name = "btnStatus";
            this.btnStatus.Size = new System.Drawing.Size(108, 23);
            this.btnStatus.TabIndex = 9;
            this.btnStatus.Text = "Status invoegen";
            this.btnStatus.UseVisualStyleBackColor = true;
            // 
            // btnReparatie
            // 
            this.btnReparatie.Location = new System.Drawing.Point(314, 40);
            this.btnReparatie.Name = "btnReparatie";
            this.btnReparatie.Size = new System.Drawing.Size(108, 23);
            this.btnReparatie.TabIndex = 10;
            this.btnReparatie.Text = "Reparatie plannen";
            this.btnReparatie.UseVisualStyleBackColor = true;
            // 
            // btnSchoonmaakbeurt
            // 
            this.btnSchoonmaakbeurt.Location = new System.Drawing.Point(314, 302);
            this.btnSchoonmaakbeurt.Name = "btnSchoonmaakbeurt";
            this.btnSchoonmaakbeurt.Size = new System.Drawing.Size(108, 23);
            this.btnSchoonmaakbeurt.TabIndex = 11;
            this.btnSchoonmaakbeurt.Text = "Plan schoonmaken";
            this.btnSchoonmaakbeurt.UseVisualStyleBackColor = true;
            // 
            // btnService
            // 
            this.btnService.Location = new System.Drawing.Point(314, 128);
            this.btnService.Name = "btnService";
            this.btnService.Size = new System.Drawing.Size(108, 23);
            this.btnService.TabIndex = 12;
            this.btnService.Text = "Plan servicebeurt";
            this.btnService.UseVisualStyleBackColor = true;
            // 
            // btnRemise
            // 
            this.btnRemise.Location = new System.Drawing.Point(314, 157);
            this.btnRemise.Name = "btnRemise";
            this.btnRemise.Size = new System.Drawing.Size(108, 23);
            this.btnRemise.TabIndex = 13;
            this.btnRemise.Text = "Zet in remise";
            this.btnRemise.UseVisualStyleBackColor = true;
            // 
            // btnStatusAanpassen
            // 
            this.btnStatusAanpassen.Location = new System.Drawing.Point(314, 186);
            this.btnStatusAanpassen.Name = "btnStatusAanpassen";
            this.btnStatusAanpassen.Size = new System.Drawing.Size(108, 23);
            this.btnStatusAanpassen.TabIndex = 14;
            this.btnStatusAanpassen.Text = "Status aanpassen";
            this.btnStatusAanpassen.UseVisualStyleBackColor = true;
            // 
            // btnBlokkeer
            // 
            this.btnBlokkeer.Location = new System.Drawing.Point(314, 215);
            this.btnBlokkeer.Name = "btnBlokkeer";
            this.btnBlokkeer.Size = new System.Drawing.Size(108, 23);
            this.btnBlokkeer.TabIndex = 15;
            this.btnBlokkeer.Text = "Spoor blokkeren";
            this.btnBlokkeer.UseVisualStyleBackColor = true;
            // 
            // btnDeblokkeer
            // 
            this.btnDeblokkeer.Location = new System.Drawing.Point(314, 244);
            this.btnDeblokkeer.Name = "btnDeblokkeer";
            this.btnDeblokkeer.Size = new System.Drawing.Size(108, 23);
            this.btnDeblokkeer.TabIndex = 16;
            this.btnDeblokkeer.Text = "Spoor deblokkeren";
            this.btnDeblokkeer.UseVisualStyleBackColor = true;
            // 
            // btnWagenToevoegen
            // 
            this.btnWagenToevoegen.Location = new System.Drawing.Point(314, 98);
            this.btnWagenToevoegen.Name = "btnWagenToevoegen";
            this.btnWagenToevoegen.Size = new System.Drawing.Size(109, 23);
            this.btnWagenToevoegen.TabIndex = 17;
            this.btnWagenToevoegen.Text = "Wagen toevoegen";
            this.btnWagenToevoegen.UseVisualStyleBackColor = true;
            // 
            // btnWagens
            // 
            this.btnWagens.Location = new System.Drawing.Point(8, 37);
            this.btnWagens.Name = "btnWagens";
            this.btnWagens.Size = new System.Drawing.Size(81, 23);
            this.btnWagens.TabIndex = 18;
            this.btnWagens.Text = "Toon wagens";
            this.btnWagens.UseVisualStyleBackColor = true;
            // 
            // btnSporen
            // 
            this.btnSporen.Location = new System.Drawing.Point(8, 11);
            this.btnSporen.Name = "btnSporen";
            this.btnSporen.Size = new System.Drawing.Size(81, 23);
            this.btnSporen.TabIndex = 19;
            this.btnSporen.Text = "Toon sporen";
            this.btnSporen.UseVisualStyleBackColor = true;
            // 
            // btnWijsToe
            // 
            this.btnWijsToe.Location = new System.Drawing.Point(315, 69);
            this.btnWijsToe.Name = "btnWijsToe";
            this.btnWijsToe.Size = new System.Drawing.Size(108, 23);
            this.btnWijsToe.TabIndex = 20;
            this.btnWijsToe.Text = "Wijs toe aan spoor";
            this.btnWijsToe.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(429, 71);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(40, 21);
            this.comboBox1.TabIndex = 21;
            // 
            // pnMain
            // 
            this.pnMain.Controls.Add(this.lbLijst);
            this.pnMain.Controls.Add(this.comboBox1);
            this.pnMain.Controls.Add(this.btnSchoonmaaklijst);
            this.pnMain.Controls.Add(this.btnWijsToe);
            this.pnMain.Controls.Add(this.btnStatus);
            this.pnMain.Controls.Add(this.btnSporen);
            this.pnMain.Controls.Add(this.btnReparatie);
            this.pnMain.Controls.Add(this.btnWagens);
            this.pnMain.Controls.Add(this.btnSchoonmaakbeurt);
            this.pnMain.Controls.Add(this.btnWagenToevoegen);
            this.pnMain.Controls.Add(this.btnService);
            this.pnMain.Controls.Add(this.btnDeblokkeer);
            this.pnMain.Controls.Add(this.btnRemise);
            this.pnMain.Controls.Add(this.btnBlokkeer);
            this.pnMain.Controls.Add(this.btnStatusAanpassen);
            this.pnMain.Location = new System.Drawing.Point(12, 13);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(478, 341);
            this.pnMain.TabIndex = 22;
            this.pnMain.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 367);
            this.Controls.Add(this.pnMain);
            this.Controls.Add(this.btnLoguit);
            this.Controls.Add(this.lbGebruiker);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lbWachtwoord);
            this.Controls.Add(this.lbGebruikersNaam);
            this.Controls.Add(this.tbLoginWachtwoord);
            this.Controls.Add(this.tbLoginNaam);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.pnMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbLoginNaam;
        private System.Windows.Forms.TextBox tbLoginWachtwoord;
        private System.Windows.Forms.Label lbGebruikersNaam;
        private System.Windows.Forms.Label lbWachtwoord;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lbGebruiker;
        private System.Windows.Forms.Button btnLoguit;
        private System.Windows.Forms.ListBox lbLijst;
        private System.Windows.Forms.Button btnSchoonmaaklijst;
        private System.Windows.Forms.Button btnStatus;
        private System.Windows.Forms.Button btnReparatie;
        private System.Windows.Forms.Button btnSchoonmaakbeurt;
        private System.Windows.Forms.Button btnService;
        private System.Windows.Forms.Button btnRemise;
        private System.Windows.Forms.Button btnStatusAanpassen;
        private System.Windows.Forms.Button btnBlokkeer;
        private System.Windows.Forms.Button btnDeblokkeer;
        private System.Windows.Forms.Button btnWagenToevoegen;
        private System.Windows.Forms.Button btnWagens;
        private System.Windows.Forms.Button btnSporen;
        private System.Windows.Forms.Button btnWijsToe;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel pnMain;
    }
}

