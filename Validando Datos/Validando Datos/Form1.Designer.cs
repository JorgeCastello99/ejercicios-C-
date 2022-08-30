namespace Validando_Datos
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.maskedTextBoxNombre = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxApellidos = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxEmail = new System.Windows.Forms.MaskedTextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.archivar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.maskedTextBoxMovil = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxMatricula = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxNif = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxNCuenta = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(99, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(99, 106);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellidos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(99, 149);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "movil";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(99, 188);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "e-mail";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(99, 235);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Matricula Coche";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(99, 287);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Nº cuenta";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(528, 235);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "NIF";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(313, 341);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 28);
            this.button1.TabIndex = 7;
            this.button1.Text = "VALIDAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // maskedTextBoxNombre
            // 
            this.maskedTextBoxNombre.Location = new System.Drawing.Point(253, 57);
            this.maskedTextBoxNombre.Margin = new System.Windows.Forms.Padding(4);
            this.maskedTextBoxNombre.Name = "maskedTextBoxNombre";
            this.maskedTextBoxNombre.Size = new System.Drawing.Size(191, 22);
            this.maskedTextBoxNombre.TabIndex = 8;
            this.maskedTextBoxNombre.ValidatingType = typeof(int);
            this.maskedTextBoxNombre.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.MaskedTextBox1_MaskInputRejected);
            // 
            // maskedTextBoxApellidos
            // 
            this.maskedTextBoxApellidos.Location = new System.Drawing.Point(253, 100);
            this.maskedTextBoxApellidos.Margin = new System.Windows.Forms.Padding(4);
            this.maskedTextBoxApellidos.Name = "maskedTextBoxApellidos";
            this.maskedTextBoxApellidos.Size = new System.Drawing.Size(191, 22);
            this.maskedTextBoxApellidos.TabIndex = 9;
            // 
            // maskedTextBoxEmail
            // 
            this.maskedTextBoxEmail.Location = new System.Drawing.Point(253, 188);
            this.maskedTextBoxEmail.Margin = new System.Windows.Forms.Padding(4);
            this.maskedTextBoxEmail.Name = "maskedTextBoxEmail";
            this.maskedTextBoxEmail.Size = new System.Drawing.Size(191, 22);
            this.maskedTextBoxEmail.TabIndex = 11;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // archivar
            // 
            this.archivar.Enabled = false;
            this.archivar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.archivar.Location = new System.Drawing.Point(574, 341);
            this.archivar.Margin = new System.Windows.Forms.Padding(4);
            this.archivar.Name = "archivar";
            this.archivar.Size = new System.Drawing.Size(151, 28);
            this.archivar.TabIndex = 15;
            this.archivar.Text = "ARCHIVAR";
            this.archivar.UseVisualStyleBackColor = true;
            this.archivar.Click += new System.EventHandler(this.Archivar_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(438, 394);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(151, 28);
            this.button2.TabIndex = 16;
            this.button2.Text = "VER DATOS";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // maskedTextBoxMovil
            // 
            this.maskedTextBoxMovil.Location = new System.Drawing.Point(253, 147);
            this.maskedTextBoxMovil.Mask = "000-000-000";
            this.maskedTextBoxMovil.Name = "maskedTextBoxMovil";
            this.maskedTextBoxMovil.Size = new System.Drawing.Size(191, 22);
            this.maskedTextBoxMovil.TabIndex = 17;
            // 
            // maskedTextBoxMatricula
            // 
            this.maskedTextBoxMatricula.Location = new System.Drawing.Point(298, 233);
            this.maskedTextBoxMatricula.Mask = "0000-LLL";
            this.maskedTextBoxMatricula.Name = "maskedTextBoxMatricula";
            this.maskedTextBoxMatricula.Size = new System.Drawing.Size(146, 22);
            this.maskedTextBoxMatricula.TabIndex = 18;
            // 
            // maskedTextBoxNif
            // 
            this.maskedTextBoxNif.Location = new System.Drawing.Point(583, 235);
            this.maskedTextBoxNif.Mask = "00000000-L";
            this.maskedTextBoxNif.Name = "maskedTextBoxNif";
            this.maskedTextBoxNif.Size = new System.Drawing.Size(163, 22);
            this.maskedTextBoxNif.TabIndex = 19;
            // 
            // maskedTextBoxNCuenta
            // 
            this.maskedTextBoxNCuenta.Location = new System.Drawing.Point(273, 285);
            this.maskedTextBoxNCuenta.Mask = "ES00-000-0000-0000-0000";
            this.maskedTextBoxNCuenta.Name = "maskedTextBoxNCuenta";
            this.maskedTextBoxNCuenta.Size = new System.Drawing.Size(171, 22);
            this.maskedTextBoxNCuenta.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1113, 452);
            this.Controls.Add(this.maskedTextBoxNCuenta);
            this.Controls.Add(this.maskedTextBoxNif);
            this.Controls.Add(this.maskedTextBoxMatricula);
            this.Controls.Add(this.maskedTextBoxMovil);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.archivar);
            this.Controls.Add(this.maskedTextBoxEmail);
            this.Controls.Add(this.maskedTextBoxApellidos);
            this.Controls.Add(this.maskedTextBoxNombre);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxNombre;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxApellidos;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxEmail;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button archivar;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxNCuenta;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxNif;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxMatricula;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxMovil;
    }
}

