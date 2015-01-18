using System.Collections.Generic;
using WillowMartin.TodoList.Domain;

namespace WillowMartin.TodoList.Data.Repositories
{
    
    public interface ITasksRepository
    {
        IList<CustomTask> Get();
        int Create(CustomTask customTask);
    }
}