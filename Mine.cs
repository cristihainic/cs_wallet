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
    public partial class Mine : Form
    {
        MySqlConnection conn = new MySqlConnection("Datasource=localhost; UserID=root; database=wallet");

        public Mine()
        {
            InitializeComponent();
            minedBitcoins.Text = "0.00000000";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // BTC value save logic
            double currentValue;
            double newValue;
            conn.Open();
            MySqlCommand insertBTCValue = conn.CreateCommand();
            insertBTCValue.CommandText = "SELECT value from bitcoin_balance ORDER by datetime DESC LIMIT 1";
            MySqlDataReader execute = insertBTCValue.ExecuteReader();
            execute.Read();
            currentValue = Convert.ToDouble(execute.GetString(0));
            execute.Close();

            newValue = currentValue + Convert.ToDouble(minedBitcoins.Text);
            insertBTCValue.CommandText = $"INSERT into bitcoin_balance (value) VALUES ('{newValue}')";
            MySqlDataReader execute2 = insertBTCValue.ExecuteReader();
            execute2.Read();
            execute2.Close();
            conn.Close();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //double earnings = Convert.ToDouble(minedBitcoins.Text);
            //var timer = new Timer();
            //timer.Interval = 4000;
            //timer.Elapsed += (s,e)  =>
            //    {

            //    }
            //for (int i = 0; i < 999999999; i++)
            //{
            //    timer.Interval = 4000;
            //    timer.Start();
            //    earnings += 0.00000009;
            //    minedBitcoins.Text = Convert.ToString(earnings);
            //    minedBitcoins.Show();
            //    //System.Threading.Thread.Sleep(3000);
            //    //earnings += 0.00000005;
            //    //minedBitcoins.Text = Convert.ToString(earnings);
            //    //minedBitcoins.Show();
            //}
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            double i = Convert.ToDouble(minedBitcoins.Text);
            i += 0.00000009;
            minedBitcoins.Text = i.ToString("F8");
        }
    }
}
