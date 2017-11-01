/*
 * ${res:XML.StandardHeader.CreatedBy} luisg
 * User: luisg
 * Date: 22/10/2017
 * Time: 07:48 p. m.
 * 
 * 
 */
namespace SistemaPrestamos
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnGuardarAgregar;
		private System.Windows.Forms.Panel codigoQR;
		private System.Windows.Forms.TextBox txtFormato;
		private System.Windows.Forms.TextBox txtSeccion;
		private System.Windows.Forms.TextBox txtPais;
		private System.Windows.Forms.TextBox txtAutor;
		private System.Windows.Forms.TextBox txtEtiquetas;
		private System.Windows.Forms.TextBox txtAnoPublicacion;
		private System.Windows.Forms.TextBox txtEditorial;
		private System.Windows.Forms.TextBox txtTitulo;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.Label label23;
		private System.Windows.Forms.Label label24;
		private System.Windows.Forms.Label label25;
		private System.Windows.Forms.Label label26;
		private System.Windows.Forms.Label label27;
		private System.Windows.Forms.Label label30;
		private System.Windows.Forms.Button btnAgregarPrestamo;
		private System.Windows.Forms.DateTimePicker txtFechaLimite;
		private System.Windows.Forms.DateTimePicker txtFechaEntrega;
		private System.Windows.Forms.ComboBox txtEspecialidad;
		private System.Windows.Forms.NumericUpDown txtSemestre;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.TextBox txtApellidosAlumno;
		private System.Windows.Forms.TextBox txtCodigoControlPrestamo;
		private System.Windows.Forms.TextBox txtNombreAlumno;
		private System.Windows.Forms.TextBox txtNumeroPaginas;
		private System.Windows.Forms.TextBox txtCodigoControl;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn id;
		private System.Windows.Forms.DataGridViewTextBoxColumn nombreAlumno;
		private System.Windows.Forms.DataGridViewTextBoxColumn apellidosAlumno;
		private System.Windows.Forms.DataGridViewTextBoxColumn especialidad;
		private System.Windows.Forms.DataGridViewTextBoxColumn Semestre;
		private System.Windows.Forms.DataGridViewTextBoxColumn fechaEntrega;
		private System.Windows.Forms.DataGridViewTextBoxColumn fechaLimite;
		private System.Windows.Forms.DataGridViewTextBoxColumn condigoControl;
		private System.Windows.Forms.DataGridViewButtonColumn btnBorrarPrestamo;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.TabPage tabPage4;
		private System.Windows.Forms.DataGridView listaLibros;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
		private System.Windows.Forms.DataGridViewTextBoxColumn formato;
		private System.Windows.Forms.DataGridViewTextBoxColumn noPaginas;
		private System.Windows.Forms.DataGridViewImageColumn Column1;
		private System.Windows.Forms.TabPage tabPage5;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// 
		void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.btnAgregarPrestamo = new System.Windows.Forms.Button();
			this.txtFechaLimite = new System.Windows.Forms.DateTimePicker();
			this.txtFechaEntrega = new System.Windows.Forms.DateTimePicker();
			this.txtEspecialidad = new System.Windows.Forms.ComboBox();
			this.txtSemestre = new System.Windows.Forms.NumericUpDown();
			this.panel4 = new System.Windows.Forms.Panel();
			this.panel5 = new System.Windows.Forms.Panel();
			this.txtApellidosAlumno = new System.Windows.Forms.TextBox();
			this.txtCodigoControlPrestamo = new System.Windows.Forms.TextBox();
			this.txtNombreAlumno = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.txtNumeroPaginas = new System.Windows.Forms.TextBox();
			this.txtCodigoControl = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.btnGuardarAgregar = new System.Windows.Forms.Button();
			this.codigoQR = new System.Windows.Forms.Panel();
			this.txtFormato = new System.Windows.Forms.TextBox();
			this.txtSeccion = new System.Windows.Forms.TextBox();
			this.txtPais = new System.Windows.Forms.TextBox();
			this.txtAutor = new System.Windows.Forms.TextBox();
			this.txtEtiquetas = new System.Windows.Forms.TextBox();
			this.txtAnoPublicacion = new System.Windows.Forms.TextBox();
			this.txtEditorial = new System.Windows.Forms.TextBox();
			this.txtTitulo = new System.Windows.Forms.TextBox();
			this.label21 = new System.Windows.Forms.Label();
			this.label22 = new System.Windows.Forms.Label();
			this.label23 = new System.Windows.Forms.Label();
			this.label24 = new System.Windows.Forms.Label();
			this.label25 = new System.Windows.Forms.Label();
			this.label26 = new System.Windows.Forms.Label();
			this.label27 = new System.Windows.Forms.Label();
			this.label30 = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nombreAlumno = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.apellidosAlumno = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.especialidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Semestre = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.fechaEntrega = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.fechaLimite = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.condigoControl = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnBorrarPrestamo = new System.Windows.Forms.DataGridViewButtonColumn();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.tabPage4 = new System.Windows.Forms.TabPage();
			this.listaLibros = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.formato = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.noPaginas = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column1 = new System.Windows.Forms.DataGridViewImageColumn();
			this.tabPage5 = new System.Windows.Forms.TabPage();
			((System.ComponentModel.ISupportInitialize)(this.txtSemestre)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.tabControl1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage3.SuspendLayout();
			this.tabPage4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.listaLibros)).BeginInit();
			this.SuspendLayout();
			// 
			// btnAgregarPrestamo
			// 
			this.btnAgregarPrestamo.Enabled = false;
			this.btnAgregarPrestamo.Location = new System.Drawing.Point(1101, 437);
			this.btnAgregarPrestamo.Name = "btnAgregarPrestamo";
			this.btnAgregarPrestamo.Size = new System.Drawing.Size(340, 67);
			this.btnAgregarPrestamo.TabIndex = 78;
			this.btnAgregarPrestamo.Text = "Agregar prestamo";
			this.btnAgregarPrestamo.UseVisualStyleBackColor = true;
			this.btnAgregarPrestamo.Click += new System.EventHandler(this.BtnAgregarPrestamoClick);
			// 
			// txtFechaLimite
			// 
			this.txtFechaLimite.Location = new System.Drawing.Point(523, 283);
			this.txtFechaLimite.Name = "txtFechaLimite";
			this.txtFechaLimite.Size = new System.Drawing.Size(426, 35);
			this.txtFechaLimite.TabIndex = 76;
			// 
			// txtFechaEntrega
			// 
			this.txtFechaEntrega.Location = new System.Drawing.Point(12, 283);
			this.txtFechaEntrega.Name = "txtFechaEntrega";
			this.txtFechaEntrega.Size = new System.Drawing.Size(488, 35);
			this.txtFechaEntrega.TabIndex = 75;
			// 
			// txtEspecialidad
			// 
			this.txtEspecialidad.FormattingEnabled = true;
			this.txtEspecialidad.Items.AddRange(new object[] {
			"Construcción",
			"Contabilidad",
			"Programación",
			"Secretariado Ejecutivo",
			"Soporte y Mantenimiento de Equipos de Computo"});
			this.txtEspecialidad.Location = new System.Drawing.Point(523, 161);
			this.txtEspecialidad.Name = "txtEspecialidad";
			this.txtEspecialidad.Size = new System.Drawing.Size(426, 37);
			this.txtEspecialidad.TabIndex = 74;
			this.txtEspecialidad.SelectedIndexChanged += new System.EventHandler(this.txtsPrestamo);
			// 
			// txtSemestre
			// 
			this.txtSemestre.Location = new System.Drawing.Point(12, 162);
			this.txtSemestre.Maximum = new decimal(new int[] {
			6,
			0,
			0,
			0});
			this.txtSemestre.Minimum = new decimal(new int[] {
			1,
			0,
			0,
			0});
			this.txtSemestre.Name = "txtSemestre";
			this.txtSemestre.ReadOnly = true;
			this.txtSemestre.Size = new System.Drawing.Size(212, 35);
			this.txtSemestre.TabIndex = 73;
			this.txtSemestre.Value = new decimal(new int[] {
			1,
			0,
			0,
			0});
			// 
			// panel4
			// 
			this.panel4.Location = new System.Drawing.Point(1063, 29);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(402, 402);
			this.panel4.TabIndex = 79;
			// 
			// panel5
			// 
			this.panel5.BackColor = System.Drawing.Color.Gray;
			this.panel5.Location = new System.Drawing.Point(7, 337);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(943, 10);
			this.panel5.TabIndex = 77;
			// 
			// txtApellidosAlumno
			// 
			this.txtApellidosAlumno.Location = new System.Drawing.Point(523, 39);
			this.txtApellidosAlumno.Name = "txtApellidosAlumno";
			this.txtApellidosAlumno.Size = new System.Drawing.Size(426, 35);
			this.txtApellidosAlumno.TabIndex = 70;
			this.txtApellidosAlumno.TextChanged += new System.EventHandler(this.txtsPrestamo);
			// 
			// txtCodigoControlPrestamo
			// 
			this.txtCodigoControlPrestamo.Location = new System.Drawing.Point(12, 431);
			this.txtCodigoControlPrestamo.Name = "txtCodigoControlPrestamo";
			this.txtCodigoControlPrestamo.Size = new System.Drawing.Size(488, 35);
			this.txtCodigoControlPrestamo.TabIndex = 68;
			this.txtCodigoControlPrestamo.TextChanged += new System.EventHandler(this.txtsPrestamo);
			// 
			// txtNombreAlumno
			// 
			this.txtNombreAlumno.Location = new System.Drawing.Point(12, 38);
			this.txtNombreAlumno.Name = "txtNombreAlumno";
			this.txtNombreAlumno.Size = new System.Drawing.Size(488, 35);
			this.txtNombreAlumno.TabIndex = 67;
			this.txtNombreAlumno.TextChanged += new System.EventHandler(this.txtsPrestamo);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 387);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(314, 29);
			this.label4.TabIndex = 63;
			this.label4.Text = "Codigo de control del libro:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(523, 239);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(158, 29);
			this.label5.TabIndex = 62;
			this.label5.Text = "Fecha limite:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(12, 239);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(217, 29);
			this.label6.TabIndex = 61;
			this.label6.Text = "Fecha de entrega:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(523, 126);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(165, 29);
			this.label7.TabIndex = 60;
			this.label7.Text = "Especialidad:";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(7, 126);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(129, 29);
			this.label8.TabIndex = 59;
			this.label8.Text = "Semestre:";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(523, 6);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(124, 29);
			this.label9.TabIndex = 58;
			this.label9.Text = "Apellidos:";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(6, 6);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(271, 29);
			this.label10.TabIndex = 57;
			this.label10.Text = "Nombre(s) del alumno:";
			// 
			// txtNumeroPaginas
			// 
			this.txtNumeroPaginas.Location = new System.Drawing.Point(501, 482);
			this.txtNumeroPaginas.Name = "txtNumeroPaginas";
			this.txtNumeroPaginas.Size = new System.Drawing.Size(488, 35);
			this.txtNumeroPaginas.TabIndex = 69;
			this.txtNumeroPaginas.TextChanged += new System.EventHandler(this.HabilitarBotonLibro);
			this.txtNumeroPaginas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtAnoPublicacionKeyPress);
			// 
			// txtCodigoControl
			// 
			this.txtCodigoControl.Location = new System.Drawing.Point(3, 482);
			this.txtCodigoControl.Name = "txtCodigoControl";
			this.txtCodigoControl.Size = new System.Drawing.Size(436, 35);
			this.txtCodigoControl.TabIndex = 68;
			this.txtCodigoControl.TextChanged += new System.EventHandler(this.HabilitarBotonLibro);
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(501, 450);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(241, 29);
			this.label11.TabIndex = 67;
			this.label11.Text = "Numero de paginas:";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(3, 450);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(218, 29);
			this.label12.TabIndex = 66;
			this.label12.Text = "Código de contról:";
			// 
			// btnGuardarAgregar
			// 
			this.btnGuardarAgregar.AutoSize = true;
			this.btnGuardarAgregar.Enabled = false;
			this.btnGuardarAgregar.Location = new System.Drawing.Point(1057, 460);
			this.btnGuardarAgregar.Name = "btnGuardarAgregar";
			this.btnGuardarAgregar.Size = new System.Drawing.Size(402, 57);
			this.btnGuardarAgregar.TabIndex = 64;
			this.btnGuardarAgregar.Text = "Agregar y generar QR";
			this.btnGuardarAgregar.UseVisualStyleBackColor = true;
			this.btnGuardarAgregar.Click += new System.EventHandler(this.btnGenerarAgregarLibro);
			// 
			// codigoQR
			// 
			this.codigoQR.Location = new System.Drawing.Point(1057, 52);
			this.codigoQR.Name = "codigoQR";
			this.codigoQR.Size = new System.Drawing.Size(402, 402);
			this.codigoQR.TabIndex = 65;
			// 
			// txtFormato
			// 
			this.txtFormato.Location = new System.Drawing.Point(501, 385);
			this.txtFormato.Name = "txtFormato";
			this.txtFormato.Size = new System.Drawing.Size(488, 35);
			this.txtFormato.TabIndex = 63;
			this.txtFormato.TextChanged += new System.EventHandler(this.HabilitarBotonLibro);
			// 
			// txtSeccion
			// 
			this.txtSeccion.Location = new System.Drawing.Point(501, 285);
			this.txtSeccion.Name = "txtSeccion";
			this.txtSeccion.Size = new System.Drawing.Size(488, 35);
			this.txtSeccion.TabIndex = 62;
			this.txtSeccion.TextChanged += new System.EventHandler(this.HabilitarBotonLibro);
			// 
			// txtPais
			// 
			this.txtPais.Location = new System.Drawing.Point(501, 192);
			this.txtPais.Name = "txtPais";
			this.txtPais.Size = new System.Drawing.Size(488, 35);
			this.txtPais.TabIndex = 61;
			this.txtPais.TextChanged += new System.EventHandler(this.HabilitarBotonLibro);
			// 
			// txtAutor
			// 
			this.txtAutor.Location = new System.Drawing.Point(501, 84);
			this.txtAutor.Name = "txtAutor";
			this.txtAutor.Size = new System.Drawing.Size(488, 35);
			this.txtAutor.TabIndex = 60;
			this.txtAutor.TextChanged += new System.EventHandler(this.HabilitarBotonLibro);
			// 
			// txtEtiquetas
			// 
			this.txtEtiquetas.Location = new System.Drawing.Point(6, 385);
			this.txtEtiquetas.Name = "txtEtiquetas";
			this.txtEtiquetas.Size = new System.Drawing.Size(433, 35);
			this.txtEtiquetas.TabIndex = 59;
			this.txtEtiquetas.TextChanged += new System.EventHandler(this.HabilitarBotonLibro);
			// 
			// txtAnoPublicacion
			// 
			this.txtAnoPublicacion.Location = new System.Drawing.Point(3, 285);
			this.txtAnoPublicacion.MaxLength = 4;
			this.txtAnoPublicacion.Name = "txtAnoPublicacion";
			this.txtAnoPublicacion.Size = new System.Drawing.Size(436, 35);
			this.txtAnoPublicacion.TabIndex = 58;
			this.txtAnoPublicacion.TextChanged += new System.EventHandler(this.HabilitarBotonLibro);
			this.txtAnoPublicacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtAnoPublicacionKeyPress);
			// 
			// txtEditorial
			// 
			this.txtEditorial.Location = new System.Drawing.Point(3, 192);
			this.txtEditorial.Name = "txtEditorial";
			this.txtEditorial.Size = new System.Drawing.Size(436, 35);
			this.txtEditorial.TabIndex = 57;
			this.txtEditorial.TextChanged += new System.EventHandler(this.HabilitarBotonLibro);
			// 
			// txtTitulo
			// 
			this.txtTitulo.Location = new System.Drawing.Point(3, 84);
			this.txtTitulo.Name = "txtTitulo";
			this.txtTitulo.Size = new System.Drawing.Size(436, 35);
			this.txtTitulo.TabIndex = 56;
			this.txtTitulo.TextChanged += new System.EventHandler(this.HabilitarBotonLibro);
			// 
			// label21
			// 
			this.label21.AutoSize = true;
			this.label21.Location = new System.Drawing.Point(501, 353);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(114, 29);
			this.label21.TabIndex = 55;
			this.label21.Text = "Formato:";
			// 
			// label22
			// 
			this.label22.AutoSize = true;
			this.label22.Location = new System.Drawing.Point(7, 353);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(126, 29);
			this.label22.TabIndex = 54;
			this.label22.Text = "Etiquetas:";
			// 
			// label23
			// 
			this.label23.AutoSize = true;
			this.label23.Location = new System.Drawing.Point(501, 253);
			this.label23.Name = "label23";
			this.label23.Size = new System.Drawing.Size(111, 29);
			this.label23.TabIndex = 53;
			this.label23.Text = "Sección:";
			// 
			// label24
			// 
			this.label24.AutoSize = true;
			this.label24.Location = new System.Drawing.Point(7, 253);
			this.label24.Name = "label24";
			this.label24.Size = new System.Drawing.Size(235, 29);
			this.label24.TabIndex = 52;
			this.label24.Text = "Año de publicación:";
			// 
			// label25
			// 
			this.label25.AutoSize = true;
			this.label25.Location = new System.Drawing.Point(501, 160);
			this.label25.Name = "label25";
			this.label25.Size = new System.Drawing.Size(70, 29);
			this.label25.TabIndex = 51;
			this.label25.Text = "País:";
			// 
			// label26
			// 
			this.label26.AutoSize = true;
			this.label26.Location = new System.Drawing.Point(7, 160);
			this.label26.Name = "label26";
			this.label26.Size = new System.Drawing.Size(112, 29);
			this.label26.TabIndex = 50;
			this.label26.Text = "Editorial:";
			// 
			// label27
			// 
			this.label27.AutoSize = true;
			this.label27.Location = new System.Drawing.Point(501, 52);
			this.label27.Name = "label27";
			this.label27.Size = new System.Drawing.Size(80, 29);
			this.label27.TabIndex = 49;
			this.label27.Text = "Autor:";
			// 
			// label30
			// 
			this.label30.AutoSize = true;
			this.label30.Location = new System.Drawing.Point(7, 52);
			this.label30.Name = "label30";
			this.label30.Size = new System.Drawing.Size(82, 29);
			this.label30.TabIndex = 32;
			this.label30.Text = "Titulo:";
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AllowUserToOrderColumns = true;
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
			this.dataGridView1.ColumnHeadersHeight = 100;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.id,
			this.nombreAlumno,
			this.apellidosAlumno,
			this.especialidad,
			this.Semestre,
			this.fechaEntrega,
			this.fechaLimite,
			this.condigoControl,
			this.btnBorrarPrestamo});
			this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption;
			this.dataGridView1.Location = new System.Drawing.Point(0, 0);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowTemplate.Height = 25;
			this.dataGridView1.Size = new System.Drawing.Size(1684, 625);
			this.dataGridView1.TabIndex = 0;
			// 
			// id
			// 
			this.id.HeaderText = "ID del prestamo";
			this.id.MinimumWidth = 100;
			this.id.Name = "id";
			// 
			// nombreAlumno
			// 
			this.nombreAlumno.HeaderText = "Nombre del alumno";
			this.nombreAlumno.Name = "nombreAlumno";
			// 
			// apellidosAlumno
			// 
			this.apellidosAlumno.HeaderText = "Apellidos del alumno";
			this.apellidosAlumno.Name = "apellidosAlumno";
			// 
			// especialidad
			// 
			this.especialidad.HeaderText = "Especialidad";
			this.especialidad.Name = "especialidad";
			// 
			// Semestre
			// 
			this.Semestre.HeaderText = "Semestre";
			this.Semestre.Name = "Semestre";
			// 
			// fechaEntrega
			// 
			this.fechaEntrega.HeaderText = "Fecha de entrega";
			this.fechaEntrega.Name = "fechaEntrega";
			// 
			// fechaLimite
			// 
			this.fechaLimite.HeaderText = "Fecha limite";
			this.fechaLimite.Name = "fechaLimite";
			// 
			// condigoControl
			// 
			this.condigoControl.HeaderText = "Codigo de contról ";
			this.condigoControl.Name = "condigoControl";
			// 
			// btnBorrarPrestamo
			// 
			this.btnBorrarPrestamo.HeaderText = "Eliminar";
			this.btnBorrarPrestamo.Name = "btnBorrarPrestamo";
			this.btnBorrarPrestamo.Text = "Eliminar";
			this.btnBorrarPrestamo.ToolTipText = "Borrar este prestamo";
			this.btnBorrarPrestamo.UseColumnTextForButtonValue = true;
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Controls.Add(this.tabPage4);
			this.tabControl1.Controls.Add(this.tabPage5);
			this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tabControl1.Location = new System.Drawing.Point(1, 2);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(1692, 859);
			this.tabControl1.TabIndex = 80;
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.label10);
			this.tabPage2.Controls.Add(this.btnAgregarPrestamo);
			this.tabPage2.Controls.Add(this.txtNombreAlumno);
			this.tabPage2.Controls.Add(this.panel4);
			this.tabPage2.Controls.Add(this.txtFechaLimite);
			this.tabPage2.Controls.Add(this.panel5);
			this.tabPage2.Controls.Add(this.label9);
			this.tabPage2.Controls.Add(this.label4);
			this.tabPage2.Controls.Add(this.txtCodigoControlPrestamo);
			this.tabPage2.Controls.Add(this.txtFechaEntrega);
			this.tabPage2.Controls.Add(this.txtApellidosAlumno);
			this.tabPage2.Controls.Add(this.label5);
			this.tabPage2.Controls.Add(this.txtEspecialidad);
			this.tabPage2.Controls.Add(this.label8);
			this.tabPage2.Controls.Add(this.txtSemestre);
			this.tabPage2.Controls.Add(this.label7);
			this.tabPage2.Controls.Add(this.label6);
			this.tabPage2.Location = new System.Drawing.Point(4, 38);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(1577, 817);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Agregar prestamo";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.label30);
			this.tabPage1.Controls.Add(this.codigoQR);
			this.tabPage1.Controls.Add(this.btnGuardarAgregar);
			this.tabPage1.Controls.Add(this.label27);
			this.tabPage1.Controls.Add(this.txtTitulo);
			this.tabPage1.Controls.Add(this.txtAutor);
			this.tabPage1.Controls.Add(this.txtCodigoControl);
			this.tabPage1.Controls.Add(this.label26);
			this.tabPage1.Controls.Add(this.txtEditorial);
			this.tabPage1.Controls.Add(this.txtNumeroPaginas);
			this.tabPage1.Controls.Add(this.label12);
			this.tabPage1.Controls.Add(this.label25);
			this.tabPage1.Controls.Add(this.txtPais);
			this.tabPage1.Controls.Add(this.label11);
			this.tabPage1.Controls.Add(this.label24);
			this.tabPage1.Controls.Add(this.txtAnoPublicacion);
			this.tabPage1.Controls.Add(this.label22);
			this.tabPage1.Controls.Add(this.txtEtiquetas);
			this.tabPage1.Controls.Add(this.label21);
			this.tabPage1.Controls.Add(this.txtFormato);
			this.tabPage1.Controls.Add(this.label23);
			this.tabPage1.Controls.Add(this.txtSeccion);
			this.tabPage1.Location = new System.Drawing.Point(4, 38);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(1684, 817);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Agregar libro";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// tabPage3
			// 
			this.tabPage3.Controls.Add(this.dataGridView1);
			this.tabPage3.Location = new System.Drawing.Point(4, 38);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage3.Size = new System.Drawing.Size(1684, 817);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "Lista de prestamos";
			this.tabPage3.UseVisualStyleBackColor = true;
			// 
			// tabPage4
			// 
			this.tabPage4.Controls.Add(this.listaLibros);
			this.tabPage4.Location = new System.Drawing.Point(4, 38);
			this.tabPage4.Name = "tabPage4";
			this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage4.Size = new System.Drawing.Size(1684, 817);
			this.tabPage4.TabIndex = 3;
			this.tabPage4.Text = "Lista de libros";
			this.tabPage4.UseVisualStyleBackColor = true;
			// 
			// listaLibros
			// 
			this.listaLibros.AllowUserToDeleteRows = false;
			this.listaLibros.AllowUserToOrderColumns = true;
			this.listaLibros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.listaLibros.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.listaLibros.BackgroundColor = System.Drawing.SystemColors.Control;
			this.listaLibros.ColumnHeadersHeight = 100;
			this.listaLibros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.dataGridViewTextBoxColumn1,
			this.dataGridViewTextBoxColumn2,
			this.dataGridViewTextBoxColumn3,
			this.dataGridViewTextBoxColumn4,
			this.dataGridViewTextBoxColumn5,
			this.dataGridViewTextBoxColumn6,
			this.dataGridViewTextBoxColumn7,
			this.dataGridViewTextBoxColumn8,
			this.formato,
			this.noPaginas,
			this.Column1});
			this.listaLibros.GridColor = System.Drawing.SystemColors.ActiveCaption;
			this.listaLibros.Location = new System.Drawing.Point(0, 0);
			this.listaLibros.Name = "listaLibros";
			this.listaLibros.RowTemplate.Height = 25;
			this.listaLibros.Size = new System.Drawing.Size(1684, 625);
			this.listaLibros.TabIndex = 1;
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.HeaderText = "Titulo del libro";
			this.dataGridViewTextBoxColumn1.MinimumWidth = 100;
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.HeaderText = "Nombre del alumno";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.HeaderText = "Autor del libro";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.HeaderText = "Editorial";
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			// 
			// dataGridViewTextBoxColumn5
			// 
			this.dataGridViewTextBoxColumn5.HeaderText = "País";
			this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
			// 
			// dataGridViewTextBoxColumn6
			// 
			this.dataGridViewTextBoxColumn6.HeaderText = "Año";
			this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
			// 
			// dataGridViewTextBoxColumn7
			// 
			this.dataGridViewTextBoxColumn7.HeaderText = "Etiquetas";
			this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
			// 
			// dataGridViewTextBoxColumn8
			// 
			this.dataGridViewTextBoxColumn8.HeaderText = "Codigo de contról ";
			this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
			// 
			// formato
			// 
			this.formato.HeaderText = "Formato";
			this.formato.Name = "formato";
			// 
			// noPaginas
			// 
			this.noPaginas.HeaderText = "Numero de paginas";
			this.noPaginas.Name = "noPaginas";
			// 
			// Column1
			// 
			this.Column1.HeaderText = "QR";
			this.Column1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
			this.Column1.Name = "Column1";
			// 
			// tabPage5
			// 
			this.tabPage5.Location = new System.Drawing.Point(4, 38);
			this.tabPage5.Name = "tabPage5";
			this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage5.Size = new System.Drawing.Size(1684, 817);
			this.tabPage5.TabIndex = 4;
			this.tabPage5.Text = "Prestamos vencidos";
			this.tabPage5.UseVisualStyleBackColor = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.ClientSize = new System.Drawing.Size(1690, 662);
			this.Controls.Add(this.tabControl1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Location = new System.Drawing.Point(4, 38);
			this.Name = "MainForm";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.Text = "Sistema de prestamos";
			this.Load += new System.EventHandler(this.MainFormLoad);
			((System.ComponentModel.ISupportInitialize)(this.txtSemestre)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.tabControl1.ResumeLayout(false);
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.tabPage3.ResumeLayout(false);
			this.tabPage4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.listaLibros)).EndInit();
			this.ResumeLayout(false);

		}
	}
}