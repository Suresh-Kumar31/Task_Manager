using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TaskManager.Entities
{
    public class Task
    {
        public int id { get; set; }
        public DateTime createdDate { get; set; }
        public DateTime DueDate { get; set; }
        public string taskSubject { get; set; }
        public int taskCompletionStatus { get; set; }
    }
}