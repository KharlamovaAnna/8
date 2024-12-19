using System.Collections.Generic;
using System.Threading.Tasks;
using System;

namespace Task_Manager.Classes
{
    internal class Task
    {
        public string Description { get; set; }
        public DateTime? DueDate { get; set; }
        public Person Initiator { get; set; }
        public Person Assignee { get; set; }
        public TaskStatus Status { get; set; }
        public List<Report> Reports { get; set; } = new List<Report>();
        public Task(string description, DateTime? dueDate, Person initiator, Person assignee, TaskStatus status)
        {
            Description = description;
            DueDate = dueDate;
            Initiator = initiator;
            Assignee = assignee;
            Status = status;
        }
        

    }
}
