namespace BookStorApi.Models
{
    public class BookModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int TotalPages { get; set; }
        public string Author { get; set; }
        public PriceModel Price { get; set; }
        public bool IsPublished { get; set; }
        public DateTime PublishedOn { get; set; }
        public List<AuthorModel> Authors { get; set; }

        }
      

}
