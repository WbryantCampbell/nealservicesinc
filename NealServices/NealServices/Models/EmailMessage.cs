using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NealServices.Models
{
    public class EmailMessage
    {

        public string strFromAddress { get; set; }
        public string strFromName { get; set; }
        public string strPhone { get; set; }
        public string strTo { get; set; }
        public string strSubject { get; set; }
        public string strBody { get; set; }
    }
}