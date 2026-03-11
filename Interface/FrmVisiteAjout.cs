using Metier;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Interface
{
    public partial class FrmVisiteAjout : FrmBase
    {
        public FrmVisiteAjout(Session uneSession) : base(uneSession)
        {
            InitializeComponent();
        }

        private void FrmVisiteAjout_Load(object sender, EventArgs e)
        {
            this.lblTitre.Text = "Ajouter une visite";
            parametrerComposant();
        }

        private void parametrerComposant()
        {
            this.lblNouveauRdv.Text = "Enregistrer un nouveau rendez-vous";

            // Alimentation de la zone de liste déroulante contenant les praticiens
            // TODO: Charger la liste des praticiens depuis la base de données

            // Alimentation de la zone de liste déroulante contenant les motifs
            // TODO: Charger la liste des motifs depuis la base de données

            // La prise de rendez-vous s'effectue sur les deux mois à venir : propriétés MinDate et MaxDate
            // La valeur la plus petite (qui sera la valeur proposée par défaut) est dans 2 heures sans les minutes 
            // ou après demain 8 heures si demain est un dimanche
            // La valeur la plus grande possible est dans 60 jours à 19 heures
            DateTime dateMin = DateTime.Now.AddHours(2).AddMinutes(-DateTime.Now.Minute);

            if (dateMin.Hour >= 19)
            {
                dateMin = DateTime.Today.AddDays(1).AddHours(8);
            }

            if (dateMin.DayOfWeek == DayOfWeek.Sunday)
            {
                dateMin = DateTime.Today.AddDays(1).AddHours(8);
            }

            dtpDate.MinDate = dateMin;
            dtpDate.MaxDate = DateTime.Today.AddDays(60).AddHours(19);
            dtpDate.Value = dateMin;

            // Mise en forme de la date
            dtpDate.CustomFormat = "dd/MM/yyyy HH:mm";
            dtpDate.Format = DateTimePickerFormat.Custom;

            // Paramétrage du DataGridView
            // TODO: parametrerDgv(dgvVisites);
        }

        private void panelDroite_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
