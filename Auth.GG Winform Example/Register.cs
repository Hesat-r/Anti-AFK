﻿using System;
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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void siticoneRoundedButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login f1 = new Login();
            f1.Show();
        }

        private void siticoneControlBox1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void siticoneRoundedButton2_Click(object sender, EventArgs e)
        {
            if (API.Register(username.Text, password.Text,email.Text,license.Text))
            {
                var notificationManager = new NotificationManager();
                notificationManager.Show(new NotificationContent
                {
                    Title = "Registrierung",
                    Message = "Erfolgreich Registriert!",
                    Type = NotificationType.Success
                });
                this.Hide();
                Login f1 = new Login();
                f1.Show();
            }
        }

        private void siticoneImageButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
