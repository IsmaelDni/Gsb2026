namespace Interface
{
    partial class FrmVisiteConsultation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVisiteConsultation));
            panel2 = new Panel();
            panelCentral = new Panel();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dgvVisites = new DataGridView();
            panelPraticien = new Panel();
            lblRue = new Label();
            lblTelephone = new Label();
            lblEmail = new Label();
            lblPraticien = new Label();
            lblType = new Label();
            lblSpecialite = new Label();
            lblMotif = new Label();
            lblBilan = new Label();
            txtBilan = new TextBox();
            lstMedicament = new ListBox();
            dgvEchantillon = new DataGridView();
            colEchantillonNom = new DataGridViewTextBoxColumn();
            colEchantillonQuantite = new DataGridViewTextBoxColumn();
            panelCentral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVisites).BeginInit();
            panelPraticien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEchantillon).BeginInit();
            SuspendLayout();
            // 
            // lblTitre
            // 
            lblTitre.Size = new Size(1223, 74);
            // 
            // panel2
            // 
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(0, 0);
            panel2.TabIndex = 13;
            // 
            // panelCentral
            // 
            panelCentral.BorderStyle = BorderStyle.FixedSingle;
            panelCentral.Controls.Add(label4);
            panelCentral.Controls.Add(label3);
            panelCentral.Controls.Add(label2);
            panelCentral.Controls.Add(label1);
            panelCentral.Controls.Add(dgvVisites);
            panelCentral.Controls.Add(panelPraticien);
            panelCentral.Controls.Add(lblMotif);
            panelCentral.Controls.Add(lblBilan);
            panelCentral.Controls.Add(txtBilan);
            panelCentral.Controls.Add(lstMedicament);
            panelCentral.Controls.Add(dgvEchantillon);
            panelCentral.Location = new Point(29, 101);
            panelCentral.Name = "panelCentral";
            panelCentral.Size = new Size(1143, 433);
            panelCentral.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(501, 19);
            label4.Name = "label4";
            label4.Size = new Size(56, 15);
            label4.TabIndex = 11;
            label4.Text = "Praticien";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(502, 325);
            label3.Name = "label3";
            label3.Size = new Size(135, 15);
            label3.TabIndex = 10;
            label3.Text = "Medicament présentés";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(501, 130);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 9;
            label2.Text = "Motif";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 20);
            label1.Name = "label1";
            label1.Size = new Size(229, 15);
            label1.TabIndex = 8;
            label1.Text = "Selectionner la visite pour afficher le detail";
            // 
            // dgvVisites
            // 
            dgvVisites.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVisites.Location = new Point(31, 50);
            dgvVisites.Name = "dgvVisites";
            dgvVisites.Size = new Size(273, 352);
            dgvVisites.TabIndex = 7;
            // 
            // panelPraticien
            // 
            panelPraticien.BorderStyle = BorderStyle.FixedSingle;
            panelPraticien.Controls.Add(lblRue);
            panelPraticien.Controls.Add(lblTelephone);
            panelPraticien.Controls.Add(lblEmail);
            panelPraticien.Controls.Add(lblPraticien);
            panelPraticien.Controls.Add(lblType);
            panelPraticien.Controls.Add(lblSpecialite);
            panelPraticien.Location = new Point(501, 43);
            panelPraticien.Name = "panelPraticien";
            panelPraticien.Size = new Size(563, 83);
            panelPraticien.TabIndex = 1;
            // 
            // lblRue
            // 
            lblRue.Location = new Point(4, 22);
            lblRue.Name = "lblRue";
            lblRue.Size = new Size(340, 16);
            lblRue.TabIndex = 0;
            lblRue.Text = "Rue";
            // 
            // lblTelephone
            // 
            lblTelephone.Location = new Point(4, 38);
            lblTelephone.Name = "lblTelephone";
            lblTelephone.Size = new Size(200, 16);
            lblTelephone.TabIndex = 1;
            lblTelephone.Text = "Téléphone";
            // 
            // lblEmail
            // 
            lblEmail.Location = new Point(4, 55);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(340, 16);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "email@exemple.net";
            // 
            // lblPraticien
            // 
            lblPraticien.Location = new Point(3, 6);
            lblPraticien.Name = "lblPraticien";
            lblPraticien.Size = new Size(340, 20);
            lblPraticien.TabIndex = 0;
            lblPraticien.Text = "Praticien";
            // 
            // lblType
            // 
            lblType.Location = new Point(350, 6);
            lblType.Name = "lblType";
            lblType.Size = new Size(183, 32);
            lblType.TabIndex = 3;
            lblType.Text = "Type";
            // 
            // lblSpecialite
            // 
            lblSpecialite.Location = new Point(350, 38);
            lblSpecialite.Name = "lblSpecialite";
            lblSpecialite.Size = new Size(199, 33);
            lblSpecialite.TabIndex = 4;
            lblSpecialite.Text = "Spécialité";
            // 
            // lblMotif
            // 
            lblMotif.Location = new Point(563, 129);
            lblMotif.Name = "lblMotif";
            lblMotif.Size = new Size(206, 16);
            lblMotif.TabIndex = 2;
            lblMotif.Text = "Motif";
            // 
            // lblBilan
            // 
            lblBilan.Location = new Point(501, 165);
            lblBilan.Name = "lblBilan";
            lblBilan.Size = new Size(100, 16);
            lblBilan.TabIndex = 3;
            lblBilan.Text = "Bilan de la visite";
            // 
            // txtBilan
            // 
            txtBilan.Location = new Point(501, 184);
            txtBilan.Multiline = true;
            txtBilan.Name = "txtBilan";
            txtBilan.ReadOnly = true;
            txtBilan.Size = new Size(221, 127);
            txtBilan.TabIndex = 4;
            // 
            // lstMedicament
            // 
            lstMedicament.Location = new Point(501, 349);
            lstMedicament.Name = "lstMedicament";
            lstMedicament.Size = new Size(221, 79);
            lstMedicament.TabIndex = 5;
            // 
            // dgvEchantillon
            // 
            dgvEchantillon.AllowUserToAddRows = false;
            dgvEchantillon.AllowUserToDeleteRows = false;
            dgvEchantillon.Columns.AddRange(new DataGridViewColumn[] { colEchantillonNom, colEchantillonQuantite });
            dgvEchantillon.Location = new Point(809, 149);
            dgvEchantillon.Name = "dgvEchantillon";
            dgvEchantillon.ReadOnly = true;
            dgvEchantillon.RowHeadersVisible = false;
            dgvEchantillon.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEchantillon.Size = new Size(200, 264);
            dgvEchantillon.TabIndex = 6;
            // 
            // colEchantillonNom
            // 
            colEchantillonNom.HeaderText = "Nom";
            colEchantillonNom.Name = "colEchantillonNom";
            colEchantillonNom.ReadOnly = true;
            colEchantillonNom.Width = 200;
            // 
            // colEchantillonQuantite
            // 
            colEchantillonQuantite.HeaderText = "Quantité";
            colEchantillonQuantite.Name = "colEchantillonQuantite";
            colEchantillonQuantite.ReadOnly = true;
            // 
            // FrmVisiteConsultation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1223, 582);
            Controls.Add(panel2);
            Controls.Add(panelCentral);
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Location = new Point(0, 0);
            Name = "FrmVisiteConsultation";
            Text = "FrmVisiteConsultation";
            Load += FrmVistiteImpression_Load;
            Controls.SetChildIndex(panelCentral, 0);
            Controls.SetChildIndex(lblTitre, 0);
            Controls.SetChildIndex(panel2, 0);
            panelCentral.ResumeLayout(false);
            panelCentral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVisites).EndInit();
            panelPraticien.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvEchantillon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Panel panelCentral;
        private Panel panelPraticien;
        private Label lblPraticien;
        private Label lblRue;
        private Label lblTelephone;
        private Label lblEmail;
        private Label lblType;
        private Label lblSpecialite;
        private Label lblMotif;
        private Label lblBilan;
        private TextBox txtBilan;
        private ListBox lstMedicament;
        private DataGridView dgvEchantillon;
        private DataGridViewTextBoxColumn colEchantillonNom;
        private DataGridViewTextBoxColumn colEchantillonQuantite;
        private DataGridView dgvVisites;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}