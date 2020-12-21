using Microsoft.AspNetCore.Mvc;
using Sigetic.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProyectosDGTIC.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JiraController : ControllerBase
    {
        private readonly IJiraService jiraService;

        public JiraController(IJiraService jiraService)
        {
            this.jiraService = jiraService;
        }
        // GET: api/<JiraController>
        //[HttpGet]
        //public async Task<IActionResult> Get(JiraParams jiraParams)
        //{
            
        //    var data = await jiraService.GetAll(jiraParams);
        //    return Ok(new { 
        //    Data = data,
        //    RowCount = jiraParams.Page.Count
        //    });
        //}

        // Post: api/<JiraController>
        [HttpPost("[action]")]
        public async Task<IActionResult> GetAll(JiraParams jiraParams)
        {

            var data = await jiraService.GetAll(jiraParams);
            return Ok(new
            {
                Data = data,
                RowCount = jiraParams.Page.Count
            });
        }
        // GET api/<JiraController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<JiraController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<JiraController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<JiraController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
