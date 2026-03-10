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
        public FrmVisisteModification(Session uneSession) : base(uneSession)
        {
            InitializeComponent();
        }

        private void FrmVisisteModification_Load(object sender, EventArgs e)
        {
            this.lblTitre.Text = "Modifier une visite";
        }
    }
}
