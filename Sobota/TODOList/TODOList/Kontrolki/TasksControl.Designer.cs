
namespace TODOList.Kontrolki
{
    partial class TasksControl
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
            this.listViewZadania = new System.Windows.Forms.ListView();
            this.columnId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnTytul = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnZrobione = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelImie = new System.Windows.Forms.Label();
            this.buttonDodaj = new System.Windows.Forms.Button();
            this.buttonEdytuj = new System.Windows.Forms.Button();
            this.buttonUsun = new System.Windows.Forms.Button();
            this.buttonWroc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewZadania
            // 
            this.listViewZadania.BackColor = System.Drawing.Color.Gainsboro;
            this.listViewZadania.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnId,
            this.columnTytul,
            this.columnZrobione});
            this.listViewZadania.FullRowSelect = true;
            this.listViewZadania.GridLines = true;
            this.listViewZadania.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewZadania.HideSelection = false;
            this.listViewZadania.Location = new System.Drawing.Point(48, 165);
            this.listViewZadania.MultiSelect = false;
            this.listViewZadania.Name = "listViewZadania";
            this.listViewZadania.ShowGroups = false;
            this.listViewZadania.Size = new System.Drawing.Size(414, 369);
            this.listViewZadania.TabIndex = 0;
            this.listViewZadania.UseCompatibleStateImageBehavior = false;
            this.listViewZadania.View = System.Windows.Forms.View.Details;
            // 
            // columnId
            // 
            this.columnId.Text = "ID";
            this.columnId.Width = 54;
            // 
            // columnTytul
            // 
            this.columnTytul.Text = "Tytuł";
            this.columnTytul.Width = 233;
            // 
            // columnZrobione
            // 
            this.columnZrobione.Text = "Zrobione";
            this.columnZrobione.Width = 247;
            // 
            // labelTitle
            // 
            this.labelTitle.BackColor = System.Drawing.SystemColors.Info;
            this.labelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTitle.Location = new System.Drawing.Point(0, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(500, 123);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "TODO";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelImie
            // 
            this.labelImie.AutoSize = true;
            this.labelImie.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelImie.Location = new System.Drawing.Point(41, 123);
            this.labelImie.Name = "labelImie";
            this.labelImie.Size = new System.Drawing.Size(93, 38);
            this.labelImie.TabIndex = 3;
            this.labelImie.Text = "Anon";
            // 
            // buttonDodaj
            // 
            this.buttonDodaj.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.buttonDodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDodaj.Location = new System.Drawing.Point(48, 554);
            this.buttonDodaj.Name = "buttonDodaj";
            this.buttonDodaj.Size = new System.Drawing.Size(134, 58);
            this.buttonDodaj.TabIndex = 4;
            this.buttonDodaj.Text = "dodaj";
            this.buttonDodaj.UseVisualStyleBackColor = false;
            // 
            // buttonEdytuj
            // 
            this.buttonEdytuj.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.buttonEdytuj.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonEdytuj.Location = new System.Drawing.Point(188, 554);
            this.buttonEdytuj.Name = "buttonEdytuj";
            this.buttonEdytuj.Size = new System.Drawing.Size(134, 58);
            this.buttonEdytuj.TabIndex = 5;
            this.buttonEdytuj.Text = "edytuj";
            this.buttonEdytuj.UseVisualStyleBackColor = false;
            // 
            // buttonUsun
            // 
            this.buttonUsun.BackColor = System.Drawing.Color.Red;
            this.buttonUsun.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonUsun.Location = new System.Drawing.Point(328, 554);
            this.buttonUsun.Name = "buttonUsun";
            this.buttonUsun.Size = new System.Drawing.Size(134, 58);
            this.buttonUsun.TabIndex = 6;
            this.buttonUsun.Text = "usuń";
            this.buttonUsun.UseVisualStyleBackColor = false;
            // 
            // buttonWroc
            // 
            this.buttonWroc.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.buttonWroc.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonWroc.Location = new System.Drawing.Point(12, 52);
            this.buttonWroc.Name = "buttonWroc";
            this.buttonWroc.Size = new System.Drawing.Size(70, 41);
            this.buttonWroc.TabIndex = 24;
            this.buttonWroc.Text = "⟸";
            this.buttonWroc.UseVisualStyleBackColor = false;
            this.buttonWroc.Click += new System.EventHandler(this.buttonWroc_Click);
            // 
            // TasksControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.Controls.Add(this.buttonWroc);
            this.Controls.Add(this.buttonUsun);
            this.Controls.Add(this.buttonEdytuj);
            this.Controls.Add(this.buttonDodaj);
            this.Controls.Add(this.labelImie);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.listViewZadania);
            this.Name = "TasksControl";
            this.Size = new System.Drawing.Size(500, 640);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewZadania;
        private System.Windows.Forms.ColumnHeader columnId;
        private System.Windows.Forms.ColumnHeader columnTytul;
        private System.Windows.Forms.ColumnHeader columnZrobione;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelImie;
        private System.Windows.Forms.Button buttonDodaj;
        private System.Windows.Forms.Button buttonEdytuj;
        private System.Windows.Forms.Button buttonUsun;
        private System.Windows.Forms.Button buttonWroc;
    }
}
