using Metier;

namespace Interface
{
    public partial class FrmMenu : FrmBase
    {
        public FrmMenu(Session uneSession) : base(uneSession)
        {
            InitializeComponent();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            this.lblTitre.Text = "Bienvenue sur l'application de gestion des visites";
        }
    }
}
