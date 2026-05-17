using System.Data;
using System.Data.SqlClient;

namespace TodoPlast
{
    public class clsOrdenProduccion
    {
        private readonly ConexionDB _db;

        public clsOrdenProduccion(ConexionDB db)
        {
            _db = db;
        }

        // ── INSERT ──────────────────────────────────────────────────────────────
        public bool Insertar(string descripcion, int idMaquina, int horasTrabajo)
        {
            const string query = @"
                INSERT INTO dbo.OrdenesProduccion (Descripcion, IdMaquina, HorasTrabajo)
                VALUES (@Descripcion, @IdMaquina, @HorasTrabajo)";

            var parametros = new[]
            {
                new SqlParameter("@Descripcion",  SqlDbType.NVarChar, 50) { Value = descripcion  },
                new SqlParameter("@IdMaquina",    SqlDbType.Int)          { Value = idMaquina    },
                new SqlParameter("@HorasTrabajo", SqlDbType.Int)          { Value = horasTrabajo }
            };

            return _db.EjecutarComando(query, parametros);
        }

        // ── DELETE ──────────────────────────────────────────────────────────────
        public bool Eliminar(int idOrden)
        {
            const string query = "DELETE FROM dbo.OrdenesProduccion WHERE IdOrden = @IdOrden";

            var parametros = new[]
            {
                new SqlParameter("@IdOrden", SqlDbType.Int) { Value = idOrden }
            };

            return _db.EjecutarComando(query, parametros);
        }

        // ── SELECT ALL ──────────────────────────────────────────────────────────
        public DataTable Listar()
        {
            const string query = @"
                SELECT op.IdOrden, op.Descripcion, op.IdMaquina, 
                       m.Nombre AS NombreMaquina, op.HorasTrabajo
                FROM dbo.OrdenesProduccion op
                INNER JOIN dbo.Maquinas m ON op.IdMaquina = m.IdMaquina
                ORDER BY op.IdOrden";

            return _db.EjecutarConsulta(query);
        }

        // ── SELECT BY ID ────────────────────────────────────────────────────────
        public DataTable BuscarPorId(int idOrden)
        {
            const string query = @"
                SELECT IdOrden, Descripcion, IdMaquina, HorasTrabajo 
                FROM dbo.OrdenesProduccion 
                WHERE IdOrden = @IdOrden";

            var parametros = new[]
            {
                new SqlParameter("@IdOrden", SqlDbType.Int) { Value = idOrden }
            };

            return _db.EjecutarConsulta(query, parametros);
        }

        // ── EXISTE ──────────────────────────────────────────────────────────────
        public bool Existe(int idOrden)
        {
            return BuscarPorId(idOrden).Rows.Count > 0;
        }

        // ── MAQUINA EXISTE (valida la FK antes de insertar) ─────────────────────
        public bool MaquinaExiste(int idMaquina)
        {
            const string query = "SELECT IdMaquina FROM dbo.Maquinas WHERE IdMaquina = @IdMaquina";

            var parametros = new[]
            {
                new SqlParameter("@IdMaquina", SqlDbType.Int) { Value = idMaquina }
            };

            return _db.EjecutarConsulta(query, parametros).Rows.Count > 0;
        }
    }
}