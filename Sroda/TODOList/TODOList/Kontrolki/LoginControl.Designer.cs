
namespace TODOList.Kontrolki
{
    partial class LoginControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelTytul = new System.Windows.Forms.Label();
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelNiepoprawne = new System.Windows.Forms.Label();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.buttonZaloguj = new System.Windows.Forms.Button();
            this.buttonZarejestruj = new System.Windows.Forms.Button();
            this.textBoxHaslo = new System.Windows.Forms.TextBox();
            this.labelHaslo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTytul
            // 
            this.labelTytul.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelTytul.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTytul.Location = new System.Drawing.Point(0, 0);
            this.labelTytul.Name = "labelTytul";
            this.labelTytul.Size = new System.Drawing.Size(500, 100);
            this.labelTytul.TabIndex = 0;
            this.labelTytul.Text = "Lista zadań";
            this.labelTytul.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelLogin.Location = new System.Drawing.Point(77, 217);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(80, 31);
            this.labelLogin.TabIndex = 1;
            this.labelLogin.Text = "Login";
            // 
            // labelNiepoprawne
            // 
            this.labelNiepoprawne.AutoSize = true;
            this.labelNiepoprawne.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelNiepoprawne.ForeColor = System.Drawing.Color.Red;
            this.labelNiepoprawne.Location = new System.Drawing.Point(181, 313);
            this.labelNiepoprawne.Name = "labelNiepoprawne";
            this.labelNiepoprawne.Size = new System.Drawing.Size(214, 16);
            this.labelNiepoprawne.TabIndex = 3;
            this.labelNiepoprawne.Text = "Niepoprawne dane logowania";
            this.labelNiepoprawne.Click += new System.EventHandler(this.labelNiepoprawne_Click);
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.BackColor = System.Drawing.Color.SandyBrown;
            this.textBoxLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxLogin.Location = new System.Drawing.Point(163, 214);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(255, 38);
            this.textBoxLogin.TabIndex = 4;
            // 
            // buttonZaloguj
            // 
            this.buttonZaloguj.BackColor = System.Drawing.Color.SandyBrown;
            this.buttonZaloguj.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonZaloguj.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonZaloguj.Location = new System.Drawing.Point(125, 500);
            this.buttonZaloguj.Name = "buttonZaloguj";
            this.buttonZaloguj.Size = new System.Drawing.Size(250, 100);
            this.buttonZaloguj.TabIndex = 6;
            this.buttonZaloguj.Text = "Zaloguj";
            this.buttonZaloguj.UseVisualStyleBackColor = false;
            // 
            // buttonZarejestruj
            // 
            this.buttonZarejestruj.BackColor = System.Drawing.Color.SandyBrown;
            this.buttonZarejestruj.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonZarejestruj.Location = new System.Drawing.Point(343, 374);
            this.buttonZarejestruj.Name = "buttonZarejestruj";
            this.buttonZarejestruj.Size = new System.Drawing.Size(75, 23);
            this.buttonZarejestruj.TabIndex = 7;
            this.buttonZarejestruj.Text = "zarejestruj";
            this.buttonZarejestruj.UseVisualStyleBackColor = false;
            // 
            // textBoxHaslo
            // 
            this.textBoxHaslo.BackColor = System.Drawing.Color.SandyBrown;
            this.textBoxHaslo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxHaslo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxHaslo.Location = new System.Drawing.Point(163, 272);
            this.textBoxHaslo.Name = "textBoxHaslo";
            this.textBoxHaslo.PasswordChar = '*';
            this.textBoxHaslo.Size = new System.Drawing.Size(255, 38);
            this.textBoxHaslo.TabIndex = 9;
            this.textBoxHaslo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // labelHaslo
            // 
            this.labelHaslo.AutoSize = true;
            this.labelHaslo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelHaslo.Location = new System.Drawing.Point(77, 275);
            this.labelHaslo.Name = "labelHaslo";
            this.labelHaslo.Size = new System.Drawing.Size(84, 31);
            this.labelHaslo.TabIndex = 8;
            this.labelHaslo.Text = "Haslo";
            this.labelHaslo.Click += new System.EventHandler(this.label1_Click);
            // 
            // LoginControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.Controls.Add(this.textBoxHaslo);
            this.Controls.Add(this.labelHaslo);
            this.Controls.Add(this.buttonZarejestruj);
            this.Controls.Add(this.buttonZaloguj);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.labelNiepoprawne);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.labelTytul);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "LoginControl";
            this.Size = new System.Drawing.Size(500, 640);
            this.Load += new System.EventHandler(this.LoginControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTytul;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelNiepoprawne;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.Button buttonZaloguj;
        private System.Windows.Forms.Button buttonZarejestruj;
        private System.Windows.Forms.TextBox textBoxHaslo;
        private System.Windows.Forms.Label labelHaslo;
    }
}
