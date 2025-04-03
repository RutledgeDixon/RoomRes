using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoomResPlusPlus
{
    public partial class Form2 : Form
    {

        List<(string Username, string Password)> userCredentials = new List<(string, string)>
            {
                ("user1", "password1"),
                ("user2", "password2"),
                ("user3", "password3")
            };
        public Form2()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string user = email.Text;
            string pass = password.Text;

            bool isAuthenticated = userCredentials.Any(cred => cred.Username == user && cred.Password == pass);

            if (isAuthenticated)
            {
                MessageBox.Show("Login Successful");
            }
            else
            {
                MessageBox.Show("Login Failed");
            }
        }
    }
}
