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
    public partial class UserControlDashboard : UserControl
    {
        public UserControlDashboard()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\HotelDatabase.mdf;Integrated Security=True");

        public void User()
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM User_Table", Con);
                int count = (int)cmd.ExecuteScalar();
                labelUserCount.Text = count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                Con.Close();
            }
        }
        public void Client()
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Client_Table", Con);
                int count = (int)cmd.ExecuteScalar();
                labelClientCount.Text = count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                Con.Close();
            }
        }
        public void Room()
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Room_Table", Con);
                int count = (int)cmd.ExecuteScalar();
                labelRoomCount.Text = count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                Con.Close();
            }
        }
        public void Reservation()
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Reservation_Table", Con);
                int count = (int)cmd.ExecuteScalar();
                labelReservationCount.Text = count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                Con.Close();
            }
        }

        private void UserControlDashboard_Load(object sender, EventArgs e)
        {
            User();
            Client();
            Room();
            Reservation();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}
