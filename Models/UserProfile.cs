using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EchoBot1.Models
{
    public class UserProfile
    {
        public string Name { get; set; }
        public string Description { get; internal set; }
        public DateTime CallbackTime { get; internal set; }
        public string PhoneNumber { get; internal set; }
        public string Bug { get; internal set; }
    }
}
