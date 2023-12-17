﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Bachup_s_backup.Form1;

namespace Bachup_s_backup
{
    public partial class Form_DI_Color : Form
    {
        public Form_DI_Color()
        {
            InitializeComponent();
            //propertyGrid1.SelectedObject = new DI_color_property();
        }

        private void submit_Click(object sender, EventArgs e)
        {

        }

        private void cancel_Click(object sender, EventArgs e)
        {
            //this.Close();
        }

        private string ColorToHex(Color c)
        {
            return $"#{c.R:X2}{c.G:X2}{c.B:X2}";
        }

        private void label2_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                Form1_Instance.config_JSON.DI_BackColor = colorDialog.Color.Color2Hex();
                Form1_Instance.Refresh();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                Form1_Instance.config_JSON.DI_ForeColor = colorDialog.Color.Color2Hex();
                Form1_Instance.Refresh();
            }
        }
    }
    class DI_color_property
    {
        [Category("Color Setting")]
        [DisplayName("Desktop Item BackColor")]
        public Color DI_BackColor
        {
            get
            {
                return Form1_Instance.config_JSON.DI_BackColor.Hex2Coler();
            }
            set
            {
                Form1_Instance.config_JSON.DI_BackColor = $"#{value.R:X2}{value.G:X2}{value.B:X2}";
                Form1_Instance.Refresh();
            }
        }
        [Category("Color Setting")]
        [DisplayName("Desktop Item ForeColor")]
        public Color DI_ForeColor
        {
            get
            {
                return Form1_Instance.config_JSON.DI_ForeColor.Hex2Coler();
            }
            set
            {
                Form1_Instance.config_JSON.DI_ForeColor = $"#{value.R:X2}{value.G:X2}{value.B:X2}";
                Form1_Instance.Refresh();
            }
        }
    }
}