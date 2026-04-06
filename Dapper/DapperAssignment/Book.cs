using System;
using System.Collections.Generic;
using System.Text;

namespace DapperAssignment
{
    internal class Book
    {
        public int BookId { get; set; }
        public string? Title { get; set; }
        public int Price { get; set; }
        public string? Author { get; set; }
        public string? Publisher { get; set; }
        public string? Language { get; set; }
        public DateTime Created { get; set; }
    }
}
