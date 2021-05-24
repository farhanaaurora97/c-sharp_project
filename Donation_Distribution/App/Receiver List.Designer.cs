namespace Donation_Distribution
{
    partial class Receiver_List
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
            this.Next_button = new System.Windows.Forms.Button();
            this.Previous_button = new System.Windows.Forms.Button();
            this.Receiver_amount_list_textBox1 = new System.Windows.Forms.TextBox();
            this.Receiver_amount_list_label1 = new System.Windows.Forms.Label();
            this.Receiver_description_list_textbox1 = new System.Windows.Forms.TextBox();
            this.Receiver_description_list_label1 = new System.Windows.Forms.Label();
            this.Receiver_name_list_label1 = new System.Windows.Forms.Label();
            this.Receiver_names_comboBox = new System.Windows.Forms.ComboBox();
            this.Donate_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Next_button
            // 
            this.Next_button.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Next_button.Location = new System.Drawing.Point(669, 541);
            this.Next_button.Margin = new System.Windows.Forms.Padding(2);
            this.Next_button.Name = "Next_button";
            this.Next_button.Size = new System.Drawing.Size(198, 77);
            this.Next_button.TabIndex = 42;
            this.Next_button.Text = "Next";
            this.Next_button.UseVisualStyleBackColor = true;
            // 
            // Previous_button
            // 
            this.Previous_button.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Previous_button.Location = new System.Drawing.Point(408, 541);
            this.Previous_button.Margin = new System.Windows.Forms.Padding(2);
            this.Previous_button.Name = "Previous_button";
            this.Previous_button.Size = new System.Drawing.Size(199, 77);
            this.Previous_button.TabIndex = 41;
            this.Previous_button.Text = "Back";
            this.Previous_button.UseVisualStyleBackColor = true;
            this.Previous_button.Click += new System.EventHandler(this.Previous_button_Click);
            // 
            // Receiver_amount_list_textBox1
            // 
            this.Receiver_amount_list_textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Receiver_amount_list_textBox1.Location = new System.Drawing.Point(690, 98);
            this.Receiver_amount_list_textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.Receiver_amount_list_textBox1.Multiline = true;
            this.Receiver_amount_list_textBox1.Name = "Receiver_amount_list_textBox1";
            this.Receiver_amount_list_textBox1.ReadOnly = true;
            this.Receiver_amount_list_textBox1.Size = new System.Drawing.Size(177, 28);
            this.Receiver_amount_list_textBox1.TabIndex = 28;
            // 
            // Receiver_amount_list_label1
            // 
            this.Receiver_amount_list_label1.AutoSize = true;
            this.Receiver_amount_list_label1.Location = new System.Drawing.Point(687, 69);
            this.Receiver_amount_list_label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Receiver_amount_list_label1.Name = "Receiver_amount_list_label1";
            this.Receiver_amount_list_label1.Size = new System.Drawing.Size(137, 17);
            this.Receiver_amount_list_label1.TabIndex = 27;
            this.Receiver_amount_list_label1.Text = "Requested Amount :";
            // 
            // Receiver_description_list_textbox1
            // 
            this.Receiver_description_list_textbox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Receiver_description_list_textbox1.Location = new System.Drawing.Point(347, 98);
            this.Receiver_description_list_textbox1.Margin = new System.Windows.Forms.Padding(2);
            this.Receiver_description_list_textbox1.Multiline = true;
            this.Receiver_description_list_textbox1.Name = "Receiver_description_list_textbox1";
            this.Receiver_description_list_textbox1.ReadOnly = true;
            this.Receiver_description_list_textbox1.Size = new System.Drawing.Size(299, 395);
            this.Receiver_description_list_textbox1.TabIndex = 26;
            // 
            // Receiver_description_list_label1
            // 
            this.Receiver_description_list_label1.AutoSize = true;
            this.Receiver_description_list_label1.Location = new System.Drawing.Point(344, 69);
            this.Receiver_description_list_label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Receiver_description_list_label1.Name = "Receiver_description_list_label1";
            this.Receiver_description_list_label1.Size = new System.Drawing.Size(87, 17);
            this.Receiver_description_list_label1.TabIndex = 25;
            this.Receiver_description_list_label1.Text = "Description :";
            // 
            // Receiver_name_list_label1
            // 
            this.Receiver_name_list_label1.AutoSize = true;
            this.Receiver_name_list_label1.Location = new System.Drawing.Point(36, 69);
            this.Receiver_name_list_label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Receiver_name_list_label1.Name = "Receiver_name_list_label1";
            this.Receiver_name_list_label1.Size = new System.Drawing.Size(53, 17);
            this.Receiver_name_list_label1.TabIndex = 23;
            this.Receiver_name_list_label1.Text = "Name :";
            // 
            // Receiver_names_comboBox
            // 
            this.Receiver_names_comboBox.FormattingEnabled = true;
            this.Receiver_names_comboBox.Location = new System.Drawing.Point(39, 98);
            this.Receiver_names_comboBox.Name = "Receiver_names_comboBox";
            this.Receiver_names_comboBox.Size = new System.Drawing.Size(254, 24);
            this.Receiver_names_comboBox.TabIndex = 44;
            this.Receiver_names_comboBox.SelectedIndexChanged += new System.EventHandler(this.Receiver_names_comboBox_SelectedIndexChanged);
            // 
            // Donate_button
            // 
            this.Donate_button.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Donate_button.Location = new System.Drawing.Point(668, 291);
            this.Donate_button.Margin = new System.Windows.Forms.Padding(2);
            this.Donate_button.Name = "Donate_button";
            this.Donate_button.Size = new System.Drawing.Size(199, 77);
            this.Donate_button.TabIndex = 45;
            this.Donate_button.Text = "Donate";
            this.Donate_button.UseVisualStyleBackColor = true;
            this.Donate_button.Click += new System.EventHandler(this.Donate_button_Click);
            // 
            // Receiver_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 716);
            this.Controls.Add(this.Donate_button);
            this.Controls.Add(this.Receiver_names_comboBox);
            this.Controls.Add(this.Next_button);
            this.Controls.Add(this.Previous_button);
            this.Controls.Add(this.Receiver_amount_list_textBox1);
            this.Controls.Add(this.Receiver_amount_list_label1);
            this.Controls.Add(this.Receiver_description_list_textbox1);
            this.Controls.Add(this.Receiver_description_list_label1);
            this.Controls.Add(this.Receiver_name_list_label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Receiver_List";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Receiver_List";
            this.Load += new System.EventHandler(this.Receiver_List_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Next_button;
        private System.Windows.Forms.Button Previous_button;
        private System.Windows.Forms.TextBox Receiver_amount_list_textBox1;
        private System.Windows.Forms.Label Receiver_amount_list_label1;
        private System.Windows.Forms.TextBox Receiver_description_list_textbox1;
        private System.Windows.Forms.Label Receiver_description_list_label1;
        private System.Windows.Forms.Label Receiver_name_list_label1;
        private System.Windows.Forms.ComboBox Receiver_names_comboBox;
        private System.Windows.Forms.Button Donate_button;
    }
}