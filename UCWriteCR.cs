﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace compte_rendu
{
    public partial class UCWriteCR : UserControl
    {

        private static FormSample echantillon = new FormSample();
        public static FormSample getInstance()
        {
            return echantillon;
        }

        public UCWriteCR()
        {
            InitializeComponent();
        }

        private void bEditSample_Click(object sender, EventArgs e)
        {
            echantillon.Show();
        }
        
    }
}
