using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TodoPlast;

namespace pryPereiroSP3ER
{
    public partial class frmPrincipal : Form
    {
        private ConexionDB _db;
        public frmPrincipal()
        {
            InitializeComponent();
            _db = new ConexionDB(statusStrip1);
        }


        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            _db.Abrir();   // → muestra "● Conectado" en verde
        }

        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            _db.Cerrar();  // → muestra "● Desconectado" en gris
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }


    }
}
