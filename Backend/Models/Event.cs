using System;
using System.ComponentModel.DataAnnotations;

namespace Backend.Models
{
    public class Event
    {
        public int Id { get; set; }

        public DateTime DateTime { get; set; }

        [Required]
        [MaxLength(255)]
        public string Title { get; set; }

        [Required]
        [MaxLength(1024)]
        public string Details { get; set; }

    }
}