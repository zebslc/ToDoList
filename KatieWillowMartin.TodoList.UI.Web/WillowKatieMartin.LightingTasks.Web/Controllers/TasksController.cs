using System.Net;
using System.Net.Http;
using System.Web.Http;
using WillowMartin.TodoList.Data.Repositories;
using WillowMartin.TodoList.Domain;

namespace WillowKatieMartin.LightingTasks.Web.Controllers
{
    public class TasksController : ApiController
    {
        private readonly ITasksRepository _repository;

        public TasksController(ITasksRepository repository)
        {
            this._repository = repository;
        }

        public HttpResponseMessage Get()
        {
            return Request.CreateResponse(HttpStatusCode.OK,_repository.Get());
        }

        public HttpResponseMessage Post(CustomTask customTask)
        {
            return Request.CreateResponse(HttpStatusCode.OK, _repository.Create(customTask));
        }
    }
}
