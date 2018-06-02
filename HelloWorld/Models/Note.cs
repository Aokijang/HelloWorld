using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace HelloWorld.Models
{
    public class Note
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Subject { get; set; }
        [DataType(DataType.MultilineText)]
        public string Text { get; set; }
        public DateTime TimeSent { get; set; }
    }

    public class NoteDBContext : DbContext
    {
        public DbSet<Note> Notes { get; set; }
    }
}