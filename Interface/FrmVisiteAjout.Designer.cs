namespace Interface
{
    partial class FrmVisiteAjout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVisiteAjout));
            panel2 = new Panel();
            btnAjouter = new Button();
            cbxPraticien = new ComboBox();
            dtpDate = new DateTimePicker();
            lblNouveauRdv = new Label();
            lblDateHeure = new Label();
            lblPraticien = new Label();
            cbxMotif = new ComboBox();
            lblMotif = new Label();
            panelDroit = new Panel();
            panelGauche = new Panel();
            label1 = new Label();
            dgvVisites = new DataGridView();
            panel2.SuspendLayout();
            panelDroit.SuspendLayout();
            panelGauche.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVisites).BeginInit();
            SuspendLayout();
            // 
            // lblTitre
            // 
            lblTitre.Size = new Size(1015, 59);
            // 
            // panel2
            // 
            panel2.Controls.Add(btnAjouter);
            panel2.Controls.Add(cbxPraticien);
            panel2.Controls.Add(dtpDate);
            panel2.Controls.Add(lblNouveauRdv);
            panel2.Controls.Add(lblDateHeure);
            panel2.Controls.Add(lblPraticien);
            panel2.Controls.Add(cbxMotif);
            panel2.Controls.Add(lblMotif);
            panel2.Location = new Point(32, 28);
            panel2.Name = "panel2";
            panel2.Size = new Size(368, 275);
            panel2.TabIndex = 8;
            // 
            // btnAjouter
            // 
            btnAjouter.BackColor = Color.Red;
            btnAjouter.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnAjouter.ForeColor = Color.White;
            btnAjouter.Location = new Point(109, 217);
            btnAjouter.Name = "btnAjouter";
            btnAjouter.Size = new Size(216, 37);
            btnAjouter.TabIndex = 7;
            btnAjouter.Text = "Ajouter";
            btnAjouter.UseVisualStyleBackColor = false;
            btnAjouter.Click += btnAjouter_Click;
            // 
            // cbxPraticien
            // 
            cbxPraticien.FormattingEnabled = true;
            cbxPraticien.Location = new Point(109, 66);
            cbxPraticien.Name = "cbxPraticien";
            cbxPraticien.Size = new Size(216, 23);
            cbxPraticien.TabIndex = 2;
            // 
            // dtpDate
            // 
            dtpDate.CustomFormat = "dd/MM/yyyy HH:mm";
            dtpDate.Format = DateTimePickerFormat.Custom;
            dtpDate.Location = new Point(109, 178);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(216, 23);
            dtpDate.TabIndex = 6;
            // 
            // lblNouveauRdv
            // 
            lblNouveauRdv.AutoSize = true;
            lblNouveauRdv.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblNouveauRdv.Location = new Point(24, 15);
            lblNouveauRdv.Name = "lblNouveauRdv";
            lblNouveauRdv.Size = new Size(160, 20);
            lblNouveauRdv.TabIndex = 0;
            lblNouveauRdv.Text = "Nouveau rendez vous";
            // 
            // lblDateHeure
            // 
            lblDateHeure.AutoSize = true;
            lblDateHeure.Location = new Point(26, 184);
            lblDateHeure.Name = "lblDateHeure";
            lblDateHeure.Size = new Size(77, 15);
            lblDateHeure.TabIndex = 5;
            lblDateHeure.Text = "Date et heure";
            // 
            // lblPraticien
            // 
            lblPraticien.AutoSize = true;
            lblPraticien.Location = new Point(24, 66);
            lblPraticien.Name = "lblPraticien";
            lblPraticien.Size = new Size(53, 15);
            lblPraticien.TabIndex = 1;
            lblPraticien.Text = "Praticien";
            // 
            // cbxMotif
            // 
            cbxMotif.FormattingEnabled = true;
            cbxMotif.Location = new Point(109, 121);
            cbxMotif.Name = "cbxMotif";
            cbxMotif.Size = new Size(216, 23);
            cbxMotif.TabIndex = 4;
            // 
            // lblMotif
            // 
            lblMotif.AutoSize = true;
            lblMotif.Location = new Point(24, 121);
            lblMotif.Name = "lblMotif";
            lblMotif.Size = new Size(36, 15);
            lblMotif.TabIndex = 3;
            lblMotif.Text = "Motif";
            // 
            // panelDroit
            // 
            panelDroit.Controls.Add(panel2);
            panelDroit.Dock = DockStyle.Right;
            panelDroit.Location = new Point(534, 83);
            panelDroit.Name = "panelDroit";
            panelDroit.Size = new Size(481, 312);
            panelDroit.TabIndex = 13;
            // 
            // panelGauche
            // 
            panelGauche.Controls.Add(label1);
            panelGauche.Controls.Add(dgvVisites);
            panelGauche.Dock = DockStyle.Fill;
            panelGauche.Location = new Point(0, 83);
            panelGauche.Name = "panelGauche";
            panelGauche.Padding = new Padding(10);
            panelGauche.Size = new Size(534, 312);
            panelGauche.TabIndex = 14;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Location = new Point(10, 10);
            label1.Name = "label1";
            label1.Size = new Size(514, 15);
            label1.TabIndex = 1;
            label1.Text = "Liste des rendez-vous déjà enregistrés";
            // 
            // dgvVisites
            // 
            dgvVisites.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVisites.Dock = DockStyle.Fill;
            dgvVisites.Location = new Point(10, 10);
            dgvVisites.Name = "dgvVisites";
            dgvVisites.Size = new Size(514, 292);
            dgvVisites.TabIndex = 0;
            // 
            // FrmVisiteAjout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1015, 440);
            Controls.Add(panelGauche);
            Controls.Add(panelDroit);
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Location = new Point(0, 0);
            Name = "FrmVisiteAjout";
            Text = "Ajouter une visite";
            Load += FrmVisiteAjout_Load;
            Controls.SetChildIndex(lblTitre, 0);
            Controls.SetChildIndex(panelDroit, 0);
            Controls.SetChildIndex(panelGauche, 0);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panelDroit.ResumeLayout(false);
            panelGauche.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvVisites).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel2;
        private Button btnAjouter;
        private ComboBox cbxPraticien;
        private DateTimePicker dtpDate;
        private Label lblNouveauRdv;
        private Label lblDateHeure;
        private Label lblPraticien;
        private ComboBox cbxMotif;
        private Label lblMotif;
        private Panel panelDroit;
        private Panel panelGauche;
        private Label label1;
        private DataGridView dgvVisites;
    }
}