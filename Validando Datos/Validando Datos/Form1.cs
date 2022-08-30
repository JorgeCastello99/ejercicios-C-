using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Validando_Datos
{
    public partial class Form1 : Form
    {
        bool ok = false;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void MaskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            elimarError();
          



          
            bool erNom=validarNombre();
            bool erA=validarApellido();
            bool erM = validarMovil();
            bool erE=validarEmail();
            bool erMat = validarMatricula();
            bool ereDni = validarDNI();
            bool ereCuenta = validarCuenta();

            if (erNom==true && erA==true && erM==true&& erE==true && erMat==true &&ereDni==true&&ereCuenta==true )
            {
                MessageBox.Show("Datos ingresados Correctamente", "Excelente", MessageBoxButtons.OK);
                ok = true;
            }

            if (ok == true)
            {
                archivar.Enabled = true;
            }
            ok = false;

        }

        public bool validarNombre()
        {
            bool er = false;

            Regex Val1 = new Regex("^[a-zA-Z ]*$");
            if (Val1.IsMatch(maskedTextBoxNombre.Text) && maskedTextBoxNombre.Text != "")
            {
                er = true;
            }
            else
            {
                MessageBox.Show("El Nombre solo debe conener letras", "Error", MessageBoxButtons.OK);

            }
            return er;
        }

        public bool validarApellido() {
            bool er=false;
            Regex Val1 = new Regex("^[a-zA-Z ]*$");
            if (Val1.IsMatch(maskedTextBoxApellidos.Text) && maskedTextBoxApellidos.Text != "")
            {
                er = true;
            }
            else {
                MessageBox.Show("El Apellido solo debe conener letras", "Error", MessageBoxButtons.OK);
                
            }
            return er;
        }

        

        private bool validarMovil()
        {
            bool er = false;



            return er;
        }
        


            private bool validarEmail() {
            bool erroremail = false;
            String texto = maskedTextBoxEmail.Text;
            int a = texto.IndexOf("@");
            int b = texto.IndexOf(".com");
            int c = texto.IndexOf(".es");

            if (a==-1)
            {

                MessageBox.Show("El E-mail debe tener @", "Error", MessageBoxButtons.OK);

            }
            else
            {
                if (b==-1){
                   
                }
                else
                {
                    erroremail = true;
                }
                if (c == -1)
                {
                    
                }
                else
                {
                    erroremail = true;
                }
            }
            return erroremail;
        }

        private bool validarMatricula() {

            bool er = false;



            return er;
        }
        private bool validarDNI() {

            bool er = false;



            return er;

        }
        private bool validarCuenta() {

            bool er = false;



            return er;
        }

      
            

         


        
        private void elimarError() {

            errorProvider1.SetError(maskedTextBoxNombre, "");
            errorProvider1.SetError(maskedTextBoxApellidos, "");
            errorProvider1.SetError(maskedTextBoxMatricula, "");
            errorProvider1.SetError(maskedTextBoxEmail, "");
            errorProvider1.SetError(maskedTextBoxNif, "");
            errorProvider1.SetError(maskedTextBoxNCuenta, "");
            errorProvider1.SetError(maskedTextBoxMovil, "");
        }

        private void Archivar_Click(object sender, EventArgs e)
        {
            string a = maskedTextBoxNombre.Text;
            string b = maskedTextBoxApellidos.Text;
            string c = maskedTextBoxMatricula.Text;
            string d = maskedTextBoxEmail.Text;
            string t = maskedTextBoxNif.Text;
            string f = maskedTextBoxNCuenta.Text;
            string g = maskedTextBoxMovil.Text;
            StreamWriter fichero;
            fichero = File.CreateText("Fichdatos.txt");
            fichero.Write(a + "\n");
            fichero.Write(b + "\n");
            fichero.Write(c + "\n");
            fichero.Write(d + "\n");
            fichero.Write(t + "\n");
            fichero.Write(f + "\n");
            fichero.Write(g + "\n");
            fichero.WriteLine("**************************");
            fichero.Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {   
            int count=0;
            string ruta = "c:\\Users\\Sofia\\Desktop\\Fichdatos.txt";
            StreamReader fichero = new StreamReader(ruta);
            string linea;
            string txt="";
            fichero = File.OpenText(@"c:\Users\Sofia\Desktop\Fichdatos.txt");
            linea = fichero.ReadLine();
            fichero.Close();
            while( linea != null) {
                linea = fichero.ReadLine();
                txt = linea;
                System.Console.WriteLine(txt);
                count++;
                //me lo guarda pero no abre el txt.
            }
            fichero.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
