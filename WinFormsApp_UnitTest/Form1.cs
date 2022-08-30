using DemoLirary;
using DemoLirary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp_UnitTest
{
    public partial class Form1 : Form
    {
        List<PersonModels> people;
        public Form1()
        {
            InitializeComponent();

            UsersDropdown();
        }

        private void UsersDropdown()
        {
            people = DataAccess.GetAll();
            usersDropdown.DataSource = null;
            usersDropdown.DataSource = people;
            usersDropdown.DisplayMember = "Fullname";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void result_view_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
