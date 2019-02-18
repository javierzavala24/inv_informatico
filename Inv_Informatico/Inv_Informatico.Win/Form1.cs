using Inv_Informatico.BL;
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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var hardwareBL = new HardwareBL();
            var listadeHardware = hardwareBL.ObtenerHardware();
            foreach (var hardware in listadeHardware)
            {
                MessageBox.Show(hardware.Descripcion);
            }
        }
    }
}
