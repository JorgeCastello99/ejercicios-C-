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
    public partial class FormUser : Form
    {
        public FormUser()
        {
            InitializeComponent();
        }

        public int IDSocio;
        private void Button1_Click(object sender, EventArgs e)
        {
            videoclubDataSet ds = new videoclubDataSet();

            videoclubDataSetTableAdapters.sociosTableAdapter tbSocios = new videoclubDataSetTableAdapters.sociosTableAdapter();

            tbSocios.FillBy(ds.socios, textBox1.Text, textBox2.Text);

            if (ds.socios.Count > 0)
            {
                MessageBox.Show("Buenas" + ds.socios[0].nombre, "Saludo", MessageBoxButtons.OK);
                IDSocio = ds.socios[0].idSocio;

                this.Hide();
                Form fr = new Form4();
               
                fr.Show();
               
            }
            else MessageBox.Show("Te has tenido que equivocar...");
            
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
