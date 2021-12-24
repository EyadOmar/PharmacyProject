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
    public partial class Medicine : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=pharmacy;Integrated Security=True");
        SqlDataAdapter da;
        DataTable dt = new DataTable();
        SqlCommand cmd;
        int ID = 0;

        public void showData()
        {

            da = new SqlDataAdapter("select * from medicines", con);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        public void emptyTextBoxs()
        {
            textBox1.Text = String.Empty;
            textBox2.Text = String.Empty;
            textBox3.Text = String.Empty;
            textBox4.Text = String.Empty;
            textBox5.Text = String.Empty;
            textBox6.Text = String.Empty;
            textBox7.Text = String.Empty;
            textBox8.Text = String.Empty;
        }
        public Medicine()
        {
            InitializeComponent();
        }
        private void Medicine_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pharmacyDataSet.medicines' table. You can move, or remove it, as needed.
            this.medicinesTableAdapter.Fill(this.pharmacyDataSet.medicines);
            showData();
        }

        //row cell click
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            textBox6.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            textBox7.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            textBox8.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();

        }

        //Buttons
        //Insert Button
        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            try
            {
                string insertCmd = "insert into medicines values(" + textBox1.Text +", '"+ textBox2.Text + "', '"+ textBox3.Text + "', '"+ textBox4.Text + "', "+ textBox5.Text + ", '"+ textBox6.Text + "', "+ textBox7.Text + ", "+ textBox8.Text + ");";
                cmd = new SqlCommand(insertCmd, con);
                cmd.ExecuteNonQuery();
                dt.Rows.Clear();
                showData();
                MessageBox.Show("Passed Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                emptyTextBoxs();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString(), "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        //Update Button
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "" && textBox7.Text != "" && textBox8.Text != "")
            {
                cmd = new SqlCommand("update medicines set medicin_name=@name,production_date=@pdate,expired_date=@edate,medicine_price=@price,medicine_Location=@loc,stock=@stock,supplier_id=@suppid where medicine_id=@id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", ID);
                cmd.Parameters.AddWithValue("@name", textBox2.Text);
                cmd.Parameters.AddWithValue("@pdate", textBox3.Text);
                cmd.Parameters.AddWithValue("@edate", textBox4.Text);
                cmd.Parameters.AddWithValue("@price", textBox5.Text);
                cmd.Parameters.AddWithValue("@loc", textBox6.Text);
                cmd.Parameters.AddWithValue("@stock", textBox7.Text);
                cmd.Parameters.AddWithValue("@suppid", textBox8.Text);
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

        //Delete Button
        private void button3_Click(object sender, EventArgs e)
        {
            if (ID != 0)
            {
                DialogResult dialogResult = MessageBox.Show("This data will be deleted forever, continue?", "Warning", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        cmd = new SqlCommand("delete medicines where medicine_ID=@id", con);
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

        //Search Button
        private void button4_Click(object sender, EventArgs e)
        {
            con.Open();
            try
            {
                string selectcmd;
                if (string.IsNullOrEmpty(textBox1.Text))
                {
                    selectcmd = "select * from medicines where medicin_name like '%" + textBox2.Text + "%'";
                }
                else
                {
                    selectcmd = "select * from medicines where medicine_id =" + textBox1.Text;
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


        //labels & textboxes
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
