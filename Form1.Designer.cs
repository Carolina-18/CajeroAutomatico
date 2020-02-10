namespace cajero2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblcantidad = new System.Windows.Forms.Label();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.btnretirar = new System.Windows.Forms.Button();
            this.lblrespuesta = new System.Windows.Forms.Label();
            this.lblpagar = new System.Windows.Forms.Label();
            this.lblcambio = new System.Windows.Forms.Label();
            this.lblefectivo = new System.Windows.Forms.Label();
            this.txtpagar = new System.Windows.Forms.TextBox();
            this.txtefectivo = new System.Windows.Forms.TextBox();
            this.btnpagar = new System.Windows.Forms.Button();
            this.btnsecuencia = new System.Windows.Forms.Button();
            this.lstsecuencia = new System.Windows.Forms.ListBox();
            this.lblnumero = new System.Windows.Forms.Label();
            this.txtnumero = new System.Windows.Forms.TextBox();
            this.btnaceptar = new System.Windows.Forms.Button();
            this.lblnumres = new System.Windows.Forms.Label();
            this.btnnuevo1 = new System.Windows.Forms.Button();
            this.btnnuevo2 = new System.Windows.Forms.Button();
            this.btnnuevo3 = new System.Windows.Forms.Button();
            this.btnnuevo4 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtsecuencia = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblcantidad
            // 
            this.lblcantidad.AutoSize = true;
            this.lblcantidad.BackColor = System.Drawing.Color.Transparent;
            this.lblcantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcantidad.ForeColor = System.Drawing.Color.White;
            this.lblcantidad.Location = new System.Drawing.Point(54, 25);
            this.lblcantidad.Name = "lblcantidad";
            this.lblcantidad.Size = new System.Drawing.Size(68, 16);
            this.lblcantidad.TabIndex = 0;
            this.lblcantidad.Text = "cantidad";
            // 
            // txtcantidad
            // 
            this.txtcantidad.Location = new System.Drawing.Point(24, 51);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(133, 20);
            this.txtcantidad.TabIndex = 2;
            // 
            // btnretirar
            // 
            this.btnretirar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnretirar.Location = new System.Drawing.Point(21, 298);
            this.btnretirar.Name = "btnretirar";
            this.btnretirar.Size = new System.Drawing.Size(136, 51);
            this.btnretirar.TabIndex = 3;
            this.btnretirar.Text = "Retirar";
            this.btnretirar.UseVisualStyleBackColor = true;
            this.btnretirar.Click += new System.EventHandler(this.btnretirar_Click);
            // 
            // lblrespuesta
            // 
            this.lblrespuesta.AutoSize = true;
            this.lblrespuesta.BackColor = System.Drawing.Color.Transparent;
            this.lblrespuesta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrespuesta.ForeColor = System.Drawing.Color.White;
            this.lblrespuesta.Location = new System.Drawing.Point(6, 93);
            this.lblrespuesta.Name = "lblrespuesta";
            this.lblrespuesta.Size = new System.Drawing.Size(93, 16);
            this.lblrespuesta.TabIndex = 1;
            this.lblrespuesta.Text = "respuesta: ?\r\n";
            // 
            // lblpagar
            // 
            this.lblpagar.AutoSize = true;
            this.lblpagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpagar.ForeColor = System.Drawing.SystemColors.Control;
            this.lblpagar.Location = new System.Drawing.Point(6, 25);
            this.lblpagar.Name = "lblpagar";
            this.lblpagar.Size = new System.Drawing.Size(79, 13);
            this.lblpagar.TabIndex = 4;
            this.lblpagar.Text = "total a pagar";
            // 
            // lblcambio
            // 
            this.lblcambio.AutoSize = true;
            this.lblcambio.BackColor = System.Drawing.Color.Transparent;
            this.lblcambio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcambio.ForeColor = System.Drawing.SystemColors.Control;
            this.lblcambio.Location = new System.Drawing.Point(24, 132);
            this.lblcambio.Name = "lblcambio";
            this.lblcambio.Size = new System.Drawing.Size(65, 32);
            this.lblcambio.TabIndex = 5;
            this.lblcambio.Text = "Cambio:\r\n ?";
            // 
            // lblefectivo
            // 
            this.lblefectivo.AutoSize = true;
            this.lblefectivo.BackColor = System.Drawing.Color.Transparent;
            this.lblefectivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblefectivo.ForeColor = System.Drawing.SystemColors.Control;
            this.lblefectivo.Location = new System.Drawing.Point(12, 78);
            this.lblefectivo.Name = "lblefectivo";
            this.lblefectivo.Size = new System.Drawing.Size(56, 15);
            this.lblefectivo.TabIndex = 6;
            this.lblefectivo.Text = "efectivo";
            // 
            // txtpagar
            // 
            this.txtpagar.Location = new System.Drawing.Point(85, 22);
            this.txtpagar.Name = "txtpagar";
            this.txtpagar.Size = new System.Drawing.Size(100, 20);
            this.txtpagar.TabIndex = 7;
            // 
            // txtefectivo
            // 
            this.txtefectivo.Location = new System.Drawing.Point(284, 123);
            this.txtefectivo.Name = "txtefectivo";
            this.txtefectivo.Size = new System.Drawing.Size(100, 20);
            this.txtefectivo.TabIndex = 8;
            // 
            // btnpagar
            // 
            this.btnpagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpagar.Location = new System.Drawing.Point(27, 298);
            this.btnpagar.Name = "btnpagar";
            this.btnpagar.Size = new System.Drawing.Size(136, 51);
            this.btnpagar.TabIndex = 9;
            this.btnpagar.Text = "Pagar";
            this.btnpagar.UseVisualStyleBackColor = true;
            this.btnpagar.Click += new System.EventHandler(this.btnpagar_Click);
            // 
            // btnsecuencia
            // 
            this.btnsecuencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsecuencia.Location = new System.Drawing.Point(26, 298);
            this.btnsecuencia.Name = "btnsecuencia";
            this.btnsecuencia.Size = new System.Drawing.Size(136, 51);
            this.btnsecuencia.TabIndex = 10;
            this.btnsecuencia.Text = "Secuencia \r\nFibonacci";
            this.btnsecuencia.UseVisualStyleBackColor = true;
            this.btnsecuencia.Click += new System.EventHandler(this.btnsecuencia_Click);
            // 
            // lstsecuencia
            // 
            this.lstsecuencia.FormattingEnabled = true;
            this.lstsecuencia.Location = new System.Drawing.Point(26, 58);
            this.lstsecuencia.Name = "lstsecuencia";
            this.lstsecuencia.Size = new System.Drawing.Size(136, 225);
            this.lstsecuencia.TabIndex = 11;
            // 
            // lblnumero
            // 
            this.lblnumero.AutoSize = true;
            this.lblnumero.BackColor = System.Drawing.Color.Transparent;
            this.lblnumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnumero.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblnumero.Location = new System.Drawing.Point(601, 67);
            this.lblnumero.Name = "lblnumero";
            this.lblnumero.Size = new System.Drawing.Size(139, 16);
            this.lblnumero.TabIndex = 14;
            this.lblnumero.Text = "Ingrese un numero:";
            // 
            // txtnumero
            // 
            this.txtnumero.Location = new System.Drawing.Point(620, 103);
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.Size = new System.Drawing.Size(108, 20);
            this.txtnumero.TabIndex = 15;
            this.txtnumero.TextChanged += new System.EventHandler(this.txtnumero_TextChanged);
            // 
            // btnaceptar
            // 
            this.btnaceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaceptar.Location = new System.Drawing.Point(16, 298);
            this.btnaceptar.Name = "btnaceptar";
            this.btnaceptar.Size = new System.Drawing.Size(136, 51);
            this.btnaceptar.TabIndex = 16;
            this.btnaceptar.Text = "Aceptar";
            this.btnaceptar.UseVisualStyleBackColor = true;
            this.btnaceptar.Click += new System.EventHandler(this.btnaceptar_Click);
            // 
            // lblnumres
            // 
            this.lblnumres.AutoSize = true;
            this.lblnumres.BackColor = System.Drawing.Color.Transparent;
            this.lblnumres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnumres.ForeColor = System.Drawing.Color.White;
            this.lblnumres.Location = new System.Drawing.Point(638, 152);
            this.lblnumres.Name = "lblnumres";
            this.lblnumres.Size = new System.Drawing.Size(0, 16);
            this.lblnumres.TabIndex = 17;
            // 
            // btnnuevo1
            // 
            this.btnnuevo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnuevo1.Location = new System.Drawing.Point(21, 365);
            this.btnnuevo1.Name = "btnnuevo1";
            this.btnnuevo1.Size = new System.Drawing.Size(136, 35);
            this.btnnuevo1.TabIndex = 18;
            this.btnnuevo1.Text = "Nuevo";
            this.btnnuevo1.UseVisualStyleBackColor = true;
            this.btnnuevo1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnnuevo2
            // 
            this.btnnuevo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnuevo2.Location = new System.Drawing.Point(27, 365);
            this.btnnuevo2.Name = "btnnuevo2";
            this.btnnuevo2.Size = new System.Drawing.Size(136, 35);
            this.btnnuevo2.TabIndex = 19;
            this.btnnuevo2.Text = "Nuevo";
            this.btnnuevo2.UseVisualStyleBackColor = true;
            this.btnnuevo2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnnuevo3
            // 
            this.btnnuevo3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnuevo3.Location = new System.Drawing.Point(26, 365);
            this.btnnuevo3.Name = "btnnuevo3";
            this.btnnuevo3.Size = new System.Drawing.Size(136, 35);
            this.btnnuevo3.TabIndex = 20;
            this.btnnuevo3.Text = "Nuevo";
            this.btnnuevo3.UseVisualStyleBackColor = true;
            this.btnnuevo3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnnuevo4
            // 
            this.btnnuevo4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnuevo4.Location = new System.Drawing.Point(16, 365);
            this.btnnuevo4.Name = "btnnuevo4";
            this.btnnuevo4.Size = new System.Drawing.Size(136, 35);
            this.btnnuevo4.TabIndex = 21;
            this.btnnuevo4.Text = "Nuevo";
            this.btnnuevo4.UseVisualStyleBackColor = true;
            this.btnnuevo4.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lblrespuesta);
            this.groupBox1.Controls.Add(this.txtcantidad);
            this.groupBox1.Controls.Add(this.lblcantidad);
            this.groupBox1.Controls.Add(this.btnretirar);
            this.groupBox1.Controls.Add(this.btnnuevo1);
            this.groupBox1.Location = new System.Drawing.Point(11, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(182, 411);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.lblpagar);
            this.groupBox2.Controls.Add(this.lblefectivo);
            this.groupBox2.Controls.Add(this.btnpagar);
            this.groupBox2.Controls.Add(this.txtpagar);
            this.groupBox2.Controls.Add(this.lblcambio);
            this.groupBox2.Controls.Add(this.btnnuevo2);
            this.groupBox2.Location = new System.Drawing.Point(199, 45);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(191, 411);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.txtsecuencia);
            this.groupBox3.Controls.Add(this.lstsecuencia);
            this.groupBox3.Controls.Add(this.btnsecuencia);
            this.groupBox3.Controls.Add(this.btnnuevo3);
            this.groupBox3.Location = new System.Drawing.Point(396, 45);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(186, 411);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            // 
            // txtsecuencia
            // 
            this.txtsecuencia.Location = new System.Drawing.Point(26, 25);
            this.txtsecuencia.Name = "txtsecuencia";
            this.txtsecuencia.Size = new System.Drawing.Size(136, 20);
            this.txtsecuencia.TabIndex = 21;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.btnaceptar);
            this.groupBox4.Controls.Add(this.btnnuevo4);
            this.groupBox4.Location = new System.Drawing.Point(588, 45);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(172, 411);
            this.groupBox4.TabIndex = 25;
            this.groupBox4.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(59, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 18);
            this.label1.TabIndex = 26;
            this.label1.Text = "CAJERO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(256, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 18);
            this.label2.TabIndex = 27;
            this.label2.Text = "COMPRA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(437, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 18);
            this.label3.TabIndex = 28;
            this.label3.Text = "SECUENCIA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(597, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 34);
            this.label4.TabIndex = 29;
            this.label4.Text = "NUMEROS PRIMOS\r\n    /NO PRIMOS";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(774, 470);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblnumero);
            this.Controls.Add(this.txtnumero);
            this.Controls.Add(this.lblnumres);
            this.Controls.Add(this.txtefectivo);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblcantidad;
        private System.Windows.Forms.TextBox txtcantidad;
        private System.Windows.Forms.Button btnretirar;
        private System.Windows.Forms.Label lblrespuesta;
        private System.Windows.Forms.Label lblpagar;
        private System.Windows.Forms.Label lblcambio;
        private System.Windows.Forms.Label lblefectivo;
        private System.Windows.Forms.TextBox txtpagar;
        private System.Windows.Forms.TextBox txtefectivo;
        private System.Windows.Forms.Button btnpagar;
        private System.Windows.Forms.Button btnsecuencia;
        private System.Windows.Forms.ListBox lstsecuencia;
        private System.Windows.Forms.Label lblnumero;
        private System.Windows.Forms.TextBox txtnumero;
        private System.Windows.Forms.Button btnaceptar;
        private System.Windows.Forms.Label lblnumres;
        private System.Windows.Forms.Button btnnuevo1;
        private System.Windows.Forms.Button btnnuevo2;
        private System.Windows.Forms.Button btnnuevo3;
        private System.Windows.Forms.Button btnnuevo4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtsecuencia;
    }
}

