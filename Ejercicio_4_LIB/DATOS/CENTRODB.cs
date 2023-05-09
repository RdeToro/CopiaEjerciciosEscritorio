using Ejercicio_4_LIB.NEGOCIO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4_LIB.DATOS
{
    public class CENTRODB
    {
        private string _CadenaDeConexion = @"Provider = SQLOLEDB.1; Integrated Security = SSPI; Persist Security Info=False;Initial Catalog = AuditoriasCentros; Data Source = localhost\SQLEXPRESS";

        public long GuardarCentro(Centro centro )
        {
            long resultado;

            using(OleDbConnection conexion = new OleDbConnection(_CadenaDeConexion) )
            {
                conexion.Open();

                string SQL = "INSERT INTO Tabla_Centro (Nombre,PoblacionId,Direccion,CP) values(?,?,?,?)";

                OleDbCommand comando = conexion.CreateCommand();
                comando.CommandText = SQL; 

                OleDbParameter parametro = new OleDbParameter("@Nombre",OleDbType.VarChar);
                parametro.Value = centro.Nombre;
                comando.Parameters.Add(parametro);

                parametro = new OleDbParameter("@PoblacionId", OleDbType.Integer);
                parametro.Value = centro.PoblacionId;
                comando.Parameters.Add(parametro);

                parametro = new OleDbParameter("@Direccion", OleDbType.VarChar);
                parametro.Value = centro.Direccion;
                comando.Parameters.Add(parametro);

                parametro = new OleDbParameter("@CP", OleDbType.Integer);
                parametro.Value = centro.CodigoPostal;
                comando.Parameters.Add(parametro);

                comando.ExecuteNonQuery();

                SQL = "SELECT @@IDENTITY";

                comando.CommandText = SQL;

                OleDbDataReader reader = comando.ExecuteReader();

                DataTable tabla = new DataTable();
                tabla.Load(reader);

                 resultado = Convert.ToInt64(tabla.Rows[0][0]);              

                

                conexion.Close();

            } 
            
            return resultado;

        }
        /*
        public List<Centro> GetCentros()
        {
            DataTable resultado = new DataTable();
            using(OleDbConnection conexion = new OleDbConnection(_CadenaDeConexion))
            {
                conexion.Open();

                string SQL = "SELECT ID, PoblacionID, Direccion, CP FROM Tabla_Centro";

                OleDbCommand comando = conexion.CreateCommand();
                comando.CommandText = SQL;

                OleDbDataReader reader = comando.ExecuteReader();

                DataTable tabla = new DataTable();

                tabla.Load(reader);                            
                
               
                

            }
            return resultado;

        }
        */
    }
}
