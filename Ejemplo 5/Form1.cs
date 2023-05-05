using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;

namespace Ejemplo_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string SQL = "INSERT INTO Tabla_Centro (Nombre, PoblacionId, Direccion, CP)" +
                         "VALUES (?,?,?,?)";

            string CadenaDeConexion = "Provider=SQLOLEDB.1;Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=AuditoriasCentros;Data Source=localhost\\SQLEXPRESS";

            using (OleDbConnection conexion = new OleDbConnection(CadenaDeConexion))
            {
                conexion.Open();

                //OleDbCommand Comando = conexion.CreateCommand();
                OleDbCommand Comando = new OleDbCommand(SQL, conexion);

                OleDbParameter parametro = new OleDbParameter("@Nombre", OleDbType.VarChar);
                parametro.Value = "Centro de crianza de Charizard 1 de Guadalajara";

                Comando.Parameters.Add(parametro);

                parametro = new OleDbParameter("@PoblacionId", OleDbType.Integer);
                parametro.Value = 18791;

                Comando.Parameters.Add(parametro);

                parametro = new OleDbParameter("@Direccion", OleDbType.VarChar);
                parametro.Value = "C/ Ferial 3";

                Comando.Parameters.Add(parametro);

                parametro = new OleDbParameter("@CP", OleDbType.Integer);
                parametro.Value = "19002";

                Comando.Parameters.Add(parametro);

                Comando.ExecuteScalar();

                SQL = "SELECT @@Identity";
                Comando.CommandText = SQL;
                OleDbDataReader reader = Comando.ExecuteReader();

                //Forma 1
                int UltimoId;
                while (reader.Read())
                {
                    UltimoId = (int)reader[0];

                };

                //Forma 2

                DataTable table = new DataTable();
                table.Load(reader);

                MessageBox.Show(table.Rows[0][0].ToString());



                conexion.Close();
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

            string CadenaDeConexion = "Provider=SQLOLEDB.1;Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=AuditoriasCentros;Data Source=localhost\\SQLEXPRESS";

            using (OleDbConnection conexion = new OleDbConnection(CadenaDeConexion))
            {

                conexion.Open();

                string SQL = "UPDATE Tabla_Centro SET Nombre = ? Where Id = ?";

                OleDbCommand comando = conexion.CreateCommand();
                comando.CommandText = SQL;

                OleDbParameter parametro = new OleDbParameter("@Nombre", OleDbType.VarChar);
                parametro.Value = txtCentro.Text;
                comando.Parameters.Add(parametro);

                parametro = new OleDbParameter("@Id", OleDbType.Integer);
                parametro.Value = Convert.ToInt32(txtId.Text);
                comando.Parameters.Add(parametro);

                int resultado = comando.ExecuteNonQuery();

                MessageBox.Show("Se ha modificado" + resultado.ToString() + " resultado/s", "Modificacion", MessageBoxButtons.OK, MessageBoxIcon.Information);




                conexion.Close();

            }

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {

            string CadenaDeConexion = "Provider=SQLOLEDB.1;Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=AuditoriasCentros;Data Source=localhost\\SQLEXPRESS";

            using (OleDbConnection conexion = new OleDbConnection(CadenaDeConexion))
            {

                conexion.Open();

                string SQL = "DELETE FROM Tabla_Centro Where Id = ?";

                OleDbCommand comando = conexion.CreateCommand();
                comando.CommandText = SQL;

                OleDbParameter parametro = new OleDbParameter("@Id", OleDbType.Integer);
                parametro.Value = Convert.ToInt32(txtBorrar.Text);
                comando.Parameters.Add(parametro);

                int resultado = comando.ExecuteNonQuery();

                MessageBox.Show("Se ha borrado " + resultado.ToString() + " resultado/s", "Modificacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}