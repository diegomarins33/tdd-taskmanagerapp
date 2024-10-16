using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagerApp
{
    public class TaskManager
    {
        public List<TaskModel> tasks = [];

        public List<TaskModel> AddTask(string title)
        {
            var task = new TaskModel(title);

            tasks.Add(task);

            return tasks;
        }

        public List<TaskModel> GetTasks()
        {
            return tasks;
        }

        public void MarkAsCompleted(int id)
        {
            var task = tasks.FirstOrDefault(t => t.Id == id);
            if (task != null)
            {
                task.MarkAsCompleted();
            }
        }
    }
}
