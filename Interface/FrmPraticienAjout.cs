using Metier;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Interface
{
    public partial class FrmPraticienAjout : FrmBase
    {
        public FrmPraticienAjout(Session uneSession) : base(uneSession)
        {
            InitializeComponent();
        }

        private void FrmPraticienAjout_Load(object sender, EventArgs e)
        {
            parametrerComposant();
            

        }
        private void parametrerComposant()
        {
            // titre de la fenêtre
            this.lblTitre.Text = "Ajout d'un praticien";

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

            // remplir combobox Type et Specialite
            cbxType.Items.Clear();
            cbxType.DropDownStyle = ComboBoxStyle.DropDownList;
            foreach (var t in session.LesTypesPraticien)
            {
                cbxType.Items.Add(t);
            }
            cbxType.DisplayMember = "Libelle";
            if (cbxType.Items.Count > 0) cbxType.SelectedIndex = 0;

            cbxSpecialite.Items.Clear();
            cbxSpecialite.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxSpecialite.Items.Add(string.Empty);
            foreach (var s in session.LesSpecialites)
            {
                cbxSpecialite.Items.Add(s);
            }
            cbxSpecialite.DisplayMember = "Libelle";
            cbxSpecialite.SelectedIndex = 0;

            txtVille.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtVille.AutoCompleteSource = AutoCompleteSource.CustomSource;
            var source = new AutoCompleteStringCollection();
            foreach (Ville ville in session!.MesVilles)
            {
                source.Add(ville.Nom);
            }
            txtVille.AutoCompleteCustomSource = source;

            btnAjouter.Click += BtnAjouter_Click;
        }

        private void centrerFormulaire()
        {
            if (panelCentral != null)
            {
                panelCentral.Left = (this.ClientSize.Width - panelCentral.Width) / 2;
                panelCentral.Top = (this.ClientSize.Height - panelCentral.Height) / 2;
            }
        }

        private void BtnAjouter_Click(object? sender, EventArgs e)
        {

            ajout();
        }

        // Méthode appelée par le bouton -> orchestration
        private void ajout()
        {
            // pas de contrôle sur les zone de liste qui peuvent rester vide
            bool nomOk = controlerChamp(txtNom, messageNom, "Le nom du praticien doit être précisé");
            bool prenomOk = controlerChamp(txtPrenom, messagePrenom, "Le prénom du praticien doit être précisé");
            bool rueOk = controlerChamp(txtRue, messageRue, "La rue du praticien doit être précisée");
            bool villeOk = controlerVille();
            bool emailOk = controlerEmail();
            bool telephoneOk = controlerTelephone();
            bool typeOk = controlerType();

            if (nomOk && prenomOk && rueOk && villeOk && emailOk && telephoneOk && typeOk)
            {
                ajouter();
            }
        }

        // Méthode qui récupère les champs et persiste en base
        private void ajouter()
        {
            try
            {
                string nom = txtNom.Text.Trim();
                string prenom = txtPrenom.Text.Trim();
                string rue = txtRue.Text.Trim();

                // récupérer le code postal à partir de la ville sélectionnée
                Ville laVille = session!.MesVilles.Find(x => string.Equals(x.Nom, txtVille.Text.Trim(), StringComparison.OrdinalIgnoreCase))!;
                string codePostal = laVille.Code;

                string ville = laVille.Nom;
                string telephone = mtbTelephone.Text.Trim();
                string email = txtEmail.Text.Trim();

                string idType = ((Metier.TypePraticien)cbxType.SelectedItem!).Id;
                string? idSpecialite = null;
                if (cbxSpecialite.SelectedItem is Metier.Specialite sp)
                    idSpecialite = sp.Id;

                int id = Donnee.Passerelle.ajouterPraticien(nom, prenom, rue, codePostal, ville, telephone, email, idType, idSpecialite);

                // mettre à jour la session
                var typeObj = session.LesTypesPraticien.Find(t => t.Id == idType);
                Specialite? specObj = null;
                if (idSpecialite != null)
                    specObj = session.LesSpecialites.Find(s => s.Id == idSpecialite);

                var p = new Praticien(id, nom, prenom, rue, codePostal, ville, email, telephone, typeObj, specObj);
                session.MesPraticiens.Add(p);
                session.MesPraticiens.Sort();

                // mise à jour interface : vider les champs
                txtNom.Text = string.Empty;
                txtPrenom.Text = string.Empty;
                txtRue.Text = string.Empty;
                txtVille.Text = string.Empty;
                mtbTelephone.Text = string.Empty;
                txtEmail.Text = string.Empty;
                cbxType.SelectedIndex = -1;
                cbxSpecialite.SelectedIndex = 0;

                MessageBox.Show("Le praticien a été ajouté.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Contrôles auxiliaires
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
            Regex uneExpression = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$");
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

        private bool controlerType()
        {
            if (cbxType.SelectedIndex == -1)
            {
                messageType.Text = "Veuillez sélectionner le type de praticien.";
                messageType.Visible = true;
                return false;
            }
            messageType.Text = string.Empty;
            messageType.Visible = false;
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

        
    }
}
