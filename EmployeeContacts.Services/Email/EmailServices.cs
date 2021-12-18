
using OpenPop.Pop3;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;


namespace EmployeeContacts.Services.Email
{
    public class EmailServices : IEmailServices
    {
        private SmtpClient _CLIENT;
        private Pop3Client _POP3;
        private Config _CONFIG = new Config();

        public EmailServices()
        {
            _CLIENT = new SmtpClient(_CONFIG._MAIL_HOST);
            _CLIENT.Port = _CONFIG._MAIL_PORT;
            _CLIENT.EnableSsl = true;
            _CLIENT.Credentials = new NetworkCredential(_CONFIG._MAIL_USER, _CONFIG._MAIL_PASSWORD);

            _POP3 = new Pop3Client();
            _POP3.Connect(_CONFIG._POP3_HOST, _CONFIG._POP3_PORT, true);
            _POP3.Authenticate(_CONFIG._MAIL_USER, _CONFIG._MAIL_PASSWORD);

        }
        public bool Send(string sendTo, string subject, string body)
        {
            try
            {
                _CLIENT.Send(_CONFIG._MAIL_USER, sendTo, subject, body);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task<bool> SendAsync(string sendTo, string subject, string body)
        {
            try
            {
                await _CLIENT.SendMailAsync(_CONFIG._MAIL_USER, sendTo, subject, body);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<OpenPop.Mime.Message> GetMails()
        {
            int count = _POP3.GetMessageCount();
            List<OpenPop.Mime.Message> list = new List<OpenPop.Mime.Message>();
            if(count < 1)
            {
                return null;
            }
            for (int index = 1; index <= count; index++)
            {
                list.Add(_POP3.GetMessage(index));
            }
            return list;
        }
        
    }
}
