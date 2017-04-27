using System;
using System.Collections.Generic;
using System.Text;

namespace FeloopTodo
{
    public class Task
    {
        public string Description { get; set; }
        public bool IsCompleted { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
