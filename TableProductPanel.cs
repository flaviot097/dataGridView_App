using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dataGridView_App
{
    public partial class TableProductPanel : Form
    {
        public TableProductPanel()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'app_gestor_cajaDataSet.Product' Puede moverla o quitarla según sea necesario.
            this.productTableAdapter.Fill(this.app_gestor_cajaDataSet.Product);

        }

    }
}
