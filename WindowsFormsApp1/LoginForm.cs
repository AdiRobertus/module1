using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Username atau Password tidak boleh kosong");
                return;
            }

            DataSet ds = DB.Login(textBox1.Text, textBox2.Text);

            if (ds.Tables[0].Rows.Count < 1 )
            {
                MessageBox.Show("Login Failed");
                return;
            }

            int job = ds.Tables[0].Rows[0].Field<int>("JobID");

            MainForm mf = new MainForm(job);

            this.Hide();
            mf.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
