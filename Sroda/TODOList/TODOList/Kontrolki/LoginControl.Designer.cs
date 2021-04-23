
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
            this.labelTytul.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTytul.Name = "labelTytul";
            this.labelTytul.Size = new System.Drawing.Size(667, 123);
            this.labelTytul.TabIndex = 0;
            this.labelTytul.Text = "Lista zadań";
            this.labelTytul.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelLogin.Location = new System.Drawing.Point(103, 267);
            this.labelLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(101, 39);
            this.labelLogin.TabIndex = 1;
            this.labelLogin.Text = "Login";
            // 
            // labelNiepoprawne
            // 
            this.labelNiepoprawne.AutoSize = true;
            this.labelNiepoprawne.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelNiepoprawne.ForeColor = System.Drawing.Color.Red;
            this.labelNiepoprawne.Location = new System.Drawing.Point(241, 385);
            this.labelNiepoprawne.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNiepoprawne.Name = "labelNiepoprawne";
            this.labelNiepoprawne.Size = new System.Drawing.Size(252, 20);
            this.labelNiepoprawne.TabIndex = 3;
            this.labelNiepoprawne.Text = "Niepoprawne dane logowania";
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.BackColor = System.Drawing.Color.SandyBrown;
            this.textBoxLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxLogin.Location = new System.Drawing.Point(217, 263);
            this.textBoxLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(339, 46);
            this.textBoxLogin.TabIndex = 4;
            // 
            // buttonZaloguj
            // 
            this.buttonZaloguj.BackColor = System.Drawing.Color.SandyBrown;
            this.buttonZaloguj.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonZaloguj.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonZaloguj.Location = new System.Drawing.Point(167, 615);
            this.buttonZaloguj.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonZaloguj.Name = "buttonZaloguj";
            this.buttonZaloguj.Size = new System.Drawing.Size(333, 123);
            this.buttonZaloguj.TabIndex = 6;
            this.buttonZaloguj.Text = "Zaloguj";
            this.buttonZaloguj.UseVisualStyleBackColor = false;
            this.buttonZaloguj.Click += new System.EventHandler(this.buttonZaloguj_Click);
            // 
            // buttonZarejestruj
            // 
            this.buttonZarejestruj.BackColor = System.Drawing.Color.SandyBrown;
            this.buttonZarejestruj.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonZarejestruj.Location = new System.Drawing.Point(457, 460);
            this.buttonZarejestruj.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonZarejestruj.Name = "buttonZarejestruj";
            this.buttonZarejestruj.Size = new System.Drawing.Size(100, 28);
            this.buttonZarejestruj.TabIndex = 7;
            this.buttonZarejestruj.Text = "zarejestruj";
            this.buttonZarejestruj.UseVisualStyleBackColor = false;
            this.buttonZarejestruj.Click += new System.EventHandler(this.buttonZarejestruj_Click);
            // 
            // textBoxHaslo
            // 
            this.textBoxHaslo.BackColor = System.Drawing.Color.SandyBrown;
            this.textBoxHaslo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxHaslo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxHaslo.Location = new System.Drawing.Point(217, 335);
            this.textBoxHaslo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxHaslo.Name = "textBoxHaslo";
            this.textBoxHaslo.PasswordChar = '*';
            this.textBoxHaslo.Size = new System.Drawing.Size(339, 46);
            this.textBoxHaslo.TabIndex = 9;
            // 
            // labelHaslo
            // 
            this.labelHaslo.AutoSize = true;
            this.labelHaslo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelHaslo.Location = new System.Drawing.Point(103, 338);
            this.labelHaslo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHaslo.Name = "labelHaslo";
            this.labelHaslo.Size = new System.Drawing.Size(105, 39);
            this.labelHaslo.TabIndex = 8;
            this.labelHaslo.Text = "Haslo";
            // 
            // LoginControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "LoginControl";
            this.Size = new System.Drawing.Size(667, 788);
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
