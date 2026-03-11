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
            panelGauche = new Panel();
            dgvVisites = new DataGridView();
            lblListeRdv = new Label();
            panelDroite = new Panel();
            btnAjouter = new Button();
            dtpDate = new DateTimePicker();
            lblDateHeure = new Label();
            cbxMotif = new ComboBox();
            lblMotif = new Label();
            cbxPraticien = new ComboBox();
            lblPraticien = new Label();
            lblNouveauRdv = new Label();
            panelGauche.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVisites).BeginInit();
            panelDroite.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitre
            // 
            lblTitre.Dock = DockStyle.Top;
            lblTitre.Size = new Size(1015, 74);
            // 
            // panelGauche
            // 
            panelGauche.Controls.Add(dgvVisites);
            panelGauche.Controls.Add(lblListeRdv);
            panelGauche.Dock = DockStyle.Left;
            panelGauche.Location = new Point(0, 74);
            panelGauche.Name = "panelGauche";
            panelGauche.Padding = new Padding(10);
            panelGauche.Size = new Size(615, 366);
            panelGauche.TabIndex = 1;
            // 
            // dgvVisites
            // 
            dgvVisites.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVisites.Dock = DockStyle.Fill;
            dgvVisites.Location = new Point(10, 35);
            dgvVisites.Name = "dgvVisites";
            dgvVisites.RowTemplate.Height = 25;
            dgvVisites.Size = new Size(595, 321);
            dgvVisites.TabIndex = 1;
            // 
            // lblListeRdv
            // 
            lblListeRdv.AutoSize = false;
            lblListeRdv.Dock = DockStyle.Top;
            lblListeRdv.Location = new Point(10, 10);
            lblListeRdv.Name = "lblListeRdv";
            lblListeRdv.Size = new Size(595, 25);
            lblListeRdv.TabIndex = 0;
            lblListeRdv.Text = "Liste des rendez-vous déjà enregistrés";
            // 
            // panelDroite
            // 
            panelDroite.BorderStyle = BorderStyle.FixedSingle;
            panelDroite.Controls.Add(btnAjouter);
            panelDroite.Controls.Add(dtpDate);
            panelDroite.Controls.Add(lblDateHeure);
            panelDroite.Controls.Add(cbxMotif);
            panelDroite.Controls.Add(lblMotif);
            panelDroite.Controls.Add(cbxPraticien);
            panelDroite.Controls.Add(lblPraticien);
            panelDroite.Controls.Add(lblNouveauRdv);
            panelDroite.Dock = DockStyle.Right;
            panelDroite.Location = new Point(615, 74);
            panelDroite.Name = "panelDroite";
            panelDroite.Padding = new Padding(20);
            panelDroite.Size = new Size(400, 366);
            panelDroite.TabIndex = 2;
            // 
            // btnAjouter
            // 
            btnAjouter.BackColor = Color.Red;
            btnAjouter.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnAjouter.ForeColor = Color.White;
            btnAjouter.Location = new Point(60, 280);
            btnAjouter.Name = "btnAjouter";
            btnAjouter.Size = new Size(280, 50);
            btnAjouter.TabIndex = 7;
            btnAjouter.Text = "Ajouter";
            btnAjouter.UseVisualStyleBackColor = false;
            // 
            // dtpDate
            // 
            dtpDate.Format = DateTimePickerFormat.Custom;
            dtpDate.CustomFormat = "dd/MM/yyyy HH:mm";
            dtpDate.Location = new Point(60, 237);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(280, 23);
            dtpDate.TabIndex = 6;
            // 
            // lblDateHeure
            // 
            lblDateHeure.AutoSize = true;
            lblDateHeure.Location = new Point(60, 215);
            lblDateHeure.Name = "lblDateHeure";
            lblDateHeure.Size = new Size(101, 15);
            lblDateHeure.TabIndex = 5;
            lblDateHeure.Text = "Date et heure";
            // 
            // cbxMotif
            // 
            cbxMotif.FormattingEnabled = true;
            cbxMotif.Location = new Point(60, 180);
            cbxMotif.Name = "cbxMotif";
            cbxMotif.Size = new Size(280, 23);
            cbxMotif.TabIndex = 4;
            // 
            // lblMotif
            // 
            lblMotif.AutoSize = true;
            lblMotif.Location = new Point(60, 160);
            lblMotif.Name = "lblMotif";
            lblMotif.Size = new Size(39, 15);
            lblMotif.TabIndex = 3;
            lblMotif.Text = "Motif";
            // 
            // cbxPraticien
            // 
            cbxPraticien.FormattingEnabled = true;
            cbxPraticien.Location = new Point(60, 125);
            cbxPraticien.Name = "cbxPraticien";
            cbxPraticien.Size = new Size(280, 23);
            cbxPraticien.TabIndex = 2;
            // 
            // lblPraticien
            // 
            lblPraticien.AutoSize = true;
            lblPraticien.Location = new Point(60, 105);
            lblPraticien.Name = "lblPraticien";
            lblPraticien.Size = new Size(64, 15);
            lblPraticien.TabIndex = 1;
            lblPraticien.Text = "Praticien";
            // 
            // lblNouveauRdv
            // 
            lblNouveauRdv.AutoSize = true;
            lblNouveauRdv.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblNouveauRdv.Location = new Point(60, 20);
            lblNouveauRdv.Name = "lblNouveauRdv";
            lblNouveauRdv.Size = new Size(156, 20);
            lblNouveauRdv.TabIndex = 0;
            lblNouveauRdv.Text = "Nouveau rendez vous";
            // 
            // FrmVisiteAjout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1015, 440);
            Controls.Add(panelDroite);
            Controls.Add(panelGauche);
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Location = new Point(0, 0);
            Name = "FrmVisiteAjout";
            Text = "Ajouter une visite";
            Load += FrmVisiteAjout_Load;
            Controls.SetChildIndex(panelGauche, 0);
            Controls.SetChildIndex(panelDroite, 0);
            Controls.SetChildIndex(lblTitre, 0);
            panelGauche.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvVisites).EndInit();
            panelDroite.ResumeLayout(false);
            panelDroite.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Panel panelGauche;
        private System.Windows.Forms.Label lblListeRdv;
        private System.Windows.Forms.DataGridView dgvVisites;
        private System.Windows.Forms.Panel panelDroite;
        private System.Windows.Forms.Label lblNouveauRdv;
        private System.Windows.Forms.Label lblPraticien;
        private System.Windows.Forms.ComboBox cbxPraticien;
        private System.Windows.Forms.ComboBox cbxMotif;
        private System.Windows.Forms.Label lblMotif;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblDateHeure;
        private System.Windows.Forms.Button btnAjouter;
    }
}