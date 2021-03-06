﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyWindowsFormProject
{
    public partial class FrmRegistrationForm : Form
    {
        public FrmRegistrationForm()
        {
            InitializeComponent();
            string[] country = new string[5];
            country[0] = "Bangladesh";
            country[1] = "India";
            country[2] = "Pakistan";
            country[3] = "Canada";
            country[4] = "London";
            cboNationality.DataSource = country;
             
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string id = "ID is : " + txtStudentID.Text;
            string name = "Name is : " + txtName.Text;
            string dob = "Date of birth is : " + dtpDOB.Value;
            string gender = string.Empty;
            if(rbMale.Checked)
            {
                gender = "Male";
            }
            else
            {
                gender = "Female";
            }
            string nationality = cboNationality.SelectedItem.ToString();
            string details = id + "\n" + name + "\n" + dob + "\n" + gender + "\n" + nationality;

            rtbOutput.Text = details;
            pbProfileImage.ImageLocation = "D:\\image.jpg";

            //MessageBox.Show(details);


        }

        private void dbinsert_Click(object sender, EventArgs e)
        {
            try
            {

                String str = "Server=LAPTOP-OGTST92J\\SQLEXPRESS; Database=MrinBD; Integrated Security=True;";

       
                String query = "select * from Names";

                SqlConnection con = new SqlConnection(str);

                SqlCommand cmd = new SqlCommand(query, con);

                con.Open();

                DataSet ds = new DataSet();

                MessageBox.Show("connect with sql server");

                con.Close();

            }

            catch (Exception es)
            {

                MessageBox.Show(es.Message);



            }
        }
    }
}
