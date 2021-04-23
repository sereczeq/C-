
namespace TODOList.Kontrolki
{
    partial class RegisterControl
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
            this.buttonZarejestruj = new System.Windows.Forms.Button();
            this.buttonWroc = new System.Windows.Forms.Button();
            this.textBoxHaslo = new System.Windows.Forms.TextBox();
            this.labelImie = new System.Windows.Forms.Label();
            this.labelNiepoprawneImie = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelNiepoprawneLogin = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.labelHaslo = new System.Windows.Forms.Label();
            this.labelNiepoprawneHaslo = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.labelPowtorzHaslo = new System.Windows.Forms.Label();
            this.labelNiepoprawnePowtorzHaslo = new System.Windows.Forms.Label();
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
            this.labelTytul.Text = "Rejestracja";
            this.labelTytul.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonZarejestruj
            // 
            this.buttonZarejestruj.BackColor = System.Drawing.Color.SandyBrown;
            this.buttonZarejestruj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonZarejestruj.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonZarejestruj.Location = new System.Drawing.Point(153, 615);
            this.buttonZarejestruj.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonZarejestruj.Name = "buttonZarejestruj";
            this.buttonZarejestruj.Size = new System.Drawing.Size(360, 123);
            this.buttonZarejestruj.TabIndex = 13;
            this.buttonZarejestruj.Text = "Zarejestruj";
            this.buttonZarejestruj.UseVisualStyleBackColor = false;
            this.buttonZarejestruj.Click += new System.EventHandler(this.buttonZarejestruj_Click);
            // 
            // buttonWroc
            // 
            this.buttonWroc.BackColor = System.Drawing.Color.SandyBrown;
            this.buttonWroc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonWroc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonWroc.Location = new System.Drawing.Point(13, 4);
            this.buttonWroc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonWroc.Name = "buttonWroc";
            this.buttonWroc.Size = new System.Drawing.Size(67, 37);
            this.buttonWroc.TabIndex = 14;
            this.buttonWroc.Text = "wróć";
            this.buttonWroc.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonWroc.UseVisualStyleBackColor = false;
            this.buttonWroc.Click += new System.EventHandler(this.buttonWroc_Click);
            // 
            // textBoxHaslo
            // 
            this.textBoxHaslo.BackColor = System.Drawing.Color.SandyBrown;
            this.textBoxHaslo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxHaslo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxHaslo.Location = new System.Drawing.Point(219, 185);
            this.textBoxHaslo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxHaslo.Name = "textBoxHaslo";
            this.textBoxHaslo.PasswordChar = '*';
            this.textBoxHaslo.Size = new System.Drawing.Size(339, 46);
            this.textBoxHaslo.TabIndex = 17;
            // 
            // labelImie
            // 
            this.labelImie.AutoSize = true;
            this.labelImie.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelImie.Location = new System.Drawing.Point(104, 188);
            this.labelImie.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelImie.Name = "labelImie";
            this.labelImie.Size = new System.Drawing.Size(82, 39);
            this.labelImie.TabIndex = 16;
            this.labelImie.Text = "Imię";
            // 
            // labelNiepoprawneImie
            // 
            this.labelNiepoprawneImie.AutoSize = true;
            this.labelNiepoprawneImie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelNiepoprawneImie.ForeColor = System.Drawing.Color.Red;
            this.labelNiepoprawneImie.Location = new System.Drawing.Point(243, 235);
            this.labelNiepoprawneImie.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNiepoprawneImie.Name = "labelNiepoprawneImie";
            this.labelNiepoprawneImie.Size = new System.Drawing.Size(252, 20);
            this.labelNiepoprawneImie.TabIndex = 15;
            this.labelNiepoprawneImie.Text = "Niepoprawne dane logowania";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.SandyBrown;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox1.Location = new System.Drawing.Point(219, 287);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '*';
            this.textBox1.Size = new System.Drawing.Size(339, 46);
            this.textBox1.TabIndex = 20;
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelLogin.Location = new System.Drawing.Point(84, 289);
            this.labelLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(101, 39);
            this.labelLogin.TabIndex = 19;
            this.labelLogin.Text = "Login";
            // 
            // labelNiepoprawneLogin
            // 
            this.labelNiepoprawneLogin.AutoSize = true;
            this.labelNiepoprawneLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelNiepoprawneLogin.ForeColor = System.Drawing.Color.Red;
            this.labelNiepoprawneLogin.Location = new System.Drawing.Point(243, 337);
            this.labelNiepoprawneLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNiepoprawneLogin.Name = "labelNiepoprawneLogin";
            this.labelNiepoprawneLogin.Size = new System.Drawing.Size(252, 20);
            this.labelNiepoprawneLogin.TabIndex = 18;
            this.labelNiepoprawneLogin.Text = "Niepoprawne dane logowania";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.SandyBrown;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox2.Location = new System.Drawing.Point(219, 382);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(339, 46);
            this.textBox2.TabIndex = 23;
            // 
            // labelHaslo
            // 
            this.labelHaslo.AutoSize = true;
            this.labelHaslo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelHaslo.Location = new System.Drawing.Point(84, 384);
            this.labelHaslo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHaslo.Name = "labelHaslo";
            this.labelHaslo.Size = new System.Drawing.Size(105, 39);
            this.labelHaslo.TabIndex = 22;
            this.labelHaslo.Text = "Hasło";
            // 
            // labelNiepoprawneHaslo
            // 
            this.labelNiepoprawneHaslo.AutoSize = true;
            this.labelNiepoprawneHaslo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelNiepoprawneHaslo.ForeColor = System.Drawing.Color.Red;
            this.labelNiepoprawneHaslo.Location = new System.Drawing.Point(243, 432);
            this.labelNiepoprawneHaslo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNiepoprawneHaslo.Name = "labelNiepoprawneHaslo";
            this.labelNiepoprawneHaslo.Size = new System.Drawing.Size(252, 20);
            this.labelNiepoprawneHaslo.TabIndex = 21;
            this.labelNiepoprawneHaslo.Text = "Niepoprawne dane logowania";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.SandyBrown;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox3.Location = new System.Drawing.Point(219, 479);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox3.Name = "textBox3";
            this.textBox3.PasswordChar = '*';
            this.textBox3.Size = new System.Drawing.Size(339, 46);
            this.textBox3.TabIndex = 26;
            // 
            // labelPowtorzHaslo
            // 
            this.labelPowtorzHaslo.AutoSize = true;
            this.labelPowtorzHaslo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPowtorzHaslo.Location = new System.Drawing.Point(57, 481);
            this.labelPowtorzHaslo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPowtorzHaslo.Name = "labelPowtorzHaslo";
            this.labelPowtorzHaslo.Size = new System.Drawing.Size(150, 39);
            this.labelPowtorzHaslo.TabIndex = 25;
            this.labelPowtorzHaslo.Text = "Hasło x2";
            // 
            // labelNiepoprawnePowtorzHaslo
            // 
            this.labelNiepoprawnePowtorzHaslo.AutoSize = true;
            this.labelNiepoprawnePowtorzHaslo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelNiepoprawnePowtorzHaslo.ForeColor = System.Drawing.Color.Red;
            this.labelNiepoprawnePowtorzHaslo.Location = new System.Drawing.Point(243, 529);
            this.labelNiepoprawnePowtorzHaslo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNiepoprawnePowtorzHaslo.Name = "labelNiepoprawnePowtorzHaslo";
            this.labelNiepoprawnePowtorzHaslo.Size = new System.Drawing.Size(252, 20);
            this.labelNiepoprawnePowtorzHaslo.TabIndex = 24;
            this.labelNiepoprawnePowtorzHaslo.Text = "Niepoprawne dane logowania";
            // 
            // RegisterControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.labelPowtorzHaslo);
            this.Controls.Add(this.labelNiepoprawnePowtorzHaslo);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.labelHaslo);
            this.Controls.Add(this.labelNiepoprawneHaslo);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.labelNiepoprawneLogin);
            this.Controls.Add(this.textBoxHaslo);
            this.Controls.Add(this.labelImie);
            this.Controls.Add(this.labelNiepoprawneImie);
            this.Controls.Add(this.buttonWroc);
            this.Controls.Add(this.buttonZarejestruj);
            this.Controls.Add(this.labelTytul);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "RegisterControl";
            this.Size = new System.Drawing.Size(667, 788);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTytul;
        private System.Windows.Forms.Button buttonZarejestruj;
        private System.Windows.Forms.Button buttonWroc;
        private System.Windows.Forms.TextBox textBoxHaslo;
        private System.Windows.Forms.Label labelImie;
        private System.Windows.Forms.Label labelNiepoprawneImie;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelNiepoprawneLogin;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label labelHaslo;
        private System.Windows.Forms.Label labelNiepoprawneHaslo;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label labelPowtorzHaslo;
        private System.Windows.Forms.Label labelNiepoprawnePowtorzHaslo;
    }
}
