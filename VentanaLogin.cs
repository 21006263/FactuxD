



using MiLibreria;
using System.Data;

namespace FactuxD
{
    public partial class VentanaLogin : FormBase
    {
        public VentanaLogin()
        {
            InitializeComponent();
        }


        public static string Codigo = "";

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {

               string CMD = string.Format("Select * FROM Usuario WHERE accoun = '{0}' AND password = '{1}'", txtNomAcc.Text.Trim(), txtPass.Text.Trim());



             DataSet ds = Utilidades.Ejecutar(CMD);


#pragma warning disable CS8602 // Desreferencia de una referencia posiblemente NULL.
                Codigo  = ds.Tables[0].Rows[0]["id_usuario"].ToString().Trim();
#pragma warning restore CS8602 // Desreferencia de una referencia posiblemente NULL.


#pragma warning disable CS8602 // Desreferencia de una referencia posiblemente NULL.

                string cuenta = ds.Tables[0].Rows[0]["accoun"].ToString().Trim();

                string v = ds.Tables[0].Rows[0]["password"].ToString().Trim();

#pragma warning restore CS8602 // Desreferencia de una referencia posiblemente NULL.
                string contra = v;


                if (cuenta == txtNomAcc.Text.Trim() && contra == txtPass.Text.Trim())
                {
                    // MessageBox.Show("se ha iniciado ");
                    if (Convert.ToBoolean(ds.Tables[0].Rows[0]["Status_admin"]) == true)
                    {
                        VentanaAdmin VenAdmin = new VentanaAdmin();
                        this.Hide();
                       VenAdmin.Show();
                    }
                    else
                    {
                        VentanaUser VenUser = new VentanaUser();
                        this.Hide();
                        VenUser.Show();
                    }


                }
             

            }
            catch(Exception)
            {
                MessageBox.Show("Usuario o password incorrecta!..");
            }


         



            /*
            try
            {
                //SqlAlreadyFilledException con = new SqlAlreadyFilledException();
                // SqlConnectionStringBuilder con = new SqlConnectionStringBuilder();
                SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=Administracion;Integrated Security=True");
               conn.Open();
                MessageBox.Show("Se ha conectado!..");

            }
            catch(Exception error)
            {
                MessageBox.Show("Ha ocurrido un error" + error);
            }
            */


            //  Utilidades.Ejecutar("Select * FROM Cliente Where id = 1 ");


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNomAcc_TextChanged(object sender, EventArgs e)
        {

        }

        private void VentanaLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void VentanaLogin_Load(object sender, EventArgs e)
        {

        }
    }
}