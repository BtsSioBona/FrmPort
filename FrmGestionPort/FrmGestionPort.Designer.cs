namespace Port_Classe
{
    partial class FrmGestionPort
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.TxNumLLOYD = new System.Windows.Forms.TextBox();
            this.TxNomNavire = new System.Windows.Forms.TextBox();
            this.TxPavillon = new System.Windows.Forms.TextBox();
            this.TxLongueur = new System.Windows.Forms.TextBox();
            this.TxLargeur = new System.Windows.Forms.TextBox();
            this.TxTirant = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.GrbPort = new System.Windows.Forms.GroupBox();
            this.TxNomPort = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.BtnCreerPort = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.TxNbFretPresent = new System.Windows.Forms.TextBox();
            this.TxNbPassagerPresent = new System.Windows.Forms.TextBox();
            this.TxNbFretCreer = new System.Windows.Forms.TextBox();
            this.TxNbPassagerStatic = new System.Windows.Forms.TextBox();
            this.GrbNavireFret = new System.Windows.Forms.GroupBox();
            this.TxNumFret = new System.Windows.Forms.TextBox();
            this.TxQuantiteFret = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.BtnCreerNavireFret = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.TxLibelleFret = new System.Windows.Forms.TextBox();
            this.BtnAffecterPort = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.TxIndiceSupp = new System.Windows.Forms.TextBox();
            this.BtnRetirerDuPort = new System.Windows.Forms.Button();
            this.GrbNavirePassagers = new System.Windows.Forms.GroupBox();
            this.BtnRetirerDuPort2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.BtnAffecterAuPort2 = new System.Windows.Forms.Button();
            this.TxNbCabine = new System.Windows.Forms.TextBox();
            this.TxNbChambre = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.BtnCreerNavirePassager = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.TxNbMaxiPassager = new System.Windows.Forms.TextBox();
            this.BtnAfficherTousNavire = new System.Windows.Forms.Button();
            this.CbAfficherTousNavire = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.NupIndiceAfficher = new System.Windows.Forms.NumericUpDown();
            this.BtnAfficherUnNavire = new System.Windows.Forms.Button();
            this.CbAfficherUnNavire = new System.Windows.Forms.ComboBox();
            this.BtnQuitter = new System.Windows.Forms.Button();
            this.GrbPort.SuspendLayout();
            this.GrbNavireFret.SuspendLayout();
            this.GrbNavirePassagers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NupIndiceAfficher)).BeginInit();
            this.SuspendLayout();
            // 
            // TxNumLLOYD
            // 
            this.TxNumLLOYD.Location = new System.Drawing.Point(114, 22);
            this.TxNumLLOYD.Name = "TxNumLLOYD";
            this.TxNumLLOYD.Size = new System.Drawing.Size(121, 20);
            this.TxNumLLOYD.TabIndex = 0;
            // 
            // TxNomNavire
            // 
            this.TxNomNavire.Location = new System.Drawing.Point(114, 48);
            this.TxNomNavire.Name = "TxNomNavire";
            this.TxNomNavire.Size = new System.Drawing.Size(121, 20);
            this.TxNomNavire.TabIndex = 1;
            // 
            // TxPavillon
            // 
            this.TxPavillon.Location = new System.Drawing.Point(114, 74);
            this.TxPavillon.Name = "TxPavillon";
            this.TxPavillon.Size = new System.Drawing.Size(121, 20);
            this.TxPavillon.TabIndex = 2;
            // 
            // TxLongueur
            // 
            this.TxLongueur.Location = new System.Drawing.Point(114, 100);
            this.TxLongueur.Name = "TxLongueur";
            this.TxLongueur.Size = new System.Drawing.Size(121, 20);
            this.TxLongueur.TabIndex = 3;
            // 
            // TxLargeur
            // 
            this.TxLargeur.Location = new System.Drawing.Point(114, 126);
            this.TxLargeur.Name = "TxLargeur";
            this.TxLargeur.Size = new System.Drawing.Size(121, 20);
            this.TxLargeur.TabIndex = 4;
            // 
            // TxTirant
            // 
            this.TxTirant.Location = new System.Drawing.Point(114, 152);
            this.TxTirant.Name = "TxTirant";
            this.TxTirant.Size = new System.Drawing.Size(121, 20);
            this.TxTirant.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Numéro LLOYD";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 55);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nom Navire";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Pavillon";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Longueur";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Largeur";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Tirant d\'eau";
            // 
            // GrbPort
            // 
            this.GrbPort.Controls.Add(this.TxNbPassagerStatic);
            this.GrbPort.Controls.Add(this.TxNbFretCreer);
            this.GrbPort.Controls.Add(this.TxNbPassagerPresent);
            this.GrbPort.Controls.Add(this.TxNbFretPresent);
            this.GrbPort.Controls.Add(this.label11);
            this.GrbPort.Controls.Add(this.label10);
            this.GrbPort.Controls.Add(this.label9);
            this.GrbPort.Controls.Add(this.label8);
            this.GrbPort.Controls.Add(this.BtnCreerPort);
            this.GrbPort.Controls.Add(this.label7);
            this.GrbPort.Controls.Add(this.TxNomPort);
            this.GrbPort.Location = new System.Drawing.Point(332, 22);
            this.GrbPort.Name = "GrbPort";
            this.GrbPort.Size = new System.Drawing.Size(432, 150);
            this.GrbPort.TabIndex = 12;
            this.GrbPort.TabStop = false;
            this.GrbPort.Text = "Port";
            // 
            // TxNomPort
            // 
            this.TxNomPort.Location = new System.Drawing.Point(121, 26);
            this.TxNomPort.Name = "TxNomPort";
            this.TxNomPort.Size = new System.Drawing.Size(121, 20);
            this.TxNomPort.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Nom du Port";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // BtnCreerPort
            // 
            this.BtnCreerPort.Location = new System.Drawing.Point(73, 59);
            this.BtnCreerPort.Name = "BtnCreerPort";
            this.BtnCreerPort.Size = new System.Drawing.Size(113, 39);
            this.BtnCreerPort.TabIndex = 14;
            this.BtnCreerPort.Text = "Créer Le Port";
            this.BtnCreerPort.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 107);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Nb Frets présents :";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 131);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Nb Passagers présents :";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(252, 105);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Nb Frêt crées :";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(245, 131);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Static Passager :";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // TxNbFretPresent
            // 
            this.TxNbFretPresent.Location = new System.Drawing.Point(156, 100);
            this.TxNbFretPresent.Name = "TxNbFretPresent";
            this.TxNbFretPresent.Size = new System.Drawing.Size(57, 20);
            this.TxNbFretPresent.TabIndex = 19;
            // 
            // TxNbPassagerPresent
            // 
            this.TxNbPassagerPresent.Location = new System.Drawing.Point(156, 124);
            this.TxNbPassagerPresent.Name = "TxNbPassagerPresent";
            this.TxNbPassagerPresent.Size = new System.Drawing.Size(57, 20);
            this.TxNbPassagerPresent.TabIndex = 20;
            // 
            // TxNbFretCreer
            // 
            this.TxNbFretCreer.Location = new System.Drawing.Point(338, 98);
            this.TxNbFretCreer.Name = "TxNbFretCreer";
            this.TxNbFretCreer.Size = new System.Drawing.Size(57, 20);
            this.TxNbFretCreer.TabIndex = 21;
            // 
            // TxNbPassagerStatic
            // 
            this.TxNbPassagerStatic.Location = new System.Drawing.Point(338, 123);
            this.TxNbPassagerStatic.Name = "TxNbPassagerStatic";
            this.TxNbPassagerStatic.Size = new System.Drawing.Size(57, 20);
            this.TxNbPassagerStatic.TabIndex = 22;
            // 
            // GrbNavireFret
            // 
            this.GrbNavireFret.Controls.Add(this.BtnRetirerDuPort);
            this.GrbNavireFret.Controls.Add(this.TxIndiceSupp);
            this.GrbNavireFret.Controls.Add(this.label12);
            this.GrbNavireFret.Controls.Add(this.BtnAffecterPort);
            this.GrbNavireFret.Controls.Add(this.TxNumFret);
            this.GrbNavireFret.Controls.Add(this.TxQuantiteFret);
            this.GrbNavireFret.Controls.Add(this.label14);
            this.GrbNavireFret.Controls.Add(this.label15);
            this.GrbNavireFret.Controls.Add(this.BtnCreerNavireFret);
            this.GrbNavireFret.Controls.Add(this.label16);
            this.GrbNavireFret.Controls.Add(this.TxLibelleFret);
            this.GrbNavireFret.Location = new System.Drawing.Point(25, 215);
            this.GrbNavireFret.Name = "GrbNavireFret";
            this.GrbNavireFret.Size = new System.Drawing.Size(354, 238);
            this.GrbNavireFret.TabIndex = 23;
            this.GrbNavireFret.TabStop = false;
            this.GrbNavireFret.Text = "Navire Frêt";
            // 
            // TxNumFret
            // 
            this.TxNumFret.Location = new System.Drawing.Point(156, 87);
            this.TxNumFret.Name = "TxNumFret";
            this.TxNumFret.Size = new System.Drawing.Size(121, 20);
            this.TxNumFret.TabIndex = 20;
            // 
            // TxQuantiteFret
            // 
            this.TxQuantiteFret.Location = new System.Drawing.Point(156, 59);
            this.TxQuantiteFret.Name = "TxQuantiteFret";
            this.TxQuantiteFret.Size = new System.Drawing.Size(121, 20);
            this.TxQuantiteFret.TabIndex = 19;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(22, 94);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(77, 13);
            this.label14.TabIndex = 16;
            this.label14.Text = "Nombre de frêt";
            this.label14.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(22, 66);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(68, 13);
            this.label15.TabIndex = 15;
            this.label15.Text = "Quantité Frêt";
            this.label15.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // BtnCreerNavireFret
            // 
            this.BtnCreerNavireFret.Location = new System.Drawing.Point(25, 122);
            this.BtnCreerNavireFret.Name = "BtnCreerNavireFret";
            this.BtnCreerNavireFret.Size = new System.Drawing.Size(131, 39);
            this.BtnCreerNavireFret.TabIndex = 14;
            this.BtnCreerNavireFret.Text = "Créer Navire Frêt";
            this.BtnCreerNavireFret.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(22, 37);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(58, 13);
            this.label16.TabIndex = 13;
            this.label16.Text = "Libelle Frêt";
            this.label16.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // TxLibelleFret
            // 
            this.TxLibelleFret.Location = new System.Drawing.Point(156, 30);
            this.TxLibelleFret.Name = "TxLibelleFret";
            this.TxLibelleFret.Size = new System.Drawing.Size(121, 20);
            this.TxLibelleFret.TabIndex = 13;
            // 
            // BtnAffecterPort
            // 
            this.BtnAffecterPort.Location = new System.Drawing.Point(162, 122);
            this.BtnAffecterPort.Name = "BtnAffecterPort";
            this.BtnAffecterPort.Size = new System.Drawing.Size(131, 39);
            this.BtnAffecterPort.TabIndex = 21;
            this.BtnAffecterPort.Text = "Affecter au Port";
            this.BtnAffecterPort.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(22, 202);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(93, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "Indice à supprimer";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // TxIndiceSupp
            // 
            this.TxIndiceSupp.Location = new System.Drawing.Point(130, 195);
            this.TxIndiceSupp.Name = "TxIndiceSupp";
            this.TxIndiceSupp.Size = new System.Drawing.Size(37, 20);
            this.TxIndiceSupp.TabIndex = 23;
            // 
            // BtnRetirerDuPort
            // 
            this.BtnRetirerDuPort.Location = new System.Drawing.Point(192, 195);
            this.BtnRetirerDuPort.Name = "BtnRetirerDuPort";
            this.BtnRetirerDuPort.Size = new System.Drawing.Size(136, 20);
            this.BtnRetirerDuPort.TabIndex = 24;
            this.BtnRetirerDuPort.Text = "Retirer du port";
            this.BtnRetirerDuPort.UseVisualStyleBackColor = true;
            // 
            // GrbNavirePassagers
            // 
            this.GrbNavirePassagers.Controls.Add(this.BtnRetirerDuPort2);
            this.GrbNavirePassagers.Controls.Add(this.textBox1);
            this.GrbNavirePassagers.Controls.Add(this.label13);
            this.GrbNavirePassagers.Controls.Add(this.BtnAffecterAuPort2);
            this.GrbNavirePassagers.Controls.Add(this.TxNbCabine);
            this.GrbNavirePassagers.Controls.Add(this.TxNbChambre);
            this.GrbNavirePassagers.Controls.Add(this.label17);
            this.GrbNavirePassagers.Controls.Add(this.label18);
            this.GrbNavirePassagers.Controls.Add(this.BtnCreerNavirePassager);
            this.GrbNavirePassagers.Controls.Add(this.label19);
            this.GrbNavirePassagers.Controls.Add(this.TxNbMaxiPassager);
            this.GrbNavirePassagers.Location = new System.Drawing.Point(431, 215);
            this.GrbNavirePassagers.Name = "GrbNavirePassagers";
            this.GrbNavirePassagers.Size = new System.Drawing.Size(354, 238);
            this.GrbNavirePassagers.TabIndex = 25;
            this.GrbNavirePassagers.TabStop = false;
            this.GrbNavirePassagers.Text = "Navire Passagers";
            // 
            // BtnRetirerDuPort2
            // 
            this.BtnRetirerDuPort2.Location = new System.Drawing.Point(192, 195);
            this.BtnRetirerDuPort2.Name = "BtnRetirerDuPort2";
            this.BtnRetirerDuPort2.Size = new System.Drawing.Size(136, 20);
            this.BtnRetirerDuPort2.TabIndex = 24;
            this.BtnRetirerDuPort2.Text = "Retirer du port";
            this.BtnRetirerDuPort2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(130, 195);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(37, 20);
            this.textBox1.TabIndex = 23;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(22, 202);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(93, 13);
            this.label13.TabIndex = 22;
            this.label13.Text = "Indice à supprimer";
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // BtnAffecterAuPort2
            // 
            this.BtnAffecterAuPort2.Location = new System.Drawing.Point(162, 122);
            this.BtnAffecterAuPort2.Name = "BtnAffecterAuPort2";
            this.BtnAffecterAuPort2.Size = new System.Drawing.Size(131, 39);
            this.BtnAffecterAuPort2.TabIndex = 21;
            this.BtnAffecterAuPort2.Text = "Affecter au Port";
            this.BtnAffecterAuPort2.UseVisualStyleBackColor = true;
            // 
            // TxNbCabine
            // 
            this.TxNbCabine.Location = new System.Drawing.Point(156, 87);
            this.TxNbCabine.Name = "TxNbCabine";
            this.TxNbCabine.Size = new System.Drawing.Size(121, 20);
            this.TxNbCabine.TabIndex = 20;
            // 
            // TxNbChambre
            // 
            this.TxNbChambre.Location = new System.Drawing.Point(156, 59);
            this.TxNbChambre.Name = "TxNbChambre";
            this.TxNbChambre.Size = new System.Drawing.Size(121, 20);
            this.TxNbChambre.TabIndex = 19;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(22, 94);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(85, 13);
            this.label17.TabIndex = 16;
            this.label17.Text = "Nombre Cabines";
            this.label17.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(22, 66);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(94, 13);
            this.label18.TabIndex = 15;
            this.label18.Text = "Nombre Chambres";
            this.label18.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // BtnCreerNavirePassager
            // 
            this.BtnCreerNavirePassager.Location = new System.Drawing.Point(25, 122);
            this.BtnCreerNavirePassager.Name = "BtnCreerNavirePassager";
            this.BtnCreerNavirePassager.Size = new System.Drawing.Size(131, 39);
            this.BtnCreerNavirePassager.TabIndex = 14;
            this.BtnCreerNavirePassager.Text = "Créer Navire Passager";
            this.BtnCreerNavirePassager.UseVisualStyleBackColor = true;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(22, 37);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(98, 13);
            this.label19.TabIndex = 13;
            this.label19.Text = "Nb Maxi Passagers";
            this.label19.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // TxNbMaxiPassager
            // 
            this.TxNbMaxiPassager.Location = new System.Drawing.Point(156, 30);
            this.TxNbMaxiPassager.Name = "TxNbMaxiPassager";
            this.TxNbMaxiPassager.Size = new System.Drawing.Size(121, 20);
            this.TxNbMaxiPassager.TabIndex = 13;
            // 
            // BtnAfficherTousNavire
            // 
            this.BtnAfficherTousNavire.Location = new System.Drawing.Point(77, 472);
            this.BtnAfficherTousNavire.Name = "BtnAfficherTousNavire";
            this.BtnAfficherTousNavire.Size = new System.Drawing.Size(256, 57);
            this.BtnAfficherTousNavire.TabIndex = 25;
            this.BtnAfficherTousNavire.Text = "Afficher tous les navires du Port";
            this.BtnAfficherTousNavire.UseVisualStyleBackColor = true;
            // 
            // CbAfficherTousNavire
            // 
            this.CbAfficherTousNavire.FormattingEnabled = true;
            this.CbAfficherTousNavire.Location = new System.Drawing.Point(357, 491);
            this.CbAfficherTousNavire.Name = "CbAfficherTousNavire";
            this.CbAfficherTousNavire.Size = new System.Drawing.Size(428, 21);
            this.CbAfficherTousNavire.TabIndex = 26;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(74, 562);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(89, 13);
            this.label20.TabIndex = 25;
            this.label20.Text = "Indice à afficher :";
            this.label20.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // NupIndiceAfficher
            // 
            this.NupIndiceAfficher.Location = new System.Drawing.Point(181, 554);
            this.NupIndiceAfficher.Name = "NupIndiceAfficher";
            this.NupIndiceAfficher.Size = new System.Drawing.Size(120, 20);
            this.NupIndiceAfficher.TabIndex = 27;
            // 
            // BtnAfficherUnNavire
            // 
            this.BtnAfficherUnNavire.Location = new System.Drawing.Point(341, 533);
            this.BtnAfficherUnNavire.Name = "BtnAfficherUnNavire";
            this.BtnAfficherUnNavire.Size = new System.Drawing.Size(161, 56);
            this.BtnAfficherUnNavire.TabIndex = 28;
            this.BtnAfficherUnNavire.Text = "Afficher Un Navire";
            this.BtnAfficherUnNavire.UseVisualStyleBackColor = true;
            // 
            // CbAfficherUnNavire
            // 
            this.CbAfficherUnNavire.FormattingEnabled = true;
            this.CbAfficherUnNavire.Location = new System.Drawing.Point(521, 554);
            this.CbAfficherUnNavire.Name = "CbAfficherUnNavire";
            this.CbAfficherUnNavire.Size = new System.Drawing.Size(428, 21);
            this.CbAfficherUnNavire.TabIndex = 29;
            // 
            // BtnQuitter
            // 
            this.BtnQuitter.Location = new System.Drawing.Point(341, 628);
            this.BtnQuitter.Name = "BtnQuitter";
            this.BtnQuitter.Size = new System.Drawing.Size(161, 40);
            this.BtnQuitter.TabIndex = 30;
            this.BtnQuitter.Text = "Quitter";
            this.BtnQuitter.UseVisualStyleBackColor = true;
            // 
            // Frm_Gestion_Navire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 680);
            this.Controls.Add(this.BtnQuitter);
            this.Controls.Add(this.CbAfficherUnNavire);
            this.Controls.Add(this.BtnAfficherUnNavire);
            this.Controls.Add(this.NupIndiceAfficher);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.CbAfficherTousNavire);
            this.Controls.Add(this.BtnAfficherTousNavire);
            this.Controls.Add(this.GrbNavirePassagers);
            this.Controls.Add(this.GrbNavireFret);
            this.Controls.Add(this.GrbPort);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxTirant);
            this.Controls.Add(this.TxLargeur);
            this.Controls.Add(this.TxLongueur);
            this.Controls.Add(this.TxPavillon);
            this.Controls.Add(this.TxNomNavire);
            this.Controls.Add(this.TxNumLLOYD);
            this.Name = "Frm_Gestion_Navire";
            this.Text = "Frm_Gestion_Navire";
            this.GrbPort.ResumeLayout(false);
            this.GrbPort.PerformLayout();
            this.GrbNavireFret.ResumeLayout(false);
            this.GrbNavireFret.PerformLayout();
            this.GrbNavirePassagers.ResumeLayout(false);
            this.GrbNavirePassagers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NupIndiceAfficher)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxNumLLOYD;
        private System.Windows.Forms.TextBox TxNomNavire;
        private System.Windows.Forms.TextBox TxPavillon;
        private System.Windows.Forms.TextBox TxLongueur;
        private System.Windows.Forms.TextBox TxLargeur;
        private System.Windows.Forms.TextBox TxTirant;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox GrbPort;
        private System.Windows.Forms.TextBox TxNbPassagerStatic;
        private System.Windows.Forms.TextBox TxNbFretCreer;
        private System.Windows.Forms.TextBox TxNbPassagerPresent;
        private System.Windows.Forms.TextBox TxNbFretPresent;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BtnCreerPort;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxNomPort;
        private System.Windows.Forms.GroupBox GrbNavireFret;
        private System.Windows.Forms.Button BtnRetirerDuPort;
        private System.Windows.Forms.TextBox TxIndiceSupp;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button BtnAffecterPort;
        private System.Windows.Forms.TextBox TxNumFret;
        private System.Windows.Forms.TextBox TxQuantiteFret;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button BtnCreerNavireFret;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox TxLibelleFret;
        private System.Windows.Forms.GroupBox GrbNavirePassagers;
        private System.Windows.Forms.Button BtnRetirerDuPort2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button BtnAffecterAuPort2;
        private System.Windows.Forms.TextBox TxNbCabine;
        private System.Windows.Forms.TextBox TxNbChambre;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button BtnCreerNavirePassager;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox TxNbMaxiPassager;
        private System.Windows.Forms.Button BtnAfficherTousNavire;
        private System.Windows.Forms.ComboBox CbAfficherTousNavire;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.NumericUpDown NupIndiceAfficher;
        private System.Windows.Forms.Button BtnAfficherUnNavire;
        private System.Windows.Forms.ComboBox CbAfficherUnNavire;
        private System.Windows.Forms.Button BtnQuitter;
    }
}

