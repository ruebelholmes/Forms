using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Forms.Models
{
    public class Tasks
    {
        public int ID { get; set; }
        public string CreatedBy { get; set; }

        public bool IsComplete { get; set; }
    }
}