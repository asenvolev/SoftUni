namespace BookShop
{
    using System;
    using System.Linq;
    using System.Text;
    using System.Globalization;

    using BookShop.Data;
    using BookShop.Initializer;
    using BookShop.Models;

    public class StartUp
    {
        public static void Main()
        {
            using (var db = new BookShopContext())
            {
                Console.WriteLine(GetMostRecentBooks(db));
            }
        }

        public static string GetBooksByAgeRestriction(BookShopContext context, string command)
        {
            int enumValue = -1;
            if (command.ToLower() == "minor")
            {
                enumValue = 0;
            }
            else if (command.ToLower() == "teen")
            {
                enumValue = 1;
            }
            else if (command.ToLower() == "adult")
            {
                enumValue = 2;
            }

            var titles = context.Books.Where(b => b.AgeRestriction == (AgeRestriction)enumValue)
                .Select(t => t.Title).OrderBy(x=>x).ToArray();

            return string.Join(Environment.NewLine, titles);
        }

        public static string GetGoldenBooks(BookShopContext context)
        {
            var goldenBooksTitles = context.Books
                .Where(b => b.EditionType == (EditionType)2 && b.Copies<5000)
                .OrderBy(b=>b.BookId)
                .Select(t => t.Title)
                .ToArray();

            return string.Join(Environment.NewLine, goldenBooksTitles);
        }

        public static string GetBooksByPrice(BookShopContext context)
        {                      
            var sb = new StringBuilder();
            context.Books
            .Where(b => b.Price > 40)
            .OrderByDescending(b => b.Price)
            .Select(b => new
            {
                Title = b.Title,
                Price = b.Price
            })
            .ToList()
            .ForEach(b => sb.AppendLine($"{b.Title} - ${b.Price:F2}"));
            return sb.ToString().Trim();
        }

        public static string GetBooksNotRealeasedIn(BookShopContext context, int year)
        {
            var BooksNotRealeasedIn = context.Books
                .Where(b => b.ReleaseDate.Value.Year != year)
                .OrderBy(b => b.BookId)
                .Select(t => t.Title)
                .ToArray();

            return string.Join(Environment.NewLine, BooksNotRealeasedIn);
        }

        public static string GetBooksByCategory(BookShopContext context, string input)
        {
            var categories = input
                .Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x=>x.ToLower())
                .ToList();

            var booksByCategory = context.Books
                .Where(b => b.BookCategories.Any(c => categories.Contains(c.Category.Name.ToLower())))
                .Select(b => b.Title)
                .OrderBy(x => x)
                .ToList();

            return string.Join(Environment.NewLine, booksByCategory);
        }

        public static string GetBooksReleasedBefore(BookShopContext context, string date)
        {
            var parsedDate = DateTime.ParseExact(date, "dd-MM-yyyy", null);

            var sb = new StringBuilder();

            context.Books
                .Where(b => b.ReleaseDate < parsedDate)
                .OrderByDescending(b => b.ReleaseDate)
                .Select(b =>new
                {
                    Info = $"{b.Title} - {b.EditionType} - ${b.Price:f2}"
                })
                .ToList()
                .ForEach(b=> sb.AppendLine(b.Info));

            return sb.ToString().TrimEnd();
        }

        public static string GetAuthorNamesEndingIn(BookShopContext context, string input)
        {
            var sb = new StringBuilder();

            context.Authors
                .Where(a=>a.FirstName.EndsWith(input))
                .OrderBy(a => a.FirstName)
                .ThenBy(a=>a.LastName)
                .Select(a => new
                {
                    FullName = $"{a.FirstName} {a.LastName}"
                })
                .ToList()
                .ForEach(a => sb.AppendLine(a.FullName));

            return sb.ToString().TrimEnd();
        }

        public static string GetBookTitlesContaining(BookShopContext context, string input)
        {
            var BookTitlesContaining = context.Books
                .Where(b => b.Title.ToLower().Contains(input.ToLower()))
                .Select(b => b.Title)
                .OrderBy(t => t)
                .ToArray();

            return string.Join(Environment.NewLine, BookTitlesContaining);
        }

        public static string GetBooksByAuthor(BookShopContext context, string input)
        {
            var sb = new StringBuilder();

            context.Books
                .Where(b => b.Author.LastName.ToLower().StartsWith(input.ToLower()))
                .OrderBy(b => b.BookId)
                .Select(b =>  $"{b.Title} ({b.Author.FirstName} {b.Author.LastName})")
                .ToList()
                .ForEach(a => sb.AppendLine(a));

            return sb.ToString().TrimEnd();
        }

        public static int CountBooks(BookShopContext context, int lengthCheck)
        {
            return context.Books.Where(b => b.Title.Length > lengthCheck).Count();
        }

        public static string CountCopiesByAuthor(BookShopContext context)
        {
            var CountCopiesByAuthor = context.Authors
                .OrderByDescending(a=> a.Books.Sum(b => b.Copies))
                .Select(a => $"{a.FirstName} {a.LastName} - {a.Books.Sum(b => b.Copies)}")
                .ToArray();

            return string.Join(Environment.NewLine, CountCopiesByAuthor);
        }

        public static string GetTotalProfitByCategory(BookShopContext context)
        {
            var TotalProfitByCategory = context.Categories
                .OrderByDescending(c=>c.CategoryBooks.Sum(b => b.Book.Price * b.Book.Copies))
                .ThenBy(c=>c.Name)
                .Select(c => $"{c.Name} ${c.CategoryBooks.Sum(b => b.Book.Price * b.Book.Copies)}")
                .ToArray();

            return string.Join(Environment.NewLine, TotalProfitByCategory);
        }

        public static string GetMostRecentBooks(BookShopContext context)
        {
            var GetMostRecentBooks = context.Categories
                .OrderBy(c => c.Name)
                  .Select(c =>new
                {
                    Name = c.Name,
                    Books = c.CategoryBooks.OrderByDescending(b => b.Book.ReleaseDate).Select(x=> $"{x.Book.Title} ({x.Book.ReleaseDate.Value.Year})").Take(3).ToList()
                })
                .ToList();

            var sb = new StringBuilder();

            foreach (var cat in GetMostRecentBooks.OrderByDescending(c=>c.Books.Count))
            {
                sb.AppendLine($"--{cat.Name}");
                foreach (var book in cat.Books)
                {
                    sb.AppendLine(book);
                }
            }

            return sb.ToString().TrimEnd();
        }

        public static void IncreasePrices(BookShopContext context)
        {
            context.Books
                .Where(b => b.ReleaseDate.Value.Year < 2010)
                .ToList()
                .ForEach(b => b.Price += 5);

            context.SaveChanges();
        }

        public static int RemoveBooks(BookShopContext context)
        {
            var BooksToRemove = context.Books
                .Where(b => b.Copies < 4200)
                .ToArray();

            context.RemoveRange(BooksToRemove);

            context.SaveChanges();

            return BooksToRemove.Count();
        }
    }
}
