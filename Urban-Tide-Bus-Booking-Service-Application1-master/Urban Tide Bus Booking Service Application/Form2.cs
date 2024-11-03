﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Urban_Tide_Bus_Booking_Service_Application
{
    public partial class Form2MainMenu : Form
    {
        public Form2MainMenu()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Show Form1 and hide Form3
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void button1book_Click(object sender, EventArgs e)
        {

        }

        private void button2see_Click(object sender, EventArgs e)
        {

        }

        private void button3routes_Click(object sender, EventArgs e)
        {

        }

        private void button4schedules_Click(object sender, EventArgs e)
        {
            FormViewbusSchedules scheduleForm = new FormViewbusSchedules();
            scheduleForm.Show(); // Show the schedules form
        }

        private void Form2MainMenu_Load(object sender, EventArgs e)
        {

        }
        private void button6settings_Click(object sender, EventArgs e)
        {
            FormSetting settingsForm = new FormSetting();
            settingsForm.Show(); // Show the settings form
        }
        private void button7logout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                // Show Form1 (login form) and close Form2MainMenu
                Form1 loginForm = new Form1();
                loginForm.Show();
                this.Close(); // Close the main menu form
            }
        }
    }
}
