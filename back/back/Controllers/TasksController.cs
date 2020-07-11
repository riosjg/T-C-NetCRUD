using back.Repository;
using Common.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace back.Controllers
{
    public class TasksController : ApiController
    {
        private readonly TasksRepository _tasksRepository;
        private static readonly ILog Log = LogManager.GetLogger<TasksController>();
        [HttpGet]
        [Route("~/api/tasks")]
        public IHttpActionResult GetAllTasks()
        {
            try
            {
                Log.Debug("TasksController - GetAllTasks - Getting every task");
                var tasks = _tasksRepository.GetAllTasks();
                return Ok(tasks);
            }
            catch(Exception ex)
            {
                Log.Error($"{ex}");
                return InternalServerError();
            }
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
