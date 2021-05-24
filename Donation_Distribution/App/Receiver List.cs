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

namespace Donation_Distribution
{
    public partial class Receiver_List : Form
    {
        public static string receiver_name, receiver_id, reason, req_amounts, need_amounts, got_amounts, total_receiver;
        public static double n_amount;
        public static double g_amount;
        public static double donarUser_c_balance = Double.Parse(UserLogin.current_balance);

        //System info
        public static string account_name, current_stored_amount, total_received_donation, total_delivered_donation;
        public static double cs_amount, tr_donation, td_donation;
        private void Previous_button_Click(object sender, EventArgs e)
        {
            Donar_Profile dp = new Donar_Profile();
            this.Hide();
            dp.Show();
        }

        private void Donate_button_Click(object sender, EventArgs e)
        {
            if(Receiver_names_comboBox.Text.Equals(""))
            {
                MessageBox.Show("Please select a receiver.");
            }
            else
            {
                if (Double.Parse(need_amounts) == 0) 
                {
                    MessageBox.Show("This person's request has been full fill. Don't need more money");
                }
                else
                {
                    if (Double.Parse(UserLogin.current_balance) > 0)
                    {
                        
                        DialogResult dialogResult = MessageBox.Show("Do you want to donate it ?", "You have " + UserLogin.current_balance + " money stroed in your balance", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                           /* this.Refresh();
                            if (Double.Parse(need_amounts) == 0)
                            {
                                MessageBox.Show("This person's request has been full fill. Don't need more money");
                                
                            }
                            else */
                            if (Double.Parse(need_amounts) >= Double.Parse(UserLogin.current_balance))
                            {
                                g_amount = Double.Parse(got_amounts) + Double.Parse(UserLogin.current_balance);
                                n_amount = (Double.Parse(need_amounts) - Double.Parse(UserLogin.current_balance));
                                
                                cs_amount = Double.Parse(current_stored_amount) - Double.Parse(UserLogin.current_balance);
                                td_donation = Double.Parse(total_delivered_donation) + Double.Parse(UserLogin.current_balance);
                                donarUser_c_balance = 0.00;
                                
                            }
                            else
                            {
                                g_amount = Double.Parse(got_amounts) + Double.Parse(need_amounts);
                                donarUser_c_balance = Double.Parse(UserLogin.current_balance) - Double.Parse(need_amounts);
                                
                                cs_amount = Double.Parse(current_stored_amount) - Double.Parse(need_amounts);
                                td_donation = Double.Parse(total_delivered_donation) + Double.Parse(need_amounts);
                                n_amount = 0.00;
                                
                            }
                            //MessageBox.Show(receiver_id);
                            string query11 = "UPDATE Receiver_requests SET Amount_need = '" + n_amount + "', Amount_got = '" + g_amount + "' WHERE rid = '" + receiver_id + "' ";
                            objDBAccess.readDatathroughAdapter(query11, dtUsers);

                            string query12 = "UPDATE System_account SET  Total_delivered_donation = '" + td_donation + "', Current_stored_amount = '" + cs_amount + "' WHERE Account_name = 'SYSTEM'; ";
                            objDBAccess.readDatathroughAdapter(query12, dtUsers);

                            string query13 = "UPDATE Donars SET Current_Balance = '" + donarUser_c_balance + "' WHERE ID = '" + UserLogin.id + "'; ";
                            objDBAccess.readDatathroughAdapter(query13, dtUsers);
                            this.Refresh();
                            MessageBox.Show("Thanks for your donation, your donation transfer successfully.");
                            Donar_Profile dp = new Donar_Profile();
                            this.Hide();
                            dp.Refresh();
                            //dp.Show();
                            UserLogin l = new UserLogin();
                            l.Show();
                            
                        }
                        else
                        {
                            MessageBox.Show("Thankyou for your service.");
                            
                        }
                    }
                    else if (Double.Parse(UserLogin.current_balance) == 0)
                    {
                        Donar_Amount da = new Donar_Amount();
                        da.Show();
                        this.Hide();
                        
                    }
                    else
                    {
                        MessageBox.Show("Somthing Error!!!");
                        
                    }
                    
                }
                
            }
            
        }

        private void Receiver_names_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
                string query2 = "Select Name,rid,Reason,Amount_request,Amount_got,Amount_need From Receivers JOIN receiver_requests ON Receivers.Email = Receiver_requests.Email Where Name = '" + Receiver_names_comboBox.Text + "'";

                objDBAccess.readDatathroughAdapter(query2, dtUsers);
                //MessageBox.Show(dtUsers.Rows.Count.ToString());
                int du = dtUsers.Rows.Count;
                if (dtUsers.Rows.Count == du)
                {
                    receiver_name = dtUsers.Rows[du - 1]["Name"].ToString();
                    receiver_id = dtUsers.Rows[du - 1]["rid"].ToString();
                    reason = dtUsers.Rows[du - 1]["Reason"].ToString();
                    req_amounts = dtUsers.Rows[du - 1]["Amount_request"].ToString();
                    need_amounts = dtUsers.Rows[du - 1]["Amount_need"].ToString();
                    got_amounts = dtUsers.Rows[du - 1]["Amount_got"].ToString();

                }
                else
                {
                    MessageBox.Show("error2");
                }
            
            Receiver_description_list_textbox1.Text = reason;
            Receiver_amount_list_textBox1.Text = need_amounts;

        }

        int tr;
        

        DataTable dtUsers = new DataTable();
        DBAccess objDBAccess = new DBAccess();
        public Receiver_List()
        {
            InitializeComponent();
        }

        private void Receiver_List_Load(object sender, EventArgs e)
        {
            string query1 = "SELECT count( * ) as  total_record FROM Receiver_requests";
            objDBAccess.readDatathroughAdapter(query1, dtUsers);
            if (dtUsers.Rows.Count == 1)
            {
                total_receiver = dtUsers.Rows[0]["total_record"].ToString();
                tr = Int32.Parse(total_receiver);
            }
            else
            {
                MessageBox.Show("error1");
            }

            for(int i =1; i<=tr;i++)
            {
                string query = "Select Name,ID,Reason,Amount_request,Amount_got,Amount_need From Receivers JOIN receiver_requests ON Receivers.Email = Receiver_requests.Email Where rid = '" + i + "'";

                objDBAccess.readDatathroughAdapter(query, dtUsers);
                
                if (dtUsers.Rows.Count == i+1)
                { 
                    receiver_name = dtUsers.Rows[i]["Name"].ToString();
                    
                }
                else
                {
                    MessageBox.Show("error2");
                }
                Receiver_names_comboBox.Items.Add(receiver_name);
                 
               
            }

            string query4 = "SELECT *  FROM System_account";
            objDBAccess.readDatathroughAdapter(query4, dtUsers);
            //MessageBox.Show("hey  " + dtUsers.Rows.Count.ToString());
            int du = dtUsers.Rows.Count;
            if (dtUsers.Rows.Count == du)
            {
                account_name = dtUsers.Rows[du-1]["Account_name"].ToString();
                current_stored_amount = dtUsers.Rows[du-1]["Current_stored_amount"].ToString();
                cs_amount = Double.Parse(current_stored_amount);

                total_received_donation = dtUsers.Rows[du-1]["Total_received_donation"].ToString();
                tr_donation = Double.Parse(total_received_donation);

                total_delivered_donation = dtUsers.Rows[du-1]["Total_delivered_donation"].ToString();
                td_donation = Double.Parse(total_delivered_donation);

            }
            else
            {
                MessageBox.Show("error65");
            }

            this.Refresh();
        }
    }
}
