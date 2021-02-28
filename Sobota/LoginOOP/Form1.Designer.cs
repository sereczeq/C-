
namespace LoginOOP
{
    partial class Form1
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
            this.grpGroup = new System.Windows.Forms.GroupBox();
            this.txtHaslo = new System.Windows.Forms.TextBox();
            this.lblHaslo = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.btnZaloguj = new System.Windows.Forms.Button();
            this.lblLogowanie = new System.Windows.Forms.Label();
            this.grpGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpGroup
            // 
            this.grpGroup.AutoSize = true;
            this.grpGroup.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grpGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.grpGroup.Controls.Add(this.txtHaslo);
            this.grpGroup.Controls.Add(this.lblHaslo);
            this.grpGroup.Controls.Add(this.txtLogin);
            this.grpGroup.Controls.Add(this.lblLogin);
            this.grpGroup.Controls.Add(this.btnZaloguj);
            this.grpGroup.Controls.Add(this.lblLogowanie);
            this.grpGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpGroup.Location = new System.Drawing.Point(0, 0);
            this.grpGroup.Name = "grpGroup";
            this.grpGroup.Size = new System.Drawing.Size(438, 450);
            this.grpGroup.TabIndex = 0;
            this.grpGroup.TabStop = false;
            // 
            // txtHaslo
            // 
            this.txtHaslo.BackColor = System.Drawing.SystemColors.Info;
            this.txtHaslo.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtHaslo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtHaslo.Location = new System.Drawing.Point(3, 216);
            this.txtHaslo.Name = "txtHaslo";
            this.txtHaslo.PasswordChar = '*';
            this.txtHaslo.Size = new System.Drawing.Size(432, 38);
            this.txtHaslo.TabIndex = 5;
            // 
            // lblHaslo
            // 
            this.lblHaslo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblHaslo.Location = new System.Drawing.Point(3, 176);
            this.lblHaslo.Name = "lblHaslo";
            this.lblHaslo.Size = new System.Drawing.Size(432, 40);
            this.lblHaslo.TabIndex = 4;
            this.lblHaslo.Text = "Hasło";
            this.lblHaslo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtLogin
            // 
            this.txtLogin.BackColor = System.Drawing.SystemColors.Info;
            this.txtLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtLogin.Location = new System.Drawing.Point(3, 138);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(432, 38);
            this.txtLogin.TabIndex = 3;
            // 
            // lblLogin
            // 
            this.lblLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblLogin.Location = new System.Drawing.Point(3, 98);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(432, 40);
            this.lblLogin.TabIndex = 2;
            this.lblLogin.Text = "Login";
            this.lblLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnZaloguj
            // 
            this.btnZaloguj.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnZaloguj.BackColor = System.Drawing.SystemColors.Info;
            this.btnZaloguj.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnZaloguj.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnZaloguj.Location = new System.Drawing.Point(3, 335);
            this.btnZaloguj.Name = "btnZaloguj";
            this.btnZaloguj.Size = new System.Drawing.Size(432, 112);
            this.btnZaloguj.TabIndex = 1;
            this.btnZaloguj.Text = "ZALOGUJ SIĘ";
            this.btnZaloguj.UseVisualStyleBackColor = false;
            this.btnZaloguj.Click += new System.EventHandler(this.btnZaloguj_Click);
            // 
            // lblLogowanie
            // 
            this.lblLogowanie.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblLogowanie.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblLogowanie.Location = new System.Drawing.Point(3, 18);
            this.lblLogowanie.Name = "lblLogowanie";
            this.lblLogowanie.Size = new System.Drawing.Size(432, 80);
            this.lblLogowanie.TabIndex = 0;
            this.lblLogowanie.Text = "Logowanie do aplikacji";
            this.lblLogowanie.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(438, 450);
            this.Controls.Add(this.grpGroup);
            this.Name = "Form1";
            this.grpGroup.ResumeLayout(false);
            this.grpGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpGroup;
        private System.Windows.Forms.Button btnZaloguj;
        private System.Windows.Forms.Label lblLogowanie;
        private System.Windows.Forms.TextBox txtHaslo;
        private System.Windows.Forms.Label lblHaslo;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label lblLogin;
    }
}

