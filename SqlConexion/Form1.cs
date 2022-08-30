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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            videoclubDataSetTableAdapters.estilosTableAdapter dtbEstilos = new videoclubDataSetTableAdapters.estilosTableAdapter();
            dtbEstilos.Fill(videoclubDataSet.estilos);
            for (int i = 0; i < videoclubDataSet.estilos.Count; i++)
            {
                estiloComboBox.Items.Add(videoclubDataSet.estilos[i].estilo);
            }

            videoclubDataSetTableAdapters.categoriasTableAdapter dtbCategoria = new videoclubDataSetTableAdapters.categoriasTableAdapter();
            dtbCategoria.Fill(videoclubDataSet.categorias);
            for (int i = 0; i < videoclubDataSet.categorias.Count; i++)
            {
                categoriaComboBox.Items.Add(videoclubDataSet.categorias[i].categoria);
            }

            videoclubDataSetTableAdapters.peliculasTableAdapter dtbPelis = new videoclubDataSetTableAdapters.peliculasTableAdapter();
            dtbPelis.Fill(videoclubDataSet.peliculas);



            for (int i = 0; i < videoclubDataSet.peliculas.Count; i++)
            {
                toolStripComboBox1.Items.Add(videoclubDataSet.peliculas[i].titulo);
            }
            cargarCaratula();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'videoclubDataSet.peliculas' Puede moverla o quitarla según sea necesario.
            this.peliculasTableAdapter.Fill(this.videoclubDataSet.peliculas);
            cargarCaratula();

        }

        private void ToolStripComboBox1_TextChanged(object sender, EventArgs e)
        {
            videoclubDataSet.peliculas.Clear();
            peliculasTableAdapter.FillByTitulo(videoclubDataSet.peliculas, toolStripComboBox1.Text);
            cargarCaratula();
        }


        private void cargarCaratula()
        {
            string fichCarat = "Imagenes\\" + caratulaTextBox.Text;
            string rutaCaratula = System.IO.Path.Combine(Application.StartupPath, fichCarat);
            this.pictureBox1.ImageLocation = rutaCaratula;
        }

        private void BindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {


            videoclubDataSet.peliculas.Clear();


        }

        private void SociosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

            int regs;
            regs = this.peliculasTableAdapter.Update(this.videoclubDataSet.peliculas);
            MessageBox.Show("Ha sido actualizado" + regs + " registros", "ok", MessageBoxButtons.OK, MessageBoxIcon.Information);


            videoclubDataSet.Clear();
            peliculasTableAdapter.Fill(videoclubDataSet.peliculas);


        }

        private void BindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            DialogResult resp = new DialogResult();
            resp = MessageBox.Show("Estas seguro de quereer eliminar esta pelicula??", "Borrar", MessageBoxButtons.YesNo, MessageBoxIcon.Hand);

            if (resp == DialogResult.Yes)
            {
                videoclubDataSetTableAdapters.alquileresTableAdapter tbAlqs = new videoclubDataSetTableAdapters.alquileresTableAdapter();
                tbAlqs.FillByPeliNoDev(videoclubDataSet.alquileres, int.Parse(codpeliLabel1.Text));

                if (videoclubDataSet.alquileres.Count > 0)
                {
                    MessageBox.Show("No puede eliminarse porque está alquilada!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    peliculasTableAdapter.Delete(int.Parse(codpeliLabel1.Text));
                    MessageBox.Show("Pelicula eliminada correctamente", "Borrada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }



      

        private void ToolStripLabel1_Click(object sender, EventArgs e)
        {
                             videoclubDataSet.peliculas.Clear();
                        peliculasTableAdapter.Fill(videoclubDataSet.peliculas);
                        cargarCaratula();
        }
    }
}

