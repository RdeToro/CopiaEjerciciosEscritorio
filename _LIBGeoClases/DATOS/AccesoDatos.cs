using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _LIBGeoClases.NEGOCIO;

namespace _LIBGeoClases.DATOS
{
    public class AccesoDatos
    {
        public string cadenaConexion { get; set; }

        public AccesoDatos()
        {
            cadenaConexion = "Provider=SQLOLEDB.1;Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=AuditoriasCentros;Data Source=fernando-laptop\\sqlexpress";
        }

        public List<Comunidad> GetComunidades()
        {
            List<Comunidad> resultado = new List<Comunidad>();

            using (OleDbConnection conexion = new OleDbConnection(cadenaConexion))
            {
                conexion.Open();

                string SQL = "SELECT Id, Nombre FROM Tabla_Comunidad";

                OleDbCommand comando = conexion.CreateCommand();
                comando.CommandText = SQL;
                OleDbDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Comunidad comunidad = new Comunidad
                    {
                        Id = (int)reader["Id"],
                        Nombre = (string)reader["Nombre"]
                    };

                    resultado.Add(comunidad);
                }

                conexion.Close();
            }

            return resultado;
        }

        public List<Provincia> GetProvinciasPorComunidadId(int ComunidadId)
        {
            List<Provincia> resultado = new List<Provincia>();

            using (OleDbConnection conexion = new OleDbConnection(cadenaConexion))
            {
                conexion.Open();

                string SQL = "SELECT Id, Nombre, ComunidadId FROM Tabla_Provincia WHERE ComunidadId = ?";

                OleDbCommand comando = conexion.CreateCommand();
                comando.CommandText = SQL;

                OleDbParameter parametro = new OleDbParameter("@ComunidadId", OleDbType.Integer);
                parametro.Value = ComunidadId;

                comando.Parameters.Add(parametro);

                OleDbDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Provincia provincia = new Provincia
                    {
                        Id = (int)reader["Id"],
                        Nombre = (string)reader["Nombre"],
                        ComunidadId = (int)reader["ComunidadId"]
                    };

                    resultado.Add(provincia);
                }

                conexion.Close();
            }

            return resultado;
        }

        public List<Municipio> GetMunicipiosPorProvinciaId(int ProvinciaId)
        {
            List<Municipio> resultado = new List<Municipio>();

            using (OleDbConnection conexion = new OleDbConnection(cadenaConexion))
            {
                conexion.Open();

                string SQL = "SELECT Id, Nombre, ProvinciaId FROM Tabla_Municipio WHERE ProvinciaId = ?";

                OleDbCommand comando = conexion.CreateCommand();
                comando.CommandText = SQL;

                OleDbParameter parametro = new OleDbParameter("@ProvinciaId", OleDbType.Integer);
                parametro.Value = ProvinciaId;

                comando.Parameters.Add(parametro);

                OleDbDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Municipio municipio = new Municipio
                    {
                        Id = (int)reader["Id"],
                        Nombre = (string)reader["Nombre"],
                        ProvinciaId = (int)reader["ProvinciaId"]
                    };

                    resultado.Add(municipio);
                }

                conexion.Close();
            }

            return resultado;
        }

        public List<Poblacion> GetPoblacionesPorMunicipioId(int MunicipioId)
        {
            List<Poblacion> resultado = new List<Poblacion>();

            using (OleDbConnection conexion = new OleDbConnection(cadenaConexion))
            {
                conexion.Open();

                string SQL = "SELECT Id, Nombre, MunicipioId FROM Tabla_Poblacion WHERE MunicipioId = ?";

                OleDbCommand comando = conexion.CreateCommand();
                comando.CommandText = SQL;

                OleDbParameter parametro = new OleDbParameter("@MunicipioId", OleDbType.Integer);
                parametro.Value = MunicipioId;

                comando.Parameters.Add(parametro);

                OleDbDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Poblacion poblacion = new Poblacion
                    {
                        Id = (int)reader["Id"],
                        Nombre = (string)reader["Nombre"],
                        MunicipioId = (int)reader["MunicipioId"]
                    };

                    resultado.Add(poblacion);
                }

                conexion.Close();
            }

            return resultado;
        }
    }
}
