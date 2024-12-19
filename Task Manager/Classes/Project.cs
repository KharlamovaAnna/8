using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Task_Manager.Classes
{
    public enum ProjectStatus
    {
        New,
        InProgress,
        OnHold,
        Completed,
        Cancelled
    }
    internal class Project
    {
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Initiator { get; set; }
        public string TeamLead { get; set; }
        public List<Task> Tasks { get; set; } = new List<Task>(); 
        public ProjectStatus Status { get; set; }
        public Project(string description, DateTime startDate, string initiator, string Teamlead, ProjectStatus status)
        {
            Description = description;
            StartDate = startDate;
            Initiator = initiator;
            TeamLead = Teamlead;
            Status = status;
        }
        public Project(DateTime startDate, DateTime endDate)
        {
            Description = "Новый проект";
            StartDate = startDate;
            EndDate = endDate;
            Initiator = null;
            TeamLead = null;
            Status = ProjectStatus.New;
        
        }



    }
}
