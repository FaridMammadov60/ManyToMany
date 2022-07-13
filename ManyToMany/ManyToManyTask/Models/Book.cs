using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ManyToManyTask.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public List<Image> Images { get; set; }
        [NotMapped]
        public List<IFormFile> Photos { get; set; }
        public List<BookAuthor> BookAuthors { get; set; }
        public List<BookGenre> BookGenres { get; set; }

        [NotMapped]
        public List<int> AuthorIds { get; set; }
        [NotMapped]
        public List<int> GenreIds { get; set; }


    }
}
