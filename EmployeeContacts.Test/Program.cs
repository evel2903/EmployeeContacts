using EmployeeContacts.Services.Email;
using OpenPop.Mime;
using OpenPop.Pop3;
using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        EmailServices emailServices = new EmailServices();
        var list = emailServices.GetMails();
        if (list != null)
        {
            list.ForEach(_e =>
            {
                Console.WriteLine(_e.Headers.From.ToString());
                Console.WriteLine(_e.Headers.DateSent.ToString("dddd, dd MMMM yyyy"));
                Console.WriteLine(_e.Headers.Subject.ToString());
                Console.WriteLine(_e.FindFirstPlainTextVersion().GetBodyAsText().Trim());
            });
        }

    }
}