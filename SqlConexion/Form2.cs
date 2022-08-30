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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void SociosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sociosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.videoclubDataSet);
            MessageBox.Show("Se ha modificado correctamente un resgistro");

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'videoclubDataSet.socios' Puede moverla o quitarla según sea necesario.
            this.sociosTableAdapter.Fill(this.videoclubDataSet.socios);

        }

     

        private void BindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            int regs;
            DialogResult resp = new DialogResult();
            resp=MessageBox.Show("Seguro que quieres eliminar este registro??","Eliminar registro",MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation);
            if (resp == System.Windows.Forms.DialogResult.Yes)
            {
               
                regs = this.sociosTableAdapter.Delete(int.Parse(this.idSocioLabel1.Text));
                if (regs > 0)
                {
                    MessageBox.Show("Registro eliminado", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    videoclubDataSet.Clear();
                    sociosTableAdapter.Fill(videoclubDataSet.socios);
                }

            }
        }

       
    }
}
