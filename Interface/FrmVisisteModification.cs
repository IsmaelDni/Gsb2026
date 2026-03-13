using Donnee;
using Interface.Properties;
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
    public partial class FrmVisisteModification : FrmBase
    {
        private Visite? visiteeSelectionnee = null;
        public FrmVisisteModification(Session uneSession) : base(uneSession)
        {
            InitializeComponent();
        }

        #region Procédures événementielles

        private void FrmVisisteModification_Load(object sender, EventArgs e)
        {
            
            parametrerComposant();
            remplirDgv();
        }

        #endregion

        #region Procédures



        private void parametrerComposant()
        {
            // titre de la fenêtre
            this.lblTitre.Text = "Modifiez une visite";

            // paramétrage du DateTimePicker
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd/MM/yyyy HH:mm";

            // paramétrage du datagridview
            parametrerDgv(dgvVisites);

            // Ajout du gestionnaire d'événement pour les clics sur le DGV
            dgvVisites.CellClick += dgvVisites_CellClick;
        }

        private void dgvVisites_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Vérifier si le clic est sur une ligne valide et sur la colonne image (colonne 1)
            if (e.RowIndex >= 0 && e.ColumnIndex == 1)
            {
                // Récupérer la visite sélectionnée (colonne 0)
                Visite v = (Visite)dgvVisites.Rows[e.RowIndex].Cells[0].Value;
                supprimer(v);
            }
            else if (e.RowIndex >= 0)
            {
                // Clic sur une autre colonne : sélectionner la visite pour modification
                visiteeSelectionnee = (Visite)dgvVisites.Rows[e.RowIndex].Cells[0].Value;
                afficherDetailsVisite(visiteeSelectionnee);
            }
        }

        private void afficherDetailsVisite(Visite v)
        {
            // Afficher les détails de la visite sélectionnée
            lblNom.Text = v.LePraticien.NomPrenom;
            dateTimePicker1.Value = v.DateEtHeure;
        }

        private void modification()
        {
            // Vérifier la nouvelle date et l'heure
            if (dateTimePicker1.Value < DateTime.Now)
            {
                MessageBox.Show("Veuillez sélectionner une date et une heure futures.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Vérifier si c'est un dimanche
            if (dateTimePicker1.Value.DayOfWeek == DayOfWeek.Sunday)
            {
                MessageBox.Show("Veuillez sélectionner une date qui n'est pas un dimanche.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Vérifier l'heure entre 8 h et 19 h
            if (dateTimePicker1.Value.Hour < 8 || dateTimePicker1.Value.Hour >= 19)
            {
                MessageBox.Show("Veuillez sélectionner une heure entre 8 h et 19 h.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // récupérer la nouvelle date
                DateTime nouvelleDate = dateTimePicker1.Value;

                // modifier dans la base de données
                Passerelle.modifierRendezVous(visiteeSelectionnee!.Id, nouvelleDate);

                // mettre à jour la session
                visiteeSelectionnee!.deplacer(nouvelleDate);

                // mettre à jour le datagridview
                remplirDgv();

                // message de confirmation
                MessageBox.Show("La visite a été modifiée avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // réinitialiser la sélection
                visiteeSelectionnee = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void supprimer(Visite v)
        {
            // Demander confirmation
            DialogResult resultat = MessageBox.Show(
                "Êtes-vous sûr de vouloir supprimer cette visite ?",
                "Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (resultat != DialogResult.Yes)
                return;

            try
            {
                // supprimer de la base de données
                Passerelle.supprimerRendezVous(v.Id);

                // supprimer de la session
                session.MesVisites.Remove(v);

                // mettre à jour le datagridview
                remplirDgv();

                // message de confirmation
                MessageBox.Show("La visite a été supprimée avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // réinitialiser la sélection
                visiteeSelectionnee = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void parametrerDgv(DataGridView dgv)
        {
            // initialisation du datagridview : suppression des colonnes et des lignes ajoutées par défaut
            dgv.Columns.Clear();
            dgv.Rows.Clear();

            #region paramètrage concernant le datagridview dans son ensemble

            // Accessibilité
            dgv.Enabled = true;

            // style de bordure
            dgv.BorderStyle = BorderStyle.FixedSingle;

            // couleur de fond
            dgv.BackgroundColor = Color.White;

            // couleur de texte
            dgv.ForeColor = Color.Black;

            // police de caractères par défaut
            dgv.DefaultCellStyle.Font = new Font("Georgia", 11);

            // mode de sélection dans le composant
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // sélection multiple
            dgv.MultiSelect = false;

            // l'utilisateur peut-il ajouter ou supprimer des lignes ?
            dgv.AllowUserToDeleteRows = false;
            dgv.AllowUserToAddRows = false;

            // L'utilisateur peut-il modifier le contenu des cellules ?
            dgv.EditMode = DataGridViewEditMode.EditProgrammatically;

            // l'utilisateur peut-il redimensionner les colonnes et les lignes ?
            dgv.AllowUserToResizeColumns = false;
            dgv.AllowUserToResizeRows = false;

            // l'utilisateur peut-il modifier l'ordre des colonnes ?
            dgv.AllowUserToOrderColumns = false;

            // le composant accepte t'il le 'déposer' dans un Glisser - Déposer ?
            dgv.AllowDrop = false;

            // ajustement automatique de la taille des colonnes
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            #endregion

            #region paramètrage concernant la ligne d'entête

            // visibilité
            dgv.ColumnHeadersVisible = true;

            // bordure
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

            // style
            dgv.EnableHeadersVisualStyles = false;
            DataGridViewCellStyle style = dgv.ColumnHeadersDefaultCellStyle;
            style.BackColor = Color.WhiteSmoke;
            style.ForeColor = Color.Black;
            style.SelectionBackColor = Color.WhiteSmoke;
            style.SelectionForeColor = Color.Black;
            style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style.Font = new Font("Georgia", 12, FontStyle.Bold);

            // hauteur
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgv.ColumnHeadersHeight = 40;

            #endregion

            #region paramètrage concernant l'entête de ligne

            // visible
            dgv.RowHeadersVisible = false;

            // style de bordure
            dgv.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

            #endregion

            #region paramètrage au niveau des lignes

            // Hauteur
            dgv.RowTemplate.Height = 30;

            #endregion

            #region paramètrage au niveau des cellules

            // style de bordure
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.None;

            // couleur de fond
            dgv.RowsDefaultCellStyle.BackColor = Color.White;

            #endregion

            #region paramètrage au niveau de la zone sélectionnée

            // couleur de fond
            dgv.RowsDefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;

            // couleur du texte
            dgv.RowsDefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;

            #endregion

            #region paramètrage des colonnes

            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            DataGridViewColumn col;

            // Colonne 0 : Objet Visite (cachée)
            col = new DataGridViewTextBoxColumn();
            col.Name = "Visite";
            col.HeaderText = "";
            col.Visible = false;
            dgv.Columns.Add(col);

            // Colonne 1 : Image pour supprimer la visite
            DataGridViewImageColumn colImage = new DataGridViewImageColumn();
            colImage.Name = "Supprimer";
            colImage.HeaderText = "Action";
            colImage.Image = Resources.supprimer; // Assurez-vous que l'image 'delete' existe dans Resources
            colImage.Width = 50;
            colImage.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colImage.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.Columns.Add(colImage);

            // Colonne 2 : La date de la visite
            col = new DataGridViewTextBoxColumn();
            col.Name = "Date";
            col.HeaderText = "Programmée le";
            col.Width = 200;
            col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgv.Columns.Add(col);

            // Colonne 3 : Heure du rendez-vous
            col = new DataGridViewTextBoxColumn();
            col.Name = "Heure";
            col.HeaderText = "à";
            col.Width = 50;
            col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.Columns.Add(col);

            // Colonne 4 : Ville du rendez-vous
            col = new DataGridViewTextBoxColumn();
            col.Name = "Lieu";
            col.HeaderText = "sur";
            col.Width = 200;
            col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgv.Columns.Add(col);

            // Colonne 5 : Praticien à rencontrer
            col = new DataGridViewTextBoxColumn();
            col.Name = "Praticien";
            col.HeaderText = "chez";
            col.Width = 250;
            col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgv.Columns.Add(col);

            // désactiver le tri sur toutes les colonnes
            for (int i = 0; i < dgv.ColumnCount; i++)
                dgv.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;

            #endregion
        }

        private void remplirDgv()
        {
            // vider le datagridview
            dgvVisites.Rows.Clear();

            // Parcourir les visites dans l'ordre chronologique
            foreach (Visite v in session.MesVisites.Where(v => v.Bilan is null).OrderBy(v => v.DateEtHeure))
            {
                dgvVisites.Rows.Add(
                    v, // Colonne 0 : l'objet Visite (cachée)
                    Resources.supprimer, // Colonne 1 : image de suppression
                    v.DateEtHeure.ToLongDateString(), // Colonne 2 : date
                    v.DateEtHeure.ToShortTimeString(), // Colonne 3 : heure
                    v.LePraticien.Ville, // Colonne 4 : ville
                    v.LePraticien.NomPrenom); // Colonne 5 : praticien
            }
        }

        #endregion

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (visiteeSelectionnee is null)
            {
                MessageBox.Show("Veuillez sélectionner une visite à modifier.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            modification();

        }
    }
}