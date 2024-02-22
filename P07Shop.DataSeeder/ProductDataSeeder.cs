using Bogus;
using P06Shop.Shared;

namespace P07Shop.DataSeeder
{
    public class ProductDataSeeder
    {
        public static List<Product> GenerateProductData()
        {

            var productFaker = new Faker<Product>()
                 .UseSeed(123456) // seed - ziarno, dzięki temu za każdym razem będziemy dostawać te same dane
                 .RuleFor(p => p.Id, f => f.IndexFaker +1) // chcemy , żeby indeksy zaczynały się od 1
                 .RuleFor(p => p.Title, f => f.Commerce.ProductName())
                 .RuleFor(p => p.Description, f => f.Commerce.ProductDescription())
                 .RuleFor(p => p.Barcode, f => f.Commerce.Ean13().Substring(12))
                 .RuleFor(p => p.Price, f => f.Random.Double(1, 1000))
                 .RuleFor(p => p.ReleaseDate, f => f.Date.Past());

            var products = productFaker.Generate(50);
            return products;
        }
    }
}
