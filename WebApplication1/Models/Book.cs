using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        //public int TypeId { get; set; }
        public virtual BookType TypeId { get; set; }
        public int NumberOfPages { get; set; }
        public string Description { get; set; }
        public int ReleaseDate { get; set; }
    }
}