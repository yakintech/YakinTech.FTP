using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YakinTech.FTP.Models
{
    public class FTPResultFile
    {
        public bool IsSuccess { get; set; }
        public Exception Exception { get; set; }
        public string Message { get; set; }
    }
}
