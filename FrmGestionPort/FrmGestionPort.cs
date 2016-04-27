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

        /// <summary>
        /// Creation d'un port
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCreerPort_Click(object sender, EventArgs e)
        {
            Port = new Enhanced.Port(TxtNomPort.Text);
            MessageBox.Show("Port créé");
            TxtNomPort.Enabled = false;
            BtnCreerPort.Enabled = false;
            TxNbFretPresent.Text = 

            // Activations des champs de navires
            TxNumLLOYD.Enabled = true;
            TxNomNavire.Enabled = true;
            TxPavillon.Enabled = true;
            TxLongueur.Enabled = true;
            TxLargeur.Enabled = true;
            TxTirant.Enabled = true;

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

        /// <summary>
        /// Creation d'un navire de type fret
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCreerNavireFret_Click(object sender, EventArgs e)
        {

        }

        private void BtnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
