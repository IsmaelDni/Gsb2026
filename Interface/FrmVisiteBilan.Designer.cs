namespace Interface
{
    partial class FrmVisiteBilan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVisiteBilan));
            panel2 = new Panel();
            panel4 = new Panel();
            label7 = new Label();
            panel5 = new Panel();
            dataGridView1 = new DataGridView();
            btnEnregistrer = new Button();
            textBoxBilan = new TextBox();
            lblBilan = new Label();
            comboBoxSecondMedicament = new ComboBox();
            lblSecondMedicament = new Label();
            comboBoxPremierMedicament = new ComboBox();
            lblPremierMedicament = new Label();
            label5 = new Label();
            AjoutEchan = new Button();
            label6 = new Label();
            numericUpDown1 = new NumericUpDown();
            comboBox1 = new ComboBox();
            panel3 = new Panel();
            lblIndex = new Label();
            lblPraticien = new Label();
            lblChez = new Label();
            lblDate = new Label();
            btnSuivant = new Button();
            btnPrecedent = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitre
            // 
            lblTitre.Size = new Size(800, 36);
            // 
            // panel2
            // 
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(12, 63);
            panel2.Name = "panel2";
            panel2.Size = new Size(776, 335);
            panel2.TabIndex = 13;
            // 
            // panel4
            // 
            panel4.Controls.Add(label7);
            panel4.Controls.Add(panel5);
            panel4.Controls.Add(btnEnregistrer);
            panel4.Controls.Add(textBoxBilan);
            panel4.Controls.Add(lblBilan);
            panel4.Controls.Add(comboBoxSecondMedicament);
            panel4.Controls.Add(lblSecondMedicament);
            panel4.Controls.Add(comboBoxPremierMedicament);
            panel4.Controls.Add(lblPremierMedicament);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(AjoutEchan);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(numericUpDown1);
            panel4.Controls.Add(comboBox1);
            panel4.Location = new Point(12, 89);
            panel4.Name = "panel4";
            panel4.Size = new Size(761, 233);
            panel4.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(565, 35);
            label7.Name = "label7";
            label7.Size = new Size(53, 15);
            label7.TabIndex = 10;
            label7.Text = "Quantité";
            // 
            // panel5
            // 
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(dataGridView1);
            panel5.Location = new Point(390, 95);
            panel5.Name = "panel5";
            panel5.Size = new Size(330, 117);
            panel5.TabIndex = 13;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(328, 115);
            dataGridView1.TabIndex = 14;
            // 
            // btnEnregistrer
            // 
            btnEnregistrer.BackColor = Color.Red;
            btnEnregistrer.ForeColor = Color.Black;
            btnEnregistrer.Location = new Point(86, 205);
            btnEnregistrer.Name = "btnEnregistrer";
            btnEnregistrer.Size = new Size(190, 25);
            btnEnregistrer.TabIndex = 6;
            btnEnregistrer.Text = "Enregistrer la fiche visite";
            btnEnregistrer.UseVisualStyleBackColor = false;
            // 
            // textBoxBilan
            // 
            textBoxBilan.Location = new Point(14, 79);
            textBoxBilan.Multiline = true;
            textBoxBilan.Name = "textBoxBilan";
            textBoxBilan.Size = new Size(336, 120);
            textBoxBilan.TabIndex = 5;
            textBoxBilan.Text = "Praticien très satisfait.";
            // 
            // lblBilan
            // 
            lblBilan.AutoSize = true;
            lblBilan.Location = new Point(14, 61);
            lblBilan.Name = "lblBilan";
            lblBilan.Size = new Size(91, 15);
            lblBilan.TabIndex = 4;
            lblBilan.Text = "Bilan de la visite";
            // 
            // comboBoxSecondMedicament
            // 
            comboBoxSecondMedicament.FormattingEnabled = true;
            comboBoxSecondMedicament.Location = new Point(200, 32);
            comboBoxSecondMedicament.Name = "comboBoxSecondMedicament";
            comboBoxSecondMedicament.Size = new Size(150, 23);
            comboBoxSecondMedicament.TabIndex = 3;
            // 
            // lblSecondMedicament
            // 
            lblSecondMedicament.AutoSize = true;
            lblSecondMedicament.Location = new Point(200, 14);
            lblSecondMedicament.Name = "lblSecondMedicament";
            lblSecondMedicament.Size = new Size(162, 15);
            lblSecondMedicament.TabIndex = 2;
            lblSecondMedicament.Text = "Second médicament proposé";
            // 
            // comboBoxPremierMedicament
            // 
            comboBoxPremierMedicament.FormattingEnabled = true;
            comboBoxPremierMedicament.Location = new Point(14, 32);
            comboBoxPremierMedicament.Name = "comboBoxPremierMedicament";
            comboBoxPremierMedicament.Size = new Size(150, 23);
            comboBoxPremierMedicament.TabIndex = 1;
            // 
            // lblPremierMedicament
            // 
            lblPremierMedicament.AutoSize = true;
            lblPremierMedicament.Location = new Point(14, 14);
            lblPremierMedicament.Name = "lblPremierMedicament";
            lblPremierMedicament.Size = new Size(166, 15);
            lblPremierMedicament.TabIndex = 0;
            lblPremierMedicament.Text = "Premier médicament présenté";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 10F, FontStyle.Bold);
            label5.Location = new Point(390, 14);
            label5.Name = "label5";
            label5.Size = new Size(167, 16);
            label5.TabIndex = 7;
            label5.Text = "Echantillons distribués";
            // 
            // AjoutEchan
            // 
            AjoutEchan.Location = new Point(640, 58);
            AjoutEchan.Name = "AjoutEchan";
            AjoutEchan.Size = new Size(75, 23);
            AjoutEchan.TabIndex = 12;
            AjoutEchan.Text = "Ajouter";
            AjoutEchan.UseVisualStyleBackColor = true;
            AjoutEchan.Click += AjoutEchan_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(390, 35);
            label6.Name = "label6";
            label6.Size = new Size(74, 15);
            label6.TabIndex = 8;
            label6.Text = "Médicament";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(565, 58);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(53, 23);
            numericUpDown1.TabIndex = 11;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(390, 58);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(130, 23);
            comboBox1.TabIndex = 9;
            // 
            // panel3
            // 
            panel3.Controls.Add(lblIndex);
            panel3.Controls.Add(lblPraticien);
            panel3.Controls.Add(lblChez);
            panel3.Controls.Add(lblDate);
            panel3.Controls.Add(btnSuivant);
            panel3.Controls.Add(btnPrecedent);
            panel3.Location = new Point(12, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(725, 80);
            panel3.TabIndex = 0;
            // 
            // lblIndex
            // 
            lblIndex.AutoSize = true;
            lblIndex.Location = new Point(86, 13);
            lblIndex.Name = "lblIndex";
            lblIndex.Size = new Size(24, 15);
            lblIndex.TabIndex = 5;
            lblIndex.Text = "1/4";
            // 
            // lblPraticien
            // 
            lblPraticien.AutoSize = true;
            lblPraticien.Location = new Point(450, 40);
            lblPraticien.Name = "lblPraticien";
            lblPraticien.Size = new Size(90, 15);
            lblPraticien.TabIndex = 4;
            lblPraticien.Text = "Delahaye André";
            // 
            // lblChez
            // 
            lblChez.AutoSize = true;
            lblChez.Location = new Point(390, 40);
            lblChez.Name = "lblChez";
            lblChez.Size = new Size(33, 15);
            lblChez.TabIndex = 3;
            lblChez.Text = "Chez";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(127, 40);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(163, 15);
            lblDate.TabIndex = 2;
            lblDate.Text = "Le mardi 10 mars 2026 à 09:30";
            // 
            // btnSuivant
            // 
            btnSuivant.BackColor = Color.Lime;
            btnSuivant.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnSuivant.Location = new Point(60, 30);
            btnSuivant.Name = "btnSuivant";
            btnSuivant.Size = new Size(40, 33);
            btnSuivant.TabIndex = 1;
            btnSuivant.Text = ">";
            btnSuivant.UseVisualStyleBackColor = false;
            btnSuivant.Click += btnSuivant_Click;
            // 
            // btnPrecedent
            // 
            btnPrecedent.BackColor = Color.Lime;
            btnPrecedent.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnPrecedent.Location = new Point(14, 30);
            btnPrecedent.Name = "btnPrecedent";
            btnPrecedent.Size = new Size(40, 33);
            btnPrecedent.TabIndex = 0;
            btnPrecedent.Text = "<";
            btnPrecedent.UseVisualStyleBackColor = false;
            btnPrecedent.Click += btnPrecedent_Click;
            // 
            // label4
            // 
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(100, 23);
            label4.TabIndex = 0;
            // 
            // label3
            // 
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 0;
            // 
            // label2
            // 
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 0;
            // 
            // label1
            // 
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 0;
            // 
            // FrmVisiteBilan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Location = new Point(0, 0);
            Name = "FrmVisiteBilan";
            Text = "FrmBillanEchantillons";
            Load += FrmVisiteBilan_Load;
            Controls.SetChildIndex(lblTitre, 0);
            Controls.SetChildIndex(panel2, 0);
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Panel panel5;
        private Panel panel4;
        private Panel panel3;
        private Label label1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label7;
        private Button AjoutEchan;
        private NumericUpDown numericUpDown1;
        private ComboBox comboBox1;
        private Label label6;
        private Label label5;
        private DataGridView dataGridView1;
        private Button btnPrecedent;
        private Button btnSuivant;
        private Label lblDate;
        private Label lblChez;
        private Label lblPraticien;
        private Label lblIndex;
        private Label lblPremierMedicament;
        private ComboBox comboBoxPremierMedicament;
        private Label lblSecondMedicament;
        private ComboBox comboBoxSecondMedicament;
        private Label lblBilan;
        private TextBox textBoxBilan;
        private Button btnEnregistrer;
    }
}