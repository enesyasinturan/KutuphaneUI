﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KutuphaneUI.Sayfalar
{
    public partial class GirisSayfasi : Form
    {
        public GirisSayfasi()
        {
            InitializeComponent();
        }

        private void GirisSayfasi_Load(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("D");
        }
    }
}
