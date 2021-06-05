using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaTranz.NotificationModel
{
    public class CloseNotificationMessage : NotificationMessage
    {
        public CloseNotificationMessage()
        {
            Title = "Close";
        }
    }
}
