using EmployeeContacts.Services.Email;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeContacts.WinFormsApp
{
    public partial class MailDetail : Form
    {
        private OpenPop.Mime.Message message;
        public MailDetail(OpenPop.Mime.Message m)
        {
            InitializeComponent();
            message = m;
            LoadData();
        }
        private void LoadData()
        {
            from_email.Text = message.Headers.From.Address.ToString();
            txt_curr_title.Text = message.Headers.Subject.ToString();
            txt_curr_date.Text = message.Headers.DateSent.ToString("dddd, dd MMMM yyyy");
            txt_curr_content.Text = message.FindFirstPlainTextVersion().GetBodyAsText().Trim();
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            if(txt_new_content.Text.Equals("") || txt_new_title.Text.Equals(""))
            {
                MessageBox.Show("Hãy nhập nội dung", "Lỗi nhập liệu");
                return;
            }
            EmailServices emailServices = new EmailServices();
            emailServices.Send(from_email.Text, txt_new_title.Text, txt_new_content.Text);
            MessageBox.Show("Trả lời email thành công", "Thành công");
            this.Close();
        }
    }
}
