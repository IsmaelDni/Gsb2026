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
    public partial class FrmVistiteImpression : FrmBase
    {
        // collection des rendez‑vous manipulés par le formulaire (visites futures)
        private List<Visite> lesVisites = new List<Visite>();
        public FrmVistiteImpression(Session uneSession) : base(uneSession)
        {
            InitializeComponent();
        }
        private void FrmVistiteImpression_Load(object sender, EventArgs e)
        {
            parametrerComposant();
            centrerFormulaire();

            // initialisation de la collection lesVisites : uniquement les rendez‑vous
            // dont la date et l'heure sont supérieures ou égales à maintenant
            if (!DesignMode)
            {
                lesVisites = session?.MesVisites
                    .Where(v => v.DateEtHeure >= DateTime.Now)
                    .OrderBy(v => v.DateEtHeure)
                    .ToList() ?? new List<Visite>();
            }

        }

        private void centrerFormulaire()
        {
            panelCentral.Left = (this.ClientSize.Width - panelCentral.Width) / 2;
        }

        private void parametrerComposant()
        {
            // titre de la fenêtre
            this.lblTitre.Text = "Impression des rendez-vous sur une période";

           
        }
    }
}
