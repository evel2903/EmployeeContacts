using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeContacts.Services.Email
{
    public interface IEmailServices
    {
        bool Send(string sendTo, string subject, string body);
        Task<bool> SendAsync(string sendTo, string subject, string body);
        List<OpenPop.Mime.Message> GetMails();
    }
}
