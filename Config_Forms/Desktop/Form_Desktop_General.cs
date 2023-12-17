﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bachup_s_backup.Setting_items.form1
{
    public partial class Form_Desktop_General : Form
    {
        double ori = Form1.Form1_Instance.Opacity;

        public Form_Desktop_General()
        {
            InitializeComponent();
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            double opac = (double)hScrollBar1.Value / 100;
            label1.Text = $"{opac}%";
            if (opac != 0.0f) Form1.Form1_Instance.Opacity = opac;
        }

        private void onCancel(object sender, EventArgs e)
        {
            Form1.Form1_Instance.Opacity = ori;
            hScrollBar1.Value = (int)(ori * 100);
        }

        private void onSubmit(object sender, EventArgs e) => ori = Form1.Form1_Instance.Opacity;

    }
}