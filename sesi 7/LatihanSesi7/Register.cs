using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LatihanSesi7
{
    public partial class Register : Form
    {
        Config db = new Config();
        public Register()
        {
            InitializeComponent();
            db.Connect("userdata");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.Show();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            db.Execute("INSERT INTO user_info (id,name,username,password) VALUES (NULL,'"+textName.Text+"','"+textUsername.Text+"','"+textPassword.Text+"')");
            MessageBox.Show("Data berhasil disimpan !");
            this.Close();
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }
    }
}
