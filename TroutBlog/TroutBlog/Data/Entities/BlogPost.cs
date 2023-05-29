namespace TroutBlog.Data.Entities
{
    public class BlogPost
    {
        public int Id { get; set; }
        public DateTime PostCreationTime { get; set; }
        public string Title { get; set; }
        public string Introduction { get; set; }
        public string Body { get; set; }
        public string Image { get; set; }
    }
}
