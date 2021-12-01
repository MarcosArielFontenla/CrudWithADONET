using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrudWithAdoNETFinal
{
    public partial class frmPersonas : Form
    {
        public frmPersonas()
        {
            InitializeComponent();
        }

        private void frmPersonas_Load(object sender, EventArgs e)
        {
            Refresh();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmNuevo frmNuevo = new frmNuevo();
            frmNuevo.ShowDialog();
            Refresh();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int? Id = GetId();

            if (Id != null)
            {
                frmNuevo frmNuevoEditar = new frmNuevo(Id);
                frmNuevoEditar.ShowDialog();
                Refresh();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int? Id = GetId();

            try
            {
                if (Id != null)
                {
                    PersonasDb objPersonaDb = new PersonasDb();
                    objPersonaDb.Eliminar((int)Id);
                    Refresh();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error al eliminar: " + ex.Message);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Refresh()
        {
            PersonasDb objPersonasDb = new PersonasDb();
            dgvPersonas.DataSource = objPersonasDb.Get();
        }

        #region "Helper"
        private int? GetId()
        {
            try
            {
                return int.Parse(dgvPersonas.Rows[dgvPersonas.CurrentRow.Index].Cells[0].Value.ToString());

            }
            catch
            {
                return null;
            }

        }
        #endregion
    }
}
