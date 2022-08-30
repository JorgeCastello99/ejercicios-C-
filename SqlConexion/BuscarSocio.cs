using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SqlConexion
{
    public partial class BuscarSocio : Form
    {
        public int id = 0;
        public BuscarSocio()
        {
            InitializeComponent();
        }


        private void sociosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sociosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bdBD);

        }

        private void BuscarSocio_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bdBD.socios' Puede moverla o quitarla según sea necesario.
            this.sociosTableAdapter.Fill(this.bdBD.socios);

        }



        private void button2_Click(object sender, EventArgs e)
        {
            sociosTableAdapter.FillBySoc(bdBD.socios);
            //sociosDataGridView.SelectedRows=FillBySocios(bdBD.socios) ;

        }


        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int registro = dataGridView1.SelectedCells[0].RowIndex;
            id = Convert.ToInt32(dataGridView1.Rows[registro].Cells[0].Value);
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Se rellena la tabla en base al textbox que recoge la id del socio deseado
            if (textBox1.Text == "")
            {
                this.sociosTableAdapter.FillByNombreS(this.bdBD.socios, textBox2.Text);
            }
            else
            {
                this.sociosTableAdapter.FillById(this.bdBD.socios, Convert.ToInt32(textBox1.Text));

                //   this.sociosTableAdapter.FillByApell1(this.bdBD.socios, textBox4.Text);
            }

        }
    }
}