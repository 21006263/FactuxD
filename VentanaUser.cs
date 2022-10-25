
using MiLibreria;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FactuxD
{
    public partial class VentanaUser : FormBase
    {
       

        public VentanaUser() 
        {
            
            InitializeComponent();
        }

        private void VentanaUser_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void VentanaUser_Load(object sender, EventArgs e)
        {
            string cmd = "Select * FROM Usuario WHERE id_usuario= " + VentanaLogin.Codigo;

            DataSet ds = Utilidades.Ejecutar(cmd);

            lblNombre.Text = ds.Tables[0].Rows[0]["Nom_usu"].ToString();
            lblUsuario.Text = ds.Tables[0].Rows[0]["accoun"].ToString();
            lblCodigo.Text = ds.Tables[0].Rows[0]["id_usuario"].ToString();


#pragma warning disable CS8600 // Se va a convertir un literal nulo o un posible valor nulo en un tipo que no acepta valores NULL
            string url = ds.Tables[0].Rows[0]["Foto"].ToString();
#pragma warning restore CS8600 // Se va a convertir un literal nulo o un posible valor nulo en un tipo que no acepta valores NULL
            pictureBox1.Image = Image.FromFile(url!);
        }

        private void VentanaUser_Load_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ContenedoPrincipal ConP = new ContenedoPrincipal();
            this.Hide();
            ConP.Show();
        }
    }

    
}
