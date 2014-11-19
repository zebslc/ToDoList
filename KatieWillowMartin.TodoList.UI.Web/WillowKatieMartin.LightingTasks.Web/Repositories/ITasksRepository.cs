using System.Collections.Generic;

using KatieWillowMartin.TodoList.UI.Web.Models;

namespace KatieWillowMartin.TodoList.UI.Web.Repositories
{
    
    public interface ITasksRepository
    {
        IList<Task> Get();
    }
}