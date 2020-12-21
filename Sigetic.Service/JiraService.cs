using Desyco.Filters;
using Microsoft.EntityFrameworkCore;
using Sigetic.Service.Db;
using Sigetic.Service.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sigetic.Service
{

    public class JiraService : IJiraService
    {
        private readonly SigeticDbContext _db;

        public JiraService(SigeticDbContext db)
        {
            _db = db;
        }

        public async Task<IEnumerable<JiraIssue>> GetAll(JiraParams jiraParams)
        {
            jiraParams.Page.Count = await _db.JiraIssue.CountAsync();
            return await _db.JiraIssue
                .AddAndFilters(jiraParams.Filters)
                .Skip((jiraParams.Page.PageNumber - 1) * jiraParams.Page.PageSize)
                .Take(jiraParams.Page.PageSize)
                .ToListAsync();
        }

    }
}
