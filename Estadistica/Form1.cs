﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estadistica
{
    public partial class Form1 : Form
    {

        Estadistica objEstadistica = new Estadistica();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void btnencontrara_Click(object sender, EventArgs e)
        {
            //split = divide una cadena en base a un delimitador (patron) y devuelve una matriz
            lblAnswerSerie.Text = "LA MEDIA DE X ES: " +objEstadistica.Media(txtSerie.Text.Split(',')).ToString();
        }
    }
}
