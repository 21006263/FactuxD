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
    public partial class VentanaAdmin : FormBase
    {
        public VentanaAdmin()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
          
        ForeColor = Color.White;
        }

        private void VentanaAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void VentanaAdmin_Load(object sender, EventArgs e)
        {
            string cmd = "Select * FROM Usuario WHERE id_usuario= " + VentanaLogin.Codigo;

            DataSet ds = Utilidades.Ejecutar(cmd);

            lblAdmin.Text = ds.Tables[0].Rows[0]["Nom_usu"].ToString();
            lblUserAdmin.Text = ds.Tables[0].Rows[0]["accoun"].ToString();
            lblCodigo.Text = ds.Tables[0].Rows[0]["id_usuario"].ToString();


#pragma warning disable CS8600 // Se va a convertir un literal nulo o un posible valor nulo en un tipo que no acepta valores NULL
            string url = ds.Tables[0].Rows[0]["Foto"].ToString();
#pragma warning restore CS8600 // Se va a convertir un literal nulo o un posible valor nulo en un tipo que no acepta valores NULL
            pictureBox1.Image = Image.FromFile(url!);

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
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
