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
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=HPELITEBOOK;Initial Catalog=bookingkrwao;Integrated Security=True");
            DataSet ds = new DataSet();
            SqlDataAdapter adpt = new SqlDataAdapter("Select * from user_registration",conn);
            adpt.Fill(ds, "user_registration");

            DataRow dr = ds.Tables["user_registration"].NewRow();
            dr["username"] = textBox1.Text;
            dr["password"] = textBox2.Text;

            ds.Tables["user_registration"].Rows.Add(dr);
            SqlCommandBuilder build = new SqlCommandBuilder(adpt);
            adpt.Update(ds, "user_registration");

            MessageBox.Show("User created Successfully");

            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loginForm form = new loginForm();
            form.Show();
            this.Hide();
        }
    }
}
