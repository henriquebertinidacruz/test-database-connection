using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace test_database_connection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private MySqlConnection connection;

        private void Form1_Load(object sender, EventArgs e)
        {
            lblStatus.Text = "Current Status: Disconnected";
            lblStatus.BackColor = Color.LightGray;
            lblStatus.ForeColor = Color.White;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Database=test;User ID=root;Password=;";
            connection = new MySqlConnection(connectionString);

            try
            {
                connection.Open();
                lblStatus.Text = "Current Status: Connected";
                lblStatus.BackColor = Color.LightGreen;
                lblStatus.ForeColor = Color.White;
            }
            catch (Exception ex)
            {
                lblStatus.Text = "Current Status: Error";
                lblStatus.BackColor = Color.Tomato;
                lblStatus.ForeColor = Color.White;
            }
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            if (connection != null)
            {
                lblStatus.Text = "Current Status: Disconnected";
                lblStatus.BackColor = Color.Tomato;
                lblStatus.ForeColor = Color.White;
            }
            else
            {
                lblStatus.Text = "Current Status: Already Disconnected";
                lblStatus.BackColor = Color.LightGray;
                lblStatus.ForeColor = Color.White;
            }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
