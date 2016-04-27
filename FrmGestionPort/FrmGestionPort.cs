using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Port_classes_console;
using Enhanced;

namespace Port_Classe
{
    public partial class FrmGestionPort : Form
    {
        private Enhanced.Port Port;

        public FrmGestionPort()
        {
            InitializeComponent();
        }

        private void BtnCreerNavireFret_Click(object sender, EventArgs e)
        {

        }

        private void BtnCreerPort_Click(object sender, EventArgs e)
        {
            Port = new Enhanced.Port(TxtNomPort.Text);
            MessageBox.Show("Port créé");
            TxtNomPort.Enabled = false;
            BtnCreerPort.Enabled = false;

            // Activation des boutons de fret
            TxLibelleFret.Enabled = true;
            TxQuantiteFret.Enabled = true;
            TxNumFret.Enabled = true;
            BtnCreerNavireFret.Enabled = true;

            // Activation des boutons passagers
            TxNbMaxiPassager.Enabled = true;
            TxNbChambre.Enabled = true;
            TxNbCabine.Enabled = true;
            BtnCreerNavirePassager.Enabled = true;
        }

        private void BtnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
