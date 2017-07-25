using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ToDoList.Models
{
    public class Task
    {
        [Key]
        public int TaskID { get; set; }
        public string TaskDescription { get; set; }
        public DateTime DueDate { get; set; }

        [Display(Name = "Task")]
        public string ListID { get; set; }
        //Navigation Property
        public virtual ICollection<List> Lists { get; set; }
    
    }
}