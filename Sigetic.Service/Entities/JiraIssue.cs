using System;
using System.Collections.Generic;

//#nullable disable

namespace Sigetic.Service.Entities
{
    public partial class JiraIssue
    {
        public decimal IssueId { get; set; }
        public string TypeId { get; set; }
        public string IssueType { get; set; }
        public string StatusId { get; set; }
        public string Status { get; set; }
        public decimal? AssigneeId { get; set; }
        public string Username { get; set; }
        public string Assignee { get; set; }
        public decimal? GroupId { get; set; }
        public string Group { get; set; }
        public string Summary { get; set; }
        public decimal? ProjectId { get; set; }
        public string Project { get; set; }
        public decimal? ProjectTotal { get; set; }
        public DateTime? Created { get; set; }
        public decimal? TimeEstimate { get; set; }
        public decimal? TimeOriginalEstimate { get; set; }
        public string Resolution { get; set; }
        public DateTime? ResolutionDate { get; set; }
        public string ProjectType { get; set; }
    }
}
