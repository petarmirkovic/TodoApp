using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;

namespace Core.Entities
{
    public class Todo
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; } = string.Empty;
        public bool Done { get; set; } = false;
        public bool Repeating { get; set; } = false;
        public int UserId { get; set; }
        public User User { get; set; }
        public List<SubTask> SubTasks { get; set; }

    }
}