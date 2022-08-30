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
    public partial class Form4: Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            nuevaVentana(new Form2());
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
           

            nuevaVentana(new Form1());
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {

            

            nuevaVentana(new FrmAlquileres());


        }

        private void PictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox5_Click(object sender, EventArgs e)
        {
            Form fr = new FormUser();
            fr.Show();
            this.Hide();

        }
        public void nuevaVentana(object ejer)
        {
            if (this.ActiveMdiChild == null)
            {
                Formulario(ejer);
            }
            else
            {
               
                    this.ActiveMdiChild.Close();
                    Formulario(ejer);
             
            }

        }

        private void Formulario(object ejer)
        {
            Form hijo = ejer as Form;
            hijo.MdiParent = this;
            hijo.Text = "Documento" + this.MdiChildren.Length.ToString();
            hijo.FormBorderStyle = FormBorderStyle.None;
            hijo.Dock = DockStyle.Fill;
            hijo.Show();
        }
    }
}
