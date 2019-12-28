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
    public partial class ManageRooms : Form
    {
        public ManageRooms()
        {
            InitializeComponent();
        }

        private void btn_addroom_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection("Data Source=HPELITEBOOK;Initial Catalog=bookingkrwao;Integrated Security=True");
                DataSet ds = new DataSet();
                SqlDataAdapter adpt = new SqlDataAdapter("Select * from rooms", conn);
                adpt.Fill(ds, "rooms");

                DataRow dr = ds.Tables["rooms"].NewRow();
                dr["roomNo"] = textBox1.Text;
                dr["roomtype"] = comboBox1.SelectedValue;
                dr["phone"] = textBox3.Text;
                dr["free"] = ((radioYes.Checked) ? "Yes" : "No");

                ds.Tables["rooms"].Rows.Add(dr);
                SqlCommandBuilder build = new SqlCommandBuilder(adpt);
                adpt.Update(ds, "rooms");
                RefreshGrid();

                MessageBox.Show("Room added Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

    private void ManageRooms_Load(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void RefreshGrid()
        {
            SqlConnection conn = new SqlConnection("Data Source=HPELITEBOOK;Initial Catalog=bookingkrwao;Integrated Security=True");
            DataSet ds = new DataSet();
            DataSet ds1 = new DataSet();
            SqlDataAdapter adpt = new SqlDataAdapter("Select * from rooms", conn);
            SqlDataAdapter adpt1 = new SqlDataAdapter("Select * from roomscategory", conn);
            adpt.Fill(ds, "rooms");
            adpt1.Fill(ds1, "roomscategory");
            dataGridView1.DataSource = ds.Tables["rooms"];

            roomnames.DataSource = ds.Tables["rooms"];
            roomnames.ValueMember = "roomNo";

            comboBox1.DataSource = ds1.Tables["roomscategory"];
            comboBox1.DisplayMember = "label";
            comboBox1.ValueMember = "category_id";
        }

        private void btn_editroom_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection("Data Source=HPELITEBOOK;Initial Catalog=bookingkrwao;Integrated Security=True");
                DataSet ds = new DataSet();
                SqlDataAdapter adpt = new SqlDataAdapter("Select * from rooms where roomNo = '" + roomnames.SelectedValue + "' ", conn);
                adpt.Fill(ds, "rooms");

                foreach (DataRow dr in ds.Tables["rooms"].Rows)
                {
                    dr["roomNo"] = textBox1.Text;
                    dr["roomtype"] = comboBox1.SelectedValue;
                    dr["phone"] = textBox3.Text;
                    dr["free"] = ((radioYes.Checked) ? "Yes" : "No");

                }

                SqlCommandBuilder buil = new SqlCommandBuilder(adpt);
                adpt.Update(ds, "rooms");
                RefreshGrid();

                MessageBox.Show("Room edited Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void roomnames_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection("Data Source=HPELITEBOOK;Initial Catalog=bookingkrwao;Integrated Security=True");
                DataSet ds = new DataSet();
                SqlDataAdapter adpt = new SqlDataAdapter("Select * from rooms where roomNo = '" + roomnames.SelectedValue + "' ", conn);
                adpt.Fill(ds, "rooms");

                foreach (DataRow dr in ds.Tables["rooms"].Rows)
                {
                    textBox1.Text = dr["roomNo"].ToString();
                    comboBox1.SelectedValue = dr["roomtype"].ToString();
                    textBox3.Text = dr["phone"].ToString();
                    if (dr["free"].ToString() == "Yes")
                        radioYes.Checked = true;
                    else
                        radioNo.Checked = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_clearfield_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox3.Text = "";
        }

        private void btn_removeroom_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection("Data Source=HPELITEBOOK;Initial Catalog=bookingkrwao;Integrated Security=True");
                DataSet ds = new DataSet();
                SqlDataAdapter adpt = new SqlDataAdapter("Select * from rooms where roomNo = '" + roomnames.SelectedValue + "' ", conn);
                adpt.Fill(ds, "rooms");

                foreach (DataRow dr in ds.Tables["rooms"].Rows)
                {
                    dr.Delete();
                }

                SqlCommandBuilder buil = new SqlCommandBuilder(adpt);
                adpt.Update(ds, "rooms");
                RefreshGrid();

                MessageBox.Show("Room deleted Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
