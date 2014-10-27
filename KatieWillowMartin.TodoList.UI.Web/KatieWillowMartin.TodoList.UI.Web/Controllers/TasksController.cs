using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace KatieWillowMartin.TodoList.UI.Web.Controllers
{
    using KatieWillowMartin.TodoList.UI.Web.Repositories;

    public class TasksController : ApiController
    {
        private readonly ITasksRepository repository;

        public TasksController(ITasksRepository repository)
        {
            this.repository = repository;
        }

        public HttpResponseMessage Get()
        {
            return Request.CreateResponse(HttpStatusCode.OK,repository.Get());
        }
    }
}
