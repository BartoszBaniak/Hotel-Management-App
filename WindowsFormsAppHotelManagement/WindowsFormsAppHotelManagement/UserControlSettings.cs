using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppHotelManagement
{
    public partial class UserControlSettings : UserControl
    {
        private string ID = "";
        public UserControlSettings()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\HotelDatabase.mdf;Integrated Security=True");
        
        private void DisplayAndSearchUser(string query, SqlConnection connection)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridViewUser.DataSource = dt;
        }

        public void Clear()
        {
            textBoxUsername.Clear();
            textBoxPassword.Clear();
            tabControlUser.SelectedTab = tabPageAddUser;
        }

        private void Clear1()
        {
            textBoxUsername1.Clear();
            textBoxPassword1.Clear();
            ID = "";
        }

        private void tabPageAddUser_Leave(object sender, EventArgs e)
        {
            Clear();
            Clear1();
        }

        private void tabPageSearchUser_Enter(object sender, EventArgs e)
        {
            Con.Open();
            try
            {
                string query = "SELECT * FROM User_Table";
                DisplayAndSearchUser(query, Con);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during searching Users: " + ex.Message);
            }
            Con.Close(); 
           
        }

        private void tabPageSearchUser_Leave(object sender, EventArgs e)
        {
            textBoxSearchUsername.Clear();
        }

        private void tabPageUpdateDeleteUser_Leave(object sender, EventArgs e)
        {
            Clear1();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Con.Open();
            if(textBoxUsername.Text.Trim() == string.Empty || textBoxPassword.Text == string.Empty)
                MessageBox.Show("All fields are required", "Require all fields.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                try
                {
                    string query = "INSERT INTO User_Table(User_Name, User_Password) VALUES (@UN, @UP)";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.Parameters.AddWithValue("@UN", textBoxUsername.Text.Trim());
                    cmd.Parameters.AddWithValue("@UP", textBoxPassword.Text.Trim());

                    int count = cmd.ExecuteNonQuery();
                    if (count > 0)
                    {
                        MessageBox.Show("User added successfully.");
                        Clear();
                    }
                } 
                catch (Exception ex)
                {
                    MessageBox.Show("Error during adding User: " + ex.Message);
                }
            }
            Con.Close();
        }

        private void dataGridViewUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridViewUser.Rows[e.RowIndex];
                ID = row.Cells[0].Value.ToString();
                textBoxUsername1.Text = row.Cells[1].Value.ToString();
                textBoxPassword1.Text = row.Cells[2].Value.ToString();
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            Con.Open();
            if(ID != "")
            {
                if (textBoxUsername1.Text.Trim() == string.Empty || textBoxPassword1.Text == string.Empty)
                    MessageBox.Show("All fields are required", "Require all fields.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    try
                    {
                        string query = "UPDATE User_Table SET User_Name=@UN, User_Password=@UP WHERE User_ID=@UID";
                        SqlCommand cmd = new SqlCommand(query, Con);
                        cmd.Parameters.AddWithValue("@UN", textBoxUsername1.Text.Trim());
                        cmd.Parameters.AddWithValue("@UP", textBoxPassword1.Text.Trim());
                        cmd.Parameters.AddWithValue("@UID", ID);

                        int count = cmd.ExecuteNonQuery();
                        if (count > 0)
                        {
                            MessageBox.Show("User updated successfully.");
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
                if (textBoxUsername1.Text.Trim() == string.Empty || textBoxPassword1.Text == string.Empty)
                    MessageBox.Show("All fields are required", "Require all fields.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    try
                    {
                        DialogResult result = MessageBox.Show("Are you sure you want to delete this user?", "User Delete.", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if(DialogResult.Yes == result)
                        {
                            string query = "DELETE FROM User_Table WHERE User_ID=@UID";
                            SqlCommand cmd = new SqlCommand(query, Con);
                            cmd.Parameters.AddWithValue("@UID", ID);

                            int count = cmd.ExecuteNonQuery();
                            if (count > 0)
                            {
                                MessageBox.Show("User deleted successfully.");
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
                        MessageBox.Show("Error during deleting User: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a user to delete.");
            }
            Con.Close();
        }

        private void textBoxSearchUsername_TextChanged(object sender, EventArgs e)
        {
            Con.Open();
            try
            {
                string query = "SELECT * FROM User_Table WHERE User_Name LIKE @username";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.Parameters.Add(new SqlParameter("@username", "%" + textBoxSearchUsername.Text.Trim() + "%"));

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridViewUser.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during searching Users: " + ex.Message);
            }
            Con.Close();
        }

        private void tabPageAddUser_Enter(object sender, EventArgs e)
        {

        }

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
