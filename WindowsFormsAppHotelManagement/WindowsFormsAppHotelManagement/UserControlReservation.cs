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
    public partial class UserControlReservation : UserControl
    {
        private string RID = "", No;
        public UserControlReservation()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\HotelDatabase.mdf;Integrated Security=True");

        private void DisplayAndSearchReservation(string query, SqlConnection connection)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridViewReservation.DataSource = dt;
        }

        private void UserControlReservation_Load(object sender, EventArgs e)
        {
            comboBoxType.SelectedIndex = 0;
            comboBoxNo.SelectedIndex = 0;
            comboBoxType1.SelectedIndex = 0;
            comboBoxNo1.SelectedIndex = 0;
        }
        public void Clear()
        {
            comboBoxType.SelectedIndex = 0;
            comboBoxNo.SelectedIndex = 0;
            textBoxClientID.Clear();
            dateTimePickerIn.Value = DateTime.Now;
            dateTimePickerOut.Value = DateTime.Now;
            tabControlReservation.SelectedTab = tabPageAddReservation;
        }
        public void Clear1()
        {
            comboBoxType1.SelectedIndex = 0;
            comboBoxNo1.SelectedIndex = 0;
            textBoxClientID1.Clear();
            dateTimePickerIn1.Value = DateTime.Now;
            dateTimePickerOut1.Value = DateTime.Now;
            RID = "";
        }


        private void tabPageAddReservation_Leave(object sender, EventArgs e)
        {
            Clear();
            Clear1();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Con.Open();
            if (comboBoxType.SelectedIndex == 0 || textBoxClientID.Text.Trim() == string.Empty)
                MessageBox.Show("All fields are required", "Require all fields.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                try
                {
                    string query = "INSERT INTO Reservation_Table(Reservation_Room_Type, Reservation_Room_Number, Reservation_Client_ID, Reservation_In, Reservation_Out) VALUES (@RRT, @RRN, @RCI, @RI, @RO)";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.Parameters.AddWithValue("@RRT", comboBoxType.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@RRN", comboBoxNo.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@RCI", textBoxClientID.Text.Trim());
                    cmd.Parameters.AddWithValue("@RI", dateTimePickerIn.Text);
                    cmd.Parameters.AddWithValue("@RO", dateTimePickerOut.Text);

                    int count = cmd.ExecuteNonQuery();
                    if (count > 0)
                    {
                        MessageBox.Show("Reservation added successfully.");
                        Clear();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error during adding Reservation: " + ex.Message);
                }
            }
            Con.Close();
        }

        private void tabPageSearchReservation_Enter(object sender, EventArgs e)
        {
            Con.Open();
            try
            {
                string query = "SELECT * FROM Reservation_Table";
                DisplayAndSearchReservation(query, Con);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during searching Reservations: " + ex.Message);
            }
            Con.Close();
        }

        private void tabPageSearchReservation_Leave(object sender, EventArgs e)
        {
            textBoxSearchClientID.Clear();

        }

        private void textBoxSearchClientID_TextChanged(object sender, EventArgs e)
        {
            Con.Open();
            try
            {
                string query = "SELECT * FROM Reservation_Table WHERE Reservation_Client_ID LIKE @rclientid";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.Parameters.Add(new SqlParameter("@rclientid", "%" + textBoxSearchClientID.Text.Trim() + "%"));

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridViewReservation.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during searching Clients: " + ex.Message);
            }
            Con.Close();
        }

        private void dataGridViewReservation_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridViewReservation.Rows[e.RowIndex];
                RID = row.Cells[0].Value.ToString();
                comboBoxType1.SelectedItem = row.Cells[1].Value.ToString();
                No = row.Cells[2].Value.ToString();
                textBoxClientID1.Text = row.Cells[3].Value.ToString();
                if (DateTime.TryParse(row.Cells[4].Value.ToString(), out DateTime inDate))
                {
                    dateTimePickerIn.Value = inDate;
                }
                else
                {
                    dateTimePickerIn.Value = DateTime.Now;
                }
                if (DateTime.TryParse(row.Cells[5].Value.ToString(), out DateTime outDate))
                {
                    dateTimePickerOut.Value = outDate;
                }
                else
                {
                    dateTimePickerOut.Value = DateTime.Now;
                }
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            Con.Open();
            if (RID != "")
            {
                if (comboBoxType1.SelectedIndex == 0 || textBoxClientID1.Text.Trim() == string.Empty) 
                    MessageBox.Show("All fields are required", "Require all fields.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    try
                    {
                        string query = "UPDATE Reservation_Table SET Reservation_Room_Type = @RRT, Reservation_Room_Number = @RRN, Reservation_Client_ID = @RCI, Reservation_In = @RI, Reservation_Out = @RO WHERE Reservation_ID=@RID";
                        SqlCommand cmd = new SqlCommand(query, Con);
                        cmd.Parameters.AddWithValue("@RRT", comboBoxType1.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@RRN", comboBoxNo1.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@RCI", textBoxClientID1.Text.Trim());
                        cmd.Parameters.AddWithValue("@RI", dateTimePickerIn1.Text);
                        cmd.Parameters.AddWithValue("@RO", dateTimePickerOut1.Text);
                        cmd.Parameters.AddWithValue("@RID", RID);



                        int count = cmd.ExecuteNonQuery();
                        if (count > 0)
                        {
                            MessageBox.Show("Reservation updated successfully.");
                            Clear1();
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error during updating Reservation: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please first select row from table", "Selection of row.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Con.Close();
        }

        private void tabPageUpdateDeleteReservation_Leave(object sender, EventArgs e)
        {
            Clear1();
        }

        private void comboBoxType1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxType1.SelectedIndex != 0)
            {
                comboBoxNo1.Items.Clear();
                Con.Open();
                try
                {
                    string query = "SELECT Room_ID FROM Room_Table WHERE Room_Type = @RT AND Room_Free = 'Yes' ORDER BY Room_ID";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.Parameters.AddWithValue("@RT", comboBoxType1.SelectedItem.ToString());

                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        comboBoxNo1.Items.Add(reader["Room_ID"].ToString());
                    }

                    if (comboBoxNo1.Items.Count > 0)
                        comboBoxNo1.SelectedIndex = 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error during fetching Room Numbers: " + ex.Message);
                }
                Con.Close();
            }
        }

        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxType.SelectedIndex != 0)
            {
                comboBoxNo.Items.Clear();
                Con.Open();
                try
                {
                    string query = "SELECT Room_ID FROM Room_Table WHERE Room_Type = @RT AND Room_Free = 'Yes' ORDER BY Room_ID";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.Parameters.AddWithValue("@RT", comboBoxType.SelectedItem.ToString());

                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        comboBoxNo.Items.Add(reader["Room_ID"].ToString());
                    }

                    if (comboBoxNo.Items.Count > 0)
                        comboBoxNo.SelectedIndex = 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error during fetching Room Numbers: " + ex.Message);
                }
                Con.Close();
            }
        }

        private void comboBoxNo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            Con.Open();
            if (RID != "")
            {
                if (comboBoxType1.SelectedIndex == 0 || textBoxClientID1.Text.Trim() == string.Empty)
                    MessageBox.Show("All fields are required", "Require all fields.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    try
                    {
                        DialogResult result = MessageBox.Show("Are you sure you want to delete this reservation?", "Reservation Delete.", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (DialogResult.Yes == result)
                        {
                            string query = "DELETE FROM Reservation_Table WHERE Reservation_ID=@RID";
                            SqlCommand cmd = new SqlCommand(query, Con);
                            cmd.Parameters.AddWithValue("@RID", RID);

                            int count = cmd.ExecuteNonQuery();
                            if (count > 0)
                            {
                                MessageBox.Show("Reservation deleted successfully.");
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
                        MessageBox.Show("Error during deleting Reservation: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a reservation to delete.");
            }
            Con.Close();
        }
    }
}
