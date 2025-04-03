using System;
using System.Collections.Generic;
using System.IO;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace RoomResPlusPlus
{
    public partial class Form2 : Form
    {

        

        private const string FilePath = "userCredentials.json";
        private List<(string Username, string Password)> userCredentials;
        public Form2()
        {
            InitializeComponent();
            userCredentials = LoadUserCredentials();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string user = email.Text;
            string pass = password.Text;

            bool isAuthenticated = userCredentials.Any(cred => cred.Username == user && cred.Password == pass);

            if (isAuthenticated)
            {
                // for testing
                //MessageBox.Show("Login Successful");

                // open the main form
                Form1 form1 = new Form1();
                form1.Show();

                // hide this form
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login Failed");
                //email.Text = "";
                password.Text = "";
            }
        }
        private List<(string Username, string Password)> LoadUserCredentials()
        {
            if (File.Exists(FilePath))
            {
                string json = File.ReadAllText(FilePath);
                return JsonConvert.DeserializeObject<List<(string Username, string Password)>>(json);
            }
            else
            {
                var initialCredentials = new List<(string Username, string Password)>
                {
                    ("user1", "password1"),
                    ("user2", "password2"),
                    ("user3", "password3")
                };
                SaveUserCredentials(initialCredentials);
                return initialCredentials;
            }
        }

        private void SaveUserCredentials(List<(string Username, string Password)> credentials)
        {
            string json = JsonConvert.SerializeObject(credentials);
            File.WriteAllText(FilePath, json);
        }
        
    }
}
