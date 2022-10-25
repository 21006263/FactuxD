using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MiLibreria;

namespace FactuxD
{
    public partial class ManetenimientoProductos : Mantenimiento
    {
        public ManetenimientoProductos()
        {
            InitializeComponent();
        }



        public override Boolean Guardar()
        {
          if(Utilidades.ValidarFormulario(this, errorProvider1)== false)
            {
                try
                {
                    string cmd = string.Format("EXEC ActualizarArticulos '{0}', '{1}', '{2}'", txtIdPro.Text.Trim(), txtNomPro.Text.Trim(), txtPrecioPro.Text.Trim());
                    Utilidades.Ejecutar(cmd);
                    MessageBox.Show("Se ha guardado correctamente");
                    return true;
                }
                catch (Exception error)
                {
                    MessageBox.Show("Ha ocurrido un error" + error.Message);
                    return false;
                }
            }
          else
            {
                return false;
            }
        }


        public override void Eliminar()
        {
            try
            {
                string cmd = string.Format("EXEC EliminarArticulos '{0}'", txtIdPro.Text.Trim());
                Utilidades.Ejecutar(cmd);
                MessageBox.Show("Se ha eliminado");
            }
            catch (Exception error)
            {
                MessageBox.Show("ha ocurrido un problema" + error.Message);
            }
        }

        private void txtIdPro_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }
    }

    }

