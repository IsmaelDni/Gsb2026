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
        }

        private void parametrerDgv()
        {

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

        }

        private void afficherEchantillons()
        {

        }

        #endregion

        
    }

}
#endregion