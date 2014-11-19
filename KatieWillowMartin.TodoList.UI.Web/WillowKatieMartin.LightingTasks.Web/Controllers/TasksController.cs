using System.Net;
using System.Net.Http;
using System.Web.Http;
using KatieWillowMartin.TodoList.UI.Web.Repositories;

namespace WillowKatieMartin.LightingTasks.Web.Controllers
{
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
