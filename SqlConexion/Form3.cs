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
    public partial class SociosDatagridView : Form
    {
        public SociosDatagridView()
        {
            InitializeComponent();
        }

        private void SociosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sociosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.videoclubDataSet);

        }

        private void SociosDatagridView_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'videoclubDataSet.socios' Puede moverla o quitarla según sea necesario.
            this.sociosTableAdapter.Fill(this.videoclubDataSet.socios);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int regs;
            regs = this.sociosTableAdapter.Update(this.videoclubDataSet.socios);
            MessageBox.Show("Ha sido actualizado" + regs + " registros", "ok", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Limpiamos los datos para volverlos a llenar
            videoclubDataSet.Clear();
            sociosTableAdapter.Fill(videoclubDataSet.socios);
        }
    }
}
