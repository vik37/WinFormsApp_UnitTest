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

        private void addperson_Click(object sender, EventArgs e)
        {
            DataAccess.AddNewPerson(new PersonModels { Firstname = firstnameinput.Text, Lastname = lastameinput.Text });

            firstnameinput.Text = "";
            lastameinput.Text = "";

            UsersDropdown();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            resultText.Text = Calculator.Add((double)first_num.Value, (double)second_num.Value).ToString();
            first_num.Value = 0;
            second_num.Value = 0;
        }

        private void Substract_Click(object sender, EventArgs e)
        {
            resultText.Text = Calculator.Sustract((double)first_num.Value, (double)second_num.Value).ToString();
            first_num.Value = 0;
            second_num.Value = 0;
        }

        private void Multiply_Click(object sender, EventArgs e)
        {
            resultText.Text = Calculator.Multiply((double)first_num.Value, (double)second_num.Value).ToString();
            first_num.Value = 0;
            second_num.Value = 0;
        }

        private void Divide_Click(object sender, EventArgs e)
        {
            resultText.Text = Calculator.Divide((double)first_num.Value, (double)second_num.Value).ToString();
            first_num.Value = 0;
            second_num.Value = 0;
        }
    }
}
