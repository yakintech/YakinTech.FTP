using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YakinTech.FTP.Models
{
    public class FtpModel
    {
        public string Server { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Directory { get; set; }
        public string Target { get; set; }

    }
}
