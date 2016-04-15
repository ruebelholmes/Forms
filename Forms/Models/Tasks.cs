﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Forms.Models
{
    public class Tasks
    {
        public int ID { get; set; }
        public virtual  string CreatedBy { get; set; }
        public virtual string Description { get; set; }
        public virtual bool IsComplete { get; set; }

        public Tasks(string createdBy, string description, bool isComplete)
        {
            CreatedBy = createdBy;
            Description = description;
            IsComplete = isComplete;
        }
    }
}