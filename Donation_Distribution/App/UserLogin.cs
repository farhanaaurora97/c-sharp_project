using DatabaseProject;
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

namespace Donation_Distribution
{
    public partial class UserLogin : Form
    {
        public static string id, name, email, password, phn_num,dob,age,occupation,gender;

        

        public static string address,fake_name,current_balance,total_donated_amount;
        public static string present_address, permanent_address,nid,marital_status,religion,reference_person_name, reference_person_phn_number,organization_type;
        readonly DBAccess objDBAccess = new DBAccess();
        DataTable dtUsers = new DataTable();
        public UserLogin()
        {
            InitializeComponent();
        }

        

        

        private void Donar_back_form1_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home h1 = new Home();
            h1.Show();
        }

        private void Donar_signup_label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 dsf = new Form1();
            dsf.Show();
        }

        private void Donar_login_button_Click(object sender, EventArgs e)
        {

            string useremail = User_email_textbox.Text;
            string userpassword = User_password_textBox.Text;

            if (useremail.Equals(""))
            {
                MessageBox.Show("please enter your Email.");
            }
            else if (userpassword.Equals(""))
            {
                MessageBox.Show("please enter your Password.");
            }
            else
            {
                string query = "select * from Donars where Email = '" + useremail + "' AND Password = '" + userpassword + "'";
                objDBAccess.readDatathroughAdapter(query, dtUsers);
                if (dtUsers.Rows.Count == 1)
                {

                    id = dtUsers.Rows[0]["ID"].ToString();
                    name = dtUsers.Rows[0]["Name"].ToString();
                    email = dtUsers.Rows[0]["Email"].ToString();
                    password = dtUsers.Rows[0]["Password"].ToString();
                    phn_num = dtUsers.Rows[0]["Phone_number"].ToString();
                    dob = dtUsers.Rows[0]["Date_of_Birthday"].ToString();
                    age = dtUsers.Rows[0]["Age"].ToString();
                    occupation = dtUsers.Rows[0]["Occupation"].ToString();
                    gender = dtUsers.Rows[0]["Gender"].ToString();
                    address = dtUsers.Rows[0]["Address"].ToString();
                    fake_name = dtUsers.Rows[0]["Fake_name"].ToString();
                    current_balance = dtUsers.Rows[0]["Current_Balance"].ToString();
                    total_donated_amount = dtUsers.Rows[0]["Total_donated_amount"].ToString();
                    //MessageBox.Show("login Successfully");
                    objDBAccess.closeConn();
                    Donar_Profile hf = new Donar_Profile();
                    this.Hide();
                    hf.Show();
                }
                else
                {
                    query = "select * from Receivers where Email = '" + useremail + "' AND Password = '" + userpassword + "'";
                    objDBAccess.readDatathroughAdapter(query, dtUsers);
                    if (dtUsers.Rows.Count == 1)
                    {

                        id = dtUsers.Rows[0]["ID"].ToString();
                        name = dtUsers.Rows[0]["Name"].ToString();
                        email = dtUsers.Rows[0]["Email"].ToString();
                        password = dtUsers.Rows[0]["Password"].ToString();
                        phn_num = dtUsers.Rows[0]["Phone_number"].ToString();
                        dob = dtUsers.Rows[0]["Date_of_Birth"].ToString();
                        age = dtUsers.Rows[0]["Age"].ToString();
                        occupation = dtUsers.Rows[0]["Occupation"].ToString();
                        gender = dtUsers.Rows[0]["Gender"].ToString();
                        present_address = dtUsers.Rows[0]["Present_address"].ToString();
                        permanent_address = dtUsers.Rows[0]["Permanent_address"].ToString();
                        nid = dtUsers.Rows[0]["NID"].ToString();
                        marital_status = dtUsers.Rows[0]["Marital_status"].ToString();
                        religion = dtUsers.Rows[0]["Religion"].ToString();
                        reference_person_name = dtUsers.Rows[0]["Reference_person_name"].ToString();
                        reference_person_phn_number = dtUsers.Rows[0]["Reference_person_phone_number"].ToString();
                        organization_type = dtUsers.Rows[0]["Organization_type"].ToString();
                        //MessageBox.Show("login Successfully");
                        objDBAccess.closeConn();
                        Receiver_Profile_form rpf = new Receiver_Profile_form();
                        this.Hide();
                        rpf.Show();
                    }
                    else
                    {
                        MessageBox.Show("Invalid information. Provide correct email and password");
                    }
                }
            }
        }
        
    }
}
