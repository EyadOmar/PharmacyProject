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
    public partial class Client : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=pharmacy;Integrated Security=True");
        SqlDataAdapter da;
        DataTable dt = new DataTable();
        SqlCommand cmd;
        int ID = 0;
        
        public void showData()
        {
            da = new SqlDataAdapter("select * from clients", con);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        public void emptyTextBoxs()
        {
            textBox1.Text = String.Empty;
            textBox2.Text = String.Empty;
            textBox3.Text = String.Empty;
            textBox5.Text = String.Empty;
        }
        public Client()
        {
            InitializeComponent();

        }
        private void Client_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pharmacyDataSet.clients' table. You can move, or remove it, as needed.
            this.clientsTableAdapter.Fill(this.pharmacyDataSet.clients);
            showData();

        }

        //row cell click
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBox5.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        //Inset Button
        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            try
            {
                string insertCmd = "insert into clients values(" + textBox1.Text + ", '" + textBox2.Text + "', '" + textBox3.Text + "', '" + textBox5.Text + "')";
                cmd = new SqlCommand(insertCmd, con);
                cmd.ExecuteNonQuery();
                dt.Rows.Clear();
                showData();
                MessageBox.Show("Passed Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                emptyTextBoxs();
            }
            catch
            {
                MessageBox.Show("Information missing!", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        //Update Button
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox5.Text != "")
            {
                cmd = new SqlCommand("update clients set client_Name=@name,client_Phone=@phone,client_Address=@address where client_ID=@id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", ID);
                cmd.Parameters.AddWithValue("@name", textBox2.Text);
                cmd.Parameters.AddWithValue("@phone", textBox3.Text);
                cmd.Parameters.AddWithValue("@address", textBox5.Text);
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

        //delte button
        private void button3_Click(object sender, EventArgs e)
        {
            if (ID != 0)
            {
                DialogResult dialogResult = MessageBox.Show("This data will be deleted forever, continue?", "Warning", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        SqlCommand deleteOrder = new SqlCommand("delete orders where client_ID=@id", con);
                        cmd = new SqlCommand("delete clients where client_ID=@id", con);
                        con.Open();
                        deleteOrder.Parameters.AddWithValue("@id", ID);
                        deleteOrder.ExecuteNonQuery();
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
                        MessageBox.Show("Bad Entry" , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        //Search Button
        private void button4_Click(object sender, EventArgs e)
        {
            con.Open();
            try
            {
                string selectcmd;
                if (string.IsNullOrEmpty(textBox1.Text))
                {
                   selectcmd = "select * from clients where client_Phone like '%" + textBox3.Text + "%'";
                }
                else
                {
                   selectcmd = "select * from clients where client_ID =" + textBox1.Text;
                }
                da = new SqlDataAdapter(selectcmd, con);
                dt.Rows.Clear();
                da.Fill(dt);
                emptyTextBoxs();
            }
            catch
            {
                MessageBox.Show("Not Found!", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }
    }
}
