using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TodoPlast
{
    public class ConexionDB
    {
        private const string ConnectionString = "Server=.;Database=TodoPlastDB;Trusted_Connection=True;";

        private SqlConnection _conexion;

        // ← Ahora recibe el ToolStripStatusLabel que vive DENTRO del StatusStrip
        private readonly StatusStrip _strip;

        public ConexionDB(StatusStrip strip)
        {
            _strip = strip;
            _conexion = new SqlConnection(ConnectionString);
        }

        public bool Abrir()
        {
            try
            {
                if (_conexion.State != ConnectionState.Open)
                    _conexion.Open();

                MostrarEstado("● Conectado", System.Drawing.Color.Green);
                return true;
            }
            catch (SqlException ex)
            {
                MostrarEstado($"● Error: {ex.Message}", System.Drawing.Color.Red);
                return false;
            }
        }

        public void Cerrar()
        {
            if (_conexion.State != ConnectionState.Closed)
            {
                _conexion.Close();
                MostrarEstado("● Desconectado", System.Drawing.Color.Gray);
            }
        }

        public SqlConnection ObtenerConexion() => _conexion;

        public bool EjecutarComando(string query, SqlParameter[] parametros = null)
        {
            try
            {
                using (var cmd = new SqlCommand(query, _conexion))
                {
                    if (parametros != null)
                        cmd.Parameters.AddRange(parametros);

                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch (SqlException ex)
            {
                MostrarEstado($"● Error al ejecutar: {ex.Message}", System.Drawing.Color.Red);
                return false;
            }
        }

        public DataTable EjecutarConsulta(string query, SqlParameter[] parametros = null)
        {
            var tabla = new DataTable();
            try
            {
                using (var cmd = new SqlCommand(query, _conexion))
                {
                    if (parametros != null)
                        cmd.Parameters.AddRange(parametros);

                    using (var adapter = new SqlDataAdapter(cmd))
                        adapter.Fill(tabla);
                }
            }
            catch (SqlException ex)
            {
                MostrarEstado($"● Error en consulta: {ex.Message}", System.Drawing.Color.Red);
            }
            return tabla;
        }

        private void MostrarEstado(string mensaje, System.Drawing.Color color)
        {
            if (_strip == null || _strip.Items.Count == 0) return;

            // ← Accede al item interno (toolStripStatusLabel1)
            var item = (ToolStripStatusLabel)_strip.Items[0];
            item.Text = mensaje;
            item.ForeColor = color;
        }
    }
}