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
    public partial class FrmVisiteConsultation : FrmBase
    {
        public FrmVisiteConsultation(Session uneSession) : base(uneSession)
        {
            InitializeComponent();
        }

        private void FrmVistiteImpression_Load(object sender, EventArgs e)
        {
            parametrerComposant();
            centrerFormulaire();
           

        }

        private void centrerFormulaire()
        {
            panelCentral.Left = (this.ClientSize.Width - panelCentral.Width) / 2;
        }

        private void FrmVisiteConsultation_Resize(object sender, EventArgs e) { centrerFormulaire(); }

        private void dgvVisites_SelectionChanged(object sender, EventArgs e)
        {
            afficher();
        }

        private void parametrerComposant()
        {
            // titre de la fenêtre
            this.lblTitre.Text = "Consultation des visites";

            // paramétrage des grilles
            parametrerDgv(dgvVisites);
            parametrerDgvEchantillons();

            // événements
            this.Resize += FrmVisiteConsultation_Resize;
            dgvVisites.SelectionChanged += dgvVisites_SelectionChanged;

            // remplir
            remplirDgvVisites();
            afficher();


        }

        private void parametrerDgvEchantillons()
        {
            // configure dgvEchantillon appearance and column widths so Quantité is visible
            var dgv = dgvEchantillon;
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
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
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
            dgv.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgv.RowTemplate.Height = 30;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgv.RowsDefaultCellStyle.BackColor = Color.White;
            dgv.RowsDefaultCellStyle.SelectionBackColor = Color.White;
            dgv.RowsDefaultCellStyle.SelectionForeColor = Color.Black;

            // Recreate columns to ensure known names, widths and alignment so Nom et Quantité sont visibles
            dgv.Columns.Clear();
            var colNom = new DataGridViewTextBoxColumn();
            colNom.Name = "Nom";
            colNom.HeaderText = "Nom";
            colNom.Width = 200;
            colNom.ReadOnly = true;
            dgv.Columns.Add(colNom);

            var colQuantite = new DataGridViewTextBoxColumn();
            colQuantite.Name = "Quantite";
            colQuantite.HeaderText = "Quantité";
            colQuantite.Width = 100;
            colQuantite.ReadOnly = true;
            colQuantite.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.Columns.Add(colQuantite);

            // disable sorting on the columns we just added
            foreach (DataGridViewColumn col in dgv.Columns)
                col.SortMode = DataGridViewColumnSortMode.NotSortable;

            // disable autosize so widths are respected
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

            // set control width based on columns
            dgv.Width = getLargeur(dgv);
        }

        private void parametrerDgv(DataGridView dgv)
        {
            // based on parametrerDgv in FrmVisiteAjout but simplified for consultation
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
            // do not autosize columns: we want explicit widths and use getLargeur
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

            dgv.ColumnHeadersVisible = true;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
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
            dgv.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgv.RowTemplate.Height = 30;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgv.RowsDefaultCellStyle.BackColor = Color.White;
            dgv.RowsDefaultCellStyle.SelectionBackColor = Color.White;
            dgv.RowsDefaultCellStyle.SelectionForeColor = Color.Black;

            // Columns expected: hidden object, date, heure, lieu
            var col = new DataGridViewTextBoxColumn();
            col.Name = "VisiteObj";
            col.HeaderText = "_obj";
            col.Visible = false;
            dgv.Columns.Add(col);

            col = new DataGridViewTextBoxColumn();
            col.Name = "Date";
            col.HeaderText = "Programmée le";
            col.Width = 200;
            col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgv.Columns.Add(col);

            col = new DataGridViewTextBoxColumn();
            col.Name = "Heure";
            col.HeaderText = "à";
            col.Width = 50;
            col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.Columns.Add(col);

            col = new DataGridViewTextBoxColumn();
            col.Name = "Lieu";
            col.HeaderText = "sur";
            col.Width = 200;
            col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgv.Columns.Add(col);

            for (int i = 0; i < dgv.ColumnCount; i++)
                dgv.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;

            // adjust control width to fit the defined column widths
            dgv.Width = getLargeur(dgv);
        }
        private int getLargeur(DataGridView dgv)
        {
            int largeur = 0;

            foreach (DataGridViewColumn col in dgv.Columns)
            {
                if (col.Visible)
                {
                    largeur += col.Width;
                }
            }

            if (dgv.RowHeadersVisible)
            {
                largeur += dgv.RowHeadersWidth;
            }

            // Ajout scrollbar verticale si présente
            if (dgv.Controls.OfType<VScrollBar>().FirstOrDefault()?.Visible == true)
            {
                largeur += SystemInformation.VerticalScrollBarWidth;
            }

            return largeur + 2; // marge bordure
        }

        private void remplirDgvVisites()
        {
            dgvVisites.Rows.Clear();

            // afficher toutes les visites triées
            var visites = new List<Visite>(session.MesVisites);
            visites.Sort();
            foreach (Visite v in visites)
            {
                int idx = dgvVisites.Rows.Add(v, v.DateEtHeure.ToLongDateString(), v.DateEtHeure.ToShortTimeString(), v.LePraticien.Ville);
                var row = dgvVisites.Rows[idx];
                // colorer en vert uniquement si un bilan a été renseigné
                if (!string.IsNullOrEmpty(v.Bilan))
                {
                    row.DefaultCellStyle.ForeColor = Color.Green;
                }
                else
                {
                    row.DefaultCellStyle.ForeColor = Color.Black;
                }
            }
        }

        private void afficher()
        {
            Visite? v = getVisite();
            if (v is null)
            {
                ViderAffichage();
                return;
            }

            // praticien
            lblPraticien.Text = v.LePraticien.NomPrenom;
            lblRue.Text = v.LePraticien.Rue + " " + v.LePraticien.CodePostal + " " + v.LePraticien.Ville;
            lblTelephone.Text = v.LePraticien.Telephone;
            lblEmail.Text = v.LePraticien.Email;
            // Type is stored in the "Type" property of Praticien
            lblType.Text = v.LePraticien.Type is null ? string.Empty : v.LePraticien.Type.Libelle;
            lblSpecialite.Text = v.LePraticien.Specialite is null ? string.Empty : v.LePraticien.Specialite.Libelle;

            // motif / bilan
            lblMotif.Text = v.LeMotif.Libelle;
            txtBilan.Text = v.Bilan ?? string.Empty;

            // médicaments présentés
            lstMedicament.Items.Clear();
            if (v.PremierMedicament is not null)
                lstMedicament.Items.Add(v.PremierMedicament.Nom);
            if (v.SecondMedicament is not null)
                lstMedicament.Items.Add(v.SecondMedicament.Nom);

            // échantillons
            dgvEchantillon.Rows.Clear();
            foreach (var kv in v)
            {
                dgvEchantillon.Rows.Add(kv.Key.Nom, kv.Value);
            }
        }

        private void ViderAffichage()
        {
            lblPraticien.Text = string.Empty;
            lblRue.Text = string.Empty;
            lblTelephone.Text = string.Empty;
            lblEmail.Text = string.Empty;
            lblType.Text = string.Empty;
            lblSpecialite.Text = string.Empty;
            lblMotif.Text = string.Empty;
            txtBilan.Text = string.Empty;
            lstMedicament.Items.Clear();
            dgvEchantillon.Rows.Clear();
        }

        private Visite? getVisite()
        {
            if (dgvVisites.SelectedRows.Count == 0) return null;
            var row = dgvVisites.SelectedRows[0];
            if (row.Cells.Count == 0) return null;
            return row.Cells[0].Value as Visite;
        }
    }
}

