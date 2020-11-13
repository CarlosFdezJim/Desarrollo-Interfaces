using ConexionMySQL.agendaDataSetTableAdapters;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConexionMySQL
{
    public partial class Form1 : Form
    {
        static MySqlConnection Conex = new MySqlConnection();
        static string serv = "Server=localhost;";
        static string db = "Database=agenda;";
        static string usuario = "UriIdnScope=root;";
        static string pwd = "";
        string CadenaDeConexion = serv + db + usuario + pwd;
        public void Conectar()
        {
            try
            {
                Conex.ConnectionString = CadenaDeConexion;
                Conex.Open();
                MessageBox.Show("La BD está ahora conectada");
            }
            catch
            {
                MessageBox.Show("Ocurrio un error al conectar a la BD");
                throw;
            }
        }

        public static void Desconectar()
        {
            Conex.Close();
        }
    
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'agendaDataSet.contactos' Puede moverla o quitarla según sea necesario.
            this.contactosTableAdapter.Fill(this.agendaDataSet.contactos);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonInsertar_Click(object sender, EventArgs e)
        {
            this.contactosTableAdapter.InsertarDatos(ID, nombre, apellido, telefono, direccion , cp, poblacion);
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
