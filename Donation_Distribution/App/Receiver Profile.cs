using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Donation_Distribution
{
    public partial class Receiver_Profile_form : Form
    {
        public Receiver_Profile_form()
        {
            InitializeComponent();
        }

        private void Receiver_logout_button_Click(object sender, EventArgs e)
        {
            UserLogin rsf = new UserLogin();
            this.Hide();
            rsf.Show();
        }

        private void Receiver_to_home_button_Click(object sender, EventArgs e)
        {
            Home h2 = new Home();
            this.Hide();
            h2.Show();
        }

        private void Receiver_RequestForDonation_button_Click(object sender, EventArgs e)
        {
            Receiver_Request rr1 = new Receiver_Request();
            //this.Hide();
            rr1.Show();
            
        }

        private void Receiver_Profile_form_Load(object sender, EventArgs e)
        {
            Receiver_id_textBox.Text = UserLogin.id;
            Receiver_name_textbox2.Text = UserLogin.name;
            Receiver_email_textbox2.Text = UserLogin.email;
            Receiver_phn_num_textbox2.Text = UserLogin.phn_num;
            Receiver_dob_textBox2.Text = UserLogin.dob;
            Receiver_age_textbox.Text = UserLogin.age;
            Receiver_occupation_textbox2.Text = UserLogin.occupation;
            Receiver_gender_textBox2.Text = UserLogin.gender;
            Receiver_Present_address_textBox2.Text = UserLogin.present_address;
            Receiver_Permanent_address_textBox2.Text = UserLogin.present_address;
            Receiver_NID_textBox2.Text = UserLogin.nid;
            Receiver_marital_textBox2.Text = UserLogin.marital_status;
            Receiver_religion_textBox2.Text = UserLogin.religion;
            Receiver_refered_person_name_textBox2.Text = UserLogin.reference_person_name;
            Receiver_refered_phnNum_textBox2.Text = UserLogin.reference_person_phn_number;
            Receiver_organization_type_textBox2.Text = UserLogin.organization_type;
        }
    }
}
