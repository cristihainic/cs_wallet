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
    public partial class Form1 : Form
    {
        MySqlConnection conn = new MySqlConnection("Datasource=localhost; UserID=root; database=wallet");

        public Form1()
        {
            InitializeComponent();
            loadBalance();
        }

        void loadBalance()
        {
            conn.Open();
            MySqlCommand loadBitcoin = conn.CreateCommand();
            loadBitcoin.CommandText = "SELECT value from bitcoin_balance ORDER by datetime DESC";
            MySqlDataReader reader = loadBitcoin.ExecuteReader();
            reader.Read();
            balance.Text = reader.GetString(0);
            reader.Close();
            conn.Close();
            //while (reader.Read())
            //{
            //    balance.Text = reader.GetString(0);
            //}

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void transactionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void safelyCloseWalletToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void send_Click(object sender, EventArgs e)
        {
            Send send = new Send();
            send.ShowDialog();
        }

        private void mine_Click(object sender, EventArgs e)
        {
            Mine mine = new Mine();
            mine.ShowDialog();
        }

        private void balance_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            MySqlCommand loadBitcoin = conn.CreateCommand();
            loadBitcoin.CommandText = "SELECT value from bitcoin_balance ORDER by datetime DESC";
            MySqlDataReader reader = loadBitcoin.ExecuteReader();
            reader.Read();
            balance.Text = reader.GetString(0);
            reader.Close();
            conn.Close();
        }
    }
}
