using MySql.Data.MySqlClient;

namespace Verifica_WindowsFormDB
{
    public partial class Form1 : Form
    {

        string ConnectionString = "server=127.0.0.1;" +
                                  "database= archiviocomponenti;" +
                                  "uid=Miriana;" +
                                  "pwd=Miriana";
        public Form1()
        {
            InitializeComponent();
            PopolaForm1();
        }

        private void Form1_Load(object sender, EventArgs e)
        {}

        public void PopolaForm1()
        {

            MySqlConnection connessione = new MySqlConnection(ConnectionString);

            try
            {
                connessione.Open();
                string query = "SELECT * FROM lista";
                MySqlCommand cmd = new MySqlCommand(query, connessione);
                MySqlDataReader dr = cmd.ExecuteReader();
                while(dr.Read())
                {
                    dataGridViewForm1.Rows.Add(
                        dr.GetInt32("Id").ToString(),
                        dr.GetInt32("CodiceFarnell").ToString(),
                        dr.GetString("CodiceProduttore"),
                        dr.GetInt32("Quantità").ToString(),
                        dr.GetString("Prezzo"));
                }

                connessione.Close();
            }
            catch
            {
                MessageBox.Show("Connessione fallita");

            }
        }


        public void Ricerca()
        {
            string scrivi = textBoxCerca.Text;


            string query = $"SELECT * FROM lista WHERE CodiceFarnell LIKE '%{scrivi}%'" +
               $"OR CodiceProduttore LIKE '%{scrivi}%'" +
               $"OR Quantità LIKE '%{scrivi}%'" +
               $"OR Prezzo LIKE '%{scrivi}%'";
        }


        private void dataGridViewForm1_cellDoubleClick(object sender, DataGridViewCellEventArgs e )
        {
            string id = dataGridViewForm1.CurrentRow.Cells[0].Value.ToString();
            Form2 form2 = new Form2(id);

            form2.ShowDialog();

        }


    }
}