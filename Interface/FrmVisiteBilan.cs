using Donnee;
using Metier;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Interface
{
    public partial class FrmVisiteBilan : FrmBase
    {
        private List<Visite> mesVisites;
        private int indexVisiteActuelle = 0;

        public FrmVisiteBilan(Session uneSession) : base(uneSession)
        {
            InitializeComponent();
        }

        #region Procédures événementielles

        private void FrmVisiteBilan_Load(object sender, EventArgs e)
        {
            parametrerComposant();
            chargerVisites();
            afficherVisite();
        }

        private void btnPrecedent_Click(object sender, EventArgs e)
        {
            if (indexVisiteActuelle > 0)
            {
                indexVisiteActuelle--;
                afficherVisite();
            }
        }

        private void btnSuivant_Click(object sender, EventArgs e)
        {
            if (indexVisiteActuelle < mesVisites.Count - 1)
            {
                indexVisiteActuelle++;
                afficherVisite();
            }
        }



        #region Procédures

        private void parametrerComposant()
        {
            this.lblTitre.Text = "Enregistrement du bilan d'une visite";


            // Configuration du datagridview
            parametrerDgv();

            // alimentation des combobox de médicaments
            comboBoxPremierMedicament.Items.Clear();
            comboBoxSecondMedicament.Items.Clear();
            comboBox1.Items.Clear();
            foreach (Medicament m in session.LesMedicaments)
            {
                comboBoxPremierMedicament.Items.Add(m);
                comboBoxSecondMedicament.Items.Add(m);
                comboBox1.Items.Add(m);
            }
            comboBoxPremierMedicament.DisplayMember = "Nom";
            comboBoxSecondMedicament.DisplayMember = "Nom";
            comboBox1.DisplayMember = "Nom";
            comboBoxPremierMedicament.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSecondMedicament.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;

            // NumericUpDown configuration
            numericUpDown1.Minimum = 1;
            numericUpDown1.Maximum = 10;
            numericUpDown1.Value = 1;

            // événements
            button1.Click += button1_Click;
            dataGridView1.CellClick += dataGridView1_CellClick;
            btnEnregistrer.Click += btnEnregistrer_Click;
        }

        private void parametrerDgv()
        {
            var dgv = dataGridView1;
            dgv.Columns.Clear();
            dgv.Rows.Clear();

            dgv.Enabled = true;
            dgv.BorderStyle = BorderStyle.FixedSingle;
            dgv.BackgroundColor = Color.White;
            dgv.ForeColor = Color.Black;
            dgv.DefaultCellStyle.Font = new Font("Georgia", 11);
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.AllowUserToAddRows = false;
            dgv.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgv.AllowUserToResizeColumns = false;
            dgv.AllowUserToResizeRows = false;
            dgv.AllowUserToOrderColumns = false;
            dgv.AllowDrop = false;

            dgv.ColumnHeadersVisible = true;
            dgv.EnableHeadersVisualStyles = false;
            var style = dgv.ColumnHeadersDefaultCellStyle;
            style.BackColor = Color.WhiteSmoke;
            style.ForeColor = Color.Black;
            style.SelectionBackColor = Color.WhiteSmoke;
            style.SelectionForeColor = Color.Black;
            style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style.Font = new Font("Georgia", 12, FontStyle.Bold);
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgv.ColumnHeadersHeight = 40;
            dgv.RowHeadersVisible = false;
            dgv.RowTemplate.Height = 30;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgv.RowsDefaultCellStyle.BackColor = Color.White;

            // Colonne 0 : Objet medicament (cachée)
            var col = new DataGridViewTextBoxColumn();
            col.Name = "MedicamentObj";
            col.HeaderText = "_obj";
            col.Visible = false;
            dgv.Columns.Add(col);

            // Colonne 1 : Nom
            col = new DataGridViewTextBoxColumn();
            col.Name = "Nom";
            col.HeaderText = "Nom";
            col.Width = 200;
            dgv.Columns.Add(col);

            // Colonne 2 : Quantite
            col = new DataGridViewTextBoxColumn();
            col.Name = "Quantite";
            col.HeaderText = "Quantité";
            col.Width = 80;
            col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.Columns.Add(col);

            // Colonne 3 : Image supprimer
            var colImage = new DataGridViewImageColumn();
            try
            {
                colImage.Image = Interface.Properties.Resources.supprimer;
            }
            catch
            {
                // ignore if resource not available
            }
            colImage.Name = "Supprimer";
            colImage.Width = 50;
            colImage.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colImage.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.Columns.Add(colImage);

            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dgv.Width = 330;
        }

        private void chargerVisites()
        {
            // Charger les visites sans bilan
            mesVisites = new List<Visite>();
            foreach (Visite v in session.MesVisites)
            {
                if (v.Bilan == null)
                {
                    mesVisites.Add(v);
                }
            }
        }

        private void afficherVisite()
        {
            if (mesVisites == null || mesVisites.Count == 0)
            {
                // rien à afficher
                lblIndex.Text = "0/0";
                lblDate.Text = string.Empty;
                lblPraticien.Text = string.Empty;
                textBoxBilan.Text = string.Empty;
                comboBoxPremierMedicament.SelectedIndex = -1;
                comboBoxSecondMedicament.SelectedIndex = -1;
                dataGridView1.Rows.Clear();
                return;
            }

            if (indexVisiteActuelle < 0) indexVisiteActuelle = 0;
            if (indexVisiteActuelle >= mesVisites.Count) indexVisiteActuelle = mesVisites.Count - 1;

            Visite v = mesVisites[indexVisiteActuelle];

            lblIndex.Text = $"{indexVisiteActuelle + 1}/{mesVisites.Count}";
            lblDate.Text = v.DateEtHeure.ToLongDateString() + " à " + v.DateEtHeure.ToShortTimeString();
            lblPraticien.Text = v.LePraticien.NomPrenom;

            // bilan
            textBoxBilan.Text = v.Bilan ?? string.Empty;

            // médicaments présentés
            if (v.PremierMedicament is not null)
                comboBoxPremierMedicament.SelectedItem = v.PremierMedicament;
            else
                comboBoxPremierMedicament.SelectedIndex = -1;

            if (v.SecondMedicament is not null)
                comboBoxSecondMedicament.SelectedItem = v.SecondMedicament;
            else
                comboBoxSecondMedicament.SelectedIndex = -1;

            // echantillons
            afficherEchantillons();
        }

        private void afficherEchantillons()
        {
            dataGridView1.Rows.Clear();
            if (mesVisites == null || mesVisites.Count == 0) return;
            Visite v = mesVisites[indexVisiteActuelle];
            foreach (var kv in v)
            {
                int idx = dataGridView1.Rows.Add(kv.Key, kv.Key.Nom, kv.Value, Interface.Properties.Resources.supprimer);
                // store object explicitly in hidden cell
                dataGridView1.Rows[idx].Cells[0].Value = kv.Key;
            }
        }

        private void button1_Click(object? sender, EventArgs e)
        {
            if (mesVisites == null || mesVisites.Count == 0) return;
            var med = comboBox1.SelectedItem as Medicament;
            if (med is null) return;
            int quantite = (int)numericUpDown1.Value;
            Visite v = mesVisites[indexVisiteActuelle];
            v.ajouterEchantillon(med, quantite);
            afficherEchantillons();
        }

        private void dataGridView1_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            // colonne Supprimer
            var dgv = dataGridView1;
            if (dgv.Columns[e.ColumnIndex].Name == "Supprimer")
            {
                var obj = dgv.Rows[e.RowIndex].Cells[0].Value as Medicament;
                if (obj is null) return;
                Visite v = mesVisites[indexVisiteActuelle];
                v.supprimerEchantillon(obj);
                afficherEchantillons();
            }
        }

        private void btnEnregistrer_Click(object? sender, EventArgs e)
        {
            if (mesVisites == null || mesVisites.Count == 0) return;
            Visite v = mesVisites[indexVisiteActuelle];

            // récupérer les valeurs saisies
            string bilan = textBoxBilan.Text.Trim();
            Medicament premier = comboBoxPremierMedicament.SelectedItem as Medicament ?? null!;
            Medicament? second = comboBoxSecondMedicament.SelectedItem as Medicament;

            if (string.IsNullOrEmpty(bilan))
            {
                MessageBox.Show("Le bilan ne peut pas être vide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (premier is null)
            {
                MessageBox.Show("Veuillez sélectionner le premier médicament présenté.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // mettre à jour l'objet visite
                v.enregistrerBilan(bilan, premier, second);

                // enregistrer en base
                Passerelle.enregistrerBilan(v);

                // supprimer de la liste locale des visites à traiter
                mesVisites.RemoveAt(indexVisiteActuelle);

                MessageBox.Show("Le bilan a été enregistré.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // afficher la suivante
                if (mesVisites.Count == 0)
                {
                    this.Close();
                    return;
                }
                if (indexVisiteActuelle >= mesVisites.Count) indexVisiteActuelle = mesVisites.Count - 1;
                afficherVisite();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        
    }

}
#endregion