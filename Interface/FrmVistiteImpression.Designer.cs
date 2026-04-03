namespace Interface
{
    partial class FrmVistiteImpression
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVistiteImpression));
            panelCentral = new Panel();
            panelSaisie = new Panel();
            label1 = new Label();
            dptFin = new DateTimePicker();
            dptDebut = new DateTimePicker();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            printRendezVous = new System.Drawing.Printing.PrintDocument();
            choixImprimante = new PrintDialog();
            aperçuRendezVous = new PrintPreviewDialog();
            label3 = new Label();
            label4 = new Label();
            panelCentral.SuspendLayout();
            panelSaisie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblTitre
            // 
            lblTitre.Size = new Size(1203, 74);
            // 
            // panelCentral
            // 
            panelCentral.Controls.Add(panelSaisie);
            panelCentral.Controls.Add(pictureBox1);
            panelCentral.Location = new Point(127, 101);
            panelCentral.Name = "panelCentral";
            panelCentral.Size = new Size(984, 383);
            panelCentral.TabIndex = 13;
            // 
            // panelSaisie
            // 
            panelSaisie.Controls.Add(label4);
            panelSaisie.Controls.Add(label3);
            panelSaisie.Controls.Add(label1);
            panelSaisie.Controls.Add(dptFin);
            panelSaisie.Controls.Add(dptDebut);
            panelSaisie.Controls.Add(pictureBox3);
            panelSaisie.Controls.Add(pictureBox2);
            panelSaisie.Location = new Point(461, 46);
            panelSaisie.Name = "panelSaisie";
            panelSaisie.Size = new Size(495, 310);
            panelSaisie.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 12);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 4;
            label1.Text = "label1";
            // 
            // dptFin
            // 
            dptFin.Location = new Point(113, 99);
            dptFin.Name = "dptFin";
            dptFin.Size = new Size(200, 23);
            dptFin.TabIndex = 3;
            // 
            // dptDebut
            // 
            dptDebut.Location = new Point(113, 42);
            dptDebut.Name = "dptDebut";
            dptDebut.Size = new Size(200, 23);
            dptDebut.TabIndex = 2;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.imprimer;
            pictureBox3.Location = new Point(207, 164);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(156, 110);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.apercu;
            pictureBox2.Location = new Point(33, 164);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 122);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logoGSB;
            pictureBox1.Location = new Point(109, 69);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(275, 228);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(127, 71);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 14;
            label2.Text = "label2";
            // 
            // choixImprimante
            // 
            choixImprimante.UseEXDialog = true;
            // 
            // aperçuRendezVous
            // 
            aperçuRendezVous.AutoScrollMargin = new Size(0, 0);
            aperçuRendezVous.AutoScrollMinSize = new Size(0, 0);
            aperçuRendezVous.ClientSize = new Size(400, 300);
            aperçuRendezVous.Enabled = true;
            aperçuRendezVous.Icon = (Icon)resources.GetObject("aperçuRendezVous.Icon");
            aperçuRendezVous.Name = "printPreviewDialog1";
            aperçuRendezVous.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(71, 46);
            label3.Name = "label3";
            label3.Size = new Size(22, 15);
            label3.TabIndex = 5;
            label3.Text = "Du";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(74, 102);
            label4.Name = "label4";
            label4.Size = new Size(22, 15);
            label4.TabIndex = 6;
            label4.Text = "Au";
            // 
            // FrmVistiteImpression
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1203, 566);
            Controls.Add(label2);
            Controls.Add(panelCentral);
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Location = new Point(0, 0);
            Name = "FrmVistiteImpression";
            Text = "FrmImpressionsRdv";
            Load += FrmVistiteImpression_Load;
            Controls.SetChildIndex(lblTitre, 0);
            Controls.SetChildIndex(panelCentral, 0);
            Controls.SetChildIndex(label2, 0);
            panelCentral.ResumeLayout(false);
            panelSaisie.ResumeLayout(false);
            panelSaisie.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelCentral;
        private Panel panelSaisie;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label label1;
        private DateTimePicker dptFin;
        private DateTimePicker dptDebut;
        private Label label2;
        private System.Drawing.Printing.PrintDocument printRendezVous;
        private PrintDialog choixImprimante;
        private PrintPreviewDialog aperçuRendezVous;
        private Label label4;
        private Label label3;
    }
}