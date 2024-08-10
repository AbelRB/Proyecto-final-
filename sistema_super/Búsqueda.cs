using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace sistema_super
{
    public partial class Búsqueda : Form
    {
        //Variables globales;
        MySqlCommand comand;
        MySqlConnection vConexion;
        MySqlDataAdapter vAdapter;
        DataTable vTabla;
        public Búsqueda()
        {
            InitializeComponent();
        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            String servidor = "datasource=127.0.0.1; port = 3306; username=root; password=2323; database=db_super";
            vConexion = new MySqlConnection(servidor);
            string buscarid = "select * from clientes where idclientes = " + idbuscar.Text;
            comand = new MySqlCommand(buscarid, vConexion);
            vConexion.Open();
            //Método que ejecuta la sentencia
            comand.ExecuteNonQuery();

            vAdapter = new MySqlDataAdapter();

            vAdapter.SelectCommand = comand;
            vTabla = new DataTable();
            vAdapter.Fill(vTabla);
            Clientes ob = new Clientes();
            resultadoBuscar.DataSource = vTabla;
            
            
        }

        private void volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void idbuscar_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
