using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace bookingkrwao
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection("Data Source=HPELITEBOOK;Initial Catalog=bookingkrwao;Integrated Security=True");
                string query = "Select * from user_registration Where username = '" + textBox1.Text.Trim() + "'and password = '" + textBox2.Text + "'";
                SqlDataAdapter adpt = new SqlDataAdapter(query, conn);
                DataSet ds = new DataSet();
                adpt.Fill(ds);
                if (ds.Tables[0].Rows.Count != 0)
                {
                    MainForm mf = new MainForm();
                    this.Hide();
                    mf.Show();
                }
                else
                {
                    MessageBox.Show("Invalid username or password");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_reg_Click(object sender, EventArgs e)
        {
            RegistrationForm form = new RegistrationForm();
            form.Show();
            this.Hide();
        }
    }
}
