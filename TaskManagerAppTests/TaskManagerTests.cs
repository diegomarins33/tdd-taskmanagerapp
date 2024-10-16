using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagerApp;

namespace TaskManagerAppTests
{
    public class TaskManagerTests
    {

        [Fact]
        public void Should_AddTask_ReturnTaskWithCorrectTitle()
        {
            // Arrange
            var taskManager = new TaskManager();
            string taskTitle = "Learn TDD";

            // Act
            var tasks = taskManager.AddTask(taskTitle);
            var task = tasks.Last();

            // Assert
            Assert.Equal(taskTitle, task.Title);
            Assert.False(task.IsCompleted);
        }

        [Fact]
        public void Should_GetTasks_ReturnAllTasks()
        {
            // Arrange
            var taskManager = new TaskManager();

            // Act
            taskManager.AddTask("Task Test 1");
            taskManager.AddTask("Task Test 2");
            taskManager.AddTask("Task Test 3");
            var tasks = taskManager.GetTasks();


            // Assert
            Assert.Equal(3, tasks.Count);
            Assert.Contains(tasks, t => t.Title == "Task Test 1");
            Assert.Contains(tasks, t => t.Title == "Task Test 2");
            Assert.Contains(tasks, t => t.Title == "Task Test 3");
        }

        [Fact]
        public void Should_MarkAsCompleted_UpdateIsCompletedForTrue()
        {
            // Arrange
            var taskManager = new TaskManager();

            // Act
            taskManager.AddTask("Task Test 1");
            taskManager.AddTask("Task Test 2");
            taskManager.MarkAsCompleted(5);
            var tasks = taskManager.GetTasks();

            // Assert
            Assert.False(tasks[0].IsCompleted);
            Assert.True(tasks[1].IsCompleted);
        }
    }
}
