namespace DevEncurtaUrl.Entities
{
    public class ShortenedCustomLink
    {
        private ShortenedCustomLink() { }
        public ShortenedCustomLink(string title, string destinationLink, string domain)
        {
            var code = title.Split(" ")[0];

            Title = title; // ultimo-artigo Blog
            DestinationLink = destinationLink;
            ShortenedLink = $"{domain}/{code}";
            Code = code;
            CreatedAt = DateTime.Now.ToShortDateString();
        }
        public int Id { get; set; }
        public string Title { get; set; }
        public string ShortenedLink { get; set; }
        public string DestinationLink { get; set; }
        public string Code { get; set; }
        public string CreatedAt { get; set; }

        public void Update(string title, string destinationLink)
        {
            Title = title;
            DestinationLink = destinationLink;
        }
    }
}
