using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SattaTigerTS.Entities
{
    public class ApiUser
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string status { get; set; }
        public string jwt { get; set; }
        public string response_message { get; set; }
        public string request_id { get; set; }
    }
}
