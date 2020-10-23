using System;
using System.Collections.Generic;
using System.Text;

namespace BookLibrary
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Book> Books { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
