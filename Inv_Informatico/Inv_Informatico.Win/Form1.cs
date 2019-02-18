﻿using Inv_Informatico.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inv_Informatico.Win
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var hardwareBL = new HardwareBL();
            var listadeHardware = hardwareBL.ObtenerHardware();

            listadeHardwareBindingSource.DataSource = listadeHardware;
        }

    }
}
