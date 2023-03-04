
namespace Commerce.Server.Data
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base(options){}
        protected override void OnModelCreating(ModelBuilder modelBuilder){
            modelBuilder.Entity<Product>().HasData(new Product
        {
            Id = 1,
            Title = "X100pre",
            Description = "X 100pre is the debut studio album by Puerto Rican rapper Bad Bunny. It was released on December 24, 2018 on Christmas Eve, by Rimas Entertainment.",
            ImagenUrl = "https://media.pitchfork.com/photos/5c2cdf59673bd655963c817c/1:1/w_320/X%20100PRE_Bad%20Bunny.jpg",
            Price = 9.99m
        },
        new Product
        {
            Id = 2,
            Title = "Microdosis",
            Description = "Microdosis, which has 15 songs and the same number of music videos, also includes a collaboration with Latin artist Elena Rose and Feid, Mora's representatives detailed in a press release.",
            ImagenUrl = "https://i.scdn.co/image/ab67616d0000b273851222dc5c5681bd4c3119d3",
            Price = 9.99m
        },
        new Product
        {
            Id = 3,
            Title = "S.E.M",
            Description = "Sentimiento, Elegancia, & Maldad (S.E.M.) (English: Sentiment, Elegance, & Malice) is the first studio album by singer-songwriter Arcángel. It was released on November 19, 2013, by Pina Records. The first single from the album, Hace Mucho Tiempo, was released on June 21, 2013.",
            ImagenUrl = "https://upload.wikimedia.org/wikipedia/en/d/d3/Sentimiento%2CEleganciaYMaldad.JPEG",
            Price = 9.99m
        }
            );
        }
        public DbSet<Product> Products {get; set;}
    }
}