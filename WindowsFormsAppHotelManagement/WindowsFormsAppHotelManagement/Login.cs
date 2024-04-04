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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\HotelDatabase.mdf;Integrated Security=True");

        private void pictureBoxMinimize_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxMinimize, "Minimize");
        }

        private void pictureBoxClose_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxClose, "Close");
        }

        private void pictureBoxClose_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void pictureBoxMinimize_MouseClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBoxShow_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxShow, "Show Password");
        }

        private void pictureBoxHide_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxHide, "Hide Password");
        }

        private void pictureBoxShow_MouseClick(object sender, MouseEventArgs e)
        {
            pictureBoxShow.Hide();
            textBoxPassword.UseSystemPasswordChar = false;
            pictureBoxHide.Show();
        }

        private void pictureBoxHide_MouseClick(object sender, MouseEventArgs e)
        {
            pictureBoxHide.Hide();
            textBoxPassword.UseSystemPasswordChar = true;
            pictureBoxShow.Show();
        }

        private void buttonLogin_MouseClick(object sender, MouseEventArgs e)
        {
            Con.Open();
            if (textBoxUsername.Text.Trim() == string.Empty || textBoxPassword.Text.Trim() == string.Empty)
                MessageBox.Show("All fields are required", "Require all fields.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                try
                {
                    string query = "SELECT COUNT(1) FROM dbo.User_Table WHERE User_Name=@username AND User_Password=@password";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.Parameters.AddWithValue("@username", textBoxUsername.Text.Trim());
                    cmd.Parameters.AddWithValue("@password", textBoxPassword.Text.Trim());

                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    if (count == 1)
                    {
                        Dashboard fd = new Dashboard();
                        fd.Username = textBoxUsername.Text;
                        textBoxUsername.Clear();
                        textBoxPassword.Clear();
                        fd.Show();
                    }
                    else MessageBox.Show("Invalid Username or Password");
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error during login: " + ex.Message);
                }

            }
            Con.Close();
        }
    }
}
