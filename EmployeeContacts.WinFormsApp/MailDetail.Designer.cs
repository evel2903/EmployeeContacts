
namespace EmployeeContacts.WinFormsApp
{
    partial class MailDetail
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
            this.label2 = new System.Windows.Forms.Label();
            this.txt_curr_date = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_curr_title = new System.Windows.Forms.TextBox();
            this.from_email = new System.Windows.Forms.TextBox();
            this.txt_curr_content = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_send = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_new_title = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_new_content = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Người Gửi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 41);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày gửi";
            // 
            // txt_curr_date
            // 
            this.txt_curr_date.AutoSize = true;
            this.txt_curr_date.Location = new System.Drawing.Point(86, 41);
            this.txt_curr_date.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt_curr_date.Name = "txt_curr_date";
            this.txt_curr_date.Size = new System.Drawing.Size(52, 21);
            this.txt_curr_date.TabIndex = 2;
            this.txt_curr_date.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 74);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tiêu đề";
            // 
            // txt_curr_title
            // 
            this.txt_curr_title.BackColor = System.Drawing.Color.White;
            this.txt_curr_title.Enabled = false;
            this.txt_curr_title.Location = new System.Drawing.Point(87, 71);
            this.txt_curr_title.Margin = new System.Windows.Forms.Padding(4);
            this.txt_curr_title.Name = "txt_curr_title";
            this.txt_curr_title.Size = new System.Drawing.Size(457, 29);
            this.txt_curr_title.TabIndex = 4;
            // 
            // from_email
            // 
            this.from_email.BackColor = System.Drawing.Color.White;
            this.from_email.Enabled = false;
            this.from_email.Location = new System.Drawing.Point(86, 4);
            this.from_email.Margin = new System.Windows.Forms.Padding(4);
            this.from_email.Name = "from_email";
            this.from_email.Size = new System.Drawing.Size(458, 29);
            this.from_email.TabIndex = 5;
            // 
            // txt_curr_content
            // 
            this.txt_curr_content.BackColor = System.Drawing.Color.White;
            this.txt_curr_content.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_curr_content.Enabled = false;
            this.txt_curr_content.Location = new System.Drawing.Point(4, 137);
            this.txt_curr_content.Margin = new System.Windows.Forms.Padding(4);
            this.txt_curr_content.Name = "txt_curr_content";
            this.txt_curr_content.Size = new System.Drawing.Size(540, 588);
            this.txt_curr_content.TabIndex = 6;
            this.txt_curr_content.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 112);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 21);
            this.label5.TabIndex = 7;
            this.label5.Text = "Nội dung";
            // 
            // btn_send
            // 
            this.btn_send.Location = new System.Drawing.Point(470, 693);
            this.btn_send.Margin = new System.Windows.Forms.Padding(4);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(96, 32);
            this.btn_send.TabIndex = 8;
            this.btn_send.Text = "Trả lời";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.from_email);
            this.panel1.Controls.Add(this.txt_curr_content);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_curr_date);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txt_curr_title);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(548, 729);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txt_new_title);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txt_new_content);
            this.panel2.Controls.Add(this.btn_send);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(554, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(570, 729);
            this.panel2.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 45);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 21);
            this.label7.TabIndex = 8;
            this.label7.Text = "Nội dung";
            // 
            // txt_new_title
            // 
            this.txt_new_title.BackColor = System.Drawing.Color.White;
            this.txt_new_title.Location = new System.Drawing.Point(60, 4);
            this.txt_new_title.Margin = new System.Windows.Forms.Padding(4);
            this.txt_new_title.Name = "txt_new_title";
            this.txt_new_title.Size = new System.Drawing.Size(506, 29);
            this.txt_new_title.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1, 9);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 21);
            this.label6.TabIndex = 10;
            this.label6.Text = "Tiêu đề";
            // 
            // txt_new_content
            // 
            this.txt_new_content.BackColor = System.Drawing.Color.White;
            this.txt_new_content.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_new_content.Location = new System.Drawing.Point(4, 70);
            this.txt_new_content.Margin = new System.Windows.Forms.Padding(4);
            this.txt_new_content.Name = "txt_new_content";
            this.txt_new_content.Size = new System.Drawing.Size(562, 615);
            this.txt_new_content.TabIndex = 9;
            this.txt_new_content.Text = "";
            // 
            // MailDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1124, 729);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MailDetail";
            this.Text = "MailDetail";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txt_curr_date;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_curr_title;
        private System.Windows.Forms.TextBox from_email;
        private System.Windows.Forms.RichTextBox txt_curr_content;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_new_title;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox txt_new_content;
    }
}