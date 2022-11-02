using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Devart.Data.MySql;

namespace fredo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            main ss = new main();
            ss.Show();
             
       

            DB db = new DB();

            string USERNAME = txtusername.Text;
            string PASSWORD = txtpass.Text;
            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `mysqlfredo` WHERE 'USERNAME' = @USER  and 'PASSWORD' = @PASS", db.getConnection());
            command.Parameters.Add("@USER", MySqlType.VarChar).MySqlValue = USERNAME;
            command.Parameters.Add("@PASS", MySqlType.VarChar).MySqlValue = PASSWORD;

            adapter.SelectCommand = command;


            //_adapter.Fill(table);

            if (table.Rows.Count > 1)
            {
                MessageBox.Show("YES");
            }

            else
            {
                MessageBox.Show("invalid");
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {


        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox1.Checked)
            {
                txtpass.UseSystemPasswordChar = false;

            }
            else
            {
                txtpass.UseSystemPasswordChar = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {




            txtusername.Text = "";
            txtpass.Text = "";


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {


            // panel1.BackgroundImage = Properties.Resources.ku;
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
