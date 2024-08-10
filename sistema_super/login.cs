using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace sistema_super
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection vConn = new MySqlConnection("datasource=127.0.0.1; port = 3306; username=root; password=2323; database=db_super");

            vConn.Open();

            Form1 f1 = new Form1();

            string username = user.Text;
            string password=pass.Text;

            string query = "select nombre, contraseñas from usuarios where nombre='" + username + "' AND contraseñas='" + password + "' ";
            MySqlCommand cmd = new MySqlCommand(query, vConn);
            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                this.Hide();
                MessageBox.Show("Bienvenido al sistema " + username);
                f1.Show();
            }
            else
            {
                mensaje.Text = "El usuario y la contraseña son incorretos";
            }
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Salir?", "Esta apunto de salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void mostrarOcultar_CheckedChanged(object sender, EventArgs e)
        {
            if (mostrarOcultar.Checked == true)
            {
                if (pass.PasswordChar=='*')
                {
                    pass.PasswordChar = '\0';
                }
            }
            else
            {
                pass.PasswordChar = '*';
            }
        }

       
    }
}
