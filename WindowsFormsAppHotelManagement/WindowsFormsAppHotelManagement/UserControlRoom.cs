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

    public partial class UserControlRoom : UserControl
    {
        private string ID = "";
        private string Free = "";
        public UserControlRoom()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\HotelDatabase.mdf;Integrated Security=True");

        private void DisplayAndSearchRoom(string query, SqlConnection connection)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridViewRoom.DataSource = dt;
        }

        public void Clear()
        {
            textBoxPhoneNo.Clear();
            comboBoxType.SelectedIndex = 0;
            radioButtonNo.Checked = false;
            radioButtonYes.Checked = false;
            tabControlRoom.SelectedTab = tabPageAddRoom;
        }

        private void Clear1()
        {
            textBoxPhoneNo1.Clear();
            comboBoxType1.SelectedIndex = 0;
            radioButtonNo1.Checked = false;
            radioButtonYes1.Checked = false;
            ID = "";
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Con.Open();

            if (radioButtonYes.Checked)
                Free = "Yes";
            if (radioButtonNo.Checked)
                Free = "No";

            if (textBoxPhoneNo.Text.Trim() == string.Empty || comboBoxType.SelectedIndex == 0 || Free == "")
                MessageBox.Show("All fields are required", "Require all fields.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                try
                {
                    string query = "INSERT INTO Room_Table(Room_Type, Room_Phone, Room_Free) VALUES (@RT, @RP, @RF)";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.Parameters.AddWithValue("@RT", comboBoxType.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@RP", textBoxPhoneNo.Text.Trim());
                    cmd.Parameters.AddWithValue("@RF", Free);

                    int count = cmd.ExecuteNonQuery();
                    if (count > 0)
                    {
                        MessageBox.Show("Room added successfully.");
                        Clear();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error during adding Room: " + ex.Message);
                }
            }
            Con.Close();
        }

        private void tabPageAddRoom_Leave(object sender, EventArgs e)
        {
            Clear();
            Clear1();
        }

        private void tabPageSearchRoom_Enter_1(object sender, EventArgs e)
        {
            Con.Open();
            try
            {
                string query = "SELECT * FROM Room_Table";
                DisplayAndSearchRoom(query, Con);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during searching Rooms: " + ex.Message);
            }
            Con.Close();

        }

        private void tabPageSearchRoom_Leave_1(object sender, EventArgs e)
        {
            textBoxSearchRoomNo.Clear();
        }

        private void textBoxSearchRoomNo_TextChanged_1(object sender, EventArgs e)
        {
            Con.Open();
            try
            {
                string query = "SELECT * FROM Room_Table WHERE Room_Phone LIKE @phonenum";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.Parameters.Add(new SqlParameter("@phonenum", "%" + textBoxSearchRoomNo.Text.Trim() + "%"));

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridViewRoom.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during searching Rooms: " + ex.Message);
            }
            Con.Close();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            Con.Open();
            if (radioButtonYes1.Checked)
                Free = "Yes";
            if (radioButtonNo.Checked)
                Free = "No";


            if (ID != "")
            {
                if (textBoxPhoneNo1.Text.Trim() == string.Empty || comboBoxType1.SelectedIndex == 0 || Free == "")
                    MessageBox.Show("All fields are required", "Require all fields.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    try
                    {
                        string query = "UPDATE Room_Table SET Room_Type = @RT, Room_Phone = @RP, Room_Free = @RF WHERE Room_ID = @RID";
                        SqlCommand cmd = new SqlCommand(query, Con);
                        cmd.Parameters.AddWithValue("@RT", comboBoxType1.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@RP", textBoxPhoneNo1.Text.Trim());
                        cmd.Parameters.AddWithValue("@RF", Free);
                        cmd.Parameters.AddWithValue("@RID", ID); 

                        int count = cmd.ExecuteNonQuery();
                        if (count > 0)
                        {
                            MessageBox.Show("Room updated successfully.");
                            Clear1();
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error during updating Room: " + ex.Message);
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
                if (textBoxPhoneNo1.Text.Trim() == string.Empty || comboBoxType1.SelectedIndex == 0 || Free == "")
                    MessageBox.Show("All fields are required", "Require all fields.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    try
                    {
                        DialogResult result = MessageBox.Show("Are you sure you want to delete this room?", "Room Delete.", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (DialogResult.Yes == result)
                        {
                            string query = "DELETE FROM Room_Table WHERE Room_ID=@RID";
                            SqlCommand cmd = new SqlCommand(query, Con);
                            cmd.Parameters.AddWithValue("@RID", ID);

                            int count = cmd.ExecuteNonQuery();
                            if (count > 0)
                            {
                                MessageBox.Show("Room deleted successfully.");
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
                        MessageBox.Show("Error during deleting Room: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a room to delete.");
            }
            Con.Close();
        }


        private void dataGridViewRoom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridViewRoom.Rows[e.RowIndex];
                ID = row.Cells[0].Value.ToString();
                comboBoxType1.SelectedItem = row.Cells[1].Value.ToString();
                textBoxPhoneNo1.Text = row.Cells[2].Value.ToString();
                Free = row.Cells[3].Value.ToString();
                if(Free == "Yes")
                    radioButtonYes1.Checked = true;
                if(Free == "No")
                    radioButtonNo1.Checked = true;
            }
        }

        private void UserControlRoom_Load(object sender, EventArgs e)
        {
            comboBoxType.SelectedIndex = 0;
            comboBoxType1.SelectedIndex = 0;
        }

        private void tabPageUpdateDeleteRoom_Leave(object sender, EventArgs e)
        {
            Clear1();
        }
    }

}