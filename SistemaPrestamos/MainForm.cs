/*
 * ${res:XML.StandardHeader.CreatedBy} luisg
 * User: luisg
 * Date: 22/10/2017
 * Time: 07:48 p. m.
 * 
 * 
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using Gma.QrCodeNet.Encoding;
using Gma.QrCodeNet.Encoding.Windows.Render;

namespace SistemaPrestamos
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		TextBox[] listaTextBox = new TextBox[11], listaTextBoxPrestamo = new TextBox[3];
		DBconexion conexion = new DBconexion();
		
		//Constructor del formulario
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			listaTextBox[0] = txtTitulo;
			listaTextBox[1] = txtAutor;
			listaTextBox[2] = txtEditorial;
			listaTextBox[3] = txtPais;
			listaTextBox[4] = txtAnoPublicacion;
			listaTextBox[5] = txtSeccion;
			listaTextBox[6] = txtEtiquetas;
			listaTextBox[7] = txtFormato;
			listaTextBox[8] = txtCodigoControl;
			listaTextBox[9] = txtNumeroPaginas;
			listaTextBox[10] = txtCodigoControl;
			
			
			listaTextBoxPrestamo[0] = txtNombreAlumno;
			listaTextBoxPrestamo[1] = txtApellidosAlumno;
			listaTextBoxPrestamo[2] = txtCodigoControlPrestamo;
			
		}
		void MainFormLoad(object sender, EventArgs e)
		{
			Dictionary<string, Prestamo> prestamos = conexion.GetAllLends();
			
			dataGridView1.Rows.Clear();
			
			for(int i = 0; i < prestamos.Count; i++){
				dataGridView1.Rows.Add(
					prestamos["prestamo" + (i + 1)].Id,
					prestamos["prestamo" + (i + 1)].NombreEstudiante,
					prestamos["prestamo" + (i + 1)].ApellidosEstudiante,
					prestamos["prestamo" + (i + 1)].EspecialidadEstudiante,
					prestamos["prestamo" + (i + 1)].Semestre,
					prestamos["prestamo" + (i + 1)].FechaEntrega,
					prestamos["prestamo" + (i + 1)].FechaLimite,
					prestamos["prestamo" + (i + 1)].CodigoControlLibro
				);
			}
			
			Dictionary<string, Libro> libros = conexion.GetAllBooks();
			
			listaLibros.Rows.Clear();
				
			for(int i = 0; i < libros.Count; i++){
				listaLibros.Rows.Add(
					libros["libro" + (i + 1)].CodigoControl,
					libros["libro" + (i + 1)].Titulo,
					libros["libro" + (i + 1)].Autor,
					libros["libro" + (i + 1)].Editorial,
					libros["libro" + (i + 1)].Pais,
					libros["libro" + (i + 1)].Ano,
					libros["libro" + (i + 1)].Seccion,
					libros["libro" + (i + 1)].Etiquetas,
					libros["libro" + (i + 1)].Formato,
					libros["libro" + (i + 1)].NoPaginas,
					Image.FromFile(libros["libro" + (i + 1)].QR)
				);
			}
			
			Dictionary<string, Prestamo> prestamosVencidos = conexion.GetExpired();
			listaPrestamosVencidos.Rows.Clear();
						
			for(int i = 0; i < prestamosVencidos.Count; i++){
				listaPrestamosVencidos.Rows.Add(
					prestamosVencidos["prestamo" + (i + 1)].Id,
					prestamosVencidos["prestamo" + (i + 1)].NombreEstudiante,
					prestamosVencidos["prestamo" + (i + 1)].ApellidosEstudiante,
					prestamosVencidos["prestamo" + (i + 1)].EspecialidadEstudiante,
					prestamosVencidos["prestamo" + (i + 1)].Semestre,
					prestamosVencidos["prestamo" + (i + 1)].FechaEntrega,
					prestamosVencidos["prestamo" + (i + 1)].FechaLimite,
					prestamosVencidos["prestamo" + (i + 1)].CodigoControlLibro
				);
			}
		}
		void HabilitarBotonLibro(object sender, EventArgs e)
		{
			int cont = 0;
			
			foreach(TextBox textbox in listaTextBox){
				if(!string.IsNullOrEmpty(textbox.Text)){
					++cont;
				}
			}
			
			if(cont == 11){
				btnGuardarAgregar.Enabled = true;
				return;
			}
			
			btnGuardarAgregar.Enabled = false;
		}
		void TxtAnoPublicacionKeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
		    {
		            e.Handled = true;
		    }
		}
		void btnGenerarAgregarLibro(object sender, EventArgs e)
		{
			//Hacemos el objeto libro
			Libro libro = new Libro(txtCodigoControl.Text,
									txtTitulo.Text,
									txtAutor.Text,
									txtEditorial.Text,
									txtPais.Text,
									Convert.ToInt32(txtAnoPublicacion.Text),
									txtSeccion.Text,
									txtEtiquetas.Text,
									txtFormato.Text,
									Convert.ToInt32(txtNumeroPaginas.Text),
									""
            );
			
			//Creamos el codigo qr
			QrEncoder qrEncoder = new QrEncoder(ErrorCorrectionLevel.H);
			QrCode qrCode = new QrCode();
			
			qrEncoder.TryEncode(libro.ObtenerFormato() , out qrCode);
			
			GraphicsRenderer renderer = new GraphicsRenderer(new FixedCodeSize(400, QuietZoneModules.Zero), Brushes.Black, Brushes.White);
			
			MemoryStream ms = new MemoryStream();
			
			renderer.WriteToStream(qrCode.Matrix, ImageFormat.Png, ms);
			
			var imageTemporal = new Bitmap(ms);
			var imagen = new Bitmap(imageTemporal, new Size(new Point(402, 402)));
			
			codigoQR.BackgroundImage = imagen;
			
			imagen.Save("imagen.png", ImageFormat.Png);
			
			DialogResult messageGuardar = MessageBox.Show("Desea guardar la imagen?", "Confirmación", MessageBoxButtons.YesNo);
			
			if(messageGuardar == DialogResult.Yes){
				Image img = (Image)codigoQR.BackgroundImage.Clone();
				
				SaveFileDialog dialogoGuardar = new SaveFileDialog();
				
				dialogoGuardar.FileName = libro.Titulo;
				dialogoGuardar.AddExtension = true;
				dialogoGuardar.Filter = "Image PNG (*.png)|*.png";
				dialogoGuardar.ShowDialog();
			
				if(!string.IsNullOrEmpty(dialogoGuardar.FileName)) {
					img.Save(dialogoGuardar.FileName, ImageFormat.Png);
					
					libro.QR = dialogoGuardar.FileName;
				}
			}
			
			//Lo añadimos a la base de datos
			if(libro.Guardar()) {
				foreach(TextBox textbox in listaTextBox){
					textbox.Clear();
				}
				
				MessageBox.Show("El libro se ha añadido con exito!", "Aviso!");
			} else {
				MessageBox.Show("Ocurrio un error al añadir el libro!", "Aviso!");
			}
		}
		void txtsPrestamo(object sender, EventArgs e)
		{
			int cont = 0;
			
			foreach(TextBox textbox in listaTextBoxPrestamo){
				if(!string.IsNullOrEmpty(textbox.Text)){
					++cont;
				}
			}
			
			if(cont == 3 && !string.IsNullOrEmpty(txtEspecialidad.Text)){
				btnAgregarPrestamo.Enabled = true;
				return;
			}
			
			btnAgregarPrestamo.Enabled = false;	
		}
		void BtnAgregarPrestamoClick(object sender, EventArgs e)
		{
			//Creamos el objeto de tipo prestamo
			Prestamo prestamo = new Prestamo();
			
			//Asignamos a cada propiedad del prestamos su correspondiente valor
			prestamo.NombreEstudiante = txtNombreAlumno.Text;
			prestamo.ApellidosEstudiante = txtApellidosAlumno.Text;
			prestamo.Semestre = Convert.ToInt32(txtSemestre.Value);
			prestamo.EspecialidadEstudiante = txtEspecialidad.Text;
			
			//Datos de la fecha de entrega
			string[] fecha_entrega = Convert.ToDateTime(txtFechaEntrega.Text).ToString().Split(' ');
			string[] fecha_limite = Convert.ToDateTime(txtFechaLimite.Text).ToString().Split(' ');
			
			prestamo.FechaEntrega = fecha_entrega[0];
			prestamo.FechaLimite = fecha_limite[0];
			
			//Datos del libro
			prestamo.CodigoControlLibro = txtCodigoControlPrestamo.Text;
			
			//Guardamos el prestamo en la base de datos
			if(prestamo.Guardar()){
				foreach(TextBox textbox in listaTextBoxPrestamo){
					textbox.Clear();
				}
				
				txtSemestre.Value = 1;
				txtEspecialidad.Text = "";
				
				MessageBox.Show("El prestamo se ha guardado con exito!", "Aviso!");
			} else {
				MessageBox.Show("Ocurrio un error al añadir el prestamo!", "Aviso!");
			}
		}
	}
}
