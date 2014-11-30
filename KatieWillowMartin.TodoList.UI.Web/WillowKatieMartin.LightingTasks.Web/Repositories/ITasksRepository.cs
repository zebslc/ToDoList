using System.Collections.Generic;
using WillowKatieMartin.LightingTasks.Web.Models;

namespace KatieWillowMartin.TodoList.UI.Web.Repositories
{
    
    public interface ITasksRepository
    {
        IList<CustomTask> Get();
    }
}