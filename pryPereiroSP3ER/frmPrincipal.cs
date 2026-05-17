using System;
using System.Data;
using System.Windows.Forms;
using TodoPlast;

namespace pryPereiroSP3ER
{
    public partial class frmPrincipal : Form
    {
        private ConexionDB _db;
        private clsMaquinas _maquinas;        // ← AGREGAR acá, junto a _db

        public frmPrincipal()
        {
            InitializeComponent();
            _db = new ConexionDB(statusStrip1);
            _maquinas = new clsMaquinas(_db); // ← AGREGAR acá, junto a _db
        }

        private void CargarComboMaquinas()
        {
            if (_db.Abrir())
            {
                // Usamos el nombre de la tabla que aparece en tus capturas
                string query = "SELECT IdMaquina, Nombre FROM Maquinas";

                DataTable dt = _db.EjecutarConsulta(query);

                if (dt.Rows.Count > 0)
                {
                    cmbTabla.DataSource = dt;
                    cmbTabla.DisplayMember = "Nombre";    // Lo que el usuario lee
                    cmbTabla.ValueMember = "IdMaquina";   // El ID real para la DB
                }

                _db.Cerrar();
            }
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            _db.Abrir();
        }

        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            _db.Cerrar();
        }

        // ↓ PEGAR todo lo de abajo al final, antes del cierre de la clase ↓

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCamposRegistrar();
        }

        private void LimpiarCamposRegistrar()
        {
            txtIdMaquina.Clear();
            txtNombre.Clear();
            txtCapacidad.Clear();
            txtIdMaquina.Focus();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIdMaquina.Text))
            {
                MessageBox.Show("Ingrese el Id de la máquina a eliminar.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtIdMaquina.Text.Trim(), out int idMaquina))
            {
                MessageBox.Show("El Id debe ser un número entero.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!_maquinas.Existe(idMaquina))
            {
                MessageBox.Show($"No existe ninguna máquina con Id {idMaquina}.", "No encontrado",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var respuesta = MessageBox.Show(
                $"¿Eliminar la máquina con Id {idMaquina}?",
                "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                if (_maquinas.Eliminar(idMaquina))
                {
                    MessageBox.Show("Máquina eliminada correctamente.", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtIdMaquina.Clear();
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIdMaquina.Text) ||
                string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtCapacidad.Text))
            {
                MessageBox.Show("Complete todos los campos.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtIdMaquina.Text.Trim(), out int idMaquina))
            {
                MessageBox.Show("El Id Máquina debe ser un número entero.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtCapacidad.Text.Trim(), out int capacidad))
            {
                MessageBox.Show("La Capacidad debe ser un número entero.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_maquinas.Existe(idMaquina))
            {
                MessageBox.Show($"Ya existe una máquina con Id {idMaquina}.", "Duplicado",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_maquinas.Insertar(txtNombre.Text.Trim(), capacidad))
            {
                MessageBox.Show("Máquina registrada correctamente.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCamposRegistrar();
            }
            else
            {
                MessageBox.Show("No se pudo registrar la máquina.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }   // ← cierre de la clase, ya estaba
}       // ← cierre del namespace, ya estaba