namespace Interface
{
    partial class FrmPraticienAjout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPraticienAjout));
            panelCentral = new Panel();
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
            btnAjouter = new Button();
            panelCentral.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitre
            // 
            lblTitre.Size = new Size(1398, 74);
            // 
            // panelCentral
            // 
            panelCentral.BorderStyle = BorderStyle.FixedSingle;
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
            panelCentral.Controls.Add(btnAjouter);
            panelCentral.Location = new Point(12, 87);
            panelCentral.Name = "panelCentral";
            panelCentral.Size = new Size(1205, 405);
            panelCentral.TabIndex = 13;
            // 
            // lblNom
            // 
            lblNom.Location = new Point(20, 20);
            lblNom.Name = "lblNom";
            lblNom.Size = new Size(100, 17);
            lblNom.TabIndex = 0;
            lblNom.Text = "Nom";
            // 
            // txtNom
            // 
            txtNom.Location = new Point(20, 40);
            txtNom.Name = "txtNom";
            txtNom.Size = new Size(300, 23);
            txtNom.TabIndex = 1;
            // 
            // messageNom
            // 
            messageNom.AutoSize = true;
            messageNom.ForeColor = Color.Red;
            messageNom.Location = new Point(20, 65);
            messageNom.Name = "messageNom";
            messageNom.Size = new Size(0, 15);
            messageNom.TabIndex = 2;
            // 
            // lblPrenom
            // 
            lblPrenom.Location = new Point(400, 20);
            lblPrenom.Name = "lblPrenom";
            lblPrenom.Size = new Size(100, 17);
            lblPrenom.TabIndex = 3;
            lblPrenom.Text = "Prénom";
            // 
            // txtPrenom
            // 
            txtPrenom.Location = new Point(400, 40);
            txtPrenom.Name = "txtPrenom";
            txtPrenom.Size = new Size(300, 23);
            txtPrenom.TabIndex = 4;
            // 
            // messagePrenom
            // 
            messagePrenom.AutoSize = true;
            messagePrenom.ForeColor = Color.Red;
            messagePrenom.Location = new Point(400, 65);
            messagePrenom.Name = "messagePrenom";
            messagePrenom.Size = new Size(0, 15);
            messagePrenom.TabIndex = 5;
            // 
            // lblRue
            // 
            lblRue.Location = new Point(20, 90);
            lblRue.Name = "lblRue";
            lblRue.Size = new Size(100, 17);
            lblRue.TabIndex = 6;
            lblRue.Text = "Rue";
            // 
            // txtRue
            // 
            txtRue.Location = new Point(20, 110);
            txtRue.Name = "txtRue";
            txtRue.Size = new Size(680, 23);
            txtRue.TabIndex = 7;
            // 
            // messageRue
            // 
            messageRue.AutoSize = true;
            messageRue.ForeColor = Color.Red;
            messageRue.Location = new Point(20, 135);
            messageRue.Name = "messageRue";
            messageRue.Size = new Size(0, 15);
            messageRue.TabIndex = 8;
            // 
            // lblVille
            // 
            lblVille.Location = new Point(20, 155);
            lblVille.Name = "lblVille";
            lblVille.Size = new Size(100, 17);
            lblVille.TabIndex = 9;
            lblVille.Text = "Ville";
            // 
            // txtVille
            // 
            txtVille.Location = new Point(20, 175);
            txtVille.Name = "txtVille";
            txtVille.Size = new Size(300, 23);
            txtVille.TabIndex = 10;
            // 
            // messageVille
            // 
            messageVille.AutoSize = true;
            messageVille.ForeColor = Color.Red;
            messageVille.Location = new Point(20, 200);
            messageVille.Name = "messageVille";
            messageVille.Size = new Size(0, 15);
            messageVille.TabIndex = 11;
            // 
            // lblTelephone
            // 
            lblTelephone.Location = new Point(20, 220);
            lblTelephone.Name = "lblTelephone";
            lblTelephone.Size = new Size(100, 17);
            lblTelephone.TabIndex = 12;
            lblTelephone.Text = "Téléphone";
            // 
            // mtbTelephone
            // 
            mtbTelephone.Location = new Point(20, 240);
            mtbTelephone.Mask = "00 00 00 00 00 00";
            mtbTelephone.Name = "mtbTelephone";
            mtbTelephone.Size = new Size(100, 23);
            mtbTelephone.TabIndex = 13;
            // 
            // messageTelephone
            // 
            messageTelephone.AutoSize = true;
            messageTelephone.ForeColor = Color.Red;
            messageTelephone.Location = new Point(20, 265);
            messageTelephone.Name = "messageTelephone";
            messageTelephone.Size = new Size(0, 15);
            messageTelephone.TabIndex = 14;
            // 
            // lblEmail
            // 
            lblEmail.Location = new Point(400, 220);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(100, 17);
            lblEmail.TabIndex = 15;
            lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(400, 240);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(300, 23);
            txtEmail.TabIndex = 16;
            // 
            // messageEmail
            // 
            messageEmail.AutoSize = true;
            messageEmail.ForeColor = Color.Red;
            messageEmail.Location = new Point(400, 265);
            messageEmail.Name = "messageEmail";
            messageEmail.Size = new Size(0, 15);
            messageEmail.TabIndex = 17;
            // 
            // lblType
            // 
            lblType.Location = new Point(20, 290);
            lblType.Name = "lblType";
            lblType.Size = new Size(100, 17);
            lblType.TabIndex = 18;
            lblType.Text = "Type";
            // 
            // cbxType
            // 
            cbxType.Location = new Point(20, 310);
            cbxType.Name = "cbxType";
            cbxType.Size = new Size(300, 23);
            cbxType.TabIndex = 19;
            // 
            // messageType
            // 
            messageType.AutoSize = true;
            messageType.ForeColor = Color.Red;
            messageType.Location = new Point(20, 335);
            messageType.Name = "messageType";
            messageType.Size = new Size(0, 15);
            messageType.TabIndex = 20;
            // 
            // lblSpecialite
            // 
            lblSpecialite.Location = new Point(400, 290);
            lblSpecialite.Name = "lblSpecialite";
            lblSpecialite.Size = new Size(100, 17);
            lblSpecialite.TabIndex = 21;
            lblSpecialite.Text = "Spécialité";
            // 
            // cbxSpecialite
            // 
            cbxSpecialite.Location = new Point(400, 310);
            cbxSpecialite.Name = "cbxSpecialite";
            cbxSpecialite.Size = new Size(300, 23);
            cbxSpecialite.TabIndex = 22;
            // 
            // messageSpecialite
            // 
            messageSpecialite.AutoSize = true;
            messageSpecialite.ForeColor = Color.Red;
            messageSpecialite.Location = new Point(400, 335);
            messageSpecialite.Name = "messageSpecialite";
            messageSpecialite.Size = new Size(0, 15);
            messageSpecialite.TabIndex = 23;
            // 
            // btnAjouter
            // 
            btnAjouter.Anchor = AnchorStyles.None;
            btnAjouter.BackColor = Color.Red;
            btnAjouter.ForeColor = Color.Black;
            btnAjouter.Location = new Point(300, 357);
            btnAjouter.Name = "btnAjouter";
            btnAjouter.Size = new Size(100, 30);
            btnAjouter.TabIndex = 24;
            btnAjouter.Text = "Ajouter";
            btnAjouter.UseVisualStyleBackColor = false;
            // 
            // FrmPraticienAjout
            // 
            this.BackColor = Color.FromArgb(245, 246, 247);
            // style title inherited from FrmBase
            lblTitre.Font = new Font("Georgia", 20F, FontStyle.Bold);
            lblTitre.ForeColor = Color.FromArgb(30, 30, 30);
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1398, 558);
            Controls.Add(panelCentral);
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Location = new Point(0, 0);
            Name = "FrmPraticienAjout";
            Text = "FrmPaticienModification";
            Load += FrmPraticienAjout_Load;
            Controls.SetChildIndex(panelCentral, 0);
            Controls.SetChildIndex(lblTitre, 0);
            panelCentral.ResumeLayout(false);
            panelCentral.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        // Controls added dynamically in InitializeComponent
        private Panel panelCentral;
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
        private Button btnAjouter;
    }
}