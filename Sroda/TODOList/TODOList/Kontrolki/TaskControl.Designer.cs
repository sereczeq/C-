
namespace TODOList.Kontrolki
{
    partial class TaskControl
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnTytul = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnZrobione = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelImie = new System.Windows.Forms.Label();
            this.buttonDodaj = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.labelTytul = new System.Windows.Forms.Label();
            this.buttonEdytuj = new System.Windows.Forms.Button();
            this.buttonUsun = new System.Windows.Forms.Button();
            this.buttonWroc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.Bisque;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnId,
            this.columnTytul,
            this.columnZrobione});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(71, 164);
            this.listView1.Margin = new System.Windows.Forms.Padding(4);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.ShowGroups = false;
            this.listView1.Size = new System.Drawing.Size(516, 500);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnId
            // 
            this.columnId.Text = "ID";
            this.columnId.Width = 50;
            // 
            // columnTytul
            // 
            this.columnTytul.Text = "Tytuł";
            this.columnTytul.Width = 391;
            // 
            // columnZrobione
            // 
            this.columnZrobione.Text = "Zrobione";
            this.columnZrobione.Width = 70;
            // 
            // labelImie
            // 
            this.labelImie.AutoSize = true;
            this.labelImie.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelImie.Location = new System.Drawing.Point(64, 123);
            this.labelImie.Name = "labelImie";
            this.labelImie.Size = new System.Drawing.Size(127, 38);
            this.labelImie.TabIndex = 2;
            this.labelImie.Text = "Anonim";
            // 
            // buttonDodaj
            // 
            this.buttonDodaj.BackColor = System.Drawing.Color.LawnGreen;
            this.buttonDodaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDodaj.Location = new System.Drawing.Point(71, 677);
            this.buttonDodaj.Name = "buttonDodaj";
            this.buttonDodaj.Size = new System.Drawing.Size(168, 51);
            this.buttonDodaj.TabIndex = 3;
            this.buttonDodaj.Text = "Dodaj";
            this.buttonDodaj.UseVisualStyleBackColor = false;
            // 
            // labelTytul
            // 
            this.labelTytul.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelTytul.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTytul.Location = new System.Drawing.Point(0, 0);
            this.labelTytul.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTytul.Name = "labelTytul";
            this.labelTytul.Size = new System.Drawing.Size(667, 123);
            this.labelTytul.TabIndex = 6;
            this.labelTytul.Text = "TODO lista";
            this.labelTytul.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonEdytuj
            // 
            this.buttonEdytuj.BackColor = System.Drawing.Color.Gold;
            this.buttonEdytuj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEdytuj.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonEdytuj.Location = new System.Drawing.Point(245, 677);
            this.buttonEdytuj.Name = "buttonEdytuj";
            this.buttonEdytuj.Size = new System.Drawing.Size(168, 51);
            this.buttonEdytuj.TabIndex = 7;
            this.buttonEdytuj.Text = "Edytuj";
            this.buttonEdytuj.UseVisualStyleBackColor = false;
            // 
            // buttonUsun
            // 
            this.buttonUsun.BackColor = System.Drawing.Color.Crimson;
            this.buttonUsun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUsun.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonUsun.Location = new System.Drawing.Point(419, 677);
            this.buttonUsun.Name = "buttonUsun";
            this.buttonUsun.Size = new System.Drawing.Size(168, 51);
            this.buttonUsun.TabIndex = 8;
            this.buttonUsun.Text = "Usuń";
            this.buttonUsun.UseVisualStyleBackColor = false;
            // 
            // buttonWroc
            // 
            this.buttonWroc.BackColor = System.Drawing.Color.SandyBrown;
            this.buttonWroc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonWroc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonWroc.Location = new System.Drawing.Point(12, 4);
            this.buttonWroc.Margin = new System.Windows.Forms.Padding(4);
            this.buttonWroc.Name = "buttonWroc";
            this.buttonWroc.Size = new System.Drawing.Size(67, 37);
            this.buttonWroc.TabIndex = 15;
            this.buttonWroc.Text = "wróć";
            this.buttonWroc.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonWroc.UseVisualStyleBackColor = false;
            this.buttonWroc.Click += new System.EventHandler(this.buttonWroc_Click);
            // 
            // TaskControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.Controls.Add(this.buttonWroc);
            this.Controls.Add(this.buttonUsun);
            this.Controls.Add(this.buttonEdytuj);
            this.Controls.Add(this.labelTytul);
            this.Controls.Add(this.buttonDodaj);
            this.Controls.Add(this.labelImie);
            this.Controls.Add(this.listView1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TaskControl";
            this.Size = new System.Drawing.Size(667, 788);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnId;
        private System.Windows.Forms.ColumnHeader columnTytul;
        private System.Windows.Forms.ColumnHeader columnZrobione;
        private System.Windows.Forms.Label labelImie;
        private System.Windows.Forms.Button buttonDodaj;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label labelTytul;
        private System.Windows.Forms.Button buttonEdytuj;
        private System.Windows.Forms.Button buttonUsun;
        private System.Windows.Forms.Button buttonWroc;
    }
}
