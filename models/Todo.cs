using System;

namespace todolist.models
{
    public class Todo
    {
        public Guid Id { get; set; }
        public string Text { get; set; }
        public bool Completed { get; set; }
    }
}
