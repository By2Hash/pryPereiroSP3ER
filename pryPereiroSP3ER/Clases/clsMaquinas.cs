using System.Data;
using System.Data.SqlClient;

namespace TodoPlast
{
    public class clsMaquinas
    {
        private readonly ConexionDB _db;

        public clsMaquinas(ConexionDB db)
        {
            _db = db;
        }

        // ── INSERT ──────────────────────────────────────────────────────────────
        public bool Insertar(string nombre, int capacidad)
        {
            const string query = @"
                INSERT INTO dbo.Maquinas (Nombre, Capacidad)
                VALUES (@Nombre, @Capacidad)";

            var parametros = new[]
            {
                 new SqlParameter("@Nombre",    SqlDbType.NVarChar, 30) { Value = nombre    },
                 new SqlParameter("@Capacidad", SqlDbType.Int)          { Value = capacidad }
            };

            return _db.EjecutarComando(query, parametros);
        }

        // ── DELETE ──────────────────────────────────────────────────────────────
        public bool Eliminar(int idMaquina)
        {
            const string query = "DELETE FROM dbo.Maquinas WHERE IdMaquina = @IdMaquina";

            var parametros = new[]
            {
                new SqlParameter("@IdMaquina", SqlDbType.Int) { Value = idMaquina }
            };

            return _db.EjecutarComando(query, parametros);
        }

        // ── SELECT ALL ──────────────────────────────────────────────────────────
        public DataTable Listar()
        {
            const string query = "SELECT IdMaquina, Nombre, Capacidad FROM dbo.Maquinas ORDER BY IdMaquina";
            return _db.EjecutarConsulta(query);
        }

        // ── SELECT BY ID ────────────────────────────────────────────────────────
        public DataTable BuscarPorId(int idMaquina)
        {
            const string query = "SELECT IdMaquina, Nombre, Capacidad FROM dbo.Maquinas WHERE IdMaquina = @IdMaquina";

            var parametros = new[]
            {
                new SqlParameter("@IdMaquina", SqlDbType.Int) { Value = idMaquina }
            };

            return _db.EjecutarConsulta(query, parametros);
        }

        // ── EXISTE ──────────────────────────────────────────────────────────────
        public bool Existe(int idMaquina)
        {
            return BuscarPorId(idMaquina).Rows.Count > 0;
        }
    }
}