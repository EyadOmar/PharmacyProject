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


namespace Pharmacy
{
    public partial class SalesOrder : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=pharmacy;Integrated Security=True");
        SqlDataAdapter da;
        DataTable dt = new DataTable();
        SqlCommand cmd;
        int ID = 0;

        public void showData()
        {
            da = new SqlDataAdapter("select * from orders", con);
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }
        public void emptyTextBoxs()
        {
            textBox1.Text = String.Empty;
            textBox2.Text = String.Empty;
            textBox3.Text = String.Empty;
            textBox4.Text = String.Empty;
            textBox5.Text = String.Empty;
            textBox6.Text = String.Empty;
        }
        public SalesOrder()
        {
            InitializeComponent();
        }
        private void SalesOrder_Load(object sender, EventArgs e)
        {
            showData();
        }

        
        //buttons
        //Insert button
        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            try
            {
                string insertCmd = "insert into orders values("+textBox1.Text+", "+ textBox2.Text + ", "+ textBox3.Text + ",'"+ textBox5.Text + "', "+ textBox4.Text + ");";
                cmd = new SqlCommand(insertCmd, con);
                cmd.ExecuteNonQuery();

                string selectCmd = @"select  c.client_Name, c.client_Phone, c.client_Address, m.medicin_name, o.quantity 
                    from orders as o, clients as c, medicines as m
                    where
                    o.client_id = c.client_ID and
                    o.medicine_id = m.medicine_id and
                    o.client_id = "+ textBox3.Text +@"and
                    o.medicine_id = "+ textBox2.Text; // select query for order report
                SqlCommand orderCmd = new SqlCommand(selectCmd, con);
                SqlDataReader dr = orderCmd.ExecuteReader();
                while (dr.Read())
                {
                    MessageBox.Show(@"Client Name: " + dr["client_Name"].ToString() +
                        "\nClient Phone: " + dr["client_Phone"].ToString() +
                        "\nClient Address: " + dr["client_Address"].ToString() +
                        "\nordered: " +dr["quantity"].ToString() + " x " + dr["medicin_name"].ToString() +
                        "\ntotal: " + textBox6.Text + " LE"
                        ,"Order Report", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                }
                dr.Close();

                dt.Rows.Clear();
                showData();
                MessageBox.Show("Passed Successfully!", "Order Report", MessageBoxButtons.OK, MessageBoxIcon.Information);
                emptyTextBoxs();
            }
            catch(Exception error)
            {
                MessageBox.Show(error.ToString(), "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        //delete button
        private void button3_Click(object sender, EventArgs e)
        {
            if (ID != 0)
            {
                DialogResult dialogResult = MessageBox.Show("This data will be deleted forever, continue?", "Warning", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        cmd = new SqlCommand("delete orders where order_id=@id", con);
                        con.Open();
                        cmd.Parameters.AddWithValue("@id", ID);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Record Deleted Successfully!");
                        dt.Rows.Clear();
                        showData();
                        emptyTextBoxs();
                    }
                    catch
                    {
                        MessageBox.Show("Bad Entry", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    emptyTextBoxs();
                }
            }
            else
            {
                MessageBox.Show("Please Select Record to Delete");
            }
        }
        
        //Update
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox5.Text != "" && textBox4.Text != "")
            {
                cmd = new SqlCommand("update orders set medicine_id=@mid,quantity=@quant where order_id=@id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", ID);
                cmd.Parameters.AddWithValue("@mid", textBox2.Text);
                cmd.Parameters.AddWithValue("@quant", textBox4.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Updated Successfully");
                con.Close();
                dt.Rows.Clear();
                showData();
                emptyTextBoxs();
            }
            else
            {
                MessageBox.Show("Please Select Record to Update");
            }
        }

        //search button
        private void button4_Click(object sender, EventArgs e)
        {
            con.Open();
            try
            {
                string selectcmd;
                if (string.IsNullOrEmpty(textBox1.Text))
                {
                    selectcmd = "select * from orders where client_ID =" + textBox3.Text + " order by oreder_date desc";
                }
                else
                {
                    selectcmd = "select * from orders where order_ID =" + textBox1.Text;
                }
                da = new SqlDataAdapter(selectcmd, con);
                dt.Rows.Clear();
                da.Fill(dt);
                emptyTextBoxs();
            }
            catch
            {
                dt.Rows.Clear();
                showData();
                emptyTextBoxs();
            }
            con.Close();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            //textBox5.Text = DateTime.Now.ToString();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            textBox5.Text = DateTime.Now.ToString();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            string getprice = "select medicine_price from medicines where medicine_id =" + textBox2.Text;
            cmd = new SqlCommand(getprice, con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                int price = Convert.ToInt32(dr["medicine_price"]) * Convert.ToInt32(textBox4.Text);
                textBox6.Text = price.ToString();
            }
            con.Close();
            
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ID = Convert.ToInt32(dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString());
            textBox1.Text = dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBox2.Text = dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox3.Text = dataGridView2.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBox5.Text = dataGridView2.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBox4.Text = dataGridView2.Rows[e.RowIndex].Cells[4].Value.ToString();
        }
    }
}
