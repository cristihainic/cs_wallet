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

namespace BitcoinWallet
{
    public partial class Transactions : Form
    {
        MySqlConnection conn = new MySqlConnection("DataSource=localhost; UserID = root; database=wallet");
        public Transactions()
        {
            InitializeComponent();
            fillList();
        }

        void fillList()
        {
            conn.Open();
            MySqlCommand fetchTransactions = conn.CreateCommand();
            fetchTransactions.CommandText = "SELECT wallet, id, value, note, datetime FROM payments ORDER BY datetime DESC";
            MySqlDataReader transactionReader = fetchTransactions.ExecuteReader();
            while (transactionReader.Read())
            {
                tList.Items.Add($"Transaction ID: {transactionReader["id"]} Date: {transactionReader["datetime"]} Wallet Address: {transactionReader["wallet"]} Comment: {transactionReader["note"]}");
            }
            transactionReader.Close();
            conn.Close();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Transactions_Load(object sender, EventArgs e)
        {

        }
    }
}
