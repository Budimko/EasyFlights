using System;
using System.Collections.Generic;
using System.Text;

namespace EasyFlights.Entites
{
    public class Friend
    {
        public Guid Id { get; set; }
        public Guid UserSendId { get; set; }
        public Guid UserReceivedId { get; set; }
    }
}
