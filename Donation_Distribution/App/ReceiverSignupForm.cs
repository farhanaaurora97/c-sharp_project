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
    public partial class ReceiverSignupForm : Form
    {
        public ReceiverSignupForm()
        {
            InitializeComponent();
        }

        private void Back_to_signup_type_button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f2 = new Form1();
            f2.Show();
        }

        private void Receiver_signup_confirm_button_Click(object sender, EventArgs e)
        {

            DBAccess objDBAccess = new DBAccess();
            string receiver_userName = Receiver_name_textbox.Text;
            string receiver_userEmail = Receiver_email_textbox.Text;
            string receiver_Phone_number = Receiver_phn_num_textbox.Text;
            string receiver_Password = Receiver_password_textbox.Text;
            string receiver_dob = Receiver_dateTimePicker.Text;
            string receiver_present_address = Receiver_Present_address_textBox.Text;
            string receiver_permanent_address = Receiver_Permanent_address_textBox.Text;
            string receiver_occupation = Receiver_occupation_textbox.Text;
            string receiver_nid = Receiver_NID_textBox.Text;
            string receiver_organization_type = Receiver_organization_type_comboBox.Text;
            string receiver_marital_status = Receiver_marital_comboBox.Text;
            string receiver_religion = Receiver_religion_textBox.Text;
            string receiver_reference_person_name = Receiver_refered_person_name_textBox.Text;
            string receiver_reference_person_phone_number = Receiver_refered_phnNum_textBox.Text;
            string receiver_gender = Gender();
            int receiver_age = CalculateAge();
            



            if (receiver_userName.Equals(""))
            {
                MessageBox.Show("please enter your Name.");
            }
            else if (receiver_userEmail.Equals(""))
            {
                MessageBox.Show("please enter your Email.");
            }
            else if (receiver_Phone_number.Equals(""))
            {
                MessageBox.Show("please enter your Phone number.");
            }
            else if (receiver_Password.Equals(""))
            {
                MessageBox.Show("please enter your Password.");
            }
            else if (receiver_dob.Equals(""))
            {
                MessageBox.Show("please enter your Date of Birth.");
            }
            else if (receiver_present_address.Equals(""))
            {
                MessageBox.Show("please enter your present address.");
            }
            else if (receiver_permanent_address.Equals(""))
            {
                MessageBox.Show("please enter your permanent address.");
            }
            else if (receiver_occupation.Equals(""))
            {
                MessageBox.Show("please enter your occupation.");
            }
            else if (receiver_nid.Equals(""))
            {
                MessageBox.Show("please enter your NID number.");
            }
            else if (receiver_organization_type.Equals(""))
            {
                MessageBox.Show("please enter an organization.");
            }
            else if (receiver_marital_status.Equals(""))
            {
                MessageBox.Show("please enter your marital status.");
            }
            else if (receiver_religion.Equals(""))
            {
                MessageBox.Show("please enter your religion.");
            }
            else if (receiver_reference_person_name.Equals(""))
            {
                MessageBox.Show("please enter a person name who you want to be referred.");
            }
            else if (receiver_reference_person_phone_number.Equals(""))
            {
                MessageBox.Show("please enter referred person's phone number.");
            }
            else
            {
                SqlCommand insertcommand = new SqlCommand("insert into Receivers(Name,Email,Phone_number,Password,Date_of_Birth,Age,Present_address,Permanent_address,Occupation,Gender,Marital_status,NID,Religion,Reference_person_name,Reference_person_phone_number,Organization_type) values(@receiver_userName,@receiver_userEmail,@receiver_Phone_number,@receiver_Password,@receiver_dob,@receiver_age,@receiver_present_address,@receiver_permanent_address,@receiver_occupation,@receiver_gender,@receiver_marital_status,@receiver_nid,@receiver_religion,@receiver_reference_person_name,@receiver_reference_person_phone_number,@receiver_organization_type)");

                insertcommand.Parameters.AddWithValue("@receiver_userName", receiver_userName);
                insertcommand.Parameters.AddWithValue("@receiver_userEmail", receiver_userEmail);
                insertcommand.Parameters.AddWithValue("@receiver_Phone_number", receiver_Phone_number);
                insertcommand.Parameters.AddWithValue("@receiver_Password", receiver_Password);
                insertcommand.Parameters.AddWithValue("@receiver_dob", receiver_dob);
                insertcommand.Parameters.AddWithValue("@receiver_present_address", receiver_present_address);
                insertcommand.Parameters.AddWithValue("@receiver_permanent_address", receiver_permanent_address);
                insertcommand.Parameters.AddWithValue("@receiver_occupation", receiver_occupation);
                insertcommand.Parameters.AddWithValue("@receiver_nid", receiver_nid);
                insertcommand.Parameters.AddWithValue("@receiver_organization_type", receiver_organization_type);
                insertcommand.Parameters.AddWithValue("@receiver_marital_status", receiver_marital_status);
                insertcommand.Parameters.AddWithValue("@receiver_religion", receiver_religion);
                insertcommand.Parameters.AddWithValue("@receiver_reference_person_name", receiver_reference_person_name);
                insertcommand.Parameters.AddWithValue("@receiver_reference_person_phone_number", receiver_reference_person_phone_number);
                insertcommand.Parameters.AddWithValue("@receiver_gender", receiver_gender);
                insertcommand.Parameters.AddWithValue("@receiver_age", receiver_age);

                int row = objDBAccess.executeQuery(insertcommand);

                if (row == 1)
                {
                    MessageBox.Show("Account created Successfully");
                    UserLogin rpf = new UserLogin();
                    this.Hide();
                    rpf.Show();
                }
                else
                {
                    MessageBox.Show("Error occured. try again.");
                }
            }
            int CalculateAge()
            {
                int years = DateTime.Now.Year - Receiver_dateTimePicker.Value.Year;

                if (Receiver_dateTimePicker.Value.AddYears(years) > DateTime.Now)
                {
                    years--;
                }


                return years;
            }
            string Gender()
            {
                if (Receiver_male_radioButton.Checked)
                {
                    return "Male";
                }
                else if (Receiver_female_radioButton.Checked)
                {
                    return "Female";
                }
                else if (Receiver_other_radioButton.Checked)
                { return "Others"; }
                else
                {
                    return "Please select a gender";
                }
            }



        }

       
    }
}
