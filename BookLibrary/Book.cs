﻿namespace BookLibrary
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int YearOfPublication { get; set; }
        public string StyleOfBook { get; set; }
        public virtual Author Author { get; set; }

        public override string ToString()
        {
            return $"{Title} ({YearOfPublication})";
        }
    }
}
