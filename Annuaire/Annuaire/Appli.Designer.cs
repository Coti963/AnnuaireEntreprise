namespace Annuaire
{
    partial class Appli
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        public void InitializeComponent()
        {
            this.Button_Quitter = new System.Windows.Forms.Button();
            this.dateTimePicker_Date = new System.Windows.Forms.DateTimePicker();
            this.label_Recherche = new System.Windows.Forms.Label();
            this.textBox_Recherche = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Colonne_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Colonne_Prénom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Colonne_Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Téléphone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Colonne_Service = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Button_Recherche = new System.Windows.Forms.Button();
            this.button_Add_User = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Button_Quitter
            // 
            this.Button_Quitter.Location = new System.Drawing.Point(810, 309);
            this.Button_Quitter.Name = "Button_Quitter";
            this.Button_Quitter.Size = new System.Drawing.Size(87, 47);
            this.Button_Quitter.TabIndex = 1;
            this.Button_Quitter.Text = "Quitter";
            this.Button_Quitter.UseVisualStyleBackColor = true;
            this.Button_Quitter.Click += new System.EventHandler(this.Button_Quitter_Click);
            // 
            // dateTimePicker_Date
            // 
            this.dateTimePicker_Date.CustomFormat = "MM-dd-yyyy";
            this.dateTimePicker_Date.Location = new System.Drawing.Point(589, 6);
            this.dateTimePicker_Date.Name = "dateTimePicker_Date";
            this.dateTimePicker_Date.Size = new System.Drawing.Size(275, 22);
            this.dateTimePicker_Date.TabIndex = 2;
            this.dateTimePicker_Date.ValueChanged += new System.EventHandler(this.dateTimePicker_Date_ValueChanged);
            // 
            // label_Recherche
            // 
            this.label_Recherche.AutoSize = true;
            this.label_Recherche.Location = new System.Drawing.Point(9, 9);
            this.label_Recherche.Name = "label_Recherche";
            this.label_Recherche.Size = new System.Drawing.Size(79, 16);
            this.label_Recherche.TabIndex = 3;
            this.label_Recherche.Text = "Recherche :";
            this.label_Recherche.Click += new System.EventHandler(this.label_Recherche_Click);
            // 
            // textBox_Recherche
            // 
            this.textBox_Recherche.Location = new System.Drawing.Point(94, 6);
            this.textBox_Recherche.Name = "textBox_Recherche";
            this.textBox_Recherche.Size = new System.Drawing.Size(373, 22);
            this.textBox_Recherche.TabIndex = 5;
            this.textBox_Recherche.TextChanged += new System.EventHandler(this.textBox_Recherche_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Colonne_ID,
            this.Colonne_Prénom,
            this.Colonne_Nom,
            this.Téléphone,
            this.Colonne_Service});
            this.dataGridView1.Location = new System.Drawing.Point(12, 80);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(885, 223);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Colonne_ID
            // 
            this.Colonne_ID.HeaderText = "ID";
            this.Colonne_ID.MinimumWidth = 6;
            this.Colonne_ID.Name = "Colonne_ID";
            this.Colonne_ID.ReadOnly = true;
            this.Colonne_ID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Colonne_ID.Width = 125;
            // 
            // Colonne_Prénom
            // 
            this.Colonne_Prénom.HeaderText = "Prénom";
            this.Colonne_Prénom.MinimumWidth = 6;
            this.Colonne_Prénom.Name = "Colonne_Prénom";
            this.Colonne_Prénom.ReadOnly = true;
            this.Colonne_Prénom.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Colonne_Prénom.Width = 125;
            // 
            // Colonne_Nom
            // 
            this.Colonne_Nom.HeaderText = "Nom";
            this.Colonne_Nom.MinimumWidth = 6;
            this.Colonne_Nom.Name = "Colonne_Nom";
            this.Colonne_Nom.ReadOnly = true;
            this.Colonne_Nom.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Colonne_Nom.Width = 125;
            // 
            // Téléphone
            // 
            this.Téléphone.HeaderText = "Téléphone";
            this.Téléphone.MinimumWidth = 6;
            this.Téléphone.Name = "Téléphone";
            this.Téléphone.ReadOnly = true;
            this.Téléphone.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Téléphone.Width = 125;
            // 
            // Colonne_Service
            // 
            this.Colonne_Service.HeaderText = "Service";
            this.Colonne_Service.MinimumWidth = 6;
            this.Colonne_Service.Name = "Colonne_Service";
            this.Colonne_Service.ReadOnly = true;
            this.Colonne_Service.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Colonne_Service.Width = 125;
            // 
            // Button_Recherche
            // 
            this.Button_Recherche.Location = new System.Drawing.Point(473, 6);
            this.Button_Recherche.Name = "Button_Recherche";
            this.Button_Recherche.Size = new System.Drawing.Size(92, 23);
            this.Button_Recherche.TabIndex = 7;
            this.Button_Recherche.Text = "Recherche";
            this.Button_Recherche.UseVisualStyleBackColor = true;
            this.Button_Recherche.Click += new System.EventHandler(this.Button_Recherche_Click);
            // 
            // button_Add_User
            // 
            this.button_Add_User.Location = new System.Drawing.Point(717, 309);
            this.button_Add_User.Name = "button_Add_User";
            this.button_Add_User.Size = new System.Drawing.Size(87, 47);
            this.button_Add_User.TabIndex = 8;
            this.button_Add_User.Text = "Ajouter User";
            this.button_Add_User.UseVisualStyleBackColor = true;
            this.button_Add_User.Click += new System.EventHandler(this.button_Add_User_Click);
            // 
            // Appli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 364);
            this.Controls.Add(this.button_Add_User);
            this.Controls.Add(this.Button_Recherche);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox_Recherche);
            this.Controls.Add(this.label_Recherche);
            this.Controls.Add(this.dateTimePicker_Date);
            this.Controls.Add(this.Button_Quitter);
            this.MaximumSize = new System.Drawing.Size(927, 411);
            this.MinimumSize = new System.Drawing.Size(927, 411);
            this.Name = "Appli";
            this.Text = "Annuaire";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Button_Quitter;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Date;
        private System.Windows.Forms.Label label_Recherche;
        private System.Windows.Forms.TextBox textBox_Recherche;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Button_Recherche;
        private System.Windows.Forms.Button button_Add_User;
        private System.Windows.Forms.DataGridViewTextBoxColumn Colonne_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Colonne_Prénom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Colonne_Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Téléphone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Colonne_Service;
    }
}

