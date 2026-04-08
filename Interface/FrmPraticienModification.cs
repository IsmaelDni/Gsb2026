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
    public partial class FrmPraticienModification : FrmBase
    {
        public FrmPraticienModification(Session uneSession) : base(uneSession)
        {
            InitializeComponent();
        }

        private void FrmPraticienModification_Load(object sender, EventArgs e)
        {
            parametrerComposant();
        }

        private void parametrerComposant()
        {
            // titre
            this.lblTitre.Text = "Mettre à jour les coordonnées d'un praticien";

            // centrer le panneau
            centrerFormulaire();
            this.Resize += (s, e) => centrerFormulaire();

            // initialiser messages d'erreur
            messageNom.Text = string.Empty;
            messagePrenom.Text = string.Empty;
            messageRue.Text = string.Empty;
            messageVille.Text = string.Empty;
            messageTelephone.Text = string.Empty;
            messageEmail.Text = string.Empty;
            messageType.Text = string.Empty;
            messageSpecialite.Text = string.Empty;

            // Types et spécialités : on utilise DataSource pour faciliter le rafraîchissement
            cbxType.DataSource = null;
            cbxType.DataSource = session.LesTypesPraticien;
            cbxType.DisplayMember = "Libelle";
            cbxType.ValueMember = "Id";
            cbxType.SelectedIndex = -1;

            cbxSpecialite.DataSource = null;
            cbxSpecialite.DataSource = session.LesSpecialites;
            cbxSpecialite.DisplayMember = "Libelle";
            cbxSpecialite.ValueMember = "Id";
            cbxSpecialite.SelectedItem = null;

            // Liste des praticiens : on alimente la combo via Items (permet de conserver modification/suppression sur la collection)
            cbxPraticien.Items.Clear();
            cbxPraticien.DisplayMember = "NomPrenom";
            cbxPraticien.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbxPraticien.AutoCompleteSource = AutoCompleteSource.CustomSource;
            cbxPraticien.DropDownStyle = ComboBoxStyle.DropDown; // permet la saisie pour l'auto-completion
            var auto = new AutoCompleteStringCollection();
            foreach (var p in session.MesPraticiens)
            {
                cbxPraticien.Items.Add(p);
                auto.Add(p.NomPrenom);
            }
            cbxPraticien.AutoCompleteCustomSource = auto;
            if (cbxPraticien.Items.Count > 0)
            {
                cbxPraticien.SelectedIndex = 0;
                RemplirChampsDepuisPraticien();
            }

            // autoComplete pour la ville
            txtVille.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtVille.AutoCompleteSource = AutoCompleteSource.CustomSource;
            var source = new AutoCompleteStringCollection();
            foreach (Ville ville in session.MesVilles)
            {
                source.Add(ville.Nom);
            }
            txtVille.AutoCompleteCustomSource = source;

            // gestion selection praticien
            cbxPraticien.SelectedIndexChanged += (s, e) => RemplirChampsDepuisPraticien();
            // boutons
            btnModifier.Click += (s, e) => modification();
            btnSupprimer.Click += (s, e) => supprimer();
        }

        private void centrerFormulaire()
        {
            if (panelCentral != null)
            {
                panelCentral.Left = (this.ClientSize.Width - panelCentral.Width) / 2;
                panelCentral.Top = (this.ClientSize.Height - panelCentral.Height) / 2;
            }
        }

        private void RemplirChampsDepuisPraticien()
        {
            if (cbxPraticien.SelectedItem is Metier.Praticien p)
            {
                txtNom.Text = p.Nom;
                txtPrenom.Text = p.Prenom;
                txtRue.Text = p.Rue;
                txtVille.Text = p.Ville;
                mtbTelephone.Text = p.Telephone;
                txtEmail.Text = p.Email;

                btnSupprimer.Visible = p.NbVisite == 0; // suppression possible uniquement si aucune visite associée

                // sélectionner le Type et la Spécialité correspondants en utilisant les listes de session
                if (p.Type != null)
                {
                    var typeObj = session.LesTypesPraticien.Find(t => t.Id == p.Type.Id);
                    cbxType.SelectedItem = typeObj;
                }
                else
                {
                    cbxType.SelectedIndex = -1;
                }

                if (p.Specialite != null)
                {
                    var specObj = session.LesSpecialites.Find(s => s.Id == p.Specialite.Id);
                    cbxSpecialite.SelectedItem = specObj;
                }
                else
                {
                    cbxSpecialite.SelectedItem = null;
                }
            }
        }




        // Méthode appelée par le bouton Supprimer (implémentation conforme au document)
        private void supprimer()
        {
            try
            {
                if (!(cbxPraticien.SelectedItem is Metier.Praticien lePraticien)) return;

                if (MessageBox.Show($"Confirmez-vous la suppression du praticien {lePraticien.NomPrenom} ?", "Confirmation", MessageBoxButtons.YesNo) != DialogResult.Yes)
                    return;

                Donnee.Passerelle.supprimerPraticien(lePraticien.Id);
                session.MesPraticiens.Remove(lePraticien);
                panelCentral.Visible = false;

                int index = cbxPraticien.SelectedIndex;
                cbxPraticien.Items.Remove(lePraticien);

                if (index >= cbxPraticien.Items.Count)
                    index = cbxPraticien.Items.Count - 1;

                if (index >= 0)
                {
                    cbxPraticien.SelectedIndex = index;
                    RemplirChampsDepuisPraticien();
                    panelCentral.Visible = true;
                }

                MessageBox.Show("Suppression réalisée", "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // méthode de validation centrale
        private void modification()
        {
            bool nomOk = controlerChamp(txtNom, messageNom, "Le nom du praticien doit être précisé");
            bool prenomOk = controlerChamp(txtPrenom, messagePrenom, "Le prénom du praticien doit être précisé");
            bool rueOk = controlerChamp(txtRue, messageRue, "La rue du praticien doit être précisée");
            bool villeOk = controlerVille();
            bool emailOk = controlerEmail();
            bool telephoneOk = controlerTelephone();

            if (nomOk && prenomOk && rueOk && villeOk && emailOk && telephoneOk)
            {
                modifier();
            }
        }

        // méthode qui applique les modifications et appelle la passerelle
        private void modifier()
        {
            try
            {
                // Récupérer l'objet Praticien actuellement sélectionné
                Praticien lePraticien = (Praticien)cbxPraticien.SelectedItem;

                // Mettre à jour les propriétés
                lePraticien.Nom = txtNom.Text.Trim();
                lePraticien.Prenom = txtPrenom.Text.Trim();
                lePraticien.Rue = txtRue.Text.Trim();
                // code postal inchangé ici (on utilise la ville saisie)
                var villeObj = session.MesVilles.Find(v => string.Equals(v.Nom, txtVille.Text.Trim(), StringComparison.OrdinalIgnoreCase));
                if (villeObj != null)
                {
                    lePraticien.Ville = villeObj.Nom;
                    lePraticien.CodePostal = villeObj.Code;
                }
                else
                {
                    lePraticien.Ville = txtVille.Text.Trim();
                }
                lePraticien.Telephone = mtbTelephone.Text.Trim();
                lePraticien.Email = txtEmail.Text.Trim();
                lePraticien.Type = cbxType.SelectedItem as TypePraticien;
                lePraticien.Specialite = cbxSpecialite.SelectedIndex > 0 ? cbxSpecialite.SelectedItem as Specialite : null;

                // Appeler la méthode de la Passerelle pour enregistrer en base
                Passerelle.modifierPraticien(lePraticien);

                // Forcer le rafraîchissement de l'affichage dans la ComboBox
                int currentIndex = cbxPraticien.SelectedIndex;
                cbxPraticien.SelectedIndex = -1;
                cbxPraticien.SelectedIndex = currentIndex;

                MessageBox.Show("Les coordonnées du praticien ont été modifiées", "Modification coordonnées d'un praticien",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Contrôles auxiliaires (copiés de FrmPraticienAjout)
        private bool controlerVille()
        {
            if (string.IsNullOrWhiteSpace(txtVille.Text))
            {
                messageVille.Text = "La ville du praticien doit être précisée";
                messageVille.Visible = true;
                return false;
            }
            var found = session.MesVilles.Find(x => string.Equals(x.Nom, txtVille.Text.Trim(), StringComparison.OrdinalIgnoreCase));
            if (found is null)
            {
                messageVille.Text = "Ville inconnue.";
                messageVille.Visible = true;
                return false;
            }
            messageVille.Text = string.Empty;
            messageVille.Visible = false;
            return true;
        }

        private bool controlerEmail()
        {
            if (txtEmail.Text == string.Empty)
            {
                messageEmail.Text = "L'adresse mail du praticien doit être précisée";
                messageEmail.Visible = true;
                return false;
            }
            System.Text.RegularExpressions.Regex uneExpression = new System.Text.RegularExpressions.Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$");
            if (!uneExpression.IsMatch(txtEmail.Text.Trim()))
            {
                messageEmail.Text = "L'adresse mail n'est pas valide";
                messageEmail.Visible = true;
                return false;
            }
            messageEmail.Text = string.Empty;
            messageEmail.Visible = false;
            return true;
        }

        private bool controlerTelephone()
        {
            if (!mtbTelephone.MaskFull)
            {
                messageTelephone.Text = "Le téléphone du praticien doit être précisé";
                messageTelephone.Visible = true;
                return false;
            }
            messageTelephone.Visible = false;
            return true;
        }

        private bool controlerChamp(TextBox txt, Label lblMessage, string message)
        {
            if (string.IsNullOrWhiteSpace(txt.Text))
            {
                lblMessage.Text = message;
                lblMessage.Visible = true;
                return false;
            }
            lblMessage.Text = string.Empty;
            lblMessage.Visible = false;
            return true;
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {

        }
    }
}
