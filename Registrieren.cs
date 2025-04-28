using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginSystem2024
{
    public partial class Registrieren : Form
    {
        private SqlConnection cn;

        public Registrieren()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Registrieren_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\guhde\source\repos\LoginSystem2024\Datenbank.mdf;Integrated Security=True");
            cn.Open();
        }

        private void registrieren_button_Click(object sender, EventArgs e)
        {
            
        }

        private void linkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
        }

        private void textBenutzername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
