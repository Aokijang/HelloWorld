using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace HelloWorld.Models
{
    public class Assignment
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Subject { get; set; }
        [DataType(DataType.MultilineText)]
        public string Text { get; set; }
        public DateTime TimeSent { get; set; }
        [Display(Name = "Time End")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "0:d", ApplyFormatInEditMode = true)]
        public DateTime TimeEnd { get; set; }
    }
    public class AssignmentDBContext : DbContext
    {
        public DbSet<Assignment> Assignments { get; set; }
    }
}