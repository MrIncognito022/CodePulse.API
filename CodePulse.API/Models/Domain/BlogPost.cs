namespace CodePulse.API.Models.Domain
{
    public class BlogPost
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string ShortContent { get; set; }
        public string Content { get; set; }
        public string FeatureImage { get; set; }
        public string UrlHandle { get; set; }
        public DateTime PublisherDate { get; set; }
        public string Author { get; set; }
        public bool IsVisible { get; set; }

    }
}
