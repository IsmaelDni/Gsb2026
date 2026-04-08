namespace Interface
{
    partial class FrmPraticienModification
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPraticienModification));
            panelCentral = new Panel();
            lblPraticienRecherche = new Label();
            cbxPraticien = new ComboBox();
            lblNom = new Label();
            txtNom = new TextBox();
            messageNom = new Label();
            lblPrenom = new Label();
            txtPrenom = new TextBox();
            messagePrenom = new Label();
            lblRue = new Label();
            txtRue = new TextBox();
            messageRue = new Label();
            lblVille = new Label();
            txtVille = new TextBox();
            messageVille = new Label();
            lblTelephone = new Label();
            mtbTelephone = new MaskedTextBox();
            messageTelephone = new Label();
            lblEmail = new Label();
            txtEmail = new TextBox();
            messageEmail = new Label();
            lblType = new Label();
            cbxType = new ComboBox();
            messageType = new Label();
            lblSpecialite = new Label();
            cbxSpecialite = new ComboBox();
            messageSpecialite = new Label();
            btnModifier = new Button();
            btnSupprimer = new Button();
            panelCentral.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitre
            // 
            lblTitre.Font = new Font("Georgia", 20F, FontStyle.Bold);
            lblTitre.ForeColor = Color.FromArgb(30, 30, 30);
            lblTitre.Size = new Size(1398, 74);
            // 
            // panelCentral
            // 
            panelCentral.BorderStyle = BorderStyle.FixedSingle;
            panelCentral.Controls.Add(lblPraticienRecherche);
            panelCentral.Controls.Add(cbxPraticien);
            panelCentral.Controls.Add(lblNom);
            panelCentral.Controls.Add(txtNom);
            panelCentral.Controls.Add(messageNom);
            panelCentral.Controls.Add(lblPrenom);
            panelCentral.Controls.Add(txtPrenom);
            panelCentral.Controls.Add(messagePrenom);
            panelCentral.Controls.Add(lblRue);
            panelCentral.Controls.Add(txtRue);
            panelCentral.Controls.Add(messageRue);
            panelCentral.Controls.Add(lblVille);
            panelCentral.Controls.Add(txtVille);
            panelCentral.Controls.Add(messageVille);
            panelCentral.Controls.Add(lblTelephone);
            panelCentral.Controls.Add(mtbTelephone);
            panelCentral.Controls.Add(messageTelephone);
            panelCentral.Controls.Add(lblEmail);
            panelCentral.Controls.Add(txtEmail);
            panelCentral.Controls.Add(messageEmail);
            panelCentral.Controls.Add(lblType);
            panelCentral.Controls.Add(cbxType);
            panelCentral.Controls.Add(messageType);
            panelCentral.Controls.Add(lblSpecialite);
            panelCentral.Controls.Add(cbxSpecialite);
            panelCentral.Controls.Add(messageSpecialite);
            panelCentral.Controls.Add(btnModifier);
            panelCentral.Controls.Add(btnSupprimer);
            panelCentral.Location = new Point(152, 101);
            panelCentral.Name = "panelCentral";
            panelCentral.Size = new Size(1120, 398);
            panelCentral.TabIndex = 13;
            // 
            // lblPraticienRecherche
            // 
            lblPraticienRecherche.Location = new Point(258, 7);
            lblPraticienRecherche.Name = "lblPraticienRecherche";
            lblPraticienRecherche.Size = new Size(150, 17);
            lblPraticienRecherche.TabIndex = 0;
            lblPraticienRecherche.Text = "Praticien recherché";
            // 
            // cbxPraticien
            // 
            cbxPraticien.Location = new Point(258, 27);
            cbxPraticien.Name = "cbxPraticien";
            cbxPraticien.Size = new Size(300, 23);
            cbxPraticien.TabIndex = 1;
            // 
            // lblNom
            // 
            lblNom.Location = new Point(20, 70);
            lblNom.Name = "lblNom";
            lblNom.Size = new Size(100, 17);
            lblNom.TabIndex = 2;
            lblNom.Text = "Nom";
            // 
            // txtNom
            // 
            txtNom.Location = new Point(20, 90);
            txtNom.Name = "txtNom";
            txtNom.Size = new Size(300, 23);
            txtNom.TabIndex = 3;
            // 
            // messageNom
            // 
            messageNom.AutoSize = true;
            messageNom.ForeColor = Color.Red;
            messageNom.Location = new Point(20, 115);
            messageNom.Name = "messageNom";
            messageNom.Size = new Size(0, 15);
            messageNom.TabIndex = 4;
            // 
            // lblPrenom
            // 
            lblPrenom.Location = new Point(400, 70);
            lblPrenom.Name = "lblPrenom";
            lblPrenom.Size = new Size(100, 17);
            lblPrenom.TabIndex = 5;
            lblPrenom.Text = "Prénom";
            // 
            // txtPrenom
            // 
            txtPrenom.Location = new Point(400, 90);
            txtPrenom.Name = "txtPrenom";
            txtPrenom.Size = new Size(300, 23);
            txtPrenom.TabIndex = 6;
            // 
            // messagePrenom
            // 
            messagePrenom.AutoSize = true;
            messagePrenom.ForeColor = Color.Red;
            messagePrenom.Location = new Point(400, 115);
            messagePrenom.Name = "messagePrenom";
            messagePrenom.Size = new Size(0, 15);
            messagePrenom.TabIndex = 7;
            // 
            // lblRue
            // 
            lblRue.Location = new Point(20, 140);
            lblRue.Name = "lblRue";
            lblRue.Size = new Size(100, 17);
            lblRue.TabIndex = 8;
            lblRue.Text = "Rue";
            // 
            // txtRue
            // 
            txtRue.Location = new Point(20, 160);
            txtRue.Name = "txtRue";
            txtRue.Size = new Size(680, 23);
            txtRue.TabIndex = 9;
            // 
            // messageRue
            // 
            messageRue.AutoSize = true;
            messageRue.ForeColor = Color.Red;
            messageRue.Location = new Point(20, 185);
            messageRue.Name = "messageRue";
            messageRue.Size = new Size(0, 15);
            messageRue.TabIndex = 10;
            // 
            // lblVille
            // 
            lblVille.Location = new Point(20, 210);
            lblVille.Name = "lblVille";
            lblVille.Size = new Size(100, 17);
            lblVille.TabIndex = 11;
            lblVille.Text = "Ville";
            // 
            // txtVille
            // 
            txtVille.Location = new Point(20, 230);
            txtVille.Name = "txtVille";
            txtVille.Size = new Size(300, 23);
            txtVille.TabIndex = 12;
            // 
            // messageVille
            // 
            messageVille.AutoSize = true;
            messageVille.ForeColor = Color.Red;
            messageVille.Location = new Point(20, 255);
            messageVille.Name = "messageVille";
            messageVille.Size = new Size(0, 15);
            messageVille.TabIndex = 13;
            // 
            // lblTelephone
            // 
            lblTelephone.Location = new Point(308, 346);
            lblTelephone.Name = "lblTelephone";
            lblTelephone.Size = new Size(100, 17);
            lblTelephone.TabIndex = 14;
            lblTelephone.Text = "Téléphone";
            // 
            // mtbTelephone
            // 
            mtbTelephone.Location = new Point(308, 366);
            mtbTelephone.Mask = "00 00 00 00 00 00";
            mtbTelephone.Name = "mtbTelephone";
            mtbTelephone.Size = new Size(100, 23);
            mtbTelephone.TabIndex = 15;
            // 
            // messageTelephone
            // 
            messageTelephone.AutoSize = true;
            messageTelephone.ForeColor = Color.Red;
            messageTelephone.Location = new Point(20, 335);
            messageTelephone.Name = "messageTelephone";
            messageTelephone.Size = new Size(0, 15);
            messageTelephone.TabIndex = 16;
            // 
            // lblEmail
            // 
            lblEmail.Location = new Point(400, 210);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(100, 17);
            lblEmail.TabIndex = 17;
            lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(400, 230);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(300, 23);
            txtEmail.TabIndex = 18;
            // 
            // messageEmail
            // 
            messageEmail.AutoSize = true;
            messageEmail.ForeColor = Color.Red;
            messageEmail.Location = new Point(845, 335);
            messageEmail.Name = "messageEmail";
            messageEmail.Size = new Size(0, 15);
            messageEmail.TabIndex = 19;
            // 
            // lblType
            // 
            lblType.Location = new Point(20, 275);
            lblType.Name = "lblType";
            lblType.Size = new Size(100, 17);
            lblType.TabIndex = 20;
            lblType.Text = "Type";
            // 
            // cbxType
            // 
            cbxType.Location = new Point(20, 295);
            cbxType.Name = "cbxType";
            cbxType.Size = new Size(300, 23);
            cbxType.TabIndex = 21;
            // 
            // messageType
            // 
            messageType.AutoSize = true;
            messageType.ForeColor = Color.Red;
            messageType.Location = new Point(20, 405);
            messageType.Name = "messageType";
            messageType.Size = new Size(0, 15);
            messageType.TabIndex = 22;
            // 
            // lblSpecialite
            // 
            lblSpecialite.Location = new Point(400, 270);
            lblSpecialite.Name = "lblSpecialite";
            lblSpecialite.Size = new Size(100, 17);
            lblSpecialite.TabIndex = 23;
            lblSpecialite.Text = "Spécialité";
            // 
            // cbxSpecialite
            // 
            cbxSpecialite.Location = new Point(400, 295);
            cbxSpecialite.Name = "cbxSpecialite";
            cbxSpecialite.Size = new Size(300, 23);
            cbxSpecialite.TabIndex = 24;
            // 
            // messageSpecialite
            // 
            messageSpecialite.AutoSize = true;
            messageSpecialite.ForeColor = Color.Red;
            messageSpecialite.Location = new Point(400, 405);
            messageSpecialite.Name = "messageSpecialite";
            messageSpecialite.Size = new Size(0, 15);
            messageSpecialite.TabIndex = 25;
            // 
            // btnModifier
            // 
            btnModifier.Anchor = AnchorStyles.None;
            btnModifier.BackColor = Color.LightGray;
            btnModifier.ForeColor = Color.Black;
            btnModifier.Location = new Point(788, 155);
            btnModifier.Name = "btnModifier";
            btnModifier.Size = new Size(200, 30);
            btnModifier.TabIndex = 26;
            btnModifier.Text = "Modifier la fiche du praticien";
            btnModifier.UseVisualStyleBackColor = false;
            // 
            // btnSupprimer
            // 
            btnSupprimer.Anchor = AnchorStyles.None;
            btnSupprimer.BackColor = Color.Red;
            btnSupprimer.ForeColor = Color.Black;
            btnSupprimer.Location = new Point(788, 203);
            btnSupprimer.Name = "btnSupprimer";
            btnSupprimer.Size = new Size(200, 30);
            btnSupprimer.TabIndex = 27;
            btnSupprimer.Text = "Supprimer la fiche du praticien";
            btnSupprimer.UseVisualStyleBackColor = false;
            btnSupprimer.Click += btnSupprimer_Click;
            // 
            // FrmPraticienModification
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 246, 247);
            ClientSize = new Size(1398, 558);
            Controls.Add(panelCentral);
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Location = new Point(0, 0);
            Name = "FrmPraticienModification";
            Text = "Modification d'un praticien";
            Load += FrmPraticienModification_Load;
            Controls.SetChildIndex(panelCentral, 0);
            Controls.SetChildIndex(lblTitre, 0);
            panelCentral.ResumeLayout(false);
            panelCentral.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelCentral;
        private Label lblPraticienRecherche;
        private ComboBox cbxPraticien;
        private Label lblNom;
        private TextBox txtNom;
        private Label messageNom;
        private Label lblPrenom;
        private TextBox txtPrenom;
        private Label messagePrenom;
        private Label lblRue;
        private TextBox txtRue;
        private Label messageRue;
        private Label lblVille;
        private TextBox txtVille;
        private Label messageVille;
        private Label lblTelephone;
        private MaskedTextBox mtbTelephone;
        private Label messageTelephone;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label messageEmail;
        private Label lblType;
        private ComboBox cbxType;
        private Label messageType;
        private Label lblSpecialite;
        private ComboBox cbxSpecialite;
        private Label messageSpecialite;
        private Button btnModifier;
        private Button btnSupprimer;
    }
}