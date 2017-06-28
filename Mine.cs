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
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
