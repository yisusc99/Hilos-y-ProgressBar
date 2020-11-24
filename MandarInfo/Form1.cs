using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MandarInfo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Carga_Click(object sender, EventArgs e)
        {
            int it = 10;
            Progresa.Maximum = it;

            for (int i = 1; i <= it; i++)
            {

                // Asignar el número de la iteración
                Progresa.Value = i;

                Thread.Sleep(100);
            }
            Thread.Sleep(500);
            Form2 f = new Form2();
            pasado += new Form1.Info(f.tomoInfo);
            f.Show();
            
            
        }
        public delegate void Info(string dato);
        public event Info pasado;
        private void Envia_Click(object sender, EventArgs e)
        {
            pasado(txt.Text);
        }

    }
}
