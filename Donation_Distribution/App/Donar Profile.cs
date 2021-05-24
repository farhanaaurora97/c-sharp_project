using DatabaseProject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Donation_Distribution
{
    public partial class Donar_Profile : Form
    {
        public Donar_Profile()
        {
            InitializeComponent();
        }

        private void Donar_logout_button_Click(object sender, EventArgs e)
        {
            UserLogin ul2 = new UserLogin();
            this.Hide();
            ul2.Show();
        }

        private void Donar_Donate_button_Click(object sender, EventArgs e)
        {
            Receiver_List rl = new Receiver_List();
            this.Hide();
            rl.Show();
        }

        private void Donar_to_home_button_Click(object sender, EventArgs e)
        {
            Home h2 = new Home();
            this.Hide();
            h2.Show();
        }

        private void Donar_Profile_Load(object sender, EventArgs e)
        {
            Donar_id_textBox.Text = UserLogin.id;
            Donar_name_textbox2.Text = UserLogin.name;
            Donar_email_textbox2.Text = UserLogin.email;
            Donar_phn_num_textbox2.Text = UserLogin.phn_num;
            Donar_dob_textbox.Text = UserLogin.dob;
            Donar_age_textBox.Text = UserLogin.age;
            Donar_occupation_textBox2.Text = UserLogin.occupation;
            Donar_gender_textBox2.Text = UserLogin.gender;
            Donar_address_textBox2.Text = UserLogin.address;
            Donar_fake_name_textbox2.Text = UserLogin.fake_name;
            Donar_current_balance_textBox2.Text = UserLogin.current_balance;
            Donar_total_donated_amount_textBox2.Text = UserLogin.total_donated_amount;
            Donar_password_textBox2.Text = UserLogin.password;
        }

        private void Donar_update_button_Click(object sender, EventArgs e)
        {
            DBAccess objDBAccess = new DBAccess();
            string updonar_userName = Donar_name_textbox2.Text;
            string updonar_userEmail = Donar_email_textbox2.Text;
            string updonar_Phone_number = Donar_phn_num_textbox2.Text;
            string updonar_Password = Donar_password_textBox2.Text;
            
            string updonar_address = Donar_address_textBox2.Text;
            string updonar_occupation = Donar_occupation_textBox2.Text;
            string updonar_fakename = Donar_fake_name_textbox2.Text;


            if (updonar_userName.Equals(""))
            {
                MessageBox.Show("please enter your Name.");
            }
            else if (updonar_userEmail.Equals(""))
            {
                MessageBox.Show("please enter your Email.");
            }
            else if (updonar_Phone_number.Equals(""))
            {
                MessageBox.Show("please enter your Phone number.");
            }
            else if (updonar_Password.Equals(""))
            {
                MessageBox.Show("please enter your Password.");
            }
            
            else if (updonar_address.Equals(""))
            {
                MessageBox.Show("please enter your address.");
            }
            else if (updonar_occupation.Equals(""))
            {
                MessageBox.Show("please enter your occupation.");
            }
            else if (updonar_fakename.Equals(""))
            {
                MessageBox.Show("please enter a fake name for you.");
            }
            else
            {
                SqlCommand insertcommand = new SqlCommand("update Donars set Name ='"+ @updonar_userName + "', Email = '"+ @updonar_userEmail + "', Phone_number = '"+ @updonar_Phone_number + "', Password = '"+ @updonar_Password + "', Address = '"+ @updonar_address + "',Occupation = '"+ @updonar_occupation + "',Fake_name = '"+ @updonar_fakename + "' where id = '"+UserLogin.id+"' ");

                insertcommand.Parameters.AddWithValue("@updonar_userName", updonar_userName);
                insertcommand.Parameters.AddWithValue("@updonar_userEmail", updonar_userEmail);
                insertcommand.Parameters.AddWithValue("@updonar_Phone_number", updonar_Phone_number);
                insertcommand.Parameters.AddWithValue("@updonar_Password", updonar_Password);
                
               
                insertcommand.Parameters.AddWithValue("@updonar_address", updonar_address);
                insertcommand.Parameters.AddWithValue("@updonar_occupation", updonar_occupation);
                insertcommand.Parameters.AddWithValue("@updonar_fakename", updonar_fakename);
               

                int row = objDBAccess.executeQuery(insertcommand);

                if (row == 1)
                {
                    MessageBox.Show("Account Updated Successfully");
                    UserLogin hf = new UserLogin();
                    this.Hide();
                    hf.Show();
                }
                else
                {
                    MessageBox.Show("Error occured. try again.");
                }
            }
        }
    }
}
