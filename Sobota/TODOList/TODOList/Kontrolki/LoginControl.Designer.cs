
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.textBoxHaslo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonZaloguj = new System.Windows.Forms.Button();
            this.buttonUtworzKonto = new System.Windows.Forms.Button();
            this.labelWalidacjaLogowania = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(500, 129);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lista zadań";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxLogin.Location = new System.Drawing.Point(187, 231);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(256, 45);
            this.textBoxLogin.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // textBoxHaslo
            // 
            this.textBoxHaslo.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxHaslo.Location = new System.Drawing.Point(187, 308);
            this.textBoxHaslo.Name = "textBoxHaslo";
            this.textBoxHaslo.PasswordChar = '*';
            this.textBoxHaslo.Size = new System.Drawing.Size(256, 45);
            this.textBoxHaslo.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(62, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 39);
            this.label2.TabIndex = 4;
            this.label2.Text = "Login: ";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(58, 308);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 39);
            this.label3.TabIndex = 5;
            this.label3.Text = "Hasło: ";
            // 
            // buttonZaloguj
            // 
            this.buttonZaloguj.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.buttonZaloguj.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonZaloguj.Location = new System.Drawing.Point(65, 525);
            this.buttonZaloguj.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.buttonZaloguj.Name = "buttonZaloguj";
            this.buttonZaloguj.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.buttonZaloguj.Size = new System.Drawing.Size(378, 71);
            this.buttonZaloguj.TabIndex = 6;
            this.buttonZaloguj.Text = "Zaloguj";
            this.buttonZaloguj.UseVisualStyleBackColor = false;
            // 
            // buttonUtworzKonto
            // 
            this.buttonUtworzKonto.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.buttonUtworzKonto.Location = new System.Drawing.Point(326, 400);
            this.buttonUtworzKonto.Name = "buttonUtworzKonto";
            this.buttonUtworzKonto.Size = new System.Drawing.Size(117, 40);
            this.buttonUtworzKonto.TabIndex = 7;
            this.buttonUtworzKonto.Text = "Utwórz konto";
            this.buttonUtworzKonto.UseVisualStyleBackColor = false;
            // 
            // labelWalidacjaLogowania
            // 
            this.labelWalidacjaLogowania.AutoSize = true;
            this.labelWalidacjaLogowania.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelWalidacjaLogowania.ForeColor = System.Drawing.Color.Red;
            this.labelWalidacjaLogowania.Location = new System.Drawing.Point(166, 356);
            this.labelWalidacjaLogowania.Name = "labelWalidacjaLogowania";
            this.labelWalidacjaLogowania.Size = new System.Drawing.Size(295, 25);
            this.labelWalidacjaLogowania.TabIndex = 8;
            this.labelWalidacjaLogowania.Text = "Niepoprawne dane logowania";
            this.labelWalidacjaLogowania.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoginControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.Controls.Add(this.labelWalidacjaLogowania);
            this.Controls.Add(this.buttonUtworzKonto);
            this.Controls.Add(this.buttonZaloguj);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxHaslo);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.label1);
            this.Name = "LoginControl";
            this.Size = new System.Drawing.Size(500, 640);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox textBoxHaslo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonZaloguj;
        private System.Windows.Forms.Button buttonUtworzKonto;
        private System.Windows.Forms.Label labelWalidacjaLogowania;
    }
}
