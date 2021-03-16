
namespace MemoryForm
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
            this.labelCzas = new System.Windows.Forms.Label();
            this.labelCzasWartosc = new System.Windows.Forms.Label();
            this.labelPunkty = new System.Windows.Forms.Label();
            this.labelPunktyWartosc = new System.Windows.Forms.Label();
            this.labelPoczatekGry = new System.Windows.Forms.Label();
            this.panelMemory = new System.Windows.Forms.Panel();
            this.timerZakrywacz = new System.Windows.Forms.Timer(this.components);
            this.timerCzasGry = new System.Windows.Forms.Timer(this.components);
            this.timerCzasPodgladu = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // labelCzas
            // 
            this.labelCzas.AutoSize = true;
            this.labelCzas.Location = new System.Drawing.Point(33, 16);
            this.labelCzas.Name = "labelCzas";
            this.labelCzas.Size = new System.Drawing.Size(43, 17);
            this.labelCzas.TabIndex = 0;
            this.labelCzas.Text = "Czas:";
            // 
            // labelCzasWartosc
            // 
            this.labelCzasWartosc.AutoSize = true;
            this.labelCzasWartosc.Location = new System.Drawing.Point(85, 16);
            this.labelCzasWartosc.Name = "labelCzasWartosc";
            this.labelCzasWartosc.Size = new System.Drawing.Size(24, 17);
            this.labelCzasWartosc.TabIndex = 1;
            this.labelCzasWartosc.Text = "60";
            // 
            // labelPunkty
            // 
            this.labelPunkty.AutoSize = true;
            this.labelPunkty.Location = new System.Drawing.Point(204, 16);
            this.labelPunkty.Name = "labelPunkty";
            this.labelPunkty.Size = new System.Drawing.Size(51, 17);
            this.labelPunkty.TabIndex = 2;
            this.labelPunkty.Text = "Punkty";
            // 
            // labelPunktyWartosc
            // 
            this.labelPunktyWartosc.AutoSize = true;
            this.labelPunktyWartosc.Location = new System.Drawing.Point(256, 16);
            this.labelPunktyWartosc.Name = "labelPunktyWartosc";
            this.labelPunktyWartosc.Size = new System.Drawing.Size(24, 17);
            this.labelPunktyWartosc.TabIndex = 3;
            this.labelPunktyWartosc.Text = "10";
            // 
            // labelPoczatekGry
            // 
            this.labelPoczatekGry.AutoSize = true;
            this.labelPoczatekGry.Location = new System.Drawing.Point(365, 16);
            this.labelPoczatekGry.Name = "labelPoczatekGry";
            this.labelPoczatekGry.Size = new System.Drawing.Size(125, 17);
            this.labelPoczatekGry.TabIndex = 4;
            this.labelPoczatekGry.Text = "Początek gry za 5.";
            // 
            // panelMemory
            // 
            this.panelMemory.Location = new System.Drawing.Point(36, 36);
            this.panelMemory.Name = "panelMemory";
            this.panelMemory.Size = new System.Drawing.Size(454, 24);
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
            // timerCzasPodgladu
            // 
            this.timerCzasPodgladu.Interval = 1000;
            // 
            // MemoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 82);
            this.Controls.Add(this.panelMemory);
            this.Controls.Add(this.labelPoczatekGry);
            this.Controls.Add(this.labelPunktyWartosc);
            this.Controls.Add(this.labelPunkty);
            this.Controls.Add(this.labelCzasWartosc);
            this.Controls.Add(this.labelCzas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MemoryForm";
            this.Text = "MemoryGame";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCzas;
        private System.Windows.Forms.Label labelCzasWartosc;
        private System.Windows.Forms.Label labelPunkty;
        private System.Windows.Forms.Label labelPunktyWartosc;
        private System.Windows.Forms.Label labelPoczatekGry;
        private System.Windows.Forms.Panel panelMemory;
        private System.Windows.Forms.Timer timerZakrywacz;
        private System.Windows.Forms.Timer timerCzasGry;
        private System.Windows.Forms.Timer timerCzasPodgladu;
    }
}

