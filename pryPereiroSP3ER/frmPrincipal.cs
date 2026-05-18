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
        private clsOrdenProduccion _ordenes;

        public frmPrincipal()
        {
            InitializeComponent();
            _db = new ConexionDB(statusStrip1);
            _maquinas = new clsMaquinas(_db); // ← AGREGAR acá, junto a _db
            _ordenes = new clsOrdenProduccion(_db);
            cmbTabla.SelectedIndexChanged += cmbTabla_SelectedIndexChanged;
            btnListar.Click += btnListar_Click;
        }

        private void CargarComboTablas()
        {
            cmbTabla.Items.Clear();
            cmbTabla.Items.Add("Maquinas");
            cmbTabla.Items.Add("OrdenesProduccion");
            cmbTabla.SelectedIndex = 0; // selecciona la primera por defecto
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            _db.Abrir();
            CargarComboTablas();
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

            // Si hay datos en el grupo Máquinas, guarda máquina
            if (!string.IsNullOrWhiteSpace(txtNombre.Text) ||
                !string.IsNullOrWhiteSpace(txtCapacidad.Text))
            {
                GuardarMaquina();
            }
            // Si hay datos en el grupo Órdenes, guarda orden
            else if (!string.IsNullOrWhiteSpace(txtIdOrden.Text) ||
                     !string.IsNullOrWhiteSpace(txtDescripcion.Text))
            {
                GuardarOrden();
            }
            else
            {
                MessageBox.Show("Complete al menos un formulario.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cmbTabla_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListarTablaSeleccionada();

        }

        private void ListarTablaSeleccionada()
        {
            if (cmbTabla.SelectedItem == null) return;

            string tabla = cmbTabla.SelectedItem.ToString();
            string query = $"SELECT * FROM dbo.{tabla} ORDER BY 1"; // ORDER BY 1 = primera columna

            DataTable dt = _db.EjecutarConsulta(query);
            dgvListar.DataSource = dt;
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            ListarTablaSeleccionada();
        }


        private void GuardarMaquina()
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtCapacidad.Text))
            {
                MessageBox.Show("Complete Nombre y Capacidad.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtCapacidad.Text.Trim(), out int capacidad))
            {
                MessageBox.Show("Capacidad debe ser número entero.", "Advertencia",
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

        private void GuardarOrden()
        {
            if (string.IsNullOrWhiteSpace(txtIdOrden.Text) ||
                string.IsNullOrWhiteSpace(txtDescripcion.Text) ||
                string.IsNullOrWhiteSpace(txtIdMaquinaOP.Text) ||
                string.IsNullOrWhiteSpace(txtHoraTrabajo.Text))
            {
                MessageBox.Show("Complete todos los campos de la orden.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtIdMaquinaOP.Text.Trim(), out int idMaquina))
            {
                MessageBox.Show("Id Máquina debe ser número entero.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtHoraTrabajo.Text.Trim(), out int horas))
            {
                MessageBox.Show("Horas de Trabajo deben ser número entero.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!_ordenes.MaquinaExiste(idMaquina))
            {
                MessageBox.Show($"No existe una máquina con Id {idMaquina}.", "No encontrado",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_ordenes.Insertar(txtDescripcion.Text.Trim(), idMaquina, horas))
            {
                MessageBox.Show("Orden registrada correctamente.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCamposOrden();
            }
            else
            {
                MessageBox.Show("No se pudo registrar la orden.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarCamposOrden()
        {
            txtIdOrden.Clear();
            txtDescripcion.Clear();
            txtIdMaquinaOP.Clear();
            txtHoraTrabajo.Clear();
            txtIdOrden.Focus();
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            bool hayDatosMaquina = !string.IsNullOrWhiteSpace(txtIdMaquina.Text);
            bool hayDatosOrden = !string.IsNullOrWhiteSpace(txtIdOrden.Text);

            if (!hayDatosMaquina && !hayDatosOrden)
            {
                MessageBox.Show("Ingrese el Id de la máquina o de la orden a eliminar.",
                    "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (hayDatosMaquina)
                EliminarMaquina();
            else
                EliminarOrden();
        }

        private void EliminarMaquina()
        {
            if (string.IsNullOrWhiteSpace(txtIdMaquina.Text) ||
                string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtCapacidad.Text))
            {
                MessageBox.Show("Complete todos los campos de Máquina para eliminar\n" +
                                "(Id, Nombre y Capacidad).", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtIdMaquina.Text.Trim(), out int idMaquina))
            {
                MessageBox.Show("El Id Máquina debe ser un número entero.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!_maquinas.Existe(idMaquina))
            {
                MessageBox.Show($"No existe ninguna máquina con Id {idMaquina}.", "No encontrado",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show($"¿Eliminar la máquina con Id {idMaquina}?",
                    "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                != DialogResult.Yes) return;

            if (_maquinas.Eliminar(idMaquina))
            {
                MessageBox.Show("Máquina eliminada correctamente.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCamposRegistrar();
                ListarTablaSeleccionada();
            }
            else
            {
                MessageBox.Show(
        "No se pudo eliminar la máquina.\n\n" +
        "Puede que tenga órdenes de producción asociadas.\n" +
        "Eliminá primero las órdenes relacionadas.",
        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EliminarOrden()
        {
            if (string.IsNullOrWhiteSpace(txtIdOrden.Text) ||
                string.IsNullOrWhiteSpace(txtDescripcion.Text) ||
                string.IsNullOrWhiteSpace(txtIdMaquinaOP.Text) ||
                string.IsNullOrWhiteSpace(txtHoraTrabajo.Text))
            {
                MessageBox.Show("Complete todos los campos de la Orden para eliminar\n" +
                                "(Id Orden, Descripción, Id Máquina y Horas de Trabajo).", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtIdOrden.Text.Trim(), out int idOrden))
            {
                MessageBox.Show("El Id Orden debe ser un número entero.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!_ordenes.Existe(idOrden))
            {
                MessageBox.Show($"No existe ninguna orden con Id {idOrden}.", "No encontrado",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show($"¿Eliminar la orden con Id {idOrden}?",
                    "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                != DialogResult.Yes) return;

            if (_ordenes.Eliminar(idOrden))
            {
                MessageBox.Show("Orden eliminada correctamente.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCamposOrden();
                ListarTablaSeleccionada();
            }
            else
            {
                MessageBox.Show("No se pudo eliminar la orden.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }   // ← cierre de la clase, ya estaba
}       // ← cierre del namespace, ya estaba