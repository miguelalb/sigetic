using Sigetic.Service.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Sigetic.Service
{
    public interface IJiraService
    {

        Task<IEnumerable<JiraIssue>> GetAll(JiraParams jiraParams);
    }
}