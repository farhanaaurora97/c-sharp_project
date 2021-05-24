using System;

namespace Donation_Distribution
{
    partial class UserLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.User_email_label = new System.Windows.Forms.Label();
            this.User_email_textbox = new System.Windows.Forms.TextBox();
            this.Donar_login_button = new System.Windows.Forms.Button();
            this.Donar_signup_label1 = new System.Windows.Forms.Label();
            this.User_password_textBox = new System.Windows.Forms.TextBox();
            this.User_password_label = new System.Windows.Forms.Label();
            this.Donar_back_form1_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // User_email_label
            // 
            this.User_email_label.AutoSize = true;
            this.User_email_label.Font = new System.Drawing.Font("Arial Black", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User_email_label.Location = new System.Drawing.Point(88, 70);
            this.User_email_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.User_email_label.Name = "User_email_label";
            this.User_email_label.Size = new System.Drawing.Size(171, 28);
            this.User_email_label.TabIndex = 0;
            this.User_email_label.Text = "USER EMAIL  :";
            // 
            // User_email_textbox
            // 
            this.User_email_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User_email_textbox.Location = new System.Drawing.Point(274, 70);
            this.User_email_textbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.User_email_textbox.Multiline = true;
            this.User_email_textbox.Name = "User_email_textbox";
            this.User_email_textbox.Size = new System.Drawing.Size(261, 30);
            this.User_email_textbox.TabIndex = 1;
            // 
            // Donar_login_button
            // 
            this.Donar_login_button.Font = new System.Drawing.Font("Arial Black", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Donar_login_button.Location = new System.Drawing.Point(394, 232);
            this.Donar_login_button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Donar_login_button.Name = "Donar_login_button";
            this.Donar_login_button.Size = new System.Drawing.Size(140, 45);
            this.Donar_login_button.TabIndex = 2;
            this.Donar_login_button.Text = "LOGIN";
            this.Donar_login_button.UseVisualStyleBackColor = true;
            this.Donar_login_button.Click += new System.EventHandler(this.Donar_login_button_Click);
            // 
            // Donar_signup_label1
            // 
            this.Donar_signup_label1.AutoSize = true;
            this.Donar_signup_label1.Font = new System.Drawing.Font("Arial Black", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Donar_signup_label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Donar_signup_label1.Location = new System.Drawing.Point(208, 308);
            this.Donar_signup_label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Donar_signup_label1.Name = "Donar_signup_label1";
            this.Donar_signup_label1.Size = new System.Drawing.Size(343, 15);
            this.Donar_signup_label1.TabIndex = 5;
            this.Donar_signup_label1.Text = "Do you have no account? CLICK here for create new one";
            this.Donar_signup_label1.Click += new System.EventHandler(this.Donar_signup_label1_Click);
            // 
            // User_password_textBox
            // 
            this.User_password_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User_password_textBox.Location = new System.Drawing.Point(274, 166);
            this.User_password_textBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.User_password_textBox.Multiline = true;
            this.User_password_textBox.Name = "User_password_textBox";
            this.User_password_textBox.PasswordChar = '*';
            this.User_password_textBox.Size = new System.Drawing.Size(261, 30);
            this.User_password_textBox.TabIndex = 7;
            // 
            // User_password_label
            // 
            this.User_password_label.AutoSize = true;
            this.User_password_label.Font = new System.Drawing.Font("Arial Black", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User_password_label.Location = new System.Drawing.Point(88, 166);
            this.User_password_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.User_password_label.Name = "User_password_label";
            this.User_password_label.Size = new System.Drawing.Size(158, 28);
            this.User_password_label.TabIndex = 6;
            this.User_password_label.Text = "PASSWORD  :";
            // 
            // Donar_back_form1_button
            // 
            this.Donar_back_form1_button.Font = new System.Drawing.Font("Arial Black", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Donar_back_form1_button.Location = new System.Drawing.Point(250, 232);
            this.Donar_back_form1_button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Donar_back_form1_button.Name = "Donar_back_form1_button";
            this.Donar_back_form1_button.Size = new System.Drawing.Size(140, 45);
            this.Donar_back_form1_button.TabIndex = 8;
            this.Donar_back_form1_button.Text = "BACK";
            this.Donar_back_form1_button.UseVisualStyleBackColor = true;
            this.Donar_back_form1_button.Click += new System.EventHandler(this.Donar_back_form1_button_Click);
            // 
            // UserLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.Donar_back_form1_button);
            this.Controls.Add(this.User_password_textBox);
            this.Controls.Add(this.User_password_label);
            this.Controls.Add(this.Donar_signup_label1);
            this.Controls.Add(this.Donar_login_button);
            this.Controls.Add(this.User_email_textbox);
            this.Controls.Add(this.User_email_label);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UserLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.UserLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void UserLogin_Load(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label User_email_label;
        private System.Windows.Forms.TextBox User_email_textbox;
        private System.Windows.Forms.Button Donar_login_button;
        private System.Windows.Forms.Label Donar_signup_label1;
        private System.Windows.Forms.TextBox User_password_textBox;
        private System.Windows.Forms.Label User_password_label;
        private System.Windows.Forms.Button Donar_back_form1_button;
    }
}