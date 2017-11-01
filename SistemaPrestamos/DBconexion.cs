/*
 * ${res:XML.StandardHeader.CreatedBy} luisg
 * User: luisg
 * Date: 21/10/2017
 * Time: 03:15 p. m.
 * 
 * 
 */
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Collections.Generic;

namespace SistemaPrestamos
{
	/// <summary>
	/// Description of DBconexion.
	/// </summary>
	public class DBconexion
	{
		private SQLiteConnection connection;
		
	
		public DBconexion()
		{
			Initialize();
		}
		
		private void Initialize(){
			
			}
		
		//open connection to database
	    private bool OpenConnection()
	    {
	    	try{
		    	connection = new SQLiteConnection("Data Source=base.db;Version=3;");
		    	connection.Open();
		    	
		    	return true;
	    	} catch(Exception){
	    		MessageBox.Show("Ha ocurrido un error con la base de datos");
	    		
	    		return false;
	    	}
	    }
	
	    //Close connection
	    private bool CloseConnection()
	    {
	    	try{
	    		connection.Close();
	    		
	    		return true;
	    	} catch(Exception){
	    		MessageBox.Show("Ha ocurrido un error con la base de datos");
	    		
	    		return false;
	    	}
	    }
	
	    //EXECUTE ANY STATEMENT
	    public bool Execute(string query){
	    	try{
		    	if(OpenConnection()){
		    		SQLiteCommand cmd = new SQLiteCommand(query, connection);
		    		
		    		cmd.ExecuteNonQuery();
		    		
		    		CloseConnection();
		    		
		    		return true;
		    	}
	    		
	    		return false;
	    	} catch(Exception) {
	    		MessageBox.Show("Ocurrió un error al intentar guardar la información en la base de datos, contacta al administrador", "Error");
	    		
	    		return false;
	    	}
	    }
	    
	    //Insert statement
	    public bool Insert(string table, string options) {
	    	try{
		    	if(OpenConnection()){
		    		string query = string.Format("INSERT INTO {0} VALUES ({1})", table, options);
		    		SQLiteCommand cmd = new SQLiteCommand(query, connection);
		    		
		    		cmd.ExecuteNonQuery();
		    		
		    		CloseConnection();
		    		
		    		return true;
		    	}
	    		
	    		return false;
	    	} catch(Exception) {
	    		MessageBox.Show("Ocurrió un error al intentar guardar la información en la base de datos, contacta al administrador", "Error");
	    		
	    		return false;
	    	}
	    }
	
	    //Update statement
	    public bool Update(string query) {
	    	try{
		    	if(OpenConnection()){
		    		SQLiteCommand cmd = new SQLiteCommand(query, connection);
		    	
		    		cmd.ExecuteNonQuery();
		    		
		    		CloseConnection();
		    		
		    		return true;
		    	}
	    		
	    		return false;
	    	} catch(Exception){
	    		MessageBox.Show("Ocurrió un error al intentar guardar la información en la base de datos, contacta al administrador", "Error");
	    		
	    		return false;
	    	}
	    }
	
	    //Delete statement
	    public bool Delete(string query){
	    	try{
		    	if(OpenConnection()){
		    		SQLiteCommand cmd = new SQLiteCommand(query, connection);
		    		
		    		cmd.ExecuteNonQuery();
		    		
		    		CloseConnection();
		    		
		    		return true;
		    	}
	    		
	    		return false;
	    	} catch(Exception){
	    		MessageBox.Show("Ocurrió un error al intentar guardar la información en la base de datos, contacta al administrador", "Error");
	    		
	    		return false;
	    	}
	    }
	
	    //Select statement
	    public string[] SelectOneBook(string data, string where_)
	    {
	    	if(OpenConnection()){
	    		string[] libro = new string[12];
	    		
	    		string query = String.Format("SELECT {0} FROM LIBRO WHERE {1}", data, where_);
	    		
	    		
	    		SQLiteCommand cmd = new SQLiteCommand(query, connection);
	    		
	    		SQLiteDataReader dataReader = cmd.ExecuteReader();
	    		
	    		if(dataReader.Read()){
	    			libro[0] = dataReader.GetInt32(0).ToString();
	    			libro[1] = dataReader.GetString(1);
	    			libro[2] = dataReader.GetString(2);
	    			libro[3] = dataReader.GetString(3);
	    			libro[4] = dataReader.GetString(4);
	    			libro[5] = dataReader.GetInt32(5).ToString();
	    			libro[6] = dataReader.GetString(6);
	    			libro[7] = dataReader.GetString(7);
	    			libro[8] = dataReader.GetString(8);
	    			libro[9] = dataReader.GetString(9);
	    			libro[10] = dataReader.GetInt32(10).ToString();
	    			libro[11] = dataReader.GetString(11);
	    		}
	    			    		
	    		dataReader.Close();
	    		
	    		CloseConnection();
	    		
	    		return libro;
	    		
	    	}
	    	return new []{"Ha ocurrido un error"};
	    }
	    
	    //Count statement
	    public int Count(string query) {
	    	int count = -1;
	    	
	    	if(OpenConnection()){
	    		SQLiteCommand cmd = new SQLiteCommand(query, connection);
	    		
	    		count = Convert.ToInt32(cmd.ExecuteScalar() + "");
	    		
	    		CloseConnection();
	    		
	    		return count;
	    	}
	    	
	    	return count;
	    }
	    
//	    public Dictionary<string, Libro> GetAllBooks(){
//	    	try {
//	    		if(OpenConnection()){
//	    			Dictionary<string, Libro> libros = new Dictionary<string, Libro>();
//	    			string query = "SELECT * FROM libro";
//	    			
//	    			SQLiteCommand cmd = new SQLiteCommand(query, connection);
//	    			
//	    			SQLiteDataReader dataReader = cmd.ExecuteReader();
//	    			
//	    			for(int i = 0; dataReader.Read(); i++){
//    					Libro libro = new Libro(
//    						dataReader.GetString(0),
//    						dataReader.GetString(1),
//    						dataReader.GetString(2),
//    						dataReader.GetString(3),
//    						dataReader.GetString(4),
//    						dataReader.GetInt32(5),
//    						dataReader.GetString(6),
//    						dataReader.GetString(7),
//    						dataReader.GetString(8),
//    						dataReader.GetInt32(9),
//    						dataReader.GetString(10)
//    					);
//	    				
//	    				libros.Add("libro"+(i + 1), libro);
//	    			}
//	    			
//	    			dataReader.Close();
//	    			
//	    			CloseConnection();
//	    			
//	    			return libros;
//	    		}
//	    		
//	    		return null;
//	    	} catch(Exception){
//	    		MessageBox.Show("Ha ocurrido un error con la base de datos contacta al administrador", "Error!");
//	    		
//	    		return null;
//	    	}
//	    	
//	    }
	
		public Dictionary<string, Prestamo> GetAllLends(){
	    	try {
	    		if(OpenConnection()){
	    			Dictionary<string, Prestamo> prestamos = new Dictionary<string, Prestamo>();
	    			string query = "SELECT * FROM prestamo";
	    			
	    			SQLiteCommand cmd = new SQLiteCommand(query, connection);
	    			
	    			SQLiteDataReader dataReader = cmd.ExecuteReader();
	    			
	    			
	    			if(dataReader.HasRows){
		    			for(int i = 0; dataReader.Read(); i++){
	    					Prestamo prestamo = new Prestamo();
	    					
	    					prestamo.Id = dataReader.GetInt32(0);
	    					prestamo.NombreEstudiante = dataReader.GetString(1);
	    					prestamo.ApellidosEstudiante = dataReader.GetString(2);
	    					prestamo.EspecialidadEstudiante = dataReader.GetString(3);
	    					prestamo.Semestre = dataReader.GetInt32(4);
	    					prestamo.FechaEntrega = dataReader.GetString(5);
	    					prestamo.FechaLimite = dataReader.GetString(6);
	    					prestamo.CodigoControlLibro = dataReader.GetString(7);
		    				
		    				prestamos.Add("prestamo"+(i + 1), prestamo);
		    			}
	    			} else {
	    				MessageBox.Show("No se han encontrado registros");
	    			}
	    			
	    			dataReader.Close();
	    			
	    			CloseConnection();
	    			
	    			return prestamos;
	    		}
	    		
	    		return new Dictionary<string, Prestamo>();
	    	} catch(Exception ex){
	    		MessageBox.Show(ex.ToString());
	    		MessageBox.Show("Ha ocurrido un error con la base de datos contacta al administrador", "Error!");
	    		
	    		return new Dictionary<string, Prestamo>();
	    	}
	    }
	    public Dictionary<string, Libro> GetAllBooks(){
	    	try{
	    		if(OpenConnection()){
	    			Dictionary<string, Libro> libros = new Dictionary<string, Libro>();
	    			string query = "SELECT * FROM libro";
	    			
	    			SQLiteCommand cmd = new SQLiteCommand(query, connection);
	    			
	    			SQLiteDataReader dataReader = cmd.ExecuteReader();
	    			
	    			if(dataReader.HasRows){
	    				for(int i = 0; dataReader.Read(); i++){
	    					Libro libro = new Libro();
	    					
	    					libro.CodigoControl = dataReader.GetString(0);
	    					libro.Titulo = dataReader.GetString(1);
	    					libro.Autor = dataReader.GetString(2);
	    					libro.Editorial = dataReader.GetString(3);
	    					libro.Pais = dataReader.GetString(4);
	    					libro.Ano = dataReader.GetInt32(5);
	    					libro.Seccion = dataReader.GetString(6);
	    					libro.Etiquetas = dataReader.GetString(7);
	    					libro.Formato = dataReader.GetString(8);
	    					libro.NoPaginas = dataReader.GetInt32(9);
	    					libro.QR = dataReader.GetString(10);
	    					
	    					libros.Add("libro"+(i + 1), libro);
	    				}
	    			}
	    			
	    			CloseConnection();
	    			
	    			return libros;
	    		}
	    		return new Dictionary<string, Libro>();
	    	} catch(Exception){
	    		MessageBox.Show("Ha ocurrido un error con la base de datos contacta a la administrador", "Error!");
	    		return new Dictionary<string, Libro>();
	    	}
	    }
	    
		public Dictionary<string, Prestamo> GetExpired(){
			try{
	    		if(OpenConnection()){
	    			Dictionary<string, Prestamo> prestamos = new Dictionary<string, Prestamo>();
	    			DateTime fecha = new DateTime();
	    			var f = fecha.GetDateTimeFormats();
	    			MessageBox.Show(f.ToString());
	    			string query = string.Format("SELECT * FROM prestamo WHERE fechaEntrega = {0}", f);
	    			
	    			SQLiteCommand cmd = new SQLiteCommand(query, connection);
	    			
	    			SQLiteDataReader dataReader = cmd.ExecuteReader();
	    			
	    			if(dataReader.HasRows){
	    				for(int i = 0; dataReader.Read(); i++){
	    					Prestamo prestamo = new Prestamo();
	    					
	    					prestamo.Id = dataReader.GetInt32(0);
	    					prestamo.NombreEstudiante = dataReader.GetString(1);
	    					prestamo.ApellidosEstudiante = dataReader.GetString(2);
	    					prestamo.EspecialidadEstudiante = dataReader.GetString(3);
	    					prestamo.Semestre = dataReader.GetInt32(4);
	    					prestamo.FechaEntrega = dataReader.GetString(5);
	    					prestamo.FechaLimite = dataReader.GetString(6);
	    					prestamo.CodigoControlLibro = dataReader.GetString(7);
		    				
		    				prestamos.Add("prestamo"+(i + 1), prestamo);
	    				}
	    			}
	    			
	    			CloseConnection();
	    			
	    			return prestamos;
	    		}
	    		return new Dictionary<string, Prestamo>();
	    	} catch(Exception){
	    		MessageBox.Show("Ha ocurrido un error con la base de datos contacta a la administrador", "Error!");
	    		return new Dictionary<string, Prestamo>();
	    	}
		}
	}
}