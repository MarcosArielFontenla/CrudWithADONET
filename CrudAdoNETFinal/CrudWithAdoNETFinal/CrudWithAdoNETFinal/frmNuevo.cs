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
    public partial class frmNuevo : Form
    {
        private int? Id;

        public frmNuevo(int? Id = null)
        {
            InitializeComponent();
            this.Id = Id;

            if (this.Id != null)
                CargarDatos();
        }

        private void frmNuevo_Load(object sender, EventArgs e)
        {
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            PersonasDb objPersonasDb = new PersonasDb();

            try
            {
                if (Id == null)
                    objPersonasDb.Agregar(txtNombre.Text, txtApellido.Text, txtDireccion.Text, int.Parse(txtEdad.Text));
                else
                    objPersonasDb.Editar(txtNombre.Text, txtApellido.Text, txtDireccion.Text, int.Parse(txtEdad.Text), (int)Id);

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }
        }

        private void btnSalirNuevo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CargarDatos()
        {
            PersonasDb objPersonaDb = new PersonasDb();
            Personas objPersona = objPersonaDb.Get((int)Id);
            txtNombre.Text = objPersona.Nombre;
            txtApellido.Text = objPersona.Apellido;
            txtDireccion.Text = objPersona.Direccion;
            txtEdad.Text = objPersona.Edad.ToString();
        }
    }
}
