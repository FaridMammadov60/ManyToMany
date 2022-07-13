using System.Collections.Generic;

namespace ManyToManyTask.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public SocialAccount SocialAccount { get; set; }

        public List<BookAuthor> BookAuthors { get; set; }
    }
}
