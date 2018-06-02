using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace HelloWorld.Models
{
    public class TaskList
    {
        public int ID { get; set; }
        public string Subject { get; set; }
        public string Descriptions { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "0:d", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }
    }

    public class TaskListDBContext : DbContext
    {
        public DbSet<TaskList> Tasks { get; set; }
    }
}