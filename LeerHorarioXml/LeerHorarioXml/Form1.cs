using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace LeerHorarioXml
{
    public partial class Form1 : Form
    {
        string filePath = "C:\\Users\\David\\Documents\\prueba.xml";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
       

            dataSet1.ReadXml(filePath);

            dataGridView1.DataSource = dataSet1;
            dataGridView1.DataMember = "Persona";

            StringWriter swXML = new StringWriter();
            this.dataSet1.WriteXmlSchema(swXML); //nombre del dataset
            this.textBox1.Text = swXML.ToString(); //Cuadro de texto donde sale el resultado
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FileStream fichXML = new FileStream(filePath, FileMode.Create);
            this.dataSet1.WriteXml(fichXML);
            fichXML.Close();
            MessageBox.Show("Guardado");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.IO.StringWriter swXML = new System.IO.StringWriter();
            dataSet1.WriteXmlSchema(swXML);
            textBox1.Text = swXML.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
