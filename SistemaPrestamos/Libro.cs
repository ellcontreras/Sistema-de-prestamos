/*
 * ${res:XML.StandardHeader.CreatedBy} luisg
 * User: luisg
 * Date: 23/10/2017
 * Time: 06:18 p. m.
 * 
 * 
 */
using System;

namespace SistemaPrestamos
{	
	public class Libro
	{
		DBconexion conexion;
		string codigoControl;
		string titulo;
		string autor;
		string editorial;
		string pais;
		int ano;
		string seccion;
		string etiquetas;
		string formato;
		int noPaginas;
		string qr;
		
		public Libro(){
	
		}
		
		public Libro(string codigoControl,
			string titulo,
			string autor,
			string editorial,
			string pais,
			int ano,
			string seccion,
			string etiquetas,
			string formato,
			int noPaginas,
			string qr
		)
		{
			this.codigoControl = codigoControl;
			this.titulo = titulo;
			this.autor = autor;
			this.editorial = editorial;
			this.pais = pais;
			this.ano = ano;
			this.seccion = seccion;
			this.etiquetas = etiquetas;
			this.formato = formato;
			this.noPaginas = noPaginas;
			this.qr = qr;
			
			conexion = new DBconexion();
		}
		
		public string CodigoControl {
			get {
				return codigoControl;
			}
			set {
				this.codigoControl = value;
			}
		}
		public string Titulo {
			get {
				return titulo;
			}
			set {
				this.titulo = value;
			}
		}
		public string Autor {
			get {
				return autor;
			}
			set {
				this.autor = value;
			}
		}
		public string Editorial {
			get {
				return editorial;
			}
			set {
				this.editorial = value;
			}
		}
		public string Pais {
			get {
				return pais;
			}
			set {
				this.pais = value;
			}
		}
		public int Ano {
			get {
				return ano;
			}
			set {
				this.ano = value;
			}
		}
		public string Seccion {
			get {
				return seccion;
			}
			set {
				this.seccion = value;
			}
		}
		public string Etiquetas {
			get {
				return etiquetas;
			}
			set {
				this.etiquetas = value;
			}
		}
		public string Formato {
			get {
				return formato;
			}
			set {
				this.formato = value;
			}
		}
		public int NoPaginas {
			get {
				return noPaginas;
			}
			set {
				this.noPaginas = value;
			}
		}
		public string QR {
			get {
				return qr;
			}
			set {
				this.qr = value;
			}
		}
		
		public string ObtenerFormato(){
			string formato = "Titulo: " + titulo + "\n";
			formato += "Autor: " + autor + "\n";
			formato += "Editorial: " + editorial + "\n";	
			formato += "País: " + pais + "\n";
			formato += "Año: " + (ano) + "\n";
			formato += "Sección: " + seccion + "\n";
			formato += "Etiquetas: " + etiquetas + "\n";
			formato += "Formato: " + formato + "\n";
			formato += "Numero de paginas: " + (noPaginas) + "\n";
			
			return formato;
		}
		
		public bool Guardar(){
			string options = "'" + codigoControl + "','" + titulo + "','" + autor + "','" + editorial + "','" + pais + "','" + ano + "','";
			options += seccion + "','" + etiquetas + "','" + formato + "','" + noPaginas + "','" + qr + "'";
			
			return conexion.Insert("libro", options);
		}
	}
}
