
namespace MemoryGame
{
    partial class MemoryForm
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
            this.components = new System.ComponentModel.Container();
            this.labelPunkty = new System.Windows.Forms.Label();
            this.labelPunktyWartosc = new System.Windows.Forms.Label();
            this.labelCzas = new System.Windows.Forms.Label();
            this.labelCzasWartosc = new System.Windows.Forms.Label();
            this.labelPoczatekGry = new System.Windows.Forms.Label();
            this.panelMemory = new System.Windows.Forms.Panel();
            this.timerZakrywacz = new System.Windows.Forms.Timer(this.components);
            this.timerCzasGry = new System.Windows.Forms.Timer(this.components);
            this.timerCzasPodlagu = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // labelPunkty
            // 
            this.labelPunkty.AutoSize = true;
            this.labelPunkty.Location = new System.Drawing.Point(16, 11);
            this.labelPunkty.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPunkty.Name = "labelPunkty";
            this.labelPunkty.Size = new System.Drawing.Size(55, 17);
            this.labelPunkty.TabIndex = 0;
            this.labelPunkty.Text = "Punkty:";
            // 
            // labelPunktyWartosc
            // 
            this.labelPunktyWartosc.AutoSize = true;
            this.labelPunktyWartosc.Location = new System.Drawing.Point(81, 11);
            this.labelPunktyWartosc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPunktyWartosc.Name = "labelPunktyWartosc";
            this.labelPunktyWartosc.Size = new System.Drawing.Size(24, 17);
            this.labelPunktyWartosc.TabIndex = 1;
            this.labelPunktyWartosc.Text = "60";
            // 
            // labelCzas
            // 
            this.labelCzas.AutoSize = true;
            this.labelCzas.Location = new System.Drawing.Point(513, 11);
            this.labelCzas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCzas.Name = "labelCzas";
            this.labelCzas.Size = new System.Drawing.Size(43, 17);
            this.labelCzas.TabIndex = 2;
            this.labelCzas.Text = "Czas:";
            // 
            // labelCzasWartosc
            // 
            this.labelCzasWartosc.AutoSize = true;
            this.labelCzasWartosc.Location = new System.Drawing.Point(569, 11);
            this.labelCzasWartosc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCzasWartosc.Name = "labelCzasWartosc";
            this.labelCzasWartosc.Size = new System.Drawing.Size(24, 17);
            this.labelCzasWartosc.TabIndex = 3;
            this.labelCzasWartosc.Text = "60";
            // 
            // labelPoczatekGry
            // 
            this.labelPoczatekGry.AutoSize = true;
            this.labelPoczatekGry.Location = new System.Drawing.Point(261, 11);
            this.labelPoczatekGry.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPoczatekGry.Name = "labelPoczatekGry";
            this.labelPoczatekGry.Size = new System.Drawing.Size(125, 17);
            this.labelPoczatekGry.TabIndex = 4;
            this.labelPoczatekGry.Text = "Początek gry za: 5";
            // 
            // panelMemory
            // 
            this.panelMemory.Location = new System.Drawing.Point(16, 31);
            this.panelMemory.Margin = new System.Windows.Forms.Padding(4);
            this.panelMemory.Name = "panelMemory";
            this.panelMemory.Size = new System.Drawing.Size(580, 21);
            this.panelMemory.TabIndex = 5;
            // 
            // timerZakrywacz
            // 
            this.timerZakrywacz.Interval = 1000;
            // 
            // timerCzasGry
            // 
            this.timerCzasGry.Interval = 1000;
            // 
            // timerCzasPodlagu
            // 
            this.timerCzasPodlagu.Interval = 1000;
            this.timerCzasPodlagu.Tick += new System.EventHandler(this.timerCzasPodlagu_Tick);
            // 
            // MemoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(617, 63);
            this.Controls.Add(this.panelMemory);
            this.Controls.Add(this.labelPoczatekGry);
            this.Controls.Add(this.labelCzasWartosc);
            this.Controls.Add(this.labelCzas);
            this.Controls.Add(this.labelPunktyWartosc);
            this.Controls.Add(this.labelPunkty);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MemoryForm";
            this.Text = "Memory Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPunkty;
        private System.Windows.Forms.Label labelPunktyWartosc;
        private System.Windows.Forms.Label labelCzas;
        private System.Windows.Forms.Label labelCzasWartosc;
        private System.Windows.Forms.Label labelPoczatekGry;
        private System.Windows.Forms.Panel panelMemory;
        private System.Windows.Forms.Timer timerZakrywacz;
        private System.Windows.Forms.Timer timerCzasGry;
        private System.Windows.Forms.Timer timerCzasPodlagu;
    }
}

