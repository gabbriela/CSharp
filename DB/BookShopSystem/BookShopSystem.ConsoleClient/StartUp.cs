using System.Linq;
using BookShopSystem.Data;

namespace BookShopSystem.ConsoleClient
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var dbContext = new BookShopContext();

            var booksCount = dbContext.Books.Count();
        }
    }
}
