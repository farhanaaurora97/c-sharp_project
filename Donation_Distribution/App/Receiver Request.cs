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
    public partial class Receiver_Request : Form
    {
        public static string receiver_email;

        //DataTable dtUsers = new DataTable();
        DBAccess objDBAccess = new DBAccess();
        public Receiver_Request()
        {
            InitializeComponent();
        }

        private void Receiver_amount_ok_button_Click(object sender, EventArgs e)
        {
            DataTable dtUsers = new DataTable();
            string requester_email = UserLogin.email;
            string receiver_reason = Receiver_reason_textBox.Text;
            double requested_amount = Double.Parse(Receiver_enter_amount_textBox.Text);
            double needed_amount = requested_amount;
            double got_amount = 0.00;

            string query = "Select * From Receiver_requests Where Email = '" + requester_email + "'";
            objDBAccess.readDatathroughAdapter(query, dtUsers);
            if (dtUsers.Rows.Count == 1)
            {
                receiver_email = dtUsers.Rows[0]["Email"].ToString();
            }


            if (receiver_reason.Equals(""))
            {
                MessageBox.Show("please enter why you need donation.");
            }
            else if (requested_amount.Equals(""))
            {
                MessageBox.Show("please enter how much donation you want.");
            }
            else if (receiver_email==requester_email)
            {
                MessageBox.Show("you can not request more than one");
            }
            
            
            else
            {
                SqlCommand insertcommand = new SqlCommand("insert into Receiver_requests(Email,Reason,Amount_request,Amount_got,Amount_need) values(@requester_email,@receiver_reason,@requested_amount,@got_amount,@needed_amount)"); 

                insertcommand.Parameters.AddWithValue("@requester_email", requester_email);
                insertcommand.Parameters.AddWithValue("@receiver_reason", receiver_reason);
                insertcommand.Parameters.AddWithValue("@requested_amount", requested_amount);
                insertcommand.Parameters.AddWithValue("@needed_amount", needed_amount);
                insertcommand.Parameters.AddWithValue("@got_amount", got_amount);


                int row = objDBAccess.executeQuery(insertcommand);

                if (row == 1)
                {
                    MessageBox.Show("your request granted Successfully.");

                    this.Hide();

                    

                }
                else
                {
                    MessageBox.Show("something is wrong!!! try again.");
                }
                /* string query = "Select Name,ID,Reason,Amount_request,Amount_got,Amount_need From ReceiversJOIN receiver_requestsON Receivers.Email = Receiver_requests.Email; ";
                 objDBAccess.readDatathroughAdapter(query, dtUsers);
                 if (dtUsers.Rows.Count == 1)
                 {

                     receiver_id = dtUsers.Rows[0]["ID"].ToString();
                     receiver_name = dtUsers.Rows[0]["Name"].ToString();
                     reason = dtUsers.Rows[0]["Reason"].ToString();
                     req_amounts = dtUsers.Rows[0]["Amount_request"].ToString();
                     need_amounts = dtUsers.Rows[0]["Amount_got"].ToString();
                     got_amounts = dtUsers.Rows[0]["Amount_need"].ToString();
                 }
                 else
                 {
                     MessageBox.Show("error");
                 }*/
            }
        }

        private void Receiver_reason_textBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
