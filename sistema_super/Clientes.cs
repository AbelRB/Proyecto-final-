using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace sistema_super
{
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            datagridclientes.Columns[4].Width = 100;
        }

        private void add_Click(object sender, EventArgs e)
        {
            Registro vAgrega = new Registro();
            vAgrega.actualizarregistro.Enabled = false;
            vAgrega.Show();
            datagridclientes.Refresh();
            this.Close();
            
        }

        private void delete_Click(object sender, EventArgs e)
        {
            Eliminar drop = new Eliminar();
            drop.Show();
            this.Close();
        }

        private void update_Click(object sender, EventArgs e)
        {
            Registro nuevo = new Registro();
            nuevo.Aceptar_Btn.Enabled = false;
            nuevo.Show();
            this.Close();
        }

        private void search_Click(object sender, EventArgs e)
        {
            Búsqueda b1 = new Búsqueda();
            b1.Show();
        }
    }
}
