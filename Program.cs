using cs_working_with_apis.FakerBookAPI;

namespace cs_working_with_apis
{
    internal class Program
    {
        public static async Task Main(string[] args)
        {
            FakerBookResponse? res = await FakerBooks.GetBooksAsync(2);
            if (res != null)
            {
                foreach(var book in res.Data)
                {
                    Console.WriteLine($"Id: {book.Id} | Title: {book.Title} | Author: {book.Author} | Genre: {book.Genre} \nDescription: {book.Description}");
                }
            }
        }
    }
}
