using System;

namespace SqlConexion
{
    partial class FrmAlquileres
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

     
        
           #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label stockLabel1;
            System.Windows.Forms.Label caratulaLabel1;
            this.idSocioLabel = new System.Windows.Forms.Label();
            this.nombreLabel = new System.Windows.Forms.Label();
            this.codpeliLabel = new System.Windows.Forms.Label();
            this.tituloLabel = new System.Windows.Forms.Label();
            this.directorLabel = new System.Windows.Forms.Label();
            this.protagonistaLabel = new System.Windows.Forms.Label();
            this.argumentoLabel = new System.Windows.Forms.Label();
            this.estiloLabel = new System.Windows.Forms.Label();
            this.anioLabel = new System.Windows.Forms.Label();
            this.categoriaLabel = new System.Windows.Forms.Label();
            this.codAlquilerLabel = new System.Windows.Forms.Label();
            this.peliculaLabel = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.codpeliLabel2 = new System.Windows.Forms.Label();
            this.peliculasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bdBD = new SqlConexion.videoclubDataSet();
            this.anioTextBox = new System.Windows.Forms.TextBox();
            this.categoriaComboBox = new System.Windows.Forms.ComboBox();
            this.estiloComboBox = new System.Windows.Forms.ComboBox();
            this.argumentoTextBox = new System.Windows.Forms.TextBox();
            this.protagonistaTextBox = new System.Windows.Forms.TextBox();
            this.directorTextBox = new System.Windows.Forms.TextBox();
            this.caratulaTextBox = new System.Windows.Forms.TextBox();
            this.stockNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.tituloComboBox = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.picCaratula = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.peliculaTextBox = new System.Windows.Forms.TextBox();
            this.alquileresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.codAlquilerTextBox = new System.Windows.Forms.TextBox();
            this.sociosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sociosTableAdapter = new SqlConexion.videoclubDataSetTableAdapters.sociosTableAdapter();
            this.tableAdapterManager = new SqlConexion.videoclubDataSetTableAdapters.TableAdapterManager();
            this.alquileresTableAdapter = new SqlConexion.videoclubDataSetTableAdapters.alquileresTableAdapter();
            this.peliculasTableAdapter = new SqlConexion.videoclubDataSetTableAdapters.peliculasTableAdapter();
            this.idSocioTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.apell1TextBox = new System.Windows.Forms.TextBox();
            this.apell2TextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.alquileresDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bdBDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.peliculasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.peliculasBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            stockLabel1 = new System.Windows.Forms.Label();
            caratulaLabel1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.peliculasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdBD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCaratula)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alquileresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sociosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alquileresDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdBDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peliculasBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peliculasBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // stockLabel1
            // 
            stockLabel1.AutoSize = true;
            stockLabel1.Location = new System.Drawing.Point(451, 26);
            stockLabel1.Name = "stockLabel1";
            stockLabel1.Size = new System.Drawing.Size(36, 13);
            stockLabel1.TabIndex = 23;
            stockLabel1.Text = "stock:";
            // 
            // caratulaLabel1
            // 
            caratulaLabel1.AutoSize = true;
            caratulaLabel1.Location = new System.Drawing.Point(585, 30);
            caratulaLabel1.Name = "caratulaLabel1";
            caratulaLabel1.Size = new System.Drawing.Size(48, 13);
            caratulaLabel1.TabIndex = 24;
            caratulaLabel1.Text = "caratula:";
            // 
            // idSocioLabel
            // 
            this.idSocioLabel.AutoSize = true;
            this.idSocioLabel.Location = new System.Drawing.Point(93, 45);
            this.idSocioLabel.Name = "idSocioLabel";
            this.idSocioLabel.Size = new System.Drawing.Size(48, 13);
            this.idSocioLabel.TabIndex = 2;
            this.idSocioLabel.Text = "id Socio:";
            // 
            // nombreLabel
            // 
            this.nombreLabel.AutoSize = true;
            this.nombreLabel.Location = new System.Drawing.Point(353, 49);
            this.nombreLabel.Name = "nombreLabel";
            this.nombreLabel.Size = new System.Drawing.Size(45, 13);
            this.nombreLabel.TabIndex = 8;
            this.nombreLabel.Text = "nombre:";
            // 
            // codpeliLabel
            // 
            this.codpeliLabel.AutoSize = true;
            this.codpeliLabel.Location = new System.Drawing.Point(33, 16);
            this.codpeliLabel.Name = "codpeliLabel";
            this.codpeliLabel.Size = new System.Drawing.Size(44, 13);
            this.codpeliLabel.TabIndex = 0;
            this.codpeliLabel.Text = "codpeli:";
            // 
            // tituloLabel
            // 
            this.tituloLabel.AutoSize = true;
            this.tituloLabel.Location = new System.Drawing.Point(33, 45);
            this.tituloLabel.Name = "tituloLabel";
            this.tituloLabel.Size = new System.Drawing.Size(32, 13);
            this.tituloLabel.TabIndex = 2;
            this.tituloLabel.Text = "titulo:";
            // 
            // directorLabel
            // 
            this.directorLabel.AutoSize = true;
            this.directorLabel.Location = new System.Drawing.Point(33, 71);
            this.directorLabel.Name = "directorLabel";
            this.directorLabel.Size = new System.Drawing.Size(45, 13);
            this.directorLabel.TabIndex = 4;
            this.directorLabel.Text = "director:";
            // 
            // protagonistaLabel
            // 
            this.protagonistaLabel.AutoSize = true;
            this.protagonistaLabel.Location = new System.Drawing.Point(33, 97);
            this.protagonistaLabel.Name = "protagonistaLabel";
            this.protagonistaLabel.Size = new System.Drawing.Size(68, 13);
            this.protagonistaLabel.TabIndex = 6;
            this.protagonistaLabel.Text = "protagonista:";
            // 
            // argumentoLabel
            // 
            this.argumentoLabel.AutoSize = true;
            this.argumentoLabel.Location = new System.Drawing.Point(33, 165);
            this.argumentoLabel.Name = "argumentoLabel";
            this.argumentoLabel.Size = new System.Drawing.Size(60, 13);
            this.argumentoLabel.TabIndex = 8;
            this.argumentoLabel.Text = "argumento:";
            // 
            // estiloLabel
            // 
            this.estiloLabel.AutoSize = true;
            this.estiloLabel.Location = new System.Drawing.Point(33, 123);
            this.estiloLabel.Name = "estiloLabel";
            this.estiloLabel.Size = new System.Drawing.Size(34, 13);
            this.estiloLabel.TabIndex = 10;
            this.estiloLabel.Text = "estilo:";
            // 
            // anioLabel
            // 
            this.anioLabel.AutoSize = true;
            this.anioLabel.Location = new System.Drawing.Point(295, 16);
            this.anioLabel.Name = "anioLabel";
            this.anioLabel.Size = new System.Drawing.Size(30, 13);
            this.anioLabel.TabIndex = 12;
            this.anioLabel.Text = "anio:";
            // 
            // categoriaLabel
            // 
            this.categoriaLabel.AutoSize = true;
            this.categoriaLabel.Location = new System.Drawing.Point(353, 123);
            this.categoriaLabel.Name = "categoriaLabel";
            this.categoriaLabel.Size = new System.Drawing.Size(54, 13);
            this.categoriaLabel.TabIndex = 16;
            this.categoriaLabel.Text = "categoria:";
            // 
            // codAlquilerLabel
            // 
            this.codAlquilerLabel.AutoSize = true;
            this.codAlquilerLabel.Location = new System.Drawing.Point(153, 108);
            this.codAlquilerLabel.Name = "codAlquilerLabel";
            this.codAlquilerLabel.Size = new System.Drawing.Size(65, 13);
            this.codAlquilerLabel.TabIndex = 0;
            this.codAlquilerLabel.Text = "cod Alquiler:";
            // 
            // peliculaLabel
            // 
            this.peliculaLabel.AutoSize = true;
            this.peliculaLabel.Location = new System.Drawing.Point(172, 155);
            this.peliculaLabel.Name = "peliculaLabel";
            this.peliculaLabel.Size = new System.Drawing.Size(46, 13);
            this.peliculaLabel.TabIndex = 2;
            this.peliculaLabel.Text = "pelicula:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(49, 124);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(722, 295);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.BackColor = System.Drawing.Color.SandyBrown;
            this.tabPage1.Controls.Add(this.codpeliLabel2);
            this.tabPage1.Controls.Add(this.anioTextBox);
            this.tabPage1.Controls.Add(this.categoriaComboBox);
            this.tabPage1.Controls.Add(this.estiloComboBox);
            this.tabPage1.Controls.Add(this.argumentoTextBox);
            this.tabPage1.Controls.Add(this.protagonistaTextBox);
            this.tabPage1.Controls.Add(this.directorTextBox);
            this.tabPage1.Controls.Add(caratulaLabel1);
            this.tabPage1.Controls.Add(this.caratulaTextBox);
            this.tabPage1.Controls.Add(stockLabel1);
            this.tabPage1.Controls.Add(this.stockNumericUpDown);
            this.tabPage1.Controls.Add(this.tituloComboBox);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.picCaratula);
            this.tabPage1.Controls.Add(this.codpeliLabel);
            this.tabPage1.Controls.Add(this.tituloLabel);
            this.tabPage1.Controls.Add(this.directorLabel);
            this.tabPage1.Controls.Add(this.protagonistaLabel);
            this.tabPage1.Controls.Add(this.argumentoLabel);
            this.tabPage1.Controls.Add(this.estiloLabel);
            this.tabPage1.Controls.Add(this.anioLabel);
            this.tabPage1.Controls.Add(this.categoriaLabel);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(714, 269);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Alquilar";
            // 
            // codpeliLabel2
            // 
            this.codpeliLabel2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.peliculasBindingSource, "codpeli", true));
            this.codpeliLabel2.Location = new System.Drawing.Point(107, 16);
            this.codpeliLabel2.Name = "codpeliLabel2";
            this.codpeliLabel2.Size = new System.Drawing.Size(92, 17);
            this.codpeliLabel2.TabIndex = 32;
            this.codpeliLabel2.Text = "label1";
            this.codpeliLabel2.TextChanged += new System.EventHandler(this.CodpeliLabel2_TextChanged);
            // 
            // peliculasBindingSource
            // 
            this.peliculasBindingSource.DataMember = "peliculas";
            this.peliculasBindingSource.DataSource = this.bdBD;
            // 
            // bdBD
            // 
            this.bdBD.DataSetName = "bdBD";
            this.bdBD.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // anioTextBox
            // 
            this.anioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.peliculasBindingSource, "anio", true));
            this.anioTextBox.Location = new System.Drawing.Point(331, 13);
            this.anioTextBox.Name = "anioTextBox";
            this.anioTextBox.Size = new System.Drawing.Size(57, 20);
            this.anioTextBox.TabIndex = 31;
            // 
            // categoriaComboBox
            // 
            this.categoriaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.peliculasBindingSource, "categoria", true));
            this.categoriaComboBox.FormattingEnabled = true;
            this.categoriaComboBox.Location = new System.Drawing.Point(413, 120);
            this.categoriaComboBox.Name = "categoriaComboBox";
            this.categoriaComboBox.Size = new System.Drawing.Size(121, 21);
            this.categoriaComboBox.TabIndex = 30;
            // 
            // estiloComboBox
            // 
            this.estiloComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.peliculasBindingSource, "estilo", true));
            this.estiloComboBox.FormattingEnabled = true;
            this.estiloComboBox.Location = new System.Drawing.Point(107, 123);
            this.estiloComboBox.Name = "estiloComboBox";
            this.estiloComboBox.Size = new System.Drawing.Size(198, 21);
            this.estiloComboBox.TabIndex = 29;
            // 
            // argumentoTextBox
            // 
            this.argumentoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.peliculasBindingSource, "argumento", true));
            this.argumentoTextBox.Location = new System.Drawing.Point(110, 165);
            this.argumentoTextBox.Multiline = true;
            this.argumentoTextBox.Name = "argumentoTextBox";
            this.argumentoTextBox.Size = new System.Drawing.Size(342, 57);
            this.argumentoTextBox.TabIndex = 28;
            // 
            // protagonistaTextBox
            // 
            this.protagonistaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.peliculasBindingSource, "protagonista", true));
            this.protagonistaTextBox.Location = new System.Drawing.Point(110, 94);
            this.protagonistaTextBox.Name = "protagonistaTextBox";
            this.protagonistaTextBox.Size = new System.Drawing.Size(195, 20);
            this.protagonistaTextBox.TabIndex = 27;
            // 
            // directorTextBox
            // 
            this.directorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.peliculasBindingSource, "director", true));
            this.directorTextBox.Location = new System.Drawing.Point(110, 71);
            this.directorTextBox.Name = "directorTextBox";
            this.directorTextBox.Size = new System.Drawing.Size(195, 20);
            this.directorTextBox.TabIndex = 26;
            // 
            // caratulaTextBox
            // 
            this.caratulaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.peliculasBindingSource, "caratula", true));
            this.caratulaTextBox.Location = new System.Drawing.Point(564, 46);
            this.caratulaTextBox.Name = "caratulaTextBox";
            this.caratulaTextBox.Size = new System.Drawing.Size(100, 20);
            this.caratulaTextBox.TabIndex = 25;
            this.caratulaTextBox.TextChanged += new System.EventHandler(this.CaratulaTextBox_TextChanged);
            // 
            // stockNumericUpDown
            // 
            this.stockNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.peliculasBindingSource, "stock", true));
            this.stockNumericUpDown.Location = new System.Drawing.Point(484, 24);
            this.stockNumericUpDown.Name = "stockNumericUpDown";
            this.stockNumericUpDown.Size = new System.Drawing.Size(41, 20);
            this.stockNumericUpDown.TabIndex = 24;
            // 
            // tituloComboBox
            // 
            this.tituloComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.peliculasBindingSource, "titulo", true));
            this.tituloComboBox.DataSource = this.peliculasBindingSource;
            this.tituloComboBox.DisplayMember = "titulo";
            this.tituloComboBox.FormattingEnabled = true;
            this.tituloComboBox.Location = new System.Drawing.Point(107, 41);
            this.tituloComboBox.Name = "tituloComboBox";
            this.tituloComboBox.Size = new System.Drawing.Size(237, 21);
            this.tituloComboBox.TabIndex = 23;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(163, 228);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(289, 35);
            this.button2.TabIndex = 21;
            this.button2.Text = "Coger Prestada";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // picCaratula
            // 
            this.picCaratula.Image = global::SqlConexion.Properties.Resources.volver;
            this.picCaratula.Location = new System.Drawing.Point(546, 82);
            this.picCaratula.Name = "picCaratula";
            this.picCaratula.Size = new System.Drawing.Size(162, 184);
            this.picCaratula.TabIndex = 20;
            this.picCaratula.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.LightCoral;
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.peliculaLabel);
            this.tabPage2.Controls.Add(this.peliculaTextBox);
            this.tabPage2.Controls.Add(this.codAlquilerLabel);
            this.tabPage2.Controls.Add(this.codAlquilerTextBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(714, 269);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Devolver";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(398, 136);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(181, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "DEVOLVER PELICULA";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // peliculaTextBox
            // 
            this.peliculaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alquileresBindingSource, "pelicula", true));
            this.peliculaTextBox.Location = new System.Drawing.Point(224, 152);
            this.peliculaTextBox.Name = "peliculaTextBox";
            this.peliculaTextBox.Size = new System.Drawing.Size(100, 20);
            this.peliculaTextBox.TabIndex = 3;
            // 
            // alquileresBindingSource
            // 
            this.alquileresBindingSource.DataMember = "alquileres";
            this.alquileresBindingSource.DataSource = this.bdBD;
            // 
            // codAlquilerTextBox
            // 
            this.codAlquilerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alquileresBindingSource, "codAlquiler", true));
            this.codAlquilerTextBox.Location = new System.Drawing.Point(224, 105);
            this.codAlquilerTextBox.Name = "codAlquilerTextBox";
            this.codAlquilerTextBox.Size = new System.Drawing.Size(100, 20);
            this.codAlquilerTextBox.TabIndex = 1;
            // 
            // sociosBindingSource
            // 
            this.sociosBindingSource.DataMember = "socios";
            this.sociosBindingSource.DataSource = this.bdBD;
            // 
            // sociosTableAdapter
            // 
            this.sociosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.alquileresTableAdapter = this.alquileresTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.categoriasTableAdapter = null;
            this.tableAdapterManager.estilosTableAdapter = null;
            this.tableAdapterManager.peliculasTableAdapter = this.peliculasTableAdapter;
            this.tableAdapterManager.sociosTableAdapter = this.sociosTableAdapter;
            this.tableAdapterManager.UpdateOrder = SqlConexion.videoclubDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // alquileresTableAdapter
            // 
            this.alquileresTableAdapter.ClearBeforeFill = true;
            // 
            // peliculasTableAdapter
            // 
            this.peliculasTableAdapter.ClearBeforeFill = true;
            // 
            // idSocioTextBox
            // 
            this.idSocioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sociosBindingSource, "idSocio", true));
            this.idSocioTextBox.Location = new System.Drawing.Point(152, 42);
            this.idSocioTextBox.Name = "idSocioTextBox";
            this.idSocioTextBox.Size = new System.Drawing.Size(100, 20);
            this.idSocioTextBox.TabIndex = 3;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sociosBindingSource, "nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(427, 49);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(100, 20);
            this.nombreTextBox.TabIndex = 9;
            // 
            // apell1TextBox
            // 
            this.apell1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sociosBindingSource, "apell1", true));
            this.apell1TextBox.Location = new System.Drawing.Point(427, 75);
            this.apell1TextBox.Name = "apell1TextBox";
            this.apell1TextBox.Size = new System.Drawing.Size(100, 20);
            this.apell1TextBox.TabIndex = 11;
            // 
            // apell2TextBox
            // 
            this.apell2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sociosBindingSource, "apell2", true));
            this.apell2TextBox.Location = new System.Drawing.Point(546, 75);
            this.apell2TextBox.Name = "apell2TextBox";
            this.apell2TextBox.Size = new System.Drawing.Size(100, 20);
            this.apell2TextBox.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(298, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(23, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // alquileresDataGridView
            // 
            this.alquileresDataGridView.AutoGenerateColumns = false;
            this.alquileresDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.alquileresDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.alquileresDataGridView.DataSource = this.alquileresBindingSource;
            this.alquileresDataGridView.Location = new System.Drawing.Point(98, 440);
            this.alquileresDataGridView.Name = "alquileresDataGridView";
            this.alquileresDataGridView.Size = new System.Drawing.Size(619, 152);
            this.alquileresDataGridView.TabIndex = 14;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "codAlquiler";
            this.dataGridViewTextBoxColumn1.HeaderText = "codAlquiler";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "fechaAlquiler";
            this.dataGridViewTextBoxColumn2.HeaderText = "fechaAlquiler";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "socio";
            this.dataGridViewTextBoxColumn3.HeaderText = "socio";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "pelicula";
            this.dataGridViewTextBoxColumn4.HeaderText = "pelicula";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "fechaDevolucion";
            this.dataGridViewTextBoxColumn5.HeaderText = "fechaDevolucion";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "precio";
            this.dataGridViewTextBoxColumn6.HeaderText = "precio";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // bdBDBindingSource
            // 
            this.bdBDBindingSource.DataSource = this.bdBD;
            this.bdBDBindingSource.Position = 0;
            // 
            // peliculasBindingSource1
            // 
            this.peliculasBindingSource1.DataMember = "peliculas";
            this.peliculasBindingSource1.DataSource = this.bdBD;
            // 
            // peliculasBindingSource2
            // 
            this.peliculasBindingSource2.DataMember = "peliculas";
            this.peliculasBindingSource2.DataSource = this.bdBD;
            // 
            // FrmAlquileres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 686);
            this.Controls.Add(this.alquileresDataGridView);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.idSocioLabel);
            this.Controls.Add(this.idSocioTextBox);
            this.Controls.Add(this.nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(this.apell1TextBox);
            this.Controls.Add(this.apell2TextBox);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmAlquileres";
            this.Text = "FrmAlquileres";
            this.Load += new System.EventHandler(this.FrmAlquileres_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.peliculasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdBD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCaratula)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alquileresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sociosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alquileresDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdBDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peliculasBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peliculasBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

      

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private videoclubDataSet bdBD;
        private System.Windows.Forms.BindingSource sociosBindingSource;
        private videoclubDataSetTableAdapters.sociosTableAdapter sociosTableAdapter;
        private videoclubDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private videoclubDataSetTableAdapters.peliculasTableAdapter peliculasTableAdapter;
        private System.Windows.Forms.TextBox idSocioTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox apell1TextBox;
        private System.Windows.Forms.TextBox apell2TextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource peliculasBindingSource;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox picCaratula;
        private videoclubDataSetTableAdapters.alquileresTableAdapter alquileresTableAdapter;
        private System.Windows.Forms.BindingSource alquileresBindingSource;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox peliculaTextBox;
        private System.Windows.Forms.TextBox codAlquilerTextBox;
        private System.Windows.Forms.DataGridView alquileresDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Label idSocioLabel;
        private System.Windows.Forms.Label nombreLabel;
        private System.Windows.Forms.Label codpeliLabel;
        private System.Windows.Forms.Label tituloLabel;
        private System.Windows.Forms.Label directorLabel;
        private System.Windows.Forms.Label protagonistaLabel;
        private System.Windows.Forms.Label argumentoLabel;
        private System.Windows.Forms.Label estiloLabel;
        private System.Windows.Forms.Label anioLabel;
        private System.Windows.Forms.Label categoriaLabel;
        private System.Windows.Forms.Label codAlquilerLabel;
        private System.Windows.Forms.Label peliculaLabel;
        private System.Windows.Forms.ComboBox tituloComboBox;
        private System.Windows.Forms.TextBox caratulaTextBox;
        private System.Windows.Forms.NumericUpDown stockNumericUpDown;
        private System.Windows.Forms.ComboBox categoriaComboBox;
        private System.Windows.Forms.ComboBox estiloComboBox;
        private System.Windows.Forms.TextBox argumentoTextBox;
        private System.Windows.Forms.TextBox protagonistaTextBox;
        private System.Windows.Forms.TextBox directorTextBox;
        private System.Windows.Forms.Label codpeliLabel2;
        private System.Windows.Forms.TextBox anioTextBox;
        private System.Windows.Forms.BindingSource bdBDBindingSource;
        private System.Windows.Forms.BindingSource peliculasBindingSource1;
        private System.Windows.Forms.BindingSource peliculasBindingSource2;
    }
}