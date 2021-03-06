﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dynago.Forms
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
            this.LockSize();
            txtUsername.ApplyPlaceholder("username", Color.DarkGray, Color.FromArgb(255, 51, 153, 255));
            txtPassword1.ApplyPlaceholder("password", Color.DarkGray, Color.FromArgb(255, 51, 153, 255), "*");
            txtPassword2.ApplyPlaceholder("confirm password", Color.DarkGray, Color.FromArgb(255, 51, 153, 255), "*");
        }

        private bool OpenOther = false;
        private void Register_FormClosing(object sender, FormClosingEventArgs e) { if (!OpenOther) Application.Exit(); } 

        private void btrnHaveAnAccount_Click(object sender, EventArgs e)
        {
            OpenOther = true;
            new Login().Show();
            Close();
        }

        private void githubLink_Click(object sender, EventArgs e) { System.Diagnostics.Process.Start("https://github.com/Me-re-ly/oganyD/"); }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            MessageBox.Show($"Welcome, {username}! You can now log in.", "Account Created", MessageBoxButtons.OK, MessageBoxIcon.Information);
            OpenOther = true;
            new Login().Show();
            Close();
        }
    }
}
