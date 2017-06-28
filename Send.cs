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
    public partial class Send : Form
    {
        MySqlConnection conn = new MySqlConnection("Datasource=localhost; UserID=root; database=wallet");

        public Send()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string wAddress = walletAddress.Text;
            double toSend = Convert.ToDouble(sumToSend.Text), lastBitcoinValue = 0, newBitcoinValue;
            string paymentNote = this.paymentNote.Text;

            conn.Open();
            MySqlCommand savePayment = conn.CreateCommand();
            savePayment.CommandText = $"INSERT INTO payments (value, wallet, note) VALUES ('{toSend}', '{wAddress}', '{paymentNote}')";
            MySqlDataReader paymentReader = savePayment.ExecuteReader();
            paymentReader.Close();

            MySqlCommand loadBitcoin = conn.CreateCommand();
            loadBitcoin.CommandText = "SELECT value from bitcoin_balance ORDER by datetime DESC";
            MySqlDataReader reader = loadBitcoin.ExecuteReader();
            reader.Read();
            lastBitcoinValue = Convert.ToDouble(reader.GetString(0));

            //while (reader.Read())
            //{
            //    lastBitcoinValue = Convert.ToDouble(reader.GetString(0));
            //    break;
            //}
            reader.Close();

            newBitcoinValue = lastBitcoinValue - toSend;
            savePayment.CommandText = $"INSERT INTO bitcoin_balance (value) VALUES ('{newBitcoinValue}')";
            MySqlDataReader savePaymentReader = savePayment.ExecuteReader();
            savePaymentReader.Close();

            conn.Close();
            this.Close();
        }
    }
}
