namespace ArreglodeListas
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCola0 = new System.Windows.Forms.Label();
            this.lblCola1 = new System.Windows.Forms.Label();
            this.lblCola2 = new System.Windows.Forms.Label();
            this.txtPrioridad = new System.Windows.Forms.TextBox();
            this.txtDato = new System.Windows.Forms.TextBox();
            this.aaa = new System.Windows.Forms.Label();
            this.lblalgo = new System.Windows.Forms.Label();
            this.btnDesencolar = new System.Windows.Forms.Button();
            this.btnEncolar = new System.Windows.Forms.Button();
            this.btnIncrementar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtArchivo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnCargar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Prioridad 0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prioridad 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Prioridad 2";
            // 
            // lblCola0
            // 
            this.lblCola0.AutoSize = true;
            this.lblCola0.Location = new System.Drawing.Point(87, 26);
            this.lblCola0.Name = "lblCola0";
            this.lblCola0.Size = new System.Drawing.Size(37, 13);
            this.lblCola0.TabIndex = 3;
            this.lblCola0.Text = "Cola 0";
            // 
            // lblCola1
            // 
            this.lblCola1.AutoSize = true;
            this.lblCola1.Location = new System.Drawing.Point(87, 55);
            this.lblCola1.Name = "lblCola1";
            this.lblCola1.Size = new System.Drawing.Size(37, 13);
            this.lblCola1.TabIndex = 4;
            this.lblCola1.Text = "Cola 1";
            // 
            // lblCola2
            // 
            this.lblCola2.AutoSize = true;
            this.lblCola2.Location = new System.Drawing.Point(87, 82);
            this.lblCola2.Name = "lblCola2";
            this.lblCola2.Size = new System.Drawing.Size(37, 13);
            this.lblCola2.TabIndex = 5;
            this.lblCola2.Text = "Cola 2";
            // 
            // txtPrioridad
            // 
            this.txtPrioridad.Location = new System.Drawing.Point(59, 169);
            this.txtPrioridad.Name = "txtPrioridad";
            this.txtPrioridad.Size = new System.Drawing.Size(41, 20);
            this.txtPrioridad.TabIndex = 6;
            // 
            // txtDato
            // 
            this.txtDato.Location = new System.Drawing.Point(59, 139);
            this.txtDato.Name = "txtDato";
            this.txtDato.Size = new System.Drawing.Size(41, 20);
            this.txtDato.TabIndex = 7;
            // 
            // aaa
            // 
            this.aaa.AutoSize = true;
            this.aaa.Location = new System.Drawing.Point(5, 169);
            this.aaa.Name = "aaa";
            this.aaa.Size = new System.Drawing.Size(48, 13);
            this.aaa.TabIndex = 8;
            this.aaa.Text = "Prioridad";
            // 
            // lblalgo
            // 
            this.lblalgo.AutoSize = true;
            this.lblalgo.Location = new System.Drawing.Point(5, 142);
            this.lblalgo.Name = "lblalgo";
            this.lblalgo.Size = new System.Drawing.Size(30, 13);
            this.lblalgo.TabIndex = 9;
            this.lblalgo.Text = "Dato";
            // 
            // btnDesencolar
            // 
            this.btnDesencolar.Location = new System.Drawing.Point(106, 193);
            this.btnDesencolar.Name = "btnDesencolar";
            this.btnDesencolar.Size = new System.Drawing.Size(75, 23);
            this.btnDesencolar.TabIndex = 13;
            this.btnDesencolar.Text = "Desencolar";
            this.btnDesencolar.UseVisualStyleBackColor = true;
            this.btnDesencolar.Click += new System.EventHandler(this.btnDesencolar_Click);
            // 
            // btnEncolar
            // 
            this.btnEncolar.Location = new System.Drawing.Point(106, 137);
            this.btnEncolar.Name = "btnEncolar";
            this.btnEncolar.Size = new System.Drawing.Size(75, 23);
            this.btnEncolar.TabIndex = 14;
            this.btnEncolar.Text = "Encolar";
            this.btnEncolar.UseVisualStyleBackColor = true;
            this.btnEncolar.Click += new System.EventHandler(this.btnEncolar_Click);
            // 
            // btnIncrementar
            // 
            this.btnIncrementar.Location = new System.Drawing.Point(187, 193);
            this.btnIncrementar.Name = "btnIncrementar";
            this.btnIncrementar.Size = new System.Drawing.Size(75, 23);
            this.btnIncrementar.TabIndex = 15;
            this.btnIncrementar.Text = "Incrementar";
            this.btnIncrementar.UseVisualStyleBackColor = true;
            this.btnIncrementar.Click += new System.EventHandler(this.btnIncrementar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.txtArchivo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnIncrementar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnEncolar);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnDesencolar);
            this.groupBox1.Controls.Add(this.lblCola0);
            this.groupBox1.Controls.Add(this.lblalgo);
            this.groupBox1.Controls.Add(this.lblCola1);
            this.groupBox1.Controls.Add(this.aaa);
            this.groupBox1.Controls.Add(this.lblCola2);
            this.groupBox1.Controls.Add(this.txtDato);
            this.groupBox1.Controls.Add(this.txtPrioridad);
            this.groupBox1.Location = new System.Drawing.Point(4, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(329, 289);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtArchivo
            // 
            this.txtArchivo.Location = new System.Drawing.Point(106, 246);
            this.txtArchivo.Name = "txtArchivo";
            this.txtArchivo.Size = new System.Drawing.Size(100, 20);
            this.txtArchivo.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(106, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Nombre del archivo";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(25, 243);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 19;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnNuevo);
            this.groupBox2.Controls.Add(this.btnCargar);
            this.groupBox2.Location = new System.Drawing.Point(10, 1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(323, 54);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(43, 19);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 21;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(163, 19);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(75, 23);
            this.btnCargar.TabIndex = 22;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 333);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Prioridad";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCola0;
        private System.Windows.Forms.Label lblCola1;
        private System.Windows.Forms.Label lblCola2;
        private System.Windows.Forms.TextBox txtPrioridad;
        private System.Windows.Forms.TextBox txtDato;
        private System.Windows.Forms.Label aaa;
        private System.Windows.Forms.Label lblalgo;
        private System.Windows.Forms.Button btnDesencolar;
        private System.Windows.Forms.Button btnEncolar;
        private System.Windows.Forms.Button btnIncrementar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtArchivo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnCargar;
    }
}

