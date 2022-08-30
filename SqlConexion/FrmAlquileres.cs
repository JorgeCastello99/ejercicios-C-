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
    public partial class FrmAlquileres : Form
    {
        
        public FrmAlquileres()
        {
            InitializeComponent();

            cargarCaratulas();
        }

        private void sociosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sociosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bdBD);

        }

        private void FrmAlquileres_Load(object sender, EventArgs e)
        {
            videoclubDataSetTableAdapters.estilosTableAdapter dtbEstilos = new videoclubDataSetTableAdapters.estilosTableAdapter();
            dtbEstilos.Fill(bdBD.estilos);
            for (int i = 0; i < bdBD.estilos.Count; i++)
            {
                estiloComboBox.Items.Add(bdBD.estilos[i].estilo);
            }

            videoclubDataSetTableAdapters.categoriasTableAdapter dtbCategoria = new videoclubDataSetTableAdapters.categoriasTableAdapter();
            dtbCategoria.Fill(bdBD.categorias);
            for (int i = 0; i < bdBD.categorias.Count; i++)
            {
                categoriaComboBox.Items.Add(bdBD.categorias[i].categoria);
            }

            this.alquileresTableAdapter.Fill(this.bdBD.alquileres);
            this.peliculasTableAdapter.Fill(this.bdBD.peliculas);
            this.sociosTableAdapter.Fill(this.bdBD.socios);
            cargarCaratulas();

        }

        private void TitulosCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            bdBD.peliculas.Clear();
            peliculasTableAdapter.FillByTitulo(bdBD.peliculas,tituloComboBox.Text);
            cargarCaratulas();
        }

        private void cargarCaratulas()
        {
            String fichCarat = "Imagenes\\"+caratulaTextBox.Text;
            String rutaCaratula = System.IO.Path.Combine(Application.StartupPath, fichCarat);
            this.picCaratula.ImageLocation = rutaCaratula;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            BuscarSocio busca = new BuscarSocio();
            if (busca.ShowDialog() == DialogResult.Cancel)
            {
                sociosTableAdapter.FillById(bdBD.socios, busca.id);
            }
        }

  
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        private void button3_Click(object sender, EventArgs e)
        {
            videoclubDataSetTableAdapters.alquileresTableAdapter update = new videoclubDataSetTableAdapters.alquileresTableAdapter();
            update.UpdateQuery(DateTime.Now, Convert.ToInt32(codAlquilerTextBox.Text));
        }

        private void CaratulaTextBox_TextChanged(object sender, EventArgs e)
        {

            String fichCarat = "Imagenes\\" + caratulaTextBox.Text;
            String rutaCaratula = System.IO.Path.Combine(Application.StartupPath, fichCarat);
            this.picCaratula.ImageLocation = rutaCaratula;

        }

        private void CodpeliLabel2_TextChanged(object sender, EventArgs e)
        {


        }
    }
}
