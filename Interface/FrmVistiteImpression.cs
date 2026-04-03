using Metier;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
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
        // collection temporaire des visites à imprimer
        private List<Visite> visitesAImprimer = new List<Visite>();
        public FrmVistiteImpression(Session uneSession) : base(uneSession)
        {
            InitializeComponent();
        }
        private void FrmVistiteImpression_Load(object sender, EventArgs e)
        {
            parametrerComposant();
            centrerFormulaire();

            // branchement des événements
            this.Resize += FrmVistiteImpression_Resize;
            dptDebut.ValueChanged += dptDebut_ValueChanged;
            dptFin.ValueChanged += dptFin_ValueChanged;
            pictureBox3.Click += imgImprimer_Click;
            pictureBox2.Click += imgApercu_Click;
            printRendezVous.PrintPage += printRendezVous_PrintPage;

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
            // initialisation des sélecteurs de dates
            // dtpDebut : aujourd'hui .. aujourd'hui + 53
            dptDebut.MinDate = DateTime.Today;
            dptDebut.MaxDate = DateTime.Today.AddDays(53);
            dptDebut.Value = DateTime.Today;

            // dtpFin : aujourd'hui +7 .. aujourd'hui + 60
            dptFin.MinDate = DateTime.Today.AddDays(7);
            dptFin.MaxDate = DateTime.Today.AddDays(60);
            dptFin.Value = DateTime.Today.AddDays(7);

            // messages
            label1.Text = string.Empty;
        }

        private void FrmVistiteImpression_Resize(object? sender, EventArgs e)
        {
            centrerFormulaire();
        }

        private void dptFin_ValueChanged(object? sender, EventArgs e)
        {
            // efface tout message d'intervalle
            label1.Text = string.Empty;
        }

        private void dptDebut_ValueChanged(object? sender, EventArgs e)
        {
            // efface tout message d'intervalle
            label1.Text = string.Empty;
            // fixe la valeur minimale de dptFin
            try
            {
                dptFin.MinDate = dptDebut.Value.AddDays(7);
                if (dptFin.Value < dptFin.MinDate)
                {
                    dptFin.Value = dptFin.MinDate;
                }
            }
            catch
            {
                // protection contre des assignations invalides qui ne devraient pas se produire
            }
        }

        private void imgImprimer_Click(object? sender, EventArgs e)
        {
            // sélection des visites dans l'intervalle
            var debut = dptDebut.Value.Date;
            var fin = dptFin.Value.Date.AddDays(1).AddTicks(-1);
            visitesAImprimer = lesVisites.Where(v => v.DateEtHeure >= debut && v.DateEtHeure <= fin).ToList();
            if (visitesAImprimer.Count == 0)
            {
                label1.Text = "Aucun rendez-vous planifié sur cette période.";
                return;
            }

            // initialisation impression
            printRendezVous.DocumentName = "Rendez-vous";
            choixImprimante.Document = printRendezVous;
            DialogResult result = choixImprimante.ShowDialog();
            if (result == DialogResult.OK)
            {
                printRendezVous.Print();
            }
        }

        private void imgApercu_Click(object? sender, EventArgs e)
        {
            // sélection des visites dans l'intervalle
            var debut = dptDebut.Value.Date;
            var fin = dptFin.Value.Date.AddDays(1).AddTicks(-1);
            visitesAImprimer = lesVisites.Where(v => v.DateEtHeure >= debut && v.DateEtHeure <= fin).ToList();
            if (visitesAImprimer.Count == 0)
            {
                label1.Text = "Aucun rendez-vous planifié sur cette période.";
                return;
            }

            // aperçu
            aperçuRendezVous.Document = printRendezVous;
            aperçuRendezVous.ShowDialog();
        }

        private void printRendezVous_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // Impression formatée similaire à l'aperçu demandé
            var culture = CultureInfo.GetCultureInfo("fr-FR");

            // ajustement des largeurs : augmenter Date et Téléphone pour éviter le rognage
            var lesColonnes = new[] {
                new { Titre = "Date", Largeur = 220, Alignement = StringAlignment.Near },
                new { Titre = "Heure", Largeur = 80, Alignement = StringAlignment.Center },
                new { Titre = "Praticien", Largeur = 220, Alignement = StringAlignment.Near },
                new { Titre = "Téléphone", Largeur = 140, Alignement = StringAlignment.Near },
                new { Titre = "Lieu", Largeur = 160, Alignement = StringAlignment.Near },
                new { Titre = "Motif", Largeur = 160, Alignement = StringAlignment.Near }
            };

            int marginLeft = e.MarginBounds.Left;
            int marginTop = e.MarginBounds.Top;
            int pageWidth = e.MarginBounds.Width;

            // calcule un facteur d'échelle pour adapter les largeurs
            int totalSpec = lesColonnes.Sum(c => c.Largeur);
            double scale = pageWidth / (double)totalSpec;

            int hauteurLigne = 20;

            using var policeTitre = new Font("Segoe UI", 10, FontStyle.Bold);
            using var policeEntete = new Font("Segoe UI", 9, FontStyle.Bold);
            using var police = new Font("Segoe UI", 9);
            var brush = Brushes.Black;

            // entête encadré avec le texte centré (style)
            string titreIntervalle = $"Mes rendez-vous entre le {dptDebut.Value.ToString("dddd d MMMM yyyy", culture)} et le {dptFin.Value.ToString("dddd d MMMM yyyy", culture)}";
            var headerRect = new Rectangle(marginLeft, marginTop, pageWidth, 36);
            using (var headerBack = new SolidBrush(Color.FromArgb(230, 240, 255))) // léger bleu
            using (var headerBorder = new Pen(Color.Gray))
            using (var headerTextBrush = new SolidBrush(Color.FromArgb(20, 35, 70)))
            {
                e.Graphics.FillRectangle(headerBack, headerRect);
                e.Graphics.DrawRectangle(headerBorder, headerRect);
                e.Graphics.DrawString(titreIntervalle, policeTitre, headerTextBrush, headerRect, new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center });
            }

            int y = marginTop + headerRect.Height + 10;

            // ligne de séparation
            e.Graphics.DrawLine(Pens.Black, marginLeft, y, marginLeft + pageWidth, y);
            y += 8;

            // entêtes de colonnes (fond et textes)
            int x = marginLeft;
            using (var enteteBack = new SolidBrush(Color.FromArgb(200, 220, 255)))
            using (var enteteText = new SolidBrush(Color.FromArgb(10, 30, 70)))
            using (var gridPen = new Pen(Color.LightGray))
            {
                int xx = x;
                foreach (var col in lesColonnes)
                {
                    int w = (int)(col.Largeur * scale);
                    var rect = new Rectangle(xx, y, w, hauteurLigne);
                    e.Graphics.FillRectangle(enteteBack, rect);
                    e.Graphics.DrawRectangle(gridPen, rect);
                    e.Graphics.DrawString(col.Titre, policeEntete, enteteText, rect, new StringFormat { Alignment = col.Alignement, LineAlignment = StringAlignment.Center });
                    xx += w;
                }
                x = xx - pageWidth; // keep x consistent later
            }

            y += hauteurLigne + 6;

            // corps
            // si la liste à imprimer est vide on tente d'en prendre depuis lesVisites selon l'intervalle
            if (visitesAImprimer == null || visitesAImprimer.Count == 0)
            {
                var debut = dptDebut.Value.Date;
                var fin = dptFin.Value.Date.AddDays(1).AddTicks(-1);
                visitesAImprimer = lesVisites.Where(v => v.DateEtHeure >= debut && v.DateEtHeure <= fin).ToList();
            }

            int rowIndex = 0;
            foreach (var v in visitesAImprimer)
            {
                x = marginLeft;

                // Préparer les textes
                string txtDate = v.DateEtHeure.ToString("dddd d MMMM yyyy", culture);
                string txtHeure = v.DateEtHeure.ToString("HH:mm");
                string txtPraticien = v.LePraticien.NomPrenom;
                string txtTel = v.LePraticien.Telephone;
                string txtLieu = (v.LePraticien.Ville + " " + v.LePraticien.Rue).Trim();
                string txtMotif = v.LeMotif.Libelle;

                // calcul des largeurs
                int w0 = (int)(lesColonnes[0].Largeur * scale);
                int w1 = (int)(lesColonnes[1].Largeur * scale);
                int w2 = (int)(lesColonnes[2].Largeur * scale);
                int w3 = (int)(lesColonnes[3].Largeur * scale);
                int w4 = (int)(lesColonnes[4].Largeur * scale);
                int w5 = (int)(lesColonnes[5].Largeur * scale);

                // mesurer la hauteur requise pour chaque cellule avec wrapping
                var sf = new StringFormat { Alignment = StringAlignment.Near, LineAlignment = StringAlignment.Near };
                SizeF sDate = e.Graphics.MeasureString(txtDate, police, w0);
                SizeF sHeure = e.Graphics.MeasureString(txtHeure, police, w1);
                SizeF sPraticien = e.Graphics.MeasureString(txtPraticien, police, w2);
                SizeF sTel = e.Graphics.MeasureString(txtTel, police, w3);
                SizeF sLieu = e.Graphics.MeasureString(txtLieu, police, w4);
                SizeF sMotif = e.Graphics.MeasureString(txtMotif, police, w5);

                int rowHeight = (int)Math.Ceiling(new[] { sDate.Height, sHeure.Height, sPraticien.Height, sTel.Height, sLieu.Height, sMotif.Height }.Max());
                if (rowHeight < hauteurLigne) rowHeight = hauteurLigne;

                // dessiner chaque cellule (DrawString gère le wrapping dans le rectangle)
                // arrière-plan alterné pour les lignes
                Color rowBackColor = (rowIndex % 2 == 0) ? Color.White : Color.FromArgb(245, 247, 250);
                using (var rowBack = new SolidBrush(rowBackColor))
                using (var cellBorder = new Pen(Color.FromArgb(220, 225, 230)))
                {
                    e.Graphics.FillRectangle(rowBack, new Rectangle(marginLeft, y, pageWidth, rowHeight));
                    // dessiner bordures verticales
                    int vx = marginLeft;
                    foreach (var col in lesColonnes)
                    {
                        int vw = (int)(col.Largeur * scale);
                        e.Graphics.DrawLine(cellBorder, vx + vw, y, vx + vw, y + rowHeight);
                        vx += vw;
                    }

                    var r0 = new Rectangle(x, y, w0, rowHeight);
                    e.Graphics.DrawString(txtDate, police, brush, Rectangle.Inflate(r0, -4, -2), new StringFormat { Alignment = lesColonnes[0].Alignement });
                x += w0;
                    var r1 = new Rectangle(x, y, w1, rowHeight);
                    e.Graphics.DrawString(txtHeure, police, brush, Rectangle.Inflate(r1, -4, -2), new StringFormat { Alignment = lesColonnes[1].Alignement });
                x += w1;
                    var r2 = new Rectangle(x, y, w2, rowHeight);
                    e.Graphics.DrawString(txtPraticien, police, brush, Rectangle.Inflate(r2, -4, -2), new StringFormat { Alignment = lesColonnes[2].Alignement });
                x += w2;
                    var r3 = new Rectangle(x, y, w3, rowHeight);
                    e.Graphics.DrawString(txtTel, police, brush, Rectangle.Inflate(r3, -4, -2), new StringFormat { Alignment = lesColonnes[3].Alignement });
                x += w3;
                    var r4 = new Rectangle(x, y, w4, rowHeight);
                    e.Graphics.DrawString(txtLieu, police, brush, Rectangle.Inflate(r4, -4, -2), new StringFormat { Alignment = lesColonnes[4].Alignement });
                x += w4;

                    var r5 = new Rectangle(x, y, w5, rowHeight);
                    e.Graphics.DrawString(txtMotif, police, brush, Rectangle.Inflate(r5, -4, -2), new StringFormat { Alignment = lesColonnes[5].Alignement });

                    y += rowHeight + 8;
                    rowIndex++;

                    // si l'on atteint le bas de la zone imprimable, on arrête (pagination non gérée ici)
                    if (y > e.MarginBounds.Bottom)
                    {
                        break;
                    }
                }
            }

            // footer : ligne colorée et numéro de page à droite
            int footerY = e.MarginBounds.Bottom + 10;
            using (var penBleu = new Pen(Color.RoyalBlue, 6))
            {
                e.Graphics.DrawLine(penBleu, marginLeft, footerY, marginLeft + pageWidth, footerY);
            }

            string pageInfo = "Page 1 sur 1";
            var rectPage = new Rectangle(marginLeft, footerY + 6, pageWidth - 20, 30);
            e.Graphics.DrawString(pageInfo, policeTitre, Brushes.Black, rectPage, new StringFormat { Alignment = StringAlignment.Far, LineAlignment = StringAlignment.Center });

            e.HasMorePages = false;
        }
    }
}
