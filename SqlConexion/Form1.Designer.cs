namespace SqlConexion
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label codpeliLabel;
            System.Windows.Forms.Label tituloLabel;
            System.Windows.Forms.Label directorLabel;
            System.Windows.Forms.Label protagonistaLabel;
            System.Windows.Forms.Label argumentoLabel;
            System.Windows.Forms.Label estiloLabel;
            System.Windows.Forms.Label anioLabel;
            System.Windows.Forms.Label caratulaLabel;
            System.Windows.Forms.Label categoriaLabel;
            System.Windows.Forms.Label stockLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.codpeliLabel1 = new System.Windows.Forms.Label();
            this.peliculasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.videoclubDataSet = new SqlConexion.videoclubDataSet();
            this.tituloTextBox = new System.Windows.Forms.TextBox();
            this.directorTextBox = new System.Windows.Forms.TextBox();
            this.protagonistaTextBox = new System.Windows.Forms.TextBox();
            this.argumentoTextBox = new System.Windows.Forms.TextBox();
            this.estiloComboBox = new System.Windows.Forms.ComboBox();
            this.anioTextBox = new System.Windows.Forms.TextBox();
            this.caratulaTextBox = new System.Windows.Forms.TextBox();
            this.categoriaComboBox = new System.Windows.Forms.ComboBox();
            this.stockNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.peliculasTableAdapter = new SqlConexion.videoclubDataSetTableAdapters.peliculasTableAdapter();
            this.tableAdapterManager = new SqlConexion.videoclubDataSetTableAdapters.TableAdapterManager();
            this.peliculasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            codpeliLabel = new System.Windows.Forms.Label();
            tituloLabel = new System.Windows.Forms.Label();
            directorLabel = new System.Windows.Forms.Label();
            protagonistaLabel = new System.Windows.Forms.Label();
            argumentoLabel = new System.Windows.Forms.Label();
            estiloLabel = new System.Windows.Forms.Label();
            anioLabel = new System.Windows.Forms.Label();
            caratulaLabel = new System.Windows.Forms.Label();
            categoriaLabel = new System.Windows.Forms.Label();
            stockLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.peliculasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoclubDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peliculasBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // codpeliLabel
            // 
            codpeliLabel.AutoSize = true;
            codpeliLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            codpeliLabel.Location = new System.Drawing.Point(131, 88);
            codpeliLabel.Name = "codpeliLabel";
            codpeliLabel.Size = new System.Drawing.Size(72, 22);
            codpeliLabel.TabIndex = 22;
            codpeliLabel.Text = "codpeli:";
            // 
            // tituloLabel
            // 
            tituloLabel.AutoSize = true;
            tituloLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tituloLabel.Location = new System.Drawing.Point(150, 124);
            tituloLabel.Name = "tituloLabel";
            tituloLabel.Size = new System.Drawing.Size(53, 22);
            tituloLabel.TabIndex = 24;
            tituloLabel.Text = "titulo:";
            // 
            // directorLabel
            // 
            directorLabel.AutoSize = true;
            directorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            directorLabel.Location = new System.Drawing.Point(128, 146);
            directorLabel.Name = "directorLabel";
            directorLabel.Size = new System.Drawing.Size(75, 22);
            directorLabel.TabIndex = 26;
            directorLabel.Text = "director:";
            // 
            // protagonistaLabel
            // 
            protagonistaLabel.AutoSize = true;
            protagonistaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            protagonistaLabel.Location = new System.Drawing.Point(89, 176);
            protagonistaLabel.Name = "protagonistaLabel";
            protagonistaLabel.Size = new System.Drawing.Size(114, 22);
            protagonistaLabel.TabIndex = 28;
            protagonistaLabel.Text = "protagonista:";
            // 
            // argumentoLabel
            // 
            argumentoLabel.AutoSize = true;
            argumentoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            argumentoLabel.Location = new System.Drawing.Point(103, 202);
            argumentoLabel.Name = "argumentoLabel";
            argumentoLabel.Size = new System.Drawing.Size(100, 22);
            argumentoLabel.TabIndex = 30;
            argumentoLabel.Text = "argumento:";
            // 
            // estiloLabel
            // 
            estiloLabel.AutoSize = true;
            estiloLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            estiloLabel.Location = new System.Drawing.Point(92, 350);
            estiloLabel.Name = "estiloLabel";
            estiloLabel.Size = new System.Drawing.Size(57, 22);
            estiloLabel.TabIndex = 32;
            estiloLabel.Text = "estilo:";
            // 
            // anioLabel
            // 
            anioLabel.AutoSize = true;
            anioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            anioLabel.Location = new System.Drawing.Point(380, 74);
            anioLabel.Name = "anioLabel";
            anioLabel.Size = new System.Drawing.Size(45, 22);
            anioLabel.TabIndex = 34;
            anioLabel.Text = "año:";
            // 
            // caratulaLabel
            // 
            caratulaLabel.AutoSize = true;
            caratulaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            caratulaLabel.Location = new System.Drawing.Point(649, 38);
            caratulaLabel.Name = "caratulaLabel";
            caratulaLabel.Size = new System.Drawing.Size(79, 22);
            caratulaLabel.TabIndex = 36;
            caratulaLabel.Text = "caratula:";
            // 
            // categoriaLabel
            // 
            categoriaLabel.AutoSize = true;
            categoriaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            categoriaLabel.Location = new System.Drawing.Point(67, 386);
            categoriaLabel.Name = "categoriaLabel";
            categoriaLabel.Size = new System.Drawing.Size(89, 22);
            categoriaLabel.TabIndex = 38;
            categoriaLabel.Text = "categoria:";
            // 
            // stockLabel
            // 
            stockLabel.AutoSize = true;
            stockLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            stockLabel.Location = new System.Drawing.Point(472, 381);
            stockLabel.Name = "stockLabel";
            stockLabel.Size = new System.Drawing.Size(57, 22);
            stockLabel.TabIndex = 40;
            stockLabel.Text = "stock:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(627, 355);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 34);
            this.button1.TabIndex = 21;
            this.button1.Text = "Nueva carátula";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // codpeliLabel1
            // 
            this.codpeliLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.peliculasBindingSource, "codpeli", true));
            this.codpeliLabel1.Location = new System.Drawing.Point(221, 93);
            this.codpeliLabel1.Name = "codpeliLabel1";
            this.codpeliLabel1.Size = new System.Drawing.Size(57, 13);
            this.codpeliLabel1.TabIndex = 23;
            this.codpeliLabel1.Text = "label1";
            // 
            // peliculasBindingSource
            // 
            this.peliculasBindingSource.DataMember = "peliculas";
            this.peliculasBindingSource.DataSource = this.videoclubDataSet;
            // 
            // videoclubDataSet
            // 
            this.videoclubDataSet.DataSetName = "videoclubDataSet";
            this.videoclubDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tituloTextBox
            // 
            this.tituloTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.peliculasBindingSource, "titulo", true));
            this.tituloTextBox.Location = new System.Drawing.Point(212, 126);
            this.tituloTextBox.Name = "tituloTextBox";
            this.tituloTextBox.Size = new System.Drawing.Size(284, 20);
            this.tituloTextBox.TabIndex = 25;
            // 
            // directorTextBox
            // 
            this.directorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.peliculasBindingSource, "director", true));
            this.directorTextBox.Location = new System.Drawing.Point(212, 152);
            this.directorTextBox.Name = "directorTextBox";
            this.directorTextBox.Size = new System.Drawing.Size(284, 20);
            this.directorTextBox.TabIndex = 27;
            // 
            // protagonistaTextBox
            // 
            this.protagonistaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.peliculasBindingSource, "protagonista", true));
            this.protagonistaTextBox.Location = new System.Drawing.Point(212, 178);
            this.protagonistaTextBox.Name = "protagonistaTextBox";
            this.protagonistaTextBox.Size = new System.Drawing.Size(284, 20);
            this.protagonistaTextBox.TabIndex = 29;
            // 
            // argumentoTextBox
            // 
            this.argumentoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.peliculasBindingSource, "argumento", true));
            this.argumentoTextBox.Location = new System.Drawing.Point(212, 204);
            this.argumentoTextBox.Multiline = true;
            this.argumentoTextBox.Name = "argumentoTextBox";
            this.argumentoTextBox.Size = new System.Drawing.Size(284, 113);
            this.argumentoTextBox.TabIndex = 31;
            // 
            // estiloComboBox
            // 
            this.estiloComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.peliculasBindingSource, "estilo", true));
            this.estiloComboBox.FormattingEnabled = true;
            this.estiloComboBox.Location = new System.Drawing.Point(176, 350);
            this.estiloComboBox.Name = "estiloComboBox";
            this.estiloComboBox.Size = new System.Drawing.Size(284, 21);
            this.estiloComboBox.TabIndex = 33;
            // 
            // anioTextBox
            // 
            this.anioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.peliculasBindingSource, "anio", true));
            this.anioTextBox.Location = new System.Drawing.Point(431, 76);
            this.anioTextBox.Name = "anioTextBox";
            this.anioTextBox.Size = new System.Drawing.Size(65, 20);
            this.anioTextBox.TabIndex = 35;
            // 
            // caratulaTextBox
            // 
            this.caratulaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.peliculasBindingSource, "caratula", true));
            this.caratulaTextBox.Location = new System.Drawing.Point(599, 74);
            this.caratulaTextBox.Name = "caratulaTextBox";
            this.caratulaTextBox.Size = new System.Drawing.Size(180, 20);
            this.caratulaTextBox.TabIndex = 37;
            // 
            // categoriaComboBox
            // 
            this.categoriaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.peliculasBindingSource, "categoria", true));
            this.categoriaComboBox.FormattingEnabled = true;
            this.categoriaComboBox.Location = new System.Drawing.Point(176, 386);
            this.categoriaComboBox.Name = "categoriaComboBox";
            this.categoriaComboBox.Size = new System.Drawing.Size(284, 21);
            this.categoriaComboBox.TabIndex = 39;
            // 
            // stockNumericUpDown
            // 
            this.stockNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.peliculasBindingSource, "stock", true));
            this.stockNumericUpDown.Location = new System.Drawing.Point(535, 383);
            this.stockNumericUpDown.Name = "stockNumericUpDown";
            this.stockNumericUpDown.Size = new System.Drawing.Size(54, 20);
            this.stockNumericUpDown.TabIndex = 41;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SqlConexion.Properties.Resources.volver;
            this.pictureBox1.Location = new System.Drawing.Point(599, 104);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 245);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // peliculasTableAdapter
            // 
            this.peliculasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.alquileresTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.categoriasTableAdapter = null;
            this.tableAdapterManager.estilosTableAdapter = null;
            this.tableAdapterManager.peliculasTableAdapter = this.peliculasTableAdapter;
            this.tableAdapterManager.sociosTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SqlConexion.videoclubDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // peliculasBindingSource1
            // 
            this.peliculasBindingSource1.DataMember = "peliculas";
            this.peliculasBindingSource1.DataSource = this.videoclubDataSet;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BindingSource = this.peliculasBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.toolStripComboBox1,
            this.toolStripLabel1});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(836, 25);
            this.bindingNavigator1.TabIndex = 42;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 25);
            this.toolStripComboBox1.TextChanged += new System.EventHandler(this.ToolStripComboBox1_TextChanged);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(80, 22);
            this.toolStripLabel1.Text = "Mostrar todas";
            this.toolStripLabel1.Click += new System.EventHandler(this.ToolStripLabel1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 460);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(codpeliLabel);
            this.Controls.Add(this.codpeliLabel1);
            this.Controls.Add(tituloLabel);
            this.Controls.Add(this.tituloTextBox);
            this.Controls.Add(directorLabel);
            this.Controls.Add(this.directorTextBox);
            this.Controls.Add(protagonistaLabel);
            this.Controls.Add(this.protagonistaTextBox);
            this.Controls.Add(argumentoLabel);
            this.Controls.Add(this.argumentoTextBox);
            this.Controls.Add(estiloLabel);
            this.Controls.Add(this.estiloComboBox);
            this.Controls.Add(anioLabel);
            this.Controls.Add(this.anioTextBox);
            this.Controls.Add(caratulaLabel);
            this.Controls.Add(this.caratulaTextBox);
            this.Controls.Add(categoriaLabel);
            this.Controls.Add(this.categoriaComboBox);
            this.Controls.Add(stockLabel);
            this.Controls.Add(this.stockNumericUpDown);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.peliculasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoclubDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peliculasBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private videoclubDataSet videoclubDataSet;
        private System.Windows.Forms.BindingSource peliculasBindingSource;
        private videoclubDataSetTableAdapters.peliculasTableAdapter peliculasTableAdapter;
        private videoclubDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label codpeliLabel1;
        private System.Windows.Forms.TextBox tituloTextBox;
        private System.Windows.Forms.TextBox directorTextBox;
        private System.Windows.Forms.TextBox protagonistaTextBox;
        private System.Windows.Forms.TextBox argumentoTextBox;
        private System.Windows.Forms.ComboBox estiloComboBox;
        private System.Windows.Forms.TextBox anioTextBox;
        private System.Windows.Forms.TextBox caratulaTextBox;
        private System.Windows.Forms.ComboBox categoriaComboBox;
        private System.Windows.Forms.NumericUpDown stockNumericUpDown;
        private System.Windows.Forms.BindingSource peliculasBindingSource1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
    }
}

