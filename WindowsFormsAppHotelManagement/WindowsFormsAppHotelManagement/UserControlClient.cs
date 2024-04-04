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

namespace WindowsFormsAppHotelManagement
{
    public partial class UserControlClient : UserControl
    {
        private string ID = "";
        public UserControlClient()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\HotelDatabase.mdf;Integrated Security=True");

        private void DisplayAndSearchClient(string query, SqlConnection connection)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridViewClient.DataSource = dt;
        }

        public void Clear()
        {
            textBoxFirstName.Clear();
            textBoxLastName.Clear();
            textBoxPhoneNum.Clear();
            textBoxAddress.Clear();
            tabControlClient.SelectedTab = tabPageAddClient;
        }

        private void Clear1()
        {
            textBoxFirstName1.Clear();
            textBoxLastName1.Clear();
            textBoxPhoneNum1.Clear();
            textBoxAddress1.Clear();
            ID = "";
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Con.Open();
            if (textBoxFirstName.Text.Trim() == string.Empty || textBoxLastName.Text == string.Empty || textBoxPhoneNum.Text == string.Empty || textBoxAddress.Text == string.Empty)
                MessageBox.Show("All fields are required", "Require all fields.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                try
                {
                    string query = "INSERT INTO Client_Table(Client_FirstName, Client_LastName, Client_Phone, Client_Address) VALUES (@CF, @CL, @CP, @CA)";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.Parameters.AddWithValue("@CF", textBoxFirstName.Text.Trim());
                    cmd.Parameters.AddWithValue("@CL", textBoxLastName.Text.Trim());
                    cmd.Parameters.AddWithValue("@CP", textBoxPhoneNum.Text.Trim());
                    cmd.Parameters.AddWithValue("@CA", textBoxAddress.Text.Trim());

                    int count = cmd.ExecuteNonQuery();
                    if (count > 0)
                    {
                        MessageBox.Show("Client added successfully.");
                        Clear();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error during adding Client: " + ex.Message);
                }
            }
            Con.Close();
        }

        private void tabPageAddClient_Leave(object sender, EventArgs e)
        {
            Clear();
            Clear1();
        }

        private void tabPageSearchClient_Enter(object sender, EventArgs e)
        {
            Con.Open();
            try
            {
                string query = "SELECT * FROM Client_Table";
                DisplayAndSearchClient(query, Con);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during searching Clients: " + ex.Message);
            }
            Con.Close();
        }

        private void tabPageSearchClient_Leave(object sender, EventArgs e)
        {
            textBoxSearchPhoneNum.Clear();
        }

        private void textBoxSearchPhoneNum_TextChanged(object sender, EventArgs e)
        {
            Con.Open();
            try
            {
                string query = "SELECT * FROM Client_Table WHERE Client_Phone LIKE @phonenum";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.Parameters.Add(new SqlParameter("@phonenum", "%" + textBoxSearchPhoneNum.Text.Trim() + "%"));

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridViewClient.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during searching Clients: " + ex.Message);
            }
            Con.Close();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            Con.Open();
            if (ID != "")
            {
                if (textBoxFirstName1.Text.Trim() == string.Empty || textBoxLastName1.Text == string.Empty || textBoxPhoneNum1.Text == string.Empty || textBoxAddress1.Text == string.Empty)
                    MessageBox.Show("All fields are required", "Require all fields.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    try
                    {
                        string query = "UPDATE Client_Table SET Client_FirstName = @CF, Client_LastName = @CL, Client_Phone = @CP, Client_Address = @CA WHERE Client_ID=@CID";
                        SqlCommand cmd = new SqlCommand(query, Con);
                        cmd.Parameters.AddWithValue("@CF", textBoxFirstName1.Text.Trim());
                        cmd.Parameters.AddWithValue("@CL", textBoxLastName1.Text.Trim());
                        cmd.Parameters.AddWithValue("@CP", textBoxPhoneNum1.Text.Trim());
                        cmd.Parameters.AddWithValue("@CA", textBoxAddress1.Text.Trim());
                        cmd.Parameters.AddWithValue("@CID", ID);

                        int count = cmd.ExecuteNonQuery();
                        if (count > 0)
                        {
                            MessageBox.Show("Client updated successfully.");
                            Clear1();
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error during updating User: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please first select row from table", "Selection of row.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Con.Close();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            Con.Open();
            if (ID != "")
            {
                if (textBoxFirstName1.Text.Trim() == string.Empty || textBoxLastName1.Text == string.Empty || textBoxPhoneNum1.Text == string.Empty || textBoxAddress1.Text == string.Empty)
                    MessageBox.Show("All fields are required", "Require all fields.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    try
                    {
                        DialogResult result = MessageBox.Show("Are you sure you want to delete this client?", "Client Delete.", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (DialogResult.Yes == result)
                        {
                            string query = "DELETE FROM Client_Table WHERE Client_ID=@CID";
                            SqlCommand cmd = new SqlCommand(query, Con);
                            cmd.Parameters.AddWithValue("@CID", ID);

                            int count = cmd.ExecuteNonQuery();
                            if (count > 0)
                            {
                                MessageBox.Show("Client deleted successfully.");
                                Clear1();
                            }
                            else
                            {
                                MessageBox.Show("Please first select row from table", "Selection of row.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error during deleting Client: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a client to delete.");
            }
            Con.Close();
        }

        private void dataGridViewUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewClient_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridViewClient.Rows[e.RowIndex];
                ID = row.Cells[0].Value.ToString();
                textBoxFirstName1.Text = row.Cells[1].Value.ToString();
                textBoxLastName1.Text = row.Cells[2].Value.ToString();
                textBoxPhoneNum1.Text = row.Cells[3].Value.ToString();
                textBoxAddress1.Text = row.Cells[4].Value.ToString();
            }
        }

        private void tabPageUpdateDeleteClient_Leave(object sender, EventArgs e)
        {
            Clear1();
        }
    }
}
