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

namespace INSURANCES
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private MySqlConnectionStringBuilder conexaoBanco()
        {
            MySqlConnectionStringBuilder conexaoBD = new MySqlConnectionStringBuilder ();
            conexaoBD.Server = "localhost" ;
            conexaoBD.Database = "insurance" ;
            conexaoBD.UserID = "root" ;
            conexaoBD.Password = "" ;
            conexaoBD.SslMode = 0;
            return conexaoBD ;

        }

        private void atualizaGrid()
        {
            MySqlConnectionStringBuilder conexaoBD = conexaoBanco();
            MySqlConnection realizaConexacoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizaConexacoBD.Open();

                MySqlCommand comandoMySql = realizaConexacoBD.CreateCommand();
                comandoMySql.CommandText = " SELECT * FROM insurance";
                MySqlDataReader reader = comandoMySql.ExecuteReader();

                dginsurance.Rows.Clear();

                while(reader.Read())
                {
                    DataGridViewRow row = (DataGridViewRow)dginsurance.Rows[0].Clone(); // FAZ UM CAST E CLONA A LINHA DA TABELA
                    row.Cells[0].Value = reader.GetInt32(0); // ID
                    row.Cells[1].Value = reader.GetString(1); // NOME
                    row.Cells[2].Value = reader.GetString(2); // CPF
                    row.Cells[3].Value = reader.GetString(3); // SEGURADORA
                    row.Cells[4].Value = reader.GetString(4); // ATIVO
                    dginsurance.Rows.Add(row); 
                }

                realizaConexacoBD.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(" sem conexão! ");
                Console.WriteLine(ex.Message);
            }
        }

        private void limpar() 
        {


        }   


        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void LIMPAR_Click(object sender, EventArgs e)
            //limpar
        {
          
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btALTERAR_Click(object sender, EventArgs e)
        {

        }

        private void brEXCLUIR_Click(object sender, EventArgs e)
        {

        }

        private void btSALVAR_Click(object sender, EventArgs e)
        {

        }
    }
}
