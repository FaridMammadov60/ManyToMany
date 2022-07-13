namespace ManyToManyTask.Models
{
    public class SocialAccount
    {
        public int Id { get; set; }
        public string Facebook { get; set; }
        public string Linkedin { get; set; }
        public string Instagram { get; set; }
        public string Vkontakte { get; set; }
        public int AuthorId { get; set; }
        public Author Author { get; set; }
    }
}
