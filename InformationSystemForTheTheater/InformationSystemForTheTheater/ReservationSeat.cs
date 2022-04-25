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

namespace InformationSystemForTheTheater
{
    public partial class ReservationSeat : Form
    {
        public ReservationSeat()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(DateTime.Now.ToShortDateString() + ", " + DateTime.Now.ToLongTimeString());
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int starting_price, x,x1;
            starting_price = 200;
            x = System.Convert.ToInt32(comboBox1.Text);
            if ((x > 4) && (x < 9))
                starting_price += 200;
            x1 = System.Convert.ToInt32(comboBox2.Text);
            if ((x1 > 10) && (x1 < 20))
                starting_price += 200;
            label5.Text = (starting_price.ToString())+"р.";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            
            MySqlCommand command = new MySqlCommand ("INSERT INTO theater (hall, row, seat, staging) VALUES('comboBox4', 'comboBox1', 'comboBox2', 'comboBox3')", db.getConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 1)
            {
                MessageBox.Show("Забронировано");
            }
            else
                MessageBox.Show("Некорректный ввод");

            db.openConnection();
            db.closeConnection();
        }
    }
}
