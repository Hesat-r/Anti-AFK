using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Notifications.Wpf;

namespace Auth.GG_Winform_Example
{
    public partial class Login : Form
    {
        public Login()
        {
     
            InitializeComponent();
            
        }

        private void siticoneRoundedButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register f2 = new Register();
            f2.Show();
        }

        private void siticoneControlBox1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void siticoneRoundedButton1_Click(object sender, EventArgs e)
        {
            if(API.Login(username.Text,password.Text))
            {
                var notificationManager = new NotificationManager();
                //Put code here of what you want to do after successful login
                //MessageBox.Show("Erfolgreich Eingelogt!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                notificationManager.Show(new NotificationContent
                {
                    Title = "Login",
                    Message = "Erfolgreich Eingelogt!",
                    Type = NotificationType.Success
                });
                Main main = new Main();
                main.Show();
                this.Hide();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
        }

        private void siticoneImageButton1_Click(object sender, EventArgs e)
        {

        }

        private void username_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                password.SelectionStart = 0;
                password.SelectionLength = password.Text.Length;
            }
        }

       
    }
}
