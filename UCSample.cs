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
    public partial class UCSample : UserControl
    {
        public UCSample(String title)
        {
            InitializeComponent();
            bmtSampleText.Text = title;
        }

        private void bibClose_Click(object sender, EventArgs e)
        {
            FormSample fs = UCWriteCR.getInstance();
            fs.removeSample(this);
        }

        public void Delete()
        {
            Hide();
        }
    }
}
