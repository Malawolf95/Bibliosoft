using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliosoft
{
    internal class SystemSupportMail:MasterMailServer
    {
        public SystemSupportMail()
        {
            senderMail = "miguelangelhenaotorres05@gmail.com";
            password = "vnhthwzkdhdeeujk";
            host = "smtp.gmail.com";
            port = 587;
            ssl = true;
            initializeSmtpClient();
        }
    }
}
