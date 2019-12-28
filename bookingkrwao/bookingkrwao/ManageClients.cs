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
    public partial class ManageClients : Form
    {
        public ManageClients()
        {
            InitializeComponent();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void btn_addclient_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection("Data Source=HPELITEBOOK;Initial Catalog=bookingkrwao;Integrated Security=True");
                DataSet ds = new DataSet();
                SqlDataAdapter adpt = new SqlDataAdapter("Select * from clients", conn);
                adpt.Fill(ds, "clients");

                DataRow dr = ds.Tables["clients"].NewRow();
                dr["id"] = textBox1.Text;
                dr["firstname"] = textBox2.Text;
                dr["lastname"] = textBox3.Text;
                dr["phone"] = textBox4.Text;

                ds.Tables["clients"].Rows.Add(dr);
                SqlCommandBuilder build = new SqlCommandBuilder(adpt);
                adpt.Update(ds, "clients");
                RefreshGrid();

                MessageBox.Show("Client added Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void ManageClients_Load(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void RefreshGrid()
        {
            SqlConnection conn = new SqlConnection("Data Source=HPELITEBOOK;Initial Catalog=bookingkrwao;Integrated Security=True");
            DataSet ds = new DataSet();
            SqlDataAdapter adpt = new SqlDataAdapter("Select * from clients", conn);
            adpt.Fill(ds, "clients");
            dataGridView1.DataSource = ds.Tables["clients"];

            clientnames.DataSource = ds.Tables["clients"];
            clientnames.DisplayMember = "firstname";
            clientnames.ValueMember = "id";
        }

        private void btn_editclient_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection("Data Source=HPELITEBOOK;Initial Catalog=bookingkrwao;Integrated Security=True");
                DataSet ds = new DataSet();
                SqlDataAdapter adpt = new SqlDataAdapter("Select * from clients where id = '" + clientnames.SelectedValue + "' ", conn);
                adpt.Fill(ds, "clients");

                foreach (DataRow dr in ds.Tables["clients"].Rows)
                {
                    dr["id"] = textBox1.Text;
                    dr["firstname"] = textBox2.Text;
                    dr["lastname"] = textBox3.Text;
                    dr["phone"] = textBox4.Text;
                }

                SqlCommandBuilder buil = new SqlCommandBuilder(adpt);
                adpt.Update(ds, "clients");
                RefreshGrid();

                MessageBox.Show("Client edited Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_removeclient_Click(object sender, EventArgs e)
            {
                try
                {
                    SqlConnection conn = new SqlConnection("Data Source=HPELITEBOOK;Initial Catalog=bookingkrwao;Integrated Security=True");
                    DataSet ds = new DataSet();
                    SqlDataAdapter adpt = new SqlDataAdapter("Select * from clients where id = '" + clientnames.SelectedValue + "' ", conn);
                    adpt.Fill(ds, "clients");

                    foreach (DataRow dr in ds.Tables["clients"].Rows)
                    {
                        dr.Delete();
                    }

                    SqlCommandBuilder buil = new SqlCommandBuilder(adpt);
                    adpt.Update(ds, "clients");
                    RefreshGrid();

                    MessageBox.Show("Client deleted Successfully");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void clientnames_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection("Data Source=HPELITEBOOK;Initial Catalog=bookingkrwao;Integrated Security=True");
                DataSet ds = new DataSet();
                SqlDataAdapter adpt = new SqlDataAdapter("Select * from clients where id = '" + clientnames.SelectedValue + "' ", conn);
                adpt.Fill(ds, "clients");

                foreach(DataRow dr in ds.Tables["clients"].Rows)
                {
                    textBox1.Text = dr["id"].ToString();
                    textBox2.Text = dr["firstname"].ToString();
                    textBox3.Text = dr["lastname"].ToString();
                    textBox4.Text = dr["phone"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
    }

