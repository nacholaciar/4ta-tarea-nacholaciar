
namespace miapp_2
{
    partial class AltaPersona
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.mskNacimiento = new System.Windows.Forms.MaskedTextBox();
            this.lblNacimiento = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdOtro = new System.Windows.Forms.RadioButton();
            this.rdMasculino = new System.Windows.Forms.RadioButton();
            this.rdFemenino = new System.Windows.Forms.RadioButton();
            this.lblDocumento = new System.Windows.Forms.Label();
            this.cbTDocumento = new System.Windows.Forms.ComboBox();
            this.lbDNI = new System.Windows.Forms.Label();
            this.txtDNI = new System.Windows.Forms.MaskedTextBox();
            this.txtNroCasa = new System.Windows.Forms.TextBox();
            this.lblNroCasa = new System.Windows.Forms.Label();
            this.txtCalle = new System.Windows.Forms.TextBox();
            this.lblCalle = new System.Windows.Forms.Label();
            this.ckSoltero = new System.Windows.Forms.CheckBox();
            this.ckCasado = new System.Windows.Forms.CheckBox();
            this.ckHijo = new System.Windows.Forms.CheckBox();
            this.lblCantidadH = new System.Windows.Forms.Label();
            this.txtCantidadH = new System.Windows.Forms.MaskedTextBox();
            this.cbCarrera = new System.Windows.Forms.ComboBox();
            this.lblCarrera = new System.Windows.Forms.Label();
            this.btnGuardarPersona = new System.Windows.Forms.Button();
            this.btnLimpiarDatos = new System.Windows.Forms.Button();
            this.lblDAdicionales = new System.Windows.Forms.Label();
            this.dgPersona = new System.Windows.Forms.DataGridView();
            this.documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPersona)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(122, 35);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(69, 17);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(197, 32);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(183, 23);
            this.txtNombre.TabIndex = 1;
            // 
            // txtApellido
            // 
            this.txtApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.Location = new System.Drawing.Point(197, 71);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(183, 23);
            this.txtApellido.TabIndex = 3;
            this.txtApellido.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(120, 74);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(71, 17);
            this.lblApellido.TabIndex = 2;
            this.lblApellido.Text = "Apellido:";
            this.lblApellido.Click += new System.EventHandler(this.label1_Click);
            // 
            // mskNacimiento
            // 
            this.mskNacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskNacimiento.Location = new System.Drawing.Point(197, 106);
            this.mskNacimiento.Mask = "00/00/0000";
            this.mskNacimiento.Name = "mskNacimiento";
            this.mskNacimiento.Size = new System.Drawing.Size(100, 23);
            this.mskNacimiento.TabIndex = 4;
            this.mskNacimiento.ValidatingType = typeof(System.DateTime);
            this.mskNacimiento.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // lblNacimiento
            // 
            this.lblNacimiento.AutoSize = true;
            this.lblNacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNacimiento.Location = new System.Drawing.Point(98, 109);
            this.lblNacimiento.Name = "lblNacimiento";
            this.lblNacimiento.Size = new System.Drawing.Size(93, 17);
            this.lblNacimiento.TabIndex = 5;
            this.lblNacimiento.Text = "Nacimiento:";
            this.lblNacimiento.Click += new System.EventHandler(this.txtNacimiento_Click);
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexo.Location = new System.Drawing.Point(143, 178);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(48, 17);
            this.lblSexo.TabIndex = 6;
            this.lblSexo.Text = "Sexo:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.rdOtro);
            this.panel1.Controls.Add(this.rdMasculino);
            this.panel1.Controls.Add(this.rdFemenino);
            this.panel1.Location = new System.Drawing.Point(197, 147);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(206, 79);
            this.panel1.TabIndex = 7;
            // 
            // rdOtro
            // 
            this.rdOtro.AutoSize = true;
            this.rdOtro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdOtro.Location = new System.Drawing.Point(10, 42);
            this.rdOtro.Name = "rdOtro";
            this.rdOtro.Size = new System.Drawing.Size(54, 21);
            this.rdOtro.TabIndex = 10;
            this.rdOtro.TabStop = true;
            this.rdOtro.Text = "Otro";
            this.rdOtro.UseVisualStyleBackColor = true;
            this.rdOtro.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged_1);
            // 
            // rdMasculino
            // 
            this.rdMasculino.AutoSize = true;
            this.rdMasculino.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdMasculino.Location = new System.Drawing.Point(10, 15);
            this.rdMasculino.Name = "rdMasculino";
            this.rdMasculino.Size = new System.Drawing.Size(89, 21);
            this.rdMasculino.TabIndex = 8;
            this.rdMasculino.TabStop = true;
            this.rdMasculino.Text = "Masculino";
            this.rdMasculino.UseVisualStyleBackColor = true;
            this.rdMasculino.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rdFemenino
            // 
            this.rdFemenino.AutoSize = true;
            this.rdFemenino.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdFemenino.Location = new System.Drawing.Point(105, 15);
            this.rdFemenino.Name = "rdFemenino";
            this.rdFemenino.Size = new System.Drawing.Size(88, 21);
            this.rdFemenino.TabIndex = 9;
            this.rdFemenino.TabStop = true;
            this.rdFemenino.Text = "Femenino";
            this.rdFemenino.UseVisualStyleBackColor = true;
            // 
            // lblDocumento
            // 
            this.lblDocumento.AutoSize = true;
            this.lblDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocumento.Location = new System.Drawing.Point(39, 252);
            this.lblDocumento.Name = "lblDocumento";
            this.lblDocumento.Size = new System.Drawing.Size(152, 17);
            this.lblDocumento.TabIndex = 8;
            this.lblDocumento.Text = "Tipo de documento:";
            this.lblDocumento.Click += new System.EventHandler(this.lblDocumento_Click);
            // 
            // cbTDocumento
            // 
            this.cbTDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTDocumento.FormattingEnabled = true;
            this.cbTDocumento.Location = new System.Drawing.Point(197, 247);
            this.cbTDocumento.Name = "cbTDocumento";
            this.cbTDocumento.Size = new System.Drawing.Size(206, 24);
            this.cbTDocumento.TabIndex = 9;
            this.cbTDocumento.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lbDNI
            // 
            this.lbDNI.AutoSize = true;
            this.lbDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDNI.Location = new System.Drawing.Point(152, 289);
            this.lbDNI.Name = "lbDNI";
            this.lbDNI.Size = new System.Drawing.Size(39, 17);
            this.lbDNI.TabIndex = 10;
            this.lbDNI.Text = "DNI:";
            this.lbDNI.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // txtDNI
            // 
            this.txtDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDNI.Location = new System.Drawing.Point(197, 285);
            this.txtDNI.Mask = "999999999";
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(100, 23);
            this.txtDNI.TabIndex = 11;
            this.txtDNI.ValidatingType = typeof(int);
            // 
            // txtNroCasa
            // 
            this.txtNroCasa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNroCasa.Location = new System.Drawing.Point(197, 365);
            this.txtNroCasa.Name = "txtNroCasa";
            this.txtNroCasa.Size = new System.Drawing.Size(183, 23);
            this.txtNroCasa.TabIndex = 15;
            // 
            // lblNroCasa
            // 
            this.lblNroCasa.AutoSize = true;
            this.lblNroCasa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroCasa.Location = new System.Drawing.Point(85, 369);
            this.lblNroCasa.Name = "lblNroCasa";
            this.lblNroCasa.Size = new System.Drawing.Size(106, 17);
            this.lblNroCasa.TabIndex = 14;
            this.lblNroCasa.Text = "Nro. de casa:";
            // 
            // txtCalle
            // 
            this.txtCalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCalle.Location = new System.Drawing.Point(197, 326);
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(183, 23);
            this.txtCalle.TabIndex = 13;
            // 
            // lblCalle
            // 
            this.lblCalle.AutoSize = true;
            this.lblCalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalle.Location = new System.Drawing.Point(142, 330);
            this.lblCalle.Name = "lblCalle";
            this.lblCalle.Size = new System.Drawing.Size(49, 17);
            this.lblCalle.TabIndex = 12;
            this.lblCalle.Text = "Calle:";
            // 
            // ckSoltero
            // 
            this.ckSoltero.AutoSize = true;
            this.ckSoltero.Location = new System.Drawing.Point(197, 416);
            this.ckSoltero.Name = "ckSoltero";
            this.ckSoltero.Size = new System.Drawing.Size(59, 17);
            this.ckSoltero.TabIndex = 16;
            this.ckSoltero.Text = "Soltero";
            this.ckSoltero.UseVisualStyleBackColor = true;
            // 
            // ckCasado
            // 
            this.ckCasado.AutoSize = true;
            this.ckCasado.Location = new System.Drawing.Point(303, 416);
            this.ckCasado.Name = "ckCasado";
            this.ckCasado.Size = new System.Drawing.Size(62, 17);
            this.ckCasado.TabIndex = 17;
            this.ckCasado.Text = "Casado";
            this.ckCasado.UseVisualStyleBackColor = true;
            // 
            // ckHijo
            // 
            this.ckHijo.AutoSize = true;
            this.ckHijo.Location = new System.Drawing.Point(197, 449);
            this.ckHijo.Name = "ckHijo";
            this.ckHijo.Size = new System.Drawing.Size(54, 17);
            this.ckHijo.TabIndex = 18;
            this.ckHijo.Text = "Hijo/s";
            this.ckHijo.UseVisualStyleBackColor = true;
            this.ckHijo.CheckedChanged += new System.EventHandler(this.ckHijo_CheckedChanged);
            // 
            // lblCantidadH
            // 
            this.lblCantidadH.AutoSize = true;
            this.lblCantidadH.Location = new System.Drawing.Point(257, 450);
            this.lblCantidadH.Name = "lblCantidadH";
            this.lblCantidadH.Size = new System.Drawing.Size(49, 13);
            this.lblCantidadH.TabIndex = 19;
            this.lblCantidadH.Text = "Cantidad";
            this.lblCantidadH.Click += new System.EventHandler(this.lblCantidadH_Click);
            // 
            // txtCantidadH
            // 
            this.txtCantidadH.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidadH.Location = new System.Drawing.Point(309, 446);
            this.txtCantidadH.Mask = "99";
            this.txtCantidadH.Name = "txtCantidadH";
            this.txtCantidadH.Size = new System.Drawing.Size(41, 20);
            this.txtCantidadH.TabIndex = 20;
            this.txtCantidadH.ValidatingType = typeof(int);
            this.txtCantidadH.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox2_MaskInputRejected);
            // 
            // cbCarrera
            // 
            this.cbCarrera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCarrera.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCarrera.FormattingEnabled = true;
            this.cbCarrera.Location = new System.Drawing.Point(197, 484);
            this.cbCarrera.Name = "cbCarrera";
            this.cbCarrera.Size = new System.Drawing.Size(206, 24);
            this.cbCarrera.TabIndex = 22;
            // 
            // lblCarrera
            // 
            this.lblCarrera.AutoSize = true;
            this.lblCarrera.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarrera.Location = new System.Drawing.Point(123, 487);
            this.lblCarrera.Name = "lblCarrera";
            this.lblCarrera.Size = new System.Drawing.Size(68, 17);
            this.lblCarrera.TabIndex = 21;
            this.lblCarrera.Text = "Carrera:";
            // 
            // btnGuardarPersona
            // 
            this.btnGuardarPersona.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarPersona.Location = new System.Drawing.Point(449, 484);
            this.btnGuardarPersona.Name = "btnGuardarPersona";
            this.btnGuardarPersona.Size = new System.Drawing.Size(148, 36);
            this.btnGuardarPersona.TabIndex = 23;
            this.btnGuardarPersona.Text = "Guardar Persoma";
            this.btnGuardarPersona.UseVisualStyleBackColor = true;
            this.btnGuardarPersona.Click += new System.EventHandler(this.btnGuardarPersona_Click);
            // 
            // btnLimpiarDatos
            // 
            this.btnLimpiarDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarDatos.Location = new System.Drawing.Point(449, 435);
            this.btnLimpiarDatos.Name = "btnLimpiarDatos";
            this.btnLimpiarDatos.Size = new System.Drawing.Size(148, 36);
            this.btnLimpiarDatos.TabIndex = 24;
            this.btnLimpiarDatos.Text = "Limpiar Datos";
            this.btnLimpiarDatos.UseVisualStyleBackColor = true;
            this.btnLimpiarDatos.Click += new System.EventHandler(this.btnLimpiarDatos_Click);
            // 
            // lblDAdicionales
            // 
            this.lblDAdicionales.AutoSize = true;
            this.lblDAdicionales.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDAdicionales.Location = new System.Drawing.Point(49, 415);
            this.lblDAdicionales.Name = "lblDAdicionales";
            this.lblDAdicionales.Size = new System.Drawing.Size(142, 17);
            this.lblDAdicionales.TabIndex = 25;
            this.lblDAdicionales.Text = "Datos adicionales:";
            // 
            // dgPersona
            // 
            this.dgPersona.AllowUserToAddRows = false;
            this.dgPersona.AllowUserToDeleteRows = false;
            this.dgPersona.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPersona.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.documento,
            this.Nombre,
            this.Apellido});
            this.dgPersona.Location = new System.Drawing.Point(494, 32);
            this.dgPersona.Name = "dgPersona";
            this.dgPersona.ReadOnly = true;
            this.dgPersona.Size = new System.Drawing.Size(343, 367);
            this.dgPersona.TabIndex = 26;
            this.dgPersona.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPersona_CellContentClick);
            // 
            // documento
            // 
            this.documento.HeaderText = "Documento";
            this.documento.Name = "documento";
            this.documento.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            // 
            // AltaPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 548);
            this.Controls.Add(this.dgPersona);
            this.Controls.Add(this.lblDAdicionales);
            this.Controls.Add(this.btnLimpiarDatos);
            this.Controls.Add(this.btnGuardarPersona);
            this.Controls.Add(this.cbCarrera);
            this.Controls.Add(this.lblCarrera);
            this.Controls.Add(this.txtCantidadH);
            this.Controls.Add(this.lblCantidadH);
            this.Controls.Add(this.ckHijo);
            this.Controls.Add(this.ckCasado);
            this.Controls.Add(this.ckSoltero);
            this.Controls.Add(this.txtNroCasa);
            this.Controls.Add(this.lblNroCasa);
            this.Controls.Add(this.txtCalle);
            this.Controls.Add(this.lblCalle);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.lbDNI);
            this.Controls.Add(this.cbTDocumento);
            this.Controls.Add(this.lblDocumento);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.lblNacimiento);
            this.Controls.Add(this.mskNacimiento);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Name = "AltaPersona";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agendar Persona";
            this.Load += new System.EventHandler(this.AltaPersona_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPersona)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.MaskedTextBox mskNacimiento;
        private System.Windows.Forms.Label lblNacimiento;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdMasculino;
        private System.Windows.Forms.RadioButton rdFemenino;
        private System.Windows.Forms.RadioButton rdOtro;
        private System.Windows.Forms.Label lblDocumento;
        private System.Windows.Forms.ComboBox cbTDocumento;
        private System.Windows.Forms.Label lbDNI;
        private System.Windows.Forms.MaskedTextBox txtDNI;
        private System.Windows.Forms.TextBox txtNroCasa;
        private System.Windows.Forms.Label lblNroCasa;
        private System.Windows.Forms.TextBox txtCalle;
        private System.Windows.Forms.Label lblCalle;
        private System.Windows.Forms.CheckBox ckSoltero;
        private System.Windows.Forms.CheckBox ckCasado;
        private System.Windows.Forms.CheckBox ckHijo;
        private System.Windows.Forms.Label lblCantidadH;
        private System.Windows.Forms.MaskedTextBox txtCantidadH;
        private System.Windows.Forms.ComboBox cbCarrera;
        private System.Windows.Forms.Label lblCarrera;
        private System.Windows.Forms.Button btnGuardarPersona;
        private System.Windows.Forms.Button btnLimpiarDatos;
        private System.Windows.Forms.Label lblDAdicionales;
        private System.Windows.Forms.DataGridView dgPersona;
        private System.Windows.Forms.DataGridViewTextBoxColumn documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
    }
}