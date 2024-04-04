using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppHotelManagement
{
    public partial class Dashboard : Form
    {
        public string Username;
        public Dashboard()
        {
            InitializeComponent();
        }

        private void panelLogout_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void labelLogout_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void pictureBoxLogout_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelDateTime.Text = DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss");
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            timer1.Start();
            labelUsername.Text = Username;
        }

        private void buttonLogout_MouseClick(object sender, MouseEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to Log Out?", "Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(DialogResult.Yes == result)
            {
                timer1.Stop();
                this.Close();
            }
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            userControlClient1.Hide();
            userControlRoom1.Hide();
            userControlReservation1.Hide();
            userControlDashboard1.Hide();
            userControlSettings1.Clear();
            userControlSettings1.Show();
        }

        private void buttonDashboard_Click(object sender, EventArgs e)
        {
            userControlSettings1.Hide();
            userControlClient1.Hide();
            userControlRoom1.Hide();
            userControlReservation1.Hide();
            userControlDashboard1.User();
            userControlDashboard1.Client();
            userControlDashboard1.Room();
            userControlDashboard1.Reservation();
            userControlDashboard1.Show();
        }

        private void buttonClient_Click(object sender, EventArgs e)
        {
            userControlSettings1.Hide();
            userControlRoom1.Hide();
            userControlReservation1.Hide();
            userControlDashboard1.Hide();
            userControlClient1.Clear();
            userControlClient1.Show();
        }

        private void buttonRooms_Click(object sender, EventArgs e)
        {
            userControlSettings1.Hide();
            userControlClient1.Hide();
            userControlReservation1.Hide();
            userControlDashboard1.Hide();
            userControlRoom1.Clear();
            userControlRoom1.Show();
        }

        private void buttonReservation_Click(object sender, EventArgs e)
        {
            userControlSettings1.Hide();
            userControlClient1.Hide();
            userControlRoom1.Hide();
            userControlDashboard1.Hide();
            userControlReservation1.Clear();
            userControlReservation1.Show();
        }
    }

}
