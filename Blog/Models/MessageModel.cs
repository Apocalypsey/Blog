using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Blog.Models
{
    public class MessageModel
    {
        public string ReceiverId { get; set; }

        public string LeaveId { get; set; }

        public string RootId { get; set; }

        public string SuperId { get; set; }

        public string Content { get; set; }

        public DateTime WriteTime { get; set; }

        public string State { get; set; }
    }
}