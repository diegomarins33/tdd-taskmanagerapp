using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagerApp
{
    public class TaskModel
    {
        private static int _idCounter = 1;

        public int Id { get; private set; } 
        public string Title { get; private set; } 
        public bool IsCompleted { get; private set; } 

        public TaskModel(string title)
        {
            Id = _idCounter++; 
            Title = title; 
            IsCompleted = false; 
        }

        public void MarkAsCompleted()
        {
            IsCompleted = true; 
        }
    }
}

