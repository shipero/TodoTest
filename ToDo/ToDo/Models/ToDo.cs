using System.Globalization;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace ToDo.Models
{
    public class ToDoModels
    {
        [Key]
        public int ToDoId { get; set; }
        //[ForeignKey("UserProfile")]
        public int UserProfileUserId { get; set; }
        public string ToDoDisplay { get; set; }
        public bool Completed { get; set; }
        //public virtual UserProfile UserProfile { get; set; }
    }
}