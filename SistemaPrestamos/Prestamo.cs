/*
 * ${res:XML.StandardHeader.CreatedBy} luisg
 * User: luisg
 * Date: 23/10/2017
 * Time: 11:07 p. m.
 * 
 * 
 */
using System;

namespace SistemaPrestamos
{
	/// <summary>
	/// Description of Prestamo.
	/// </summary>
	public class Prestamo
	{
		DBconexion conexion;
		
		int id;
		string nombreEstudiante;
		string apellidosEstudiante;
		string especialidadEstudiante;
		int semestre;
		string fechaEntrega;
		string fechaLimite;
		string codigoControlLibro;
		
		public Prestamo(){
			conexion = new DBconexion();
		}
		
		public Prestamo(
			int id,
			string nombreEstudiante,
			string apellidosEstudiante,
			string especialidadEstudiante,
			int semestre,
			string fechaEntrega,
			string fechaLimite,
			string codigoControlLibro
		)
		{
			this.id = id;
			this.nombreEstudiante = nombreEstudiante;
			this.apellidosEstudiante = apellidosEstudiante;
			this.especialidadEstudiante = especialidadEstudiante;
			this.semestre = semestre;
			this.fechaEntrega = fechaEntrega;
			this.fechaLimite = fechaLimite;
			this.codigoControlLibro = codigoControlLibro;
			
			conexion = new DBconexion();
		}
		
		public int Id {
			set{
				id = value;
			}
			get{
				return id;
			}
		}
		
		public string NombreEstudiante {
			set {
				nombreEstudiante = value;
			}
			get{
				return nombreEstudiante;
			}
		}
		public string ApellidosEstudiante {
			set {
				apellidosEstudiante = value;
			}
			get{
				return apellidosEstudiante;
			}
		}
		public string EspecialidadEstudiante {
			set {
				especialidadEstudiante = value;
			}
			get{
				return especialidadEstudiante;
			}
		}
		public int Semestre {
			set {
				semestre = value;
			}
			get{
				return semestre;
			}
		}
		public string FechaEntrega {
			set {
				fechaEntrega = value;
			}
			get{
				return fechaEntrega;
			}
		}
		public string FechaLimite {
			set {
				fechaLimite = value;
			}
			get{
				return fechaLimite;
			}
		}
		public string CodigoControlLibro {
			set {
				codigoControlLibro = value;
			}
			get{
				return codigoControlLibro;
			}
		}
		
		public bool Guardar(){
			
			string options = "null, '" + nombreEstudiante + "','" + apellidosEstudiante + "','" + especialidadEstudiante + "'," + semestre + ",'" + fechaEntrega + "','";
			options += fechaLimite + "','" + codigoControlLibro + "'";
			
			return conexion.Insert("prestamo", options);
		}
	}
}
