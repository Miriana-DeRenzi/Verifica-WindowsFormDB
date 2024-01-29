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

namespace Verifica_WindowsFormDB
{
    public partial class Form2 : Form
    {
        public string id_codice;
        public Form2(string id)
        {
            InitializeComponent();
           id_codice = id;

        }

        private void dataGridViewForm2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {}

       
        public void PopolaForm2()
        {

            string ConnectionString = "server=127.0.0.1;" +
                                      "database= archiviocomponenti;" +
                                      "uid=Miriana;" +
                                      "pwd=Miriana";
           

            MySqlConnection connessione = new MySqlConnection(ConnectionString);

            try
            {
                 connessione.Open();

                string query = "SELECT * FROM lista";

                MySqlCommand cmd = new MySqlCommand(query, connessione);
                MySqlDataReader dr = cmd.ExecuteReader();
                   
                    dr.Read();
                    textBox1.Text = dr.GetString("CodiceFarnell");
                    textBox2.Text = dr.GetString("Descrizione");
                    textBox1.Text = dr.GetString("Produttore");
                    textBox2.Text = dr.GetString("CodiceProduttore");
                    textBox1.Text = dr.GetString("Quantità");
                    textBox2.Text = dr.GetString("Prezzo");

                    dr.Close();

                    connessione.Close();
                

            }
            catch
            {
                MessageBox.Show("Connessione fallita");

            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonSalva_Click(object sender, EventArgs e)
        {

            string ConnectionString = "server=127.0.0.1;" +
                                      "database=;archiviocomponenti" +
                                      "uid=Miriana;" +
                                      "pwd=Miriana";
             
            MySqlConnection connessione = new MySqlConnection(ConnectionString);
            try
            {
                connessione.Open();

                string query = $"UPDATE lista " +
                $"SET " +
                $"CodiceFarnell = '{textBox2.Text}', " +
                $"Descrizione = '{textBox3.Text}', " +
                $"Produttore = '{textBox4.Text}', " +
                $"CodiceProduttore = '{textBox5.Text}', " +
                $"Quantità = '{textBox6.Text}', " +
                $"Prezzo = '{textBox7.Text}', " +

                $"WHERE id = {id_codice}";


                MySqlCommand cmd = new MySqlCommand(query, connessione);
                cmd.ExecuteNonQuery();

                connessione.Close();
            }
            catch
            {
                MessageBox.Show("Impossibile connettersi");
            }

            this.Close();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }   
}
