using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace todolist_app.Models
{
    public partial class TodoItem
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public bool IsComplete { get; set; } = false;
    }
}
