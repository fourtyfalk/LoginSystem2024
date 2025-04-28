namespace LoginSystem2024
{
    partial class Registrieren
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
            this.registrieren_button = new System.Windows.Forms.Button();
            this.textBenutzername = new System.Windows.Forms.TextBox();
            this.textPasswortBe = new System.Windows.Forms.TextBox();
            this.textPasswort = new System.Windows.Forms.TextBox();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.emailAdresse = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.linkLogin = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // registrieren_button
            // 
            this.registrieren_button.Location = new System.Drawing.Point(257, 244);
            this.registrieren_button.Name = "registrieren_button";
            this.registrieren_button.Size = new System.Drawing.Size(112, 23);
            this.registrieren_button.TabIndex = 0;
            this.registrieren_button.Text = "Registrieren";
            this.registrieren_button.UseVisualStyleBackColor = true;
            this.registrieren_button.Click += new System.EventHandler(this.registrieren_button_Click);
            // 
            // textBenutzername
            // 
            this.textBenutzername.Location = new System.Drawing.Point(224, 54);
            this.textBenutzername.Name = "textBenutzername";
            this.textBenutzername.Size = new System.Drawing.Size(195, 20);
            this.textBenutzername.TabIndex = 1;
            this.textBenutzername.TextChanged += new System.EventHandler(this.textBenutzername_TextChanged);
            // 
            // textPasswortBe
            // 
            this.textPasswortBe.Location = new System.Drawing.Point(224, 175);
            this.textPasswortBe.Name = "textPasswortBe";
            this.textPasswortBe.Size = new System.Drawing.Size(195, 20);
            this.textPasswortBe.TabIndex = 3;
            // 
            // textPasswort
            // 
            this.textPasswort.Location = new System.Drawing.Point(224, 140);
            this.textPasswort.Name = "textPasswort";
            this.textPasswort.Size = new System.Drawing.Size(195, 20);
            this.textPasswort.TabIndex = 4;
            // 
            // textEmail
            // 
            this.textEmail.Location = new System.Drawing.Point(224, 97);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(195, 20);
            this.textEmail.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Benutzername";
            // 
            // emailAdresse
            // 
            this.emailAdresse.AutoSize = true;
            this.emailAdresse.Location = new System.Drawing.Point(96, 100);
            this.emailAdresse.Name = "emailAdresse";
            this.emailAdresse.Size = new System.Drawing.Size(77, 13);
            this.emailAdresse.TabIndex = 7;
            this.emailAdresse.Text = "E-Mail Adresse";
            this.emailAdresse.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(96, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Passwort";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(96, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Passwort Wiederholen";
            // 
            // linkLogin
            // 
            this.linkLogin.AutoSize = true;
            this.linkLogin.Location = new System.Drawing.Point(171, 212);
            this.linkLogin.Name = "linkLogin";
            this.linkLogin.Size = new System.Drawing.Size(262, 13);
            this.linkLogin.TabIndex = 10;
            this.linkLogin.TabStop = true;
            this.linkLogin.Text = "Du hast schon ein Account? Melde dich dann hier an!";
            this.linkLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLogin_LinkClicked);
            // 
            // Registrieren
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 361);
            this.Controls.Add(this.linkLogin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.emailAdresse);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.textPasswort);
            this.Controls.Add(this.textPasswortBe);
            this.Controls.Add(this.textBenutzername);
            this.Controls.Add(this.registrieren_button);
            this.Name = "Registrieren";
            this.Text = "Registrieren";
            this.Load += new System.EventHandler(this.Registrieren_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button registrieren_button;
        private System.Windows.Forms.TextBox textBenutzername;
        private System.Windows.Forms.TextBox textPasswortBe;
        private System.Windows.Forms.TextBox textPasswort;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label emailAdresse;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel linkLogin;
    }
}