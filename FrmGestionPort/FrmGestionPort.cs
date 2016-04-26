using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Port_classes_console;

namespace Port_Classe
{
    public partial class FrmGestionPort : Form
    {
        public FrmGestionPort()
        {
            InitializeComponent();
        }
        private List<Stockage> Stockages;
        private List<Navire> Navires;

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDecharger_Click(object sender, EventArgs e)
        {

        }
    }
}
