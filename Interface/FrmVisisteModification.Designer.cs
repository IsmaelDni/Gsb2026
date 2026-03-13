namespace Interface
{
    partial class FrmVisisteModification
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVisisteModification));
            panel2 = new Panel();
            panel4 = new Panel();
            btnAjouter = new Button();
            dateTimePicker1 = new DateTimePicker();
            lblNom = new Label();
            label4 = new Label();
            lblDate = new Label();
            label2 = new Label();
            label1 = new Label();
            panel3 = new Panel();
            dgvVisites = new DataGridView();
            labeltitre = new Label();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVisites).BeginInit();
            SuspendLayout();
            // 
            // lblTitre
            // 
            lblTitre.Size = new Size(800, 74);
            // 
            // panel2
            // 
            panel2.Controls.Add(panel4);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(466, 98);
            panel2.Name = "panel2";
            panel2.Size = new Size(334, 307);
            panel2.TabIndex = 13;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnAjouter);
            panel4.Controls.Add(dateTimePicker1);
            panel4.Controls.Add(lblNom);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(lblDate);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(label1);
            panel4.Location = new Point(41, 15);
            panel4.Name = "panel4";
            panel4.Size = new Size(281, 283);
            panel4.TabIndex = 0;
            // 
            // btnAjouter
            // 
            btnAjouter.BackColor = Color.Red;
            btnAjouter.Location = new Point(95, 226);
            btnAjouter.Name = "btnAjouter";
            btnAjouter.Size = new Size(150, 23);
            btnAjouter.TabIndex = 6;
            btnAjouter.Text = "modifiez";
            btnAjouter.UseVisualStyleBackColor = false;
            btnAjouter.Click += btnAjouter_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(45, 183);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 5;
            // 
            // lblNom
            // 
            lblNom.AutoSize = true;
            lblNom.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNom.Location = new Point(58, 61);
            lblNom.Name = "lblNom";
            lblNom.Size = new Size(102, 15);
            lblNom.TabIndex = 4;
            lblNom.Text = "Nom du pratitien";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(58, 155);
            label4.Name = "label4";
            label4.Size = new Size(71, 15);
            label4.TabIndex = 3;
            label4.Text = "est remi au  ";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Segoe UI Historic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDate.Location = new Point(45, 130);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(190, 15);
            lblDate.TabIndex = 2;
            lblDate.Text = "Date et heure du rendez-vous";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(58, 87);
            label2.Name = "label2";
            label2.Size = new Size(115, 15);
            label2.TabIndex = 1;
            label2.Text = "Prevu initialement le";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(58, 32);
            label1.Name = "label1";
            label1.Size = new Size(118, 15);
            label1.TabIndex = 0;
            label1.Text = "Le rendez vous chez :";
            // 
            // panel3
            // 
            panel3.Controls.Add(dgvVisites);
            panel3.Controls.Add(labeltitre);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 98);
            panel3.Name = "panel3";
            panel3.Size = new Size(466, 307);
            panel3.TabIndex = 14;
            // 
            // dgvVisites
            // 
            dgvVisites.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVisites.Dock = DockStyle.Fill;
            dgvVisites.Location = new Point(0, 15);
            dgvVisites.Name = "dgvVisites";
            dgvVisites.Size = new Size(466, 292);
            dgvVisites.TabIndex = 1;
            // 
            // labeltitre
            // 
            labeltitre.AutoSize = true;
            labeltitre.Dock = DockStyle.Top;
            labeltitre.Location = new Point(0, 0);
            labeltitre.Name = "labeltitre";
            labeltitre.Size = new Size(75, 15);
            labeltitre.TabIndex = 0;
            labeltitre.Text = "Selectionner ";
            // 
            // FrmVisisteModification
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Location = new Point(0, 0);
            Name = "FrmVisisteModification";
            Text = "FrmVisisteModif";
            Load += FrmVisisteModification_Load;
            Controls.SetChildIndex(lblTitre, 0);
            Controls.SetChildIndex(panel2, 0);
            Controls.SetChildIndex(panel3, 0);
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVisites).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Label lblNom;
        private Label label4;
        private Label lblDate;
        private Label label2;
        private Label label1;
        private Label labeltitre;
        private DateTimePicker dateTimePicker1;
        private Button btnAjouter;
        private DataGridView dgvVisites;
    }
}