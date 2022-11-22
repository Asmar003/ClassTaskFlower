namespace ClassTaskFlower.Models
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Flower nargis = new Flower
            {
                Name = "Nargis",
                Color = "White",
                Price = 0.5f
            };

            Flower jasmin = new Flower
            {
                Name = "Jasmin",
                Color = "Purple",
                Price = 0.7f
            };

            Bucket bucket = new Bucket();
            bucket.DiscountPercent = 20;

            bucket.AddFlower(jasmin);
            bucket.AddFlower(nargis);
            bucket.AddFlower(jasmin);
            bucket.AddFlower(nargis);
        }
    }
}