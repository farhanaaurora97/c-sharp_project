namespace Donation_Distribution
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.Donar_User = new System.Windows.Forms.Button();
            this.Receiver_user = new System.Windows.Forms.Button();
            this.Back_to_login_button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(208, 217);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1278, 70);
            this.label1.TabIndex = 0;
            this.label1.Text = "which kind of account do you want to create?\r\n";
            // 
            // Donar_User
            // 
            this.Donar_User.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Donar_User.Location = new System.Drawing.Point(220, 535);
            this.Donar_User.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Donar_User.Name = "Donar_User";
            this.Donar_User.Size = new System.Drawing.Size(400, 108);
            this.Donar_User.TabIndex = 1;
            this.Donar_User.Text = "Donar";
            this.Donar_User.UseVisualStyleBackColor = true;
            this.Donar_User.Click += new System.EventHandler(this.Donar_User_Click);
            // 
            // Receiver_user
            // 
            this.Receiver_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Receiver_user.Location = new System.Drawing.Point(1102, 535);
            this.Receiver_user.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Receiver_user.Name = "Receiver_user";
            this.Receiver_user.Size = new System.Drawing.Size(400, 108);
            this.Receiver_user.TabIndex = 2;
            this.Receiver_user.Text = "Receiver";
            this.Receiver_user.UseVisualStyleBackColor = true;
            this.Receiver_user.Click += new System.EventHandler(this.Receiver_user_Click);
            // 
            // Back_to_login_button1
            // 
            this.Back_to_login_button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back_to_login_button1.Location = new System.Drawing.Point(1202, 818);
            this.Back_to_login_button1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Back_to_login_button1.Name = "Back_to_login_button1";
            this.Back_to_login_button1.Size = new System.Drawing.Size(300, 101);
            this.Back_to_login_button1.TabIndex = 3;
            this.Back_to_login_button1.Text = "Back";
            this.Back_to_login_button1.UseVisualStyleBackColor = true;
            this.Back_to_login_button1.Click += new System.EventHandler(this.Back_to_login_button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1658, 1035);
            this.Controls.Add(this.Back_to_login_button1);
            this.Controls.Add(this.Receiver_user);
            this.Controls.Add(this.Donar_User);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Signup type selection";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Donar_User;
        private System.Windows.Forms.Button Receiver_user;
        private System.Windows.Forms.Button Back_to_login_button1;
    }
}

