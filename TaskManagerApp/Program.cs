 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagerApp
{
    class Program
    {
        static void Main()
        {
            var taskManager = new TaskManager();

            taskManager.AddTask("Task 1");
            taskManager.AddTask("Task 2");

            taskManager.MarkAsCompleted(2);

            List<TaskModel> tasks = taskManager.GetTasks();
            foreach (var task in tasks)
            {
                Console.WriteLine($"{task.Id} - {task.Title} - {(task.IsCompleted ? "Completed" : "Pending")}");
            }
        }
    }
}
