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
    public partial class ManageReservation : Form
    {
        public ManageReservation()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void ManageReservation_Load(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void RefreshGrid()
        {
            SqlConnection conn = new SqlConnection("Data Source=HPELITEBOOK;Initial Catalog=bookingkrwao;Integrated Security=True");
            DataSet ds = new DataSet();
            DataSet ds1 = new DataSet();
            DataSet ds2 = new DataSet();
            SqlDataAdapter adpt = new SqlDataAdapter("Select * from rooms", conn);
            SqlDataAdapter adpt1 = new SqlDataAdapter("Select * from roomscategory", conn);
            SqlDataAdapter adpt2 = new SqlDataAdapter("Select * from reservations", conn);
            adpt.Fill(ds, "rooms");
            adpt1.Fill(ds1, "roomscategory");
            adpt2.Fill(ds2, "reservations");
            dataGridView1.DataSource = ds2.Tables["reservations"];

            reservationslist.DataSource = ds2.Tables["reservations"];
            reservationslist.ValueMember = "reserveid";

            comboBox1.DataSource = ds1.Tables["roomscategory"];
            comboBox1.ValueMember = "label";

            comboBox2.DataSource = ds1.Tables["roomscategory"];
            comboBox2.ValueMember = "category_id";
        }

        private void btn_addroom_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection("Data Source=HPELITEBOOK;Initial Catalog=bookingkrwao;Integrated Security=True");
                DataSet ds = new DataSet();
                SqlDataAdapter adpt = new SqlDataAdapter("Select * from reservations", conn);
                adpt.Fill(ds, "reservations");

                DataRow dr = ds.Tables["reservations"].NewRow();
                dr["roomNo"] = comboBox2.SelectedValue;
                dr["clientid"] = textBox1.Text;
                dr["datein"] = dateTimePicker1.Value;
                dr["dateout"] = dateTimePicker2.Value;

                ds.Tables["reservations"].Rows.Add(dr);
                SqlCommandBuilder build = new SqlCommandBuilder(adpt);
                adpt.Update(ds, "reservations");
                RefreshGrid();

                MessageBox.Show("reservations added Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void reservationslist_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection("Data Source=HPELITEBOOK;Initial Catalog=bookingkrwao;Integrated Security=True");
                DataSet ds = new DataSet();
                SqlDataAdapter adpt = new SqlDataAdapter("Select * from reservations where reserveid = '" + reservationslist.SelectedValue + "' ", conn);
                adpt.Fill(ds, "reservations");

                foreach (DataRow dr in ds.Tables["reservations"].Rows)
                {
                    comboBox2.SelectedValue = dr["roomNo"].ToString();
                    textBox1.Text = dr["clientid"].ToString();
                    textBox2.Text = dr["reserveid"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_editreservations_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection("Data Source=HPELITEBOOK;Initial Catalog=bookingkrwao;Integrated Security=True");
                DataSet ds = new DataSet();
                SqlDataAdapter adpt = new SqlDataAdapter("Select * from reservations where reserveid = '" + reservationslist.SelectedValue + "' ", conn);
                adpt.Fill(ds, "reservations");

                foreach (DataRow dr in ds.Tables["reservations"].Rows)
                {
                    dr["roomNo"] = comboBox2.SelectedValue;
                    dr["clientid"] = textBox1.Text;
                    dr["datein"] = dateTimePicker1.Value;
                    dr["dateout"] = dateTimePicker2.Value;
                    dr["reserveid"] = textBox2.Text;
                }

                SqlCommandBuilder buil = new SqlCommandBuilder(adpt);
                adpt.Update(ds, "reservations");
                RefreshGrid();

                MessageBox.Show("reservations edited Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_removereservations_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection("Data Source=HPELITEBOOK;Initial Catalog=bookingkrwao;Integrated Security=True");
                DataSet ds = new DataSet();
                SqlDataAdapter adpt = new SqlDataAdapter("Select * from reservations where reserveid = '" + reservationslist.SelectedValue + "' ", conn);
                adpt.Fill(ds, "reservations");

                foreach (DataRow dr in ds.Tables["reservations"].Rows)
                {
                    dr.Delete();
                }

                SqlCommandBuilder buil = new SqlCommandBuilder(adpt);
                adpt.Update(ds, "reservations");
                RefreshGrid();

                MessageBox.Show("reservations deleted Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_clearfield_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            comboBox1.SelectedValue = 0;
            comboBox2.SelectedValue = 0;
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;
        }
    }
}
