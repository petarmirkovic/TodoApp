using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;

namespace Core.Entities
{
    public class SubTask
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; } = "";
        public bool Done { get; set; } = false;
        public int TodoId { get; set; }
        public Todo Todo { get; set; }
    }
}