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
    public partial class MailBox : Form
    {
        private EmailServices emailServices;
        public MailBox()
        {
            InitializeComponent();      
            GetEMailsList();
        }

        private void GetEMailsList()
        {
            table_mails.Rows.Clear();

            emailServices = new EmailServices();
            var list = emailServices.GetMails();
            if (list != null)
            {
                list.ForEach(_e =>
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(table_mails);
                    row.Cells[0].Value = list.IndexOf(_e);
                    row.Cells[1].Value = _e.Headers.From.ToString();
                    row.Cells[2].Value = _e.Headers.Subject.ToString();
                    row.Cells[3].Value = _e.Headers.DateSent.ToString("dddd, dd MMMM yyyy");
                    table_mails.Rows.Add(row);
                    //Console.WriteLine(_e.FindFirstPlainTextVersion().GetBodyAsText().Trim());
                });
            }
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            emailServices = new EmailServices();
            GetEMailsList();
        }

        private void table_mails_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            emailServices = new EmailServices();
            var list = emailServices.GetMails();
            if (e.RowIndex != -1)
            {
                DataGridViewRow selected = table_mails.Rows[e.RowIndex];
                int stt = Int32.Parse(selected.Cells[0].Value.ToString());
                new MailDetail(list[stt]).Show();
            }
                
        }
    }
}
